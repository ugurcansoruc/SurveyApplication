﻿using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class SurveyManager:ISurveyService
    {
        private ISurveyDal _surveyDal;

        public SurveyManager(ISurveyDal surveyDal)
        {
            _surveyDal = surveyDal;
        }


        public List<Survey> GetAll()
        {
            return _surveyDal.GetList();
        }
    }
}