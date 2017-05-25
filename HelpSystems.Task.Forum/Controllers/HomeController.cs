
using HelpSystems.Task.Forum.Models;
using HelpSystems.Task.Forum.Repository;
using HelpSystems.Task.Forum.Repository.Entities;
using HelpSystems.Task.Forum.Repository.Services;
using Newtonsoft.Json;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpSystems.Task.Forum.Controllers
{
    public class HomeController : Controller
    {
        private IForumRepository rpository;
        public HomeController(IForumRepository repo)
        {
            rpository = repo;
        }
       
        public ActionResult Index()
        {
            ViewBag.topics = rpository.SelectAll<Topic>().ToList();
            ViewBag.Threds = rpository.SelectAll<Thread>();
            return View();
        }
        public ActionResult GetThreadsByTopic(int id)
        {
            var threadLils = rpository.Select<Thread>(x => x.TopicId == id);

            return PartialView("Threads", threadLils.ToList());

        }
        public ActionResult Topic(int id)
        {
            ViewBag.TopicName = rpository.Select<Topic>(x => x.Id == id).FirstOrDefault().Name;
            var threadList = rpository.Select<Thread>(x =>x.TopicId == id);
            ViewBag.topicId = id;
            return View(threadList.ToList());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AddThread(ThreadViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = rpository.Insert<Thread>(model.GetDataEntity());
                    return Json(result);
                }
                else
                    return Json("failed");
            }
            catch (Exception e)
            {
                return null;
            }



        }
        public ActionResult GetPostByThreadId(int id, bool InMain)
        {
            if (InMain)
                ViewBag.InMain = true;
            else
                ViewBag.InMain = false;
            var postList = rpository.Select<Post>(x => x.ThreadId == id);

            ViewBag.PostCount = postList.Count();
            var latestpost = postList.OrderByDescending(x => x.Date).FirstOrDefault();
            return PartialView("PostPartial", latestpost);
        }
        public ActionResult Thread(int id, int? page)
        {
            var thread = rpository.Select<Thread>(x => x.Id == id).FirstOrDefault();

            ViewBag.ThreadName = thread.Title;
            ViewBag.ThreadDesc = thread.Description;
            ViewBag.ThreadId = thread.Id;
            ViewBag.IsClosed = thread.IsClosed;

            const int pageSize = 8;
            int pageNumber = (page ?? 1);
            var postList = rpository.Select<Post>(x => x.ThreadId == id);
            return View(postList.ToPagedList(pageNumber, pageSize));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AddPost(PostViewModel model)
        {
            try
            {
                var result = rpository.Insert(model.GetDataEntity());
                return Json(result);
            }
            catch (Exception e)
            {
                return null;
            }


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult EditPost(PostViewModel model, int postId)
        {

            var result = rpository.UpdateDescription(postId, model.Description);
            return Json(result);

        }
        [HttpPost]

        public JsonResult DeletePost(int postId)
        {
            try
            {
                var result = rpository.Remove<Post>(x => x.Id == postId);
                return Json(result);
            }
            catch (Exception e)
            {
                return Json(DataStatus.Failed);
            }


        }
        [HttpPost]
        public JsonResult CloseOrOpen(int Id)
        {
            var result = rpository.CloseOrOpenThread(Id);
            return Json(result);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                rpository.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}