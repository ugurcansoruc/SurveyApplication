using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual User User { get; set; }
    }
}
