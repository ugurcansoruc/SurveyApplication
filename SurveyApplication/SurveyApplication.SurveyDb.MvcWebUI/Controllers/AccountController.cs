using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.MvcWebUI.Models;

namespace SurveyApplication.SurveyDb.MvcWebUI.Controllers
{
    public class AccountController:Controller
    {
        private IPersonService _personService;
        private IManagerService _managerService;
        private IUserService _userService;
        private ICityService _cityService;
        private IGenderService _genderService;


        public AccountController(IPersonService personService, IManagerService managerService, IUserService userService, ICityService cityService, IGenderService genderService)
        {
            _personService = personService;
            _managerService = managerService;
            _userService = userService;
            _cityService = cityService;
            _genderService = genderService;
        }

        public ActionResult Login()
        {
            

            return View();
        }
        
        //public ActionResult Login()
        //{
        //    return View();
        //}

        public ActionResult Register()
        {
            var model = new AccountViewModel
            {
                Genders = _genderService.GetList(),
                Cities = _cityService.GetList()
            };
            return View(model);
        }

        //public ActionResult Register()
        //{
        //    return View();
        //}
    }
}
