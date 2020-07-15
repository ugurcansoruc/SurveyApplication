using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.MvcWebUI.Models;

namespace SurveyApplication.SurveyDb.MvcWebUI.Controllers
{
    public class UserController : Controller
    {
        private ISurveyService _surveyService;
        private IQuestionService _questionService;
        private IQuestionOptionService _questionOptionService;
        private IAnswerService _answerService;
        public UserController(ISurveyService surveyService, IQuestionService questionService, IQuestionOptionService questionOptionService, IAnswerService answerService)
        {
            _surveyService = surveyService;
            _questionService = questionService;
            _questionOptionService = questionOptionService;
            _answerService = answerService;
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult MyAccount()
        {

            return View();
        }

        public ActionResult Surveys(AnswerListViewModel answerListViewModel, int page = 1, int surveyId = 0)
        {
            int pageSize = 10;
            var questions = _questionService.GetBySurveyId(surveyId);
            var questionOptions = _questionOptionService.GetAll();
            var answers = _answerService.GetBySurveyAndUserId(surveyId, 2);
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
            answerListViewModel.Answer.SurveyId = answerListViewModel.Question.SurveyId;
            answerListViewModel.Answer.QuestionId = answerListViewModel.Question.Id;
            answerListViewModel.Answer.UserId = 2;
            answerListViewModel.QuestionOptions =
                _questionOptionService.GetByQuestionId(answerListViewModel.Question.Id);
            _answerService.Add(answerListViewModel.Answer);

            TempData["_QuestionAnswer"] = 1;
            return View(answerListViewModel);
        }
    }
}
