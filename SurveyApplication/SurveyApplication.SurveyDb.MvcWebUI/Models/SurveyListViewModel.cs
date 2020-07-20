using SurveyApplication.SurveyDb.Entities.Concrete;
using System.Collections.Generic;


namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class SurveyListViewModel
    {
        public List<Survey> Surveys { get; internal set; }
        public int CurrentSurvey { get; internal set; }
    }
}
