
using HelpSystems.Task.Forum.Repository;
using HelpSystems.Task.Forum.Repository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HelpSystems.Task.Forum.Attributes
{

    public class AuthorizationAttribute : AuthorizeAttribute
    {
        IForumRepository repo = new ForumRepository(); // my entity  
        private readonly string allowedrole;
        public AuthorizationAttribute(string role)
        {
            this.allowedrole = role;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {


            string username = httpContext.User.Identity.Name;
            var result = repo.CheckAuthRole(username, allowedrole);
            // checking active users with allowed roles.  
            if (result == DataStatus.Success)
                return true;
            else
                return false;


        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Shared/Unauthorized.cshtml"
            };
        }
    }
}