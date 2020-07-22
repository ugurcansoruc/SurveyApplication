using System.Collections.Generic;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class QuestionOptionManager : IQuestionOptionService
    {
        private readonly IQuestionOptionsDal _questionOptionsDal;

        public QuestionOptionManager(IQuestionOptionsDal questionOptionsDal)
        {
            _questionOptionsDal = questionOptionsDal;
        }

        public List<QuestionResponseOption> GetAll()
        {
            return _questionOptionsDal.GetList();
        }

        public List<QuestionResponseOption> GetByQuestionId(int questionId)
        {
            return _questionOptionsDal.GetList(p => p.QuestionId == questionId);

        }

        public QuestionResponseOption GetById(int questionResponseOptionId)
        {
            return _questionOptionsDal.Get(p => p.Id == questionResponseOptionId);
        }

        public void Update(QuestionResponseOption questionResponseOption)
        {
            _questionOptionsDal.Update(questionResponseOption);
        }

        public void Add(QuestionResponseOption questionResponseOption)
        {
            _questionOptionsDal.Add(questionResponseOption);
        }

        public int GetAddedOptionCount(int questionId)
        {
            return _questionOptionsDal.GetList(p => p.QuestionId == questionId).Count;
        }

        public void Delete(int optionId)
        {
            _questionOptionsDal.Delete(new QuestionResponseOption { Id = optionId });

        }
    }
}
