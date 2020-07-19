using System;
using System.Collections.Generic;
using SurveyApplication.SurveyDb.Entities.Abstract;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class Person:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PersonTypeId { get; set; }
        public PersonType PersonType { get; set; }
        public Manager Manager { get; set; }
        public User User { get; set; }
    }
}
