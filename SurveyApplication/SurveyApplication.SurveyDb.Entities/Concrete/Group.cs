using System;
using System.Collections.Generic;
using SurveyApplication.Core.Entities;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class Group:IEntity
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
