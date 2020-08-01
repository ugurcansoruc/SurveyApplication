using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;
using SurveyApplication.SurveyDb.MvcWebUI.Models;

namespace SurveyApplication.SurveyDb.MvcWebUI.Controllers
{
    public class ManagerController : Controller
    {
        private readonly ISurveyService _surveyService;
        private readonly IQuestionService _questionService;
        private readonly IQuestionOptionService _questionOptionService;
        private readonly IManagerService _managerService;
        private readonly IPersonService _personService;
        private readonly IGroupService _groupService;
        private readonly IAnswerService _answerService;
        private readonly IUserService _userService;
        private readonly IPersonUserService _personUserService;
        private readonly ILogger<ManagerController> _logger;

        public ManagerController(ISurveyService surveyService, IQuestionService questionService, IQuestionOptionService questionOptionService, IManagerService managerService, IPersonService personService, IGroupService groupService, IAnswerService answerService, IUserService userService, IPersonUserService personUserService, ILogger<ManagerController> logger)
        {
            _surveyService = surveyService;
            _questionService = questionService;
            _questionOptionService = questionOptionService;
            _managerService = managerService;
            _personService = personService;
            _groupService = groupService;
            _answerService = answerService;
            _userService = userService;
            _personUserService = personUserService;
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyAccount()
        {
            var personId = HttpContext.Session.GetInt32("personId");

            var locker = Security.Security.CreatLocker();

            var model = new ManagerUpdateListViewModel
            {
                Person = _personService.GetById((int)personId), //personId
                Manager = _managerService.GetById((int)personId),//personId
                Groups = _groupService.GetList()
            };

            string decryptKey = locker.Decrypt(model.Person.Password);
            model.Person.Password = decryptKey;

            return View(model);
        }

        [HttpPost]
        public ActionResult MyAccount(ManagerUpdateListViewModel managerUpdateListViewModel)
        {
            var locker = Security.Security.CreatLocker();

            if (ModelState.IsValid)
            {
                string encryptKey = locker.Encrypt(managerUpdateListViewModel.Person.Password);
                managerUpdateListViewModel.Person.Password = encryptKey;

                _personService.Update(managerUpdateListViewModel.Person);
                _managerService.Update(managerUpdateListViewModel.Manager);

                _logger.LogInformation("{firstname} {lastname} updated his personal information.", managerUpdateListViewModel.Person.FirstName,managerUpdateListViewModel.Person.LastName);
            }

            managerUpdateListViewModel.Groups = _groupService.GetList();
            return View(managerUpdateListViewModel);
        }

        public ActionResult Surveys(int page = 1, int surveyId = 0)
        {
            int pageSize = 10;
            var questions = _questionService.GetBySurveyId(surveyId);
            var questionOptions = _questionOptionService.GetAll();
            QuestionListViewModel model = new QuestionListViewModel
            {
                Questions = questions.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                QuestionOptions = questionOptions,
                SurveyId = surveyId
            };

            return View(model);
        }

        public ActionResult SurveyCreate()
        {

            return View();
        }

        public ActionResult Update(int questionId, int surveyId, SurveyQuestionCreateViewModel surveyQuestionCreateViewModel)
        {

            var model = new QuestionUpdateViewModel
            {
                Question = _questionService.GetById(questionId),
                QuestionOptions = _questionOptionService.GetByQuestionId(questionId),
                Survey = _surveyService.GetById(surveyId)
            };
            return View(model);


        }

        [HttpPost]
        public ActionResult Update(QuestionUpdateViewModel _questionUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                _surveyService.Update(_questionUpdateViewModel.Survey);
                _questionService.Update(_questionUpdateViewModel.Question);
            }

            TempData["Update_"] = 1;

            return RedirectToAction("Surveys");
        }

        public ActionResult UpdateOptions(int questionOptionId, int questionId, int surveyId)
        {
            var model = new QuestionOptionUpdateViewModel
            {
                QuestionOption = _questionOptionService.GetById(questionOptionId),
                QuestionId = questionId,
                SurveyId = surveyId
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateOptions(QuestionOptionUpdateViewModel questionOptionUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                _questionOptionService.Update(questionOptionUpdateViewModel.QuestionOption);
            }

            TempData["UpdateOption"] = 1;

            return View(questionOptionUpdateViewModel);
        }


        public ActionResult SurveyQuestionCreate(SurveyQuestionCreateViewModel surveyQuestionCreateViewModel, int surveyId, int questionId, bool isDeletedSurvey, bool isDeletedQuestion)
        {
            surveyQuestionCreateViewModel.SurveyId = surveyId;

            if (isDeletedQuestion == true)
            {
                _questionService.Delete(questionId);
            }

            if (isDeletedSurvey == true)
            {
                _surveyService.Delete(surveyId);
                return RedirectToAction("SurveyCreate");
            }

            surveyQuestionCreateViewModel.Questions = _questionService.GetBySurveyId(surveyId);
            surveyQuestionCreateViewModel.QuestionResponseOptions = _questionOptionService.GetAll();


            return View(surveyQuestionCreateViewModel);
        }

        [HttpPost]
        public ActionResult SurveyQuestionCreate(SurveyViewModel surveyViewModel, SurveyQuestionCreateViewModel surveyQuestionCreateViewModel)
        {
            var model = new SurveyQuestionCreateViewModel();
            var personId = HttpContext.Session.GetInt32("personId");

            if (surveyViewModel.Survey != null)
            {
                surveyViewModel.Survey.StartDate = DateTime.Now;
                surveyViewModel.Survey.EndDate = DateTime.Now;
                surveyViewModel.Survey.ManagerId = (int)personId;//şuanlık //personId
                surveyViewModel.Survey.IsOpen = true;

                _surveyService.Add(surveyViewModel.Survey);
            }

            if (surveyQuestionCreateViewModel.Question == null)
            {
                model.SurveyId = surveyViewModel.Survey.Id;
                model.Questions = _questionService.GetBySurveyId(surveyViewModel.Survey.Id);
                model.QuestionResponseOptions = _questionOptionService.GetAll();
            }
            else
            {
                surveyQuestionCreateViewModel.Question.QuestionTypeId = 1; //Soru türü için
                surveyQuestionCreateViewModel.Question.SurveyId = surveyQuestionCreateViewModel.SurveyId;
                _questionService.Add(surveyQuestionCreateViewModel.Question);


                model.SurveyId = surveyQuestionCreateViewModel.SurveyId;
                model.Questions = _questionService.GetBySurveyId(surveyQuestionCreateViewModel.SurveyId);
                model.QuestionResponseOptions = _questionOptionService.GetAll();

            }

            return View(model);

        }

        public ActionResult CreateOption(int questionId, int surveyId, int optionId, bool isDeleted, SurveyQuestionCreateViewModel surveyQuestionCreateViewModel)
        {
            surveyQuestionCreateViewModel.QuestionId = questionId;
            surveyQuestionCreateViewModel.SurveyId = surveyId;

            if (isDeleted == true)
            {
                _questionOptionService.Delete(optionId);
            }

            surveyQuestionCreateViewModel.QuestionResponseOptions = _questionOptionService.GetByQuestionId(surveyQuestionCreateViewModel.QuestionId);
            surveyQuestionCreateViewModel.CountOptionAdded =
                _questionOptionService.GetAddedOptionCount(surveyQuestionCreateViewModel.QuestionId);


            return View(surveyQuestionCreateViewModel);
        }

        [HttpPost]
        public ActionResult CreateOption(SurveyQuestionCreateViewModel surveyQuestionCreateViewModel)
        {

            surveyQuestionCreateViewModel.QuestionResponseOption.QuestionId = surveyQuestionCreateViewModel.QuestionId;

            _questionOptionService.Add(surveyQuestionCreateViewModel.QuestionResponseOption);

            surveyQuestionCreateViewModel.CountOptionAdded =
                _questionOptionService.GetAddedOptionCount(surveyQuestionCreateViewModel.QuestionResponseOption.QuestionId);

            surveyQuestionCreateViewModel.QuestionResponseOptions = _questionOptionService.GetByQuestionId(surveyQuestionCreateViewModel.QuestionResponseOption.QuestionId);

            return RedirectToAction("CreateOption", surveyQuestionCreateViewModel);
        }

        public ActionResult SurveyAnalysis(int questionId)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            var options = _questionOptionService.GetByQuestionId(questionId);
            foreach (var option in options)
            {
                var optionAnswerCount = _answerService.GetOptionCount(option.Id);
                dataPoints.Add(new DataPoint(option.Text, optionAnswerCount));
            }
            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);


            var model = new SurveyQuestionCreateViewModel
            {
                Question = _questionService.GetById(questionId),

            };

            return View(model);
        }


        public ActionResult UserAnalysis(int surveyId)
        {
            int questionCount = _questionService.GetQuestionCount(surveyId);
            int surveyScore = 100;
            int questionScore = surveyScore / questionCount;
            int userScore = 0, totalScore = 0, userCount = 0;

            List<Question> questions = _questionService.GetBySurveyId(surveyId);
            List<PersonUser> personUsers = _personUserService.GetAll();

            Dictionary<int, int> usersScore = new Dictionary<int, int>();
            Dictionary<int, int> test = new Dictionary<int, int>();

            int[,] array = new int[questionCount, 2];


            foreach (var personUser in personUsers)
            {
                int arrCounter = 0;

                foreach (var question in questions)
                {
                    List<QuestionResponseOption> questionResponseOptions =
                        _questionOptionService.GetByQuestionId(question.Id);
                    int counter = 1;
                    int answer = _answerService.GetBySurveyUserIdQuestionId(surveyId, personUser.Id, question.Id);

                    foreach (var questionOption in questionResponseOptions)
                    {
                        if (answer == questionOption.Id)
                        {
                            userScore += questionScore / counter;
                            array[arrCounter, 0] = question.Id;
                            array[arrCounter, 1] += questionScore / counter;
                        }
                        counter++;
                    }
                    arrCounter++;
                }
                usersScore.Add(personUser.Id, userScore);
                if (userScore != 0)
                {
                    totalScore += userScore;
                    userCount += 1;
                }
                userScore = 0;
            }

            int lowId= array[0, 0], highId = array[0, 0], highCount = 0, lowCount = array[0,1];

            for (var i = 0; i < questionCount; i++)
            {
                if (array[i, 1] > highCount)
                {
                    highCount = array[i, 1];
                    highId = array[i, 0];
                }
                if (array[i, 1] < lowCount)
                {
                    lowCount = array[i, 1];
                    lowId = array[i, 0];
                }
            }
            int scoreAvg;
            if (totalScore!=0)
            {
                scoreAvg = totalScore / userCount;
            }
            else
            {
                scoreAvg = 0;
            }
            var model = new UserAnalysisViewModel
            {
                PersonUsers = personUsers,
                UsersScore = usersScore,
                SurveyId = surveyId,
                LowQuestion = _questionService.GetById(lowId),
                LowOption = _questionOptionService.GetByQuestionId(lowId),
                HighQuestion = _questionService.GetById(highId),
                HighOption = _questionOptionService.GetByQuestionId(highId),
                ScoreAvg = scoreAvg
            };

            return View(model);
        }
    }
}
