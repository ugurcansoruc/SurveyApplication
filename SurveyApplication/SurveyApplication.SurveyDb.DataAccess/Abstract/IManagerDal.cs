using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.Core.DataAccess;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Abstract
{
    public interface IManagerDal : IEntityRepository<Manager>
    {
    }
}
