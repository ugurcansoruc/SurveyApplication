using System.Collections.Generic;

using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class QuestionListViewModel
    {
        public List<Question> Questions { get; set; }
        public List<QuestionResponseOption> QuestionOptions { get; set; }
        public Answer Answer { get; set; }
    }
}
