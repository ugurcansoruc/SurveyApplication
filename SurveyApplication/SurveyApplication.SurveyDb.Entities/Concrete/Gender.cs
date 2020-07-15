using System;
using System.Collections.Generic;
using SurveyApplication.Core.Entities;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class Gender : IEntity
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
