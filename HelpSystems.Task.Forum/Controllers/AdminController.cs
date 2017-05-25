using HelpSystems.Task.Forum.Attributes;
using HelpSystems.Task.Forum.Repository.Entities;
using HelpSystems.Task.Forum.Repository.Services;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpSystems.Task.Forum.Controllers
{
    [Authorization("Admin")]
    public class AdminController : Controller
    {
        
        private IForumRepository repository;
        public AdminController(IForumRepository repo)
        {
            repository = repo;
        }
        public ActionResult Index(int? page)
        {
            var threads = repository.SelectAll<Thread>();
            const int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(threads.ToPagedList(pageNumber, pageSize));
            
        }
        public ActionResult Topics()
        {
            return View(repository.SelectAll<Topic>().ToList());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Topics(string name)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var model = new Topic();
                    model.Name = name;
                    var result = repository.Insert<Topic>(model);
                }
                              
               
                return RedirectToAction("Topics");

            }
            catch(Exception e) {
                return View();
            }
            
        }
        [HttpPost]
      
        public JsonResult TopicRemove(string id)
        {
            int Id = Convert.ToInt32(id);
            var topic = repository.Select<Topic>(x => x.Id == Id).FirstOrDefault();
            var result = repository.Remove(topic);
            return Json(result);
        }
        public ActionResult Users(int? page)
        {
            var users = repository.SelectAll<User>();
            const int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(users.ToPagedList(pageNumber, pageSize));
        }
        [HttpPost]
        public JsonResult DeleteUser(int id)
        {
            var result = repository.Remove<User>(x => x.Id == id);
            return Json(result);
        }
        [HttpPost]
        public JsonResult DeleteThread(int id)
        {
            var result = repository.Remove<Thread>(x => x.Id == id);
            return Json(result);
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