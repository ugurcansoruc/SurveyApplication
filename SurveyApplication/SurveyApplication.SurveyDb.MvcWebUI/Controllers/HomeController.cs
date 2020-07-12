using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;
using SurveyApplication.SurveyDb.MvcWebUI.Models;

namespace SurveyApplication.SurveyDb.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private ISurveyService _surveyService;
        private IQuestionService _questionService;
        private IQuestionOptionService _questionOptionService;

        public HomeController(ISurveyService surveyService, IQuestionService questionService, IQuestionOptionService questionOptionService)
        {
            _surveyService = surveyService;
            _questionService = questionService;
            _questionOptionService = questionOptionService;
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult MyAccount()
        {

            return View();
        }

        public ActionResult Surveys(int page = 1, int surveyId = 0)
        {
            //var surveys = _surveyService.GetAll();
            //SurveyListViewModel model = new SurveyListViewModel()
            //{
            //    Surveys = surveys
            //};

            int pageSize = 10;
            var questions = _questionService.GetBySurveyId(surveyId);
            var questionOptions = _questionOptionService.GetAll();
            QuestionListViewModel model = new QuestionListViewModel
            {
                Questions = questions.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                QuestionOptions = questionOptions
            };

            return View(model);
        }

        public ActionResult SurveyCreate()
        {

            return View();
        }

        public ActionResult Update(int questionId)
        {
            var model = new QuestionUpdateViewModel
            {
                Question = _questionService.GetByQuestionId(questionId),
                QuestionOptions = _questionOptionService.GetByQuestionId(questionId)
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(QuestionUpdateViewModel questionUpdateViewModel)
        {
            return Redirect("/Home/Surveys");
        }
    }
}
