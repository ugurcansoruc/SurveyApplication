using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class PersonUserManager:IPersonUserService
    {
        private readonly IPersonUserDal _personUserDal;

        public PersonUserManager(IPersonUserDal personUserDal)
        {
            _personUserDal = personUserDal;
        }

        public List<PersonUser> GetAll()
        {
            return _personUserDal.PersonUsersGetAll();
        }
    }
}
