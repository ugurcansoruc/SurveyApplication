using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Abstract
{
    public interface IPersonUserDal : IEntityRepository<PersonUser>
    {
        List<PersonUser> PersonUsersGetAll();
    }
}
