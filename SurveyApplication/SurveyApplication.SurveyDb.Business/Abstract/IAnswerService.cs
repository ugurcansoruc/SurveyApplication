using System.Collections.Generic;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IAnswerService
    {
        List<Answer> GetBySurveyAndUserId(int surveyId, int userId);
        int GetBySurveyUserIdQuestionId(int surveyId, int userId, int questionId);

        void Add(Answer answer);

        int GetOptionCount(int choiceId);
    }
}
