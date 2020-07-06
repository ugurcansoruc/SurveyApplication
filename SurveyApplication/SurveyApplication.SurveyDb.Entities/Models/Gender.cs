using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Models
{
    public partial class Gender
    {
        public Gender()
        {
            this.Users = new List<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
