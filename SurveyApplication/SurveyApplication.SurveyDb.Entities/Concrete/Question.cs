using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class Question
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
        public List<Answer> Answers { get; set; }
        public List<QuestionResponseOption> QuestionResponseOptions { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<Survey> Surveys { get; set; }
    }
}
