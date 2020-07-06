using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Models
{
    public partial class Question
    {
        public Question()
        {
            this.Answers = new List<Answer>();
            this.QuestionResponseOptions = new List<QuestionResponseOption>();
            this.Surveys = new List<Survey>();
        }

        public int Id { get; set; }
        public int QuestionTypeId { get; set; }
        public string Text { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<QuestionResponseOption> QuestionResponseOptions { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual ICollection<Survey> Surveys { get; set; }
    }
}
