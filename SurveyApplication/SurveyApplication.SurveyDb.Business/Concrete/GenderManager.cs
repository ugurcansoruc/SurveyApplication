using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class GenderManager:IGenderService
    {
        private IGenderDal _genderDal;

        public GenderManager(IGenderDal genderDal)
        {
            _genderDal = genderDal;
        }

        public List<Gender> GetList()
        {
            return _genderDal.GetList();
        }
    }
}
