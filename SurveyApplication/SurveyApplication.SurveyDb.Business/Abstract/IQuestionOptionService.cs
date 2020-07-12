using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IQuestionOptionService
    {
        List<QuestionResponseOption> GetAll();
        List<QuestionResponseOption> GetByQuestionId(int questionId);

    }
}
