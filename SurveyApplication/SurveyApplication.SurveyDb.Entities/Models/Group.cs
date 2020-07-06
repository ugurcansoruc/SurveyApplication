using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Models
{
    public partial class Group
    {
        public Group()
        {
            this.Managers = new List<Manager>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
    }
}
