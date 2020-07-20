
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IUserService
    {
        User GetById(int personId);
        void Update(User user);

        void Add(User user);
    }
}
