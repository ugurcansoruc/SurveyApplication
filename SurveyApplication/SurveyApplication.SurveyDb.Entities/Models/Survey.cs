using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Models
{
    public partial class Survey
    {
        public Survey()
        {
            this.Answers = new List<Answer>();
            this.Questions = new List<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool IsOpen { get; set; }
        public int ManagerId { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
