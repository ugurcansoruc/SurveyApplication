using System.Collections.Generic;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class QuestionManager:IQuestionService
    {
        private readonly IQuestionDal _questionDal;

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
            return _questionDal.GetList(p => p.SurveyId == surveyId);
        }

        public Question GetById(int questionId)
        {
            return _questionDal.Get(p => p.Id == questionId);
        }

        public void Update(Question question)
        { 
            _questionDal.Update(question);
        }

        public void Add(Question question)
        {
            _questionDal.Add(question);
        }

        public void Delete(int questionId)
        {
            _questionDal.Delete(new Question { Id = questionId });
        }

        public int GetQuestionCount(int surveyId)
        {
            return _questionDal.GetList(p => p.SurveyId == surveyId).Count;
        }
    }
}
