using SurveyApplication.SurveyDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class PersonListViewModel
    {
        public List<Person> Persons { get; internal set; }
    }
}
