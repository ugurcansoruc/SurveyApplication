﻿using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface ICityService
    {
        List<City> GetList();

    }
}
