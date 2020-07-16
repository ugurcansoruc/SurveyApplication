using SurveyApplication.SurveyDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class SurveyListViewModel
    {
        public List<Survey> Surveys { get; internal set; }
        public int CurrentSurvey { get; internal set; }
    }
}
