using System;
using System.Collections.Generic;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class AnswerManager : IAnswerService
    {
        private readonly IAnswerDal _answerDal;

        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }

        public List<Answer> GetBySurveyAndUserId(int surveyId, int userId)
        {
            return _answerDal.GetList(p => p.SurveyId == surveyId && p.UserId == userId);
        }

        public int GetBySurveyUserIdQuestionId(int surveyId, int userId, int questionId)
        {
            var check = _answerDal.Get(p => p.SurveyId == surveyId && p.UserId == userId && p.QuestionId == questionId);
            if (check != null)
            {
                return _answerDal.Get(p => p.SurveyId == surveyId && p.UserId == userId && p.QuestionId == questionId).Choice;
            }
            return 0;
        }

        public void Add(Answer answer)
        {
            _answerDal.Add(answer);
        }

        public int GetOptionCount(int choiceId)
        {
            return _answerDal.GetList(p => p.Choice == choiceId).Count;
        }
    }
}
