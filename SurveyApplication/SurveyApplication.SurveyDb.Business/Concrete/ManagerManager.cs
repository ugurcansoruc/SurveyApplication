
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class ManagerManager : IManagerService
    {
        private readonly IManagerDal _managerDal;

        public ManagerManager(IManagerDal managerDal)
        {
            _managerDal = managerDal;
        }

        public Manager GetById(int personId)
        {
            return _managerDal.Get(m => m.PersonId == personId);
        }

        public void Update(Manager manager)
        {
            _managerDal.Update(manager);
        }
    }
}
