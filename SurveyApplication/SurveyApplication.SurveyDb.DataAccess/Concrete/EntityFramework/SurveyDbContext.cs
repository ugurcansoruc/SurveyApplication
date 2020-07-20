
using System.Data.Entity;
using SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework.Mapping;
using SurveyApplication.SurveyDb.Entities.Concrete;
using DbContext = System.Data.Entity.DbContext;


namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework
{
    public class SurveyDbContext : DbContext
    {
        public SurveyDbContext() : base("SurveyDB")
        {
           //Database.SetInitializer(new SurveyDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnswerMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new GenderMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new ManagerMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new QuestionResponseOptionMap());
            modelBuilder.Configurations.Add(new QuestionMap());
            modelBuilder.Configurations.Add(new QuestionTypeMap());
            modelBuilder.Configurations.Add(new SurveyMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new PersonTypeMap());
        }

        public System.Data.Entity.DbSet<Answer> Answers { get; set; }
        public System.Data.Entity.DbSet<City> Cities { get; set; }
        public System.Data.Entity.DbSet<Gender> Genders { get; set; }
        public System.Data.Entity.DbSet<Group> Groups { get; set; }
        public System.Data.Entity.DbSet<Manager> Managers { get; set; }
        public System.Data.Entity.DbSet<Person> Persons { get; set; }
        public System.Data.Entity.DbSet<QuestionResponseOption> QuestionResponseOptions { get; set; }
        public System.Data.Entity.DbSet<Question> Questions { get; set; }
        public System.Data.Entity.DbSet<QuestionType> QuestionTypes { get; set; }
        public System.Data.Entity.DbSet<Survey> Surveys { get; set; }
        public System.Data.Entity.DbSet<User> Users { get; set; }
        public System.Data.Entity.DbSet<PersonType> PersonTypes { get; set; }

        

        
        
        
    }
}
