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
                Password = "CfDJ8PlljSUaVGhHls_yGgb5oAxvVVLwROlFG_gFxLUTiqRHWIDOQAr7dEaOMrhUQMf9zv1f4E4TmzkXOsS_4nxHjY1KLUj8CDBtl27NejFLFjAca94UCWZ4PUTmvd9XBkLuAQ",
                PersonTypeId = 1
            });

            persons.Add(new Person()
            {//tüm kullanıcıların passwordleri = 123456789 
                FirstName = "Adem",
                LastName = "Soruç",
                Email = "adem.soruc@gmail.com",
                Password = "CfDJ8PlljSUaVGhHls_yGgb5oAxvVVLwROlFG_gFxLUTiqRHWIDOQAr7dEaOMrhUQMf9zv1f4E4TmzkXOsS_4nxHjY1KLUj8CDBtl27NejFLFjAca94UCWZ4PUTmvd9XBkLuAQ",
                PersonTypeId = 2
            });

            persons.Add(new Person()
            {
                FirstName = "Yusuf",
                LastName = "Ceylan",
                Email = "yusuf.ceylan@gmail.com",
                Password = "CfDJ8PlljSUaVGhHls_yGgb5oAxvVVLwROlFG_gFxLUTiqRHWIDOQAr7dEaOMrhUQMf9zv1f4E4TmzkXOsS_4nxHjY1KLUj8CDBtl27NejFLFjAca94UCWZ4PUTmvd9XBkLuAQ",
                PersonTypeId = 1
            });

            persons.Add(new Person()
            {
                FirstName = "Tuncay",
                LastName = "Damlar",
                Email = "tuncay.damlar@gmail.com",
                Password = "CfDJ8PlljSUaVGhHls_yGgb5oAxvVVLwROlFG_gFxLUTiqRHWIDOQAr7dEaOMrhUQMf9zv1f4E4TmzkXOsS_4nxHjY1KLUj8CDBtl27NejFLFjAca94UCWZ4PUTmvd9XBkLuAQ",
                PersonTypeId = 1
            });

            persons.Add(new Person()
            {
                FirstName = "Sinan",
                LastName = "Ganiz",
                Email = "sinan.ganiz@gmail.com",
                Password = "CfDJ8PlljSUaVGhHls_yGgb5oAxvVVLwROlFG_gFxLUTiqRHWIDOQAr7dEaOMrhUQMf9zv1f4E4TmzkXOsS_4nxHjY1KLUj8CDBtl27NejFLFjAca94UCWZ4PUTmvd9XBkLuAQ",
                PersonTypeId = 1
            });

            persons.Add(new Person()
            {
                FirstName = "Feyzullah",
                LastName = "Hasar",
                Email = "feyzullah.hasar@gmail.com",
                Password = "CfDJ8PlljSUaVGhHls_yGgb5oAxvVVLwROlFG_gFxLUTiqRHWIDOQAr7dEaOMrhUQMf9zv1f4E4TmzkXOsS_4nxHjY1KLUj8CDBtl27NejFLFjAca94UCWZ4PUTmvd9XBkLuAQ",
                PersonTypeId = 1
            });

            persons.Add(new Person()
            {
                FirstName = "Emine",
                LastName = "Soruç",
                Email = "emine.soruc@gmail.com",
                Password = "CfDJ8PlljSUaVGhHls_yGgb5oAxvVVLwROlFG_gFxLUTiqRHWIDOQAr7dEaOMrhUQMf9zv1f4E4TmzkXOsS_4nxHjY1KLUj8CDBtl27NejFLFjAca94UCWZ4PUTmvd9XBkLuAQ",
                PersonTypeId = 1
            });

            persons.Add(new Person()
            {
                FirstName = "Kerim",
                LastName = "Ünal",
                Email = "kerim.Ünal@gmail.com",
                Password = "CfDJ8PlljSUaVGhHls_yGgb5oAxvVVLwROlFG_gFxLUTiqRHWIDOQAr7dEaOMrhUQMf9zv1f4E4TmzkXOsS_4nxHjY1KLUj8CDBtl27NejFLFjAca94UCWZ4PUTmvd9XBkLuAQ",
                PersonTypeId = 1
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

            users.Add(new User()
            {
                PersonId = 3,
                CityId = 1,
                Age = 21,
                GenderId = 2,

            });

            users.Add(new User()
            {
                PersonId = 4,
                CityId = 3,
                Age = 21,
                GenderId = 2,

            });

            users.Add(new User()
            {
                PersonId = 5,
                CityId = 2,
                Age = 21,
                GenderId = 2,
            });

            users.Add(new User()
            {
                PersonId = 6,
                CityId = 1,
                Age = 21,
                GenderId = 2,
            });

            users.Add(new User()
            {
                PersonId = 7,
                CityId = 2,
                Age = 47,
                GenderId = 1,
            });

            users.Add(new User()
            {
                PersonId = 8,
                CityId = 3,
                Age = 29,
                GenderId = 2,
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
                Text = "Biraz olumlu"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 1,
                Text = "Ne olumlu ne de olumsuz"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 1,
                Text = "Biraz olumsuz"
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
                Text = "Kısmen memnunum"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 2,
                Text = "Ne memnunum ne de değilim"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 2,
                Text = "Pek memnun değilim"
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
                Text = "Çok gerçekçi"
            });
            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 8,
                Text = "Orta derecede gerçekçi"
            });

            questionResponseOptions.Add(new QuestionResponseOption()
            {
                QuestionId = 8,
                Text = "Kısmen gerçekçi"
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
                Text = "Hiç değer vermiyor"
            });

           
            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 1,
                UserId = 1,
                Choice = 1
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 2,
                UserId = 1,
                Choice = 6
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 3,
                UserId = 1,
                Choice = 11
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 4,
                UserId = 1,
                Choice = 14
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 5,
                UserId = 1,
                Choice = 16
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 1,
                UserId = 3,
                Choice = 2
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 2,
                UserId = 3,
                Choice = 7
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 3,
                UserId = 3,
                Choice = 12
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 4,
                UserId = 3,
                Choice = 15
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 5,
                UserId = 3,
                Choice = 17
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 1,
                UserId = 4,
                Choice = 3
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 2,
                UserId = 4,
                Choice = 8
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 3,
                UserId = 4,
                Choice = 13
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 4,
                UserId = 4,
                Choice = 14
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 5,
                UserId = 4,
                Choice = 18
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 1,
                UserId = 5,
                Choice = 4
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 2,
                UserId = 5,
                Choice = 9
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 3,
                UserId = 5,
                Choice = 13
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 4,
                UserId = 5,
                Choice = 14
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 5,
                UserId = 5,
                Choice = 18
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 1,
                UserId = 6,
                Choice = 5
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 2,
                UserId = 6,
                Choice = 10
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 3,
                UserId = 6,
                Choice = 13
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 4,
                UserId = 6,
                Choice = 14
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 5,
                UserId = 6,
                Choice = 18
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 1,
                UserId = 7,
                Choice = 1
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 2,
                UserId = 7,
                Choice = 7
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 3,
                UserId = 7,
                Choice = 11
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 4,
                UserId = 7,
                Choice = 14
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 5,
                UserId = 7,
                Choice = 16
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 1,
                UserId = 8,
                Choice = 2
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 2,
                UserId = 8,
                Choice = 6
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 3,
                UserId = 8,
                Choice = 11
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 4,
                UserId = 8,
                Choice = 15
            });

            answers.Add(new Answer()
            {
                SurveyId = 1,
                QuestionId = 5,
                UserId = 8,
                Choice = 16
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
