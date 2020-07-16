using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IAnswerService
    {
        List<Answer> GetBySurveyAndUserId(int surveyId, int userId);
        void Add(Answer answer);

        int GetOptionCount(int choiceId);
    }
}
