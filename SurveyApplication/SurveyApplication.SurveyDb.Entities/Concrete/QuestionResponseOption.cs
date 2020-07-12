using System;
using System.Collections.Generic;
using SurveyApplication.Core.Entities;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class QuestionResponseOption:IEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public Question Question { get; set; }
    }
}
