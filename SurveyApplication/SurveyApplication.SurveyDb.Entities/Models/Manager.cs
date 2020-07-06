using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Models
{
    public partial class Manager
    {
        public Manager()
        {
            this.Surveys = new List<Survey>();
        }

        public int PersonId { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Survey> Surveys { get; set; }
    }
}
