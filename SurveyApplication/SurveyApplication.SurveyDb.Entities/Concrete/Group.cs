using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class Group
    {
        public Group()
        {
            this.Managers = new List<Manager>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Manager> Managers { get; set; }
    }
}
