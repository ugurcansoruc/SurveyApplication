﻿using System.Collections.Generic;

using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.MvcWebUI.Models
{
    public class AccountViewModel
    {
        public Person Person { get; set; }
        public User User { get; set; }
        public List<Gender> Genders { get; set; }
        public List<City> Cities { get; set; }
    }
}
