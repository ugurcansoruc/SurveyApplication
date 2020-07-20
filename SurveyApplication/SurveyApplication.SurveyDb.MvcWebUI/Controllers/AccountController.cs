
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.MvcWebUI.Models;

namespace SurveyApplication.SurveyDb.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IPersonService _personService;
        private IUserService _userService;
        private ICityService _cityService;
        private IGenderService _genderService;


        public AccountController(IPersonService personService, IUserService userService, ICityService cityService, IGenderService genderService)
        {
            _personService = personService;
            _userService = userService;
            _cityService = cityService;
            _genderService = genderService;
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountViewModel accountViewModel)
        {
            if (ModelState.IsValid)
            {
                var person =
                    _personService.GetByEmailPassword(accountViewModel.Person.Email, accountViewModel.Person.Password);

                if (person != null)
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
            if (ModelState.IsValid)
            {
                accountViewModel.Person.PersonTypeId = 1;
                _personService.Add(accountViewModel.Person);
                accountViewModel.User.PersonId = accountViewModel.Person.Id;
                _userService.Add(accountViewModel.User);

                return RedirectToAction("Login");

            }

            return RedirectToAction("Register");
        }
    }
}
