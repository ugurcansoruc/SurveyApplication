using System.Collections.Generic;
using SurveyApplication.SurveyDb.Entities.Abstract;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class Question:IEntity
    {
        public Question()
        {
            this.Answers = new List<Answer>();
            this.QuestionResponseOptions = new List<QuestionResponseOption>();
        }

        public int Id { get; set; }

        public int SurveyId { get; set; }
        public int QuestionTypeId { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public List<QuestionResponseOption> QuestionResponseOptions { get; set; }
        public QuestionType QuestionType { get; set; }

        public Survey Survey { get; set; }
    }
}
