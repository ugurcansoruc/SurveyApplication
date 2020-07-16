﻿using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.Core.DataAccess.EntityFramework;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework
{
    public class EfQuestionOptionDal:  EfEntityRepositoryBase<QuestionResponseOption, SurveyDbContext>, IQuestionOptionsDal
    {

    }
}
