
using HelpSystems.Task.Forum.Managers;
using HelpSystems.Task.Forum.Models;
using HelpSystems.Task.Forum.Repository;
using HelpSystems.Task.Forum.Repository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HelpSystems.Task.Forum.Controllers
{

    public class AccountController : Controller
    {
        private IForumRepository repository;

        public AccountController(IForumRepository repo)
        {
            repository = repo;
        }

        
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Login(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = model.GetDataEntity();
                    var result = UserManager.Login(Response, user);
                    switch (result)
                    {
                        case DataStatus.Success:
                            return Json(result);
                        case DataStatus.IsRegistered:
                            return Json("This username is already registered");
                        default:
                            return Json(DataStatus.Failed);
                    }


                }
                else
                    return Json("failed");

            }
            catch (Exception e)
            {
                return Json("Token is not verified");
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Register(RegisterViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var user = model.GetDataEntity();
                    var result = repository.Register(user);
                    switch (result)
                    {
                        case DataStatus.Success:
                            var loginresult = UserManager.Login(Response, user);
                            return Json(loginresult);

                        case DataStatus.IsRegistered:
                            return Json("User is already registered");

                        default:
                            return Json("Failed");
                    }

                }
                else
                    return Json("failed");

            }
            catch (Exception e)
            {
                return Json("Token is not verified");
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOut()
        {
            //AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}