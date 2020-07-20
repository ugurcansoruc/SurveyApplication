using SurveyApplication.SurveyDb.Entities.Concrete;


namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class QuestionOptionUpdateViewModel
    {
        public QuestionResponseOption QuestionOption { get;  set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
    }
}
