using System.Collections.Generic;

using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class AnswerListViewModel
    {
        public List<Question> Questions { get; set; }
        public List<QuestionResponseOption> QuestionOptions { get; set; }
        public List<Answer> Answers { get; set; }
        public Question Question { get; set; }
        public Answer Answer { get; set; }
        public int SurveyId { get; set; }
    }
}
