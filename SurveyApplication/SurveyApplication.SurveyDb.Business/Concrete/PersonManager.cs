﻿using System.Collections.Generic;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class PersonManager:IPersonService
    {
        private readonly IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public List<Person> GetAll()
        {
            return _personDal.GetList();
        }

        public Person GetByEmailPassword(string email, string password)
        {
            return _personDal.Get(p => p.Email == email && p.Password == password);
        }

        public Person GetByEmail(string email)
        {
            return _personDal.Get(p => p.Email == email);
        }

        public Person GetById(int personId)
        {
            return _personDal.Get(p=> p.Id == personId);
        }

        public void Update(Person person)
        {
            _personDal.Update(person);
        }

        public void Add(Person person)
        {
            _personDal.Add(person);
        }
    }
}
