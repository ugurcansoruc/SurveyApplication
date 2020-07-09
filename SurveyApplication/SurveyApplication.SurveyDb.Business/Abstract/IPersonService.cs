using SurveyApplication.SurveyDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();

    }
}
