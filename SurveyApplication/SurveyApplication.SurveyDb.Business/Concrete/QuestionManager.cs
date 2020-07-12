using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class QuestionManager:IQuestionService
    {
        private IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public List<Question> GetAll()
        {
            return _questionDal.GetList();
        }

        public List<Question> GetBySurveyId(int surveyId)
        {
            return _questionDal.GetList(p => p.SurveyId == surveyId );
        }

        public List<Question> GetByQuestionId(int questionId)
        {
            return _questionDal.GetList(p => p.Id == questionId);
        }
    }
}
