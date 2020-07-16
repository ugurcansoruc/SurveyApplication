using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class QuestionUpdateViewModel
    {
        public Question Question { get; set; }
        public List<QuestionResponseOption> QuestionOptions { get; set; }
        public Survey Survey { get; set; }
    }
}
