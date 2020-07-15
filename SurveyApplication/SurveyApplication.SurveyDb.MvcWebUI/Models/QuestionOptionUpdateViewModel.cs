using SurveyApplication.SurveyDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class QuestionOptionUpdateViewModel
    {
        public QuestionResponseOption QuestionOption { get;  set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
    }
}
