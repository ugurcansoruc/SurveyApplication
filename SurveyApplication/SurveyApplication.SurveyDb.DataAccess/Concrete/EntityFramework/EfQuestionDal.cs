
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework
{
    public class EfQuestionDal: EfEntityRepositoryBase<Question, SurveyDbContext>, IQuestionDal
    {
    }
}
