using System.Collections.Generic;

using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class ManagerUpdateListViewModel
    {
        public Person Person { get; set; }
        public Manager Manager { get; set; }
        public List<Group> Groups { get; set; }
    }
}
