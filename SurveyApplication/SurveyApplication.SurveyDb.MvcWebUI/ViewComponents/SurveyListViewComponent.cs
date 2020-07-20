﻿using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.MvcWebUI.Models;

namespace SurveyApplication.SurveyDb.MvcWebUI.ViewComponents
{
    public class SurveyListViewComponent:ViewComponent
    {
        private ISurveyService _surveyService;

        public SurveyListViewComponent(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new SurveyListViewModel()
            {
                Surveys = _surveyService.GetAll(),
                CurrentSurvey =Convert.ToInt32(HttpContext.Request.Query["surveyId"])
            };

            return View(model);
        }
    }
}
