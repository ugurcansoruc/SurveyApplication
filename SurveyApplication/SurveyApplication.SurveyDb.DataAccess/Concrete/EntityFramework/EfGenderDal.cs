using System;
using System.Collections.Generic;
using System.Text;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework
{
    public class EfGenderDal : EfEntityRepositoryBase<Gender, SurveyDbContext>, IGenderDal
    {
    }
}
