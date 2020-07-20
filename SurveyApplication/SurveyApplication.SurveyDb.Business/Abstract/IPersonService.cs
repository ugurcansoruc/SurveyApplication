using SurveyApplication.SurveyDb.Entities.Concrete;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person GetByEmailPassword(string email, string password);

        Person GetById(int personId);

        void Update(Person person);
        void Add(Person person);
    }
}
