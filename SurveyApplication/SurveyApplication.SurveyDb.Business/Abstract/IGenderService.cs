using System.Collections.Generic;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IGenderService
    {
        List<Gender> GetList();

    }
}
