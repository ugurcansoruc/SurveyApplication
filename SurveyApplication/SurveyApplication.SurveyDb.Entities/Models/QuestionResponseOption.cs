using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Models
{
    public partial class QuestionResponseOption
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public virtual Question Question { get; set; }
    }
}
