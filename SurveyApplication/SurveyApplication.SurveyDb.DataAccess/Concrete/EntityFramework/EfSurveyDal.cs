﻿
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework
{
    public class EfSurveyDal : EfEntityRepositoryBase<Survey, SurveyDbContext>, ISurveyDal
    {


    }
}
