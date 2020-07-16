using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetById(int personId)
        {
            return _userDal.Get(u => u.PersonId == personId);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }
    }
}
