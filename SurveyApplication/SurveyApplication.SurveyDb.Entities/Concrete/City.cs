using System.Collections.Generic;
using SurveyApplication.SurveyDb.Entities.Abstract;

namespace SurveyApplication.SurveyDb.Entities.Concrete
{
    public class City : IEntity
    {
        public City()
        {
            this.Users = new List<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
