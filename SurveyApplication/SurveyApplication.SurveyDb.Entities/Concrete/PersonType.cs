using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class PersonType
    {
        public PersonType()
        {
            this.Persons = new List<Person>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> Persons { get; set; }
    }
}
