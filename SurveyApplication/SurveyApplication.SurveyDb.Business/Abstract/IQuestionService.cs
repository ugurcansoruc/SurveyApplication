using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IQuestionService
    {
        List<Question> GetAll();
        List<Question> GetBySurveyId(int surveyId);

        List<Question> GetByQuestionId(int questionId);
    }
}
