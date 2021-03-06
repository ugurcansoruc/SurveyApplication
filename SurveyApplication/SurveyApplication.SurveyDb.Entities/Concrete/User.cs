using System.Collections.Generic;
using SurveyApplication.SurveyDb.Entities.Abstract;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class User:IEntity
    {
        public User()
        {
            this.Answers = new List<Answer>();
        }

        public int PersonId { get; set; }
        public int Age { get; set; }
        public int GenderId { get; set; }
        public int CityId { get; set; }
        public List<Answer> Answers { get; set; }
        public City City { get; set; }
        public Gender Gender { get; set; }
        public Person Person { get; set; }
    }
}
