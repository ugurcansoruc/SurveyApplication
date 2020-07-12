using System.Data.Entity;
using SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework.Mapping;
using SurveyApplication.SurveyDb.Entities.Concrete;
using DbContext = System.Data.Entity.DbContext;


namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework
{
    public class SurveyDbContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<QuestionResponseOption> QuestionResponseOptions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<PersonType> PersonTypes { get; set; }
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
    }
}
