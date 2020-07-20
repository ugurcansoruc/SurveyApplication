using System.Collections.Generic;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Abstract
{
    public interface IGroupService
    {
        List<Group> GetList();
    }
}
