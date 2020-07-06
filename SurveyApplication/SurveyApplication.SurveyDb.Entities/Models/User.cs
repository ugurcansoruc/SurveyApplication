using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Models
{
    public partial class User
    {
        public User()
        {
            this.Answers = new List<Answer>();
        }

        public int PersonId { get; set; }
        public int Age { get; set; }
        public int GenderId { get; set; }
        public int CityId { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual City City { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Person Person { get; set; }
    }
}
