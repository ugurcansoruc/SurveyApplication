
using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.MvcWebUI.Models;

namespace SurveyApplication.SurveyDb.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IPersonService _personService;
        private readonly IUserService _userService;
        private readonly ICityService _cityService;
        private readonly IGenderService _genderService;
        private readonly ILogger<AccountController> _logger;


        public AccountController(IPersonService personService, IUserService userService, ICityService cityService, IGenderService genderService, ILogger<AccountController> logger)
        {
            _personService = personService;
            _userService = userService;
            _cityService = cityService;
            _genderService = genderService;
            _logger = logger;
            logger.LogInformation("Hello first log in AccountController Constructor");
        }

        public ActionResult Login()
        {
            _logger.LogInformation("Hello firs log in AccountController Login Action");
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountViewModel accountViewModel)
        {
            var locker = Security.Security.CreatLocker();

            if (ModelState.IsValid)
            {
                bool check = false;
                
                var person = _personService.GetByEmail(accountViewModel.Person.Email);

                if (person!=null)
                {
                    var decryptKey = locker.Decrypt(person.Password);
                    _logger.LogInformation("{name} {lastname} in logged",person.FirstName,person.LastName);
                    
                    if (accountViewModel.Person.Password == decryptKey)
                    {
                        check = true;
                    }
                }

                if (person != null && check)
                {
                    HttpContext.Session.SetInt32("personId",person.Id);

                    if (person.PersonTypeId == 1)
                    {
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Manager");
                    }
                }
            }
            return RedirectToAction("Login");
        }

        public ActionResult Register()
        {
            var model = new AccountViewModel
            {
                Genders = _genderService.GetList(),
                Cities = _cityService.GetList()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(AccountViewModel accountViewModel)
        {
            var SCollection = new ServiceCollection();
            SCollection.AddDataProtection();
            var LockerKey = SCollection.BuildServiceProvider();
            var locker = ActivatorUtilities.CreateInstance<Security.Security>(LockerKey);

            if (ModelState.IsValid)
            {
                _logger.LogInformation("{firstname} {lastname}",accountViewModel.Person.FirstName,accountViewModel.Person.LastName);

                accountViewModel.Person.PersonTypeId = 1;
                string encryptKey = locker.Encrypt(accountViewModel.Person.Password);
                accountViewModel.Person.Password = encryptKey;

                _personService.Add(accountViewModel.Person);
                accountViewModel.User.PersonId = accountViewModel.Person.Id;
                _userService.Add(accountViewModel.User);

                return RedirectToAction("Login");

            }

            return RedirectToAction("Register");
        }
    }
}
