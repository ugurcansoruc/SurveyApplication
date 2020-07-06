using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class Gender
    {
        public Gender()
        {
            this.Users = new List<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
