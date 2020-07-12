using System;
using System.Collections.Generic;
using SurveyApplication.Core.Entities;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class Manager:IEntity
    {
        public Manager()
        {
            this.Surveys = new List<Survey>();
        }

        public int PersonId { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public Person Person { get; set; }
        public ICollection<Survey> Surveys { get; set; }
    }
}
