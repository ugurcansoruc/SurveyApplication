using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class QuestionOptionManager : IQuestionOptionService
    {
        private IQuestionOptionsDal _questionOptionsDal;

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
    }
}
