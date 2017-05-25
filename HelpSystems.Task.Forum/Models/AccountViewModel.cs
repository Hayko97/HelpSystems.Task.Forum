
using HelpSystems.Task.Forum.Interfaces;
using HelpSystems.Task.Forum.Repository.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TopicForum.Helpers;

namespace HelpSystems.Task.Forum.Models
{
    public class LoginViewModel:IEntity<User>
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public User GetDataEntity()
        {
            var model = new User();
            model.Username = Username;            
            model.Password = StringHelper.Encrypt(Password);
            model.RegisterDate = DateTime.Now;
            model.Roles = "User";
            return model;
        }

    }
    public class RegisterViewModel:IEntity<User>
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }

        public  User GetDataEntity()
        {
            var model = new User();
            model.Username = Username;
            model.City = City;
            model.Country = Country;
            model.Password = StringHelper.Encrypt(Password);
            model.RegisterDate = DateTime.Now;
            model.Roles = "User";
            return model;
        }
    }
}