
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.MvcWebUI.Models;

namespace SurveyApplication.SurveyDb.MvcWebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly IQuestionOptionService _questionOptionService;
        private readonly IAnswerService _answerService;
        private readonly IPersonService _personService;
        private readonly IUserService _userService;
        private readonly ICityService _cityService;
        private readonly IGenderService _genderService;

        public UserController(IQuestionService questionService, IQuestionOptionService questionOptionService, IAnswerService answerService, IPersonService personService, IUserService userService, ICityService cityService, IGenderService genderService)
        {
            _questionService = questionService;
            _questionOptionService = questionOptionService;
            _answerService = answerService;
            _personService = personService;
            _userService = userService;
            _cityService = cityService;
            _genderService = genderService;
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult MyAccount()
        {
            var personId = HttpContext.Session.GetInt32("personId");

            var model = new UserUpdateListViewModel
            {
                Person = _personService.GetById((int)personId), //personId !!
                User = _userService.GetById((int)personId), //personId !!
                Genders = _genderService.GetList(),
                Cities = _cityService.GetList()
            };
            return View(model);
        }


        [HttpPost]
        public ActionResult MyAccount(UserUpdateListViewModel userUpdateListViewModel)
        {
            if (ModelState.IsValid)
            {
                _personService.Update(userUpdateListViewModel.Person);
                _userService.Update(userUpdateListViewModel.User);
            }

            userUpdateListViewModel.Cities = _cityService.GetList();
            userUpdateListViewModel.Genders = _genderService.GetList();

            return View(userUpdateListViewModel);
        }

        public ActionResult Surveys(AnswerListViewModel answerListViewModel, int page = 1, int surveyId = 0)
        {
            var personId = HttpContext.Session.GetInt32("personId");

            int pageSize = 10;
            var questions = _questionService.GetBySurveyId(surveyId);
            var questionOptions = _questionOptionService.GetAll();
            var answers = _answerService.GetBySurveyAndUserId(surveyId, (int)personId);//personId!!
            AnswerListViewModel model = new AnswerListViewModel
            {
                Questions = questions.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                QuestionOptions = questionOptions,
                Answers = answers
            };

            return View(model);
        }

        public ActionResult QuestionAnswer(int surveyId, int questionId)
        {
            AnswerListViewModel model = new AnswerListViewModel()
            {

                QuestionOptions = _questionOptionService.GetByQuestionId(questionId),
                Question = _questionService.GetById(questionId),
            };

            return View(model);
        }

        [HttpPost]

        public ActionResult QuestionAnswer(AnswerListViewModel answerListViewModel)
        {
            var personId = HttpContext.Session.GetInt32("personId");

            answerListViewModel.Answer.SurveyId = answerListViewModel.Question.SurveyId;
            answerListViewModel.Answer.QuestionId = answerListViewModel.Question.Id;
            answerListViewModel.Answer.UserId = (int) personId; //personId !!
            answerListViewModel.QuestionOptions =
                _questionOptionService.GetByQuestionId(answerListViewModel.Question.Id);
            _answerService.Add(answerListViewModel.Answer);

            TempData["_QuestionAnswer"] = 1;
            return View(answerListViewModel);
        }
    }
}
