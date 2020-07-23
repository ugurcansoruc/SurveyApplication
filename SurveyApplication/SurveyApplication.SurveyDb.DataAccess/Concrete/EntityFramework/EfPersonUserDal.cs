using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework
{
    public class EfPersonUserDal: EfEntityRepositoryBase<PersonUser, SurveyDbContext>, IPersonUserDal
    {
        public List<PersonUser> PersonUsersGetAll()
        {
            using (var surveyDbContext = new SurveyDbContext())
            {
                return (from p in surveyDbContext.Persons
                    join u in surveyDbContext.Users on p.Id equals u.PersonId
                    join g in surveyDbContext.Genders on u.GenderId equals g.Id
                    join c in surveyDbContext.Cities on u.CityId equals c.Id
                    select new PersonUser
                    {
                        Id = p.Id,
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        Age = u.Age,
                        City = c.Name,
                        Gender = g.Name
                    }).ToList();
            }
        }
    }
}
