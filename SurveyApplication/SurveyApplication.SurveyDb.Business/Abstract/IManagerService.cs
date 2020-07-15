using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IManagerService
    {
        Manager GetById(int personId);

        void Update(Manager manager);
    }
}
