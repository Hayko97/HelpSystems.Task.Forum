
using HelpSystems.Task.Forum.Controllers;

using HelpSystems.Task.Forum.Repository;
using HelpSystems.Task.Forum.Repository.Entities;
using HelpSystems.Task.Forum.Repository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using TopicForum.Helpers;

namespace HelpSystems.Task.Forum.Managers
{
    public static class UserManager
    {
        private static IForumRepository repo = new ForumRepository();
        
        private static  void SetAuthCoockie(HttpResponseBase response,User user)
        {
            FormsAuthentication.SetAuthCookie(user.Username, false);

            var authTicket = new FormsAuthenticationTicket(1, user.Username, DateTime.Now, DateTime.Now.AddMinutes(20), false, user.Roles);
            string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
            var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            response.Cookies.Add(authCookie);
        }
        public static DataStatus Login(HttpResponseBase response, User user)
        {
    
            var result = repo.Login(user.Username,user.Password);
            switch (result)
            {
                case DataStatus.Success:
                    SetAuthCoockie(response, user);
                    return result;
                case DataStatus.NotAvailable:
                    return result;
                default:
                    return DataStatus.Failed;
            }
        }
        public static int? GetId(this IPrincipal user)
        {
           
            var result = repo.Select<User>(x => x.Username == user.Identity.Name).FirstOrDefault();
            if (result != null)
                return result.Id;

            return null;

        }
        public static bool IsAdmin(this IPrincipal user)
        {

            var result = repo.Select<User>(x => x.Username == user.Identity.Name).FirstOrDefault();
            if (result != null)
            {
                if (result.Roles == "Admin")
                    return true;
                else
                    return false;
            }

            return false;

        }
        public static string UserPostsCount(int? id)
        {
            var  count = repo.Select<Post>(x => x.UserId == id).Count();
            return count.ToString();
        }
    
    }
}