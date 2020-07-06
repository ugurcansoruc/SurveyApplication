using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class Answer
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public int Choice { get; set; }
        public Question Question { get; set; }
        public Survey Survey { get; set; }
        public User User { get; set; }
    }
}
