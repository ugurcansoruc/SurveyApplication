using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class UserUpdateListViewModel
    {
        public Person Person { get; set; }
        public User User { get; set; }
        public List<City> Cities { get; set; }
        public List<Gender> Genders { get; set; }
    }
}
