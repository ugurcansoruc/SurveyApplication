using System.Collections.Generic;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IQuestionOptionService
    {
        List<QuestionResponseOption> GetAll();
        List<QuestionResponseOption> GetByQuestionId(int questionId);
        QuestionResponseOption GetById(int questionResponseOptionId);

        void Update(QuestionResponseOption questionResponseOption);
        void Add(QuestionResponseOption questionResponseOption);
    }
}
