using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class SurveyQuestionCreateViewModel
    {
        public List<Question> Questions { get; set; }
        public Question Question { get; set; }
        public QuestionResponseOption QuestionResponseOption { get; set; }
        public List<QuestionResponseOption> QuestionResponseOptions { get; set; }

        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
    }
}
