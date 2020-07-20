using System;
using System.Collections.Generic;
using System.Data.Entity;

using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework
{
    public class SurveyDbInitializer : DropCreateDatabaseAlways<SurveyDbContext>
    {
        protected override void Seed(SurveyDbContext context)
        {
            IList<City> cities = new List<City>();
            IList<Gender> genders = new List<Gender>();
            IList<Group> groups = new List<Group>();
            IList<PersonType> personTypes = new List<PersonType>();
            IList<QuestionType> questionTypes = new List<QuestionType>();
            IList<Person> persons = new List<Person>();
            IList<User> users = new List<User>();
            IList<Manager> managers = new List<Manager>();
            IList<Survey> surveys = new List<Survey>();
            IList<Question> questions = new List<Question>();
            IList<QuestionResponseOption> questionResponseOptions = new List<QuestionResponseOption>();
            IList<Answer> answers = new List<Answer>();

            cities.Add(new City() { Name = "Adana" });
            cities.Add(new City() { Name = "Adıyaman" });
            cities.Add(new City() { Name = "Afyon" });

            genders.Add(new Gender() { Name = "Kadın" });
            genders.Add(new Gender() { Name = "Erkek" });

            groups.Add(new Group() { Name = "Sube1" });
            groups.Add(new Group() { Name = "Sube2" });

            personTypes.Add(new PersonType() { Name = "Kullanıcı" });
            personTypes.Add(new PersonType() { Name = "Yönetici" });

            questionTypes.Add(new QuestionType() { Name = "Çoktan Seçmeli" });

            persons.Add(new Person()
            {
                FirstName = "Uğurcan",
                LastName = "Soruç",
                Email = "ugurcan.soruc@gmail.com",
                Password = "123456789",
                PersonTypeId = 1
            });

            persons.Add(new Person()
            {
                FirstName = "Adem",
                LastName = "Soruç",
                Email = "adem.soruc@gmail.com",
                Password = "123456789",
                PersonTypeId = 2
            });

            users.Add(new User()
            {
                PersonId = 1,
                CityId = 1,
                Age = 21,
                GenderId = 2,

            });

            managers.Add(new Manager()
            {
                PersonId = 2,
                GroupId = 1
            });

            surveys.Add(new Survey()
            {
                Name = "İşyeri Memnuniyeti Anketi 1",
                Description = "Çalışanlardan işyeri memnuniyetlerini değerlendirmelerini isteyin ve bunu nasıl geliştireceğinizi öğrenin.",
                IsOpen = true,
                ManagerId = 2,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
            });

            surveys.Add(new Survey()
            {
                Name = "İşyeri Memnuniyeti Anketi 2",
                Description = "Çalışanlardan işyeri memnuniyetlerini değerlendirmelerini isteyin ve bunu nasıl geliştireceğinizi öğrenin.",
                IsOpen = true,
                ManagerId = 2,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
            });

            questions.Add(new Question()
            {
                SurveyId = 1,
                QuestionTypeId = 1,
                Text = "Genel olarak işyerinizle ilgili hisleriniz olumlu mu, olumsuz mu yoksa nötr mü?"
            });

            questions.Add(new Question()
            {
                SurveyId = 1,
                QuestionTypeId = 1,
                Text = "Genel olarak işinizden memnun musunuz, memnun değil misiniz yoksa nötr müsünüz?"
            });
            questions.Add(new Question()
            {
                SurveyId = 1,
                QuestionTypeId = 1,
                Text = "İşvereninizin çalışma ortamı olumlu mu, olumsuz mu yoksa nötr mü?"
            });
            questions.Add(new Question()
            {
                SurveyId = 1,
                QuestionTypeId = 1,
                Text = "Şirketinizde çalışanların yetenekleri ne kadar iyi kullanılıyor?"
            });
            questions.Add(new Question()
            {
                SurveyId = 1,
                QuestionTypeId = 1,
                Text = "Çalışanlar şirket hedeflerinin belirlenmesine ne kadar katılıyor?"
            });

            questions.Add(new Question()
            {
                SurveyId = 2,
                QuestionTypeId = 1,
                Text = "İşvereninizin şirkete ilişkin temel değerlerine inancınız ne kadar güçlü?"
            });

            questions.Add(new Question()
            {
                SurveyId = 2,
                QuestionTypeId = 1,
                Text = "Şirket hedefleri ne kadar net?"
            });
            questions.Add(new Question()
            {
                SurveyId = 2,
                QuestionTypeId = 1,
                Text = "Şirket hedefleri ne kadar gerçekçi?"
            });
            questions.Add(new Question()
            {
                SurveyId = 2,
                QuestionTypeId = 1,
                Text = "İşvereninizin markasıyla ne kadar gurur duyuyorsunuz?"
            });
            questions.Add(new Question()
            {
                SurveyId = 2,
                QuestionTypeId = 1,
                Text = "Sizce bu şirket ürün kalitesine ne kadar değer veriyor?"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 1,
                Text = "Son derece olumlu"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 1,
                Text = "Ne olumlu ne de olumsuz"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 1,
                Text = "Son derece olumsuz"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 2,
                Text = "Son derece memnunum"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 2,
                Text = "Ne memnunum ne de değilim"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 2,
                Text = "Hiç memnun değilim"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 3,
                Text = "Son derece olumlu"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 3,
                Text = "Ne olumlu ne de olumsuz"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 3,
                Text = "Son derece olumsuz"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 4,
                Text = "Son derece iyi"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 4,
                Text = "Orta derecede iyi"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 4,
                Text = "Hiç iyi değil"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 5,
                Text = "Çok katılıyor"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 5,
                Text = "Orta derecede katılıyor"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 5,
                Text = "Hiç katılmıyor"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 6,
                Text = "Oldukça güçlü"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 6,
                Text = "Orta derecede güçlü"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 6,
                Text = "Hiç güçlü değil"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 7,
                Text = "Son derece net"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 7,
                Text = "Orta derecede net"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 7,
                Text = "Hiç net değil"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 8,
                Text = "Son derece gerçekçi"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 8,
                Text = "Orta derecede gerçekçi"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 8,
                Text = "Hiç gerçekçi değil"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 9,
                Text = "Kesinlikle gurur duyuyorum"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 9,
                Text = "Orta derecede gurur duyuyorum"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 9,
                Text = "Hiç gurur duymuyorum"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 10,
                Text = "Son derece fazla"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 10,
                Text = "Orta derecede"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 10,
                Text = "Hiç değer vermiyor"
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 1,
                UserId = 1,
                Choice = 1,
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 2,
                UserId = 1,
                Choice = 4,
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 3,
                UserId = 1,
                Choice = 8,
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 4,
                UserId = 1,
                Choice = 12,
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 5,
                UserId = 1,
                Choice = 14,
            });


            context.Cities.AddRange(cities);
            context.Genders.AddRange(genders);
            context.Groups.AddRange(groups);
            context.PersonTypes.AddRange(personTypes);
            context.QuestionTypes.AddRange(questionTypes);
            context.SaveChanges();
            context.Persons.AddRange(persons);
            context.SaveChanges();
            context.Users.AddRange(users);
            context.Managers.AddRange(managers);
            context.SaveChanges();
            context.Surveys.AddRange(surveys);
            context.SaveChanges();
            context.Questions.AddRange(questions);
            context.SaveChanges();
            context.QuestionResponseOptions.AddRange(questionResponseOptions);
            context.SaveChanges();
            context.Answers.AddRange(answers);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
