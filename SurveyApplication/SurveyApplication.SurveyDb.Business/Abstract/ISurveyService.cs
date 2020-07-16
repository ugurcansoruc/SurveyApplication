using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface ISurveyService
    {
        List<Survey> GetAll();
        Survey GetById(int surveyId);
        void Update(Survey survey);
        void Add(Survey survey);

    }
}
