using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Entities.Abstract;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class PersonUser:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }
}
