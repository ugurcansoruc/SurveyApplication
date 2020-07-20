using System.Collections.Generic;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IQuestionService
    {
        List<Question> GetAll();
        List<Question> GetBySurveyId(int surveyId);
        Question GetById(int questionId);

        void Update(Question question);
        void Add(Question question);
    }
}
