﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;
using SurveyApplication.SurveyDb.MvcWebUI.Models;

namespace SurveyApplication.SurveyDb.MvcWebUI.Controllers
{
    public class ManagerController : Controller
    {
        private ISurveyService _surveyService;
        private IQuestionService _questionService;
        private IQuestionOptionService _questionOptionService;
        private IManagerService _managerService;
        private IPersonService _personService;
        private IGroupService _groupService;
        public ManagerController(ISurveyService surveyService, IQuestionService questionService, IQuestionOptionService questionOptionService, IManagerService managerService, IPersonService personService, IGroupService groupService)
        {
            _surveyService = surveyService;
            _questionService = questionService;
            _questionOptionService = questionOptionService;
            _managerService = managerService;
            _personService = personService;
            _groupService = groupService;
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult MyAccount()
        {
            var model = new ManagerUpdateListViewModel
            {
                Person = _personService.GetById(1),
                Manager = _managerService.GetById(1),
                Groups = _groupService.GetList()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult MyAccount(ManagerUpdateListViewModel managerUpdateListViewModel)
        {
            if (ModelState.IsValid)
            {
                _personService.Update(managerUpdateListViewModel.Person);
                _managerService.Update(managerUpdateListViewModel.Manager);
            }

            managerUpdateListViewModel.Groups = _groupService.GetList();
            return View(managerUpdateListViewModel);
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


        public ActionResult SurveyQuestionCreate(SurveyQuestionCreateViewModel surveyQuestionCreateViewModel, int surveyId)
        {
            surveyQuestionCreateViewModel.SurveyId = surveyId;
            surveyQuestionCreateViewModel.Questions = _questionService.GetBySurveyId(surveyId);
            surveyQuestionCreateViewModel.QuestionResponseOptions = _questionOptionService.GetAll();

            return View(surveyQuestionCreateViewModel);
        }

        [HttpPost]
        public ActionResult SurveyQuestionCreate(SurveyViewModel surveyViewModel, SurveyQuestionCreateViewModel surveyQuestionCreateViewModel)
        {
            var model = new SurveyQuestionCreateViewModel();

            if (surveyViewModel.Survey != null)
            {
                surveyViewModel.Survey.StartDate = DateTime.Now;
                surveyViewModel.Survey.EndDate = DateTime.Now;
                surveyViewModel.Survey.ManagerId = 1;//şuanlık 
                surveyViewModel.Survey.IsOpen = true;

                _surveyService.Add(surveyViewModel.Survey);
            }

            if (surveyQuestionCreateViewModel.Question == null)
            {
                model.SurveyId = surveyViewModel.Survey.Id;
                model.Questions = _questionService.GetBySurveyId(surveyViewModel.Survey.Id);//nket ıd ye göre getireceğim.
                model.QuestionResponseOptions = _questionOptionService.GetAll();
            }
            else
            {
                surveyQuestionCreateViewModel.Question.QuestionTypeId = 2;
                surveyQuestionCreateViewModel.Question.SurveyId = surveyQuestionCreateViewModel.SurveyId;
                _questionService.Add(surveyQuestionCreateViewModel.Question);


                model.SurveyId = surveyQuestionCreateViewModel.SurveyId;
                model.Questions = _questionService.GetBySurveyId(surveyQuestionCreateViewModel.SurveyId);//nket ıd ye göre getireceğim.
                model.QuestionResponseOptions = _questionOptionService.GetAll();

            }

            return View(model);

        }

        public ActionResult CreateOption(int questionId, int surveyId, SurveyQuestionCreateViewModel surveyQuestionCreateViewModel)
        {
            surveyQuestionCreateViewModel.QuestionId = questionId;
            surveyQuestionCreateViewModel.SurveyId = surveyId;
            return View(surveyQuestionCreateViewModel);
        }

        [HttpPost]
        public ActionResult CreateOption(SurveyQuestionCreateViewModel surveyQuestionCreateViewModel)
        {

            surveyQuestionCreateViewModel.QuestionResponseOption.QuestionId = surveyQuestionCreateViewModel.QuestionId;
            _questionOptionService.Add(surveyQuestionCreateViewModel.QuestionResponseOption);

            TempData["CreateOption"] = 1;


            return View(surveyQuestionCreateViewModel);
        }

    }
}