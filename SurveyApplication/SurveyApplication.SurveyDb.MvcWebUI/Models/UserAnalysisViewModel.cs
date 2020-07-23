using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class UserAnalysisViewModel
    {
        public Question LowQuestion { get; set; }
        public Question HighQuestion { get; set; }
        public List<PersonUser> PersonUsers { get; set; }
        public Dictionary<int, int> UsersScore { get; set; }
        public int SurveyId { get; set; }
        public List<QuestionResponseOption> LowOption { get; set; }
        public List<QuestionResponseOption> HighOption { get; set; }
        public int ScoreAvg { get; set; }
    }
}
