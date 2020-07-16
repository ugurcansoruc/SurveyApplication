using System;
using System.Collections.Generic;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class QuestionType
    {
        public QuestionType()
        {
            this.Questions = new List<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
    }
}
