using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class PersonManager:IPersonService
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public List<Person> GetAll()
        {
            return _personDal.GetList();
        }

        public Person GetById(int personId)
        {
            return _personDal.Get(p=> p.Id == personId);
        }

        public void Update(Person person)
        {
            _personDal.Update(person);
        }
    }
}
