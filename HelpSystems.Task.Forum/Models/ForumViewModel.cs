
using HelpSystems.Task.Forum.Interfaces;
using HelpSystems.Task.Forum.Managers;
using HelpSystems.Task.Forum.Repository.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelpSystems.Task.Forum.Models
{
    public class ThreadViewModel:IEntity<Thread>
    {       
        public int TopicId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        public Thread  GetDataEntity()
        {
            int? id = HttpContext.Current.User.GetId();
            if (id == null)
                return null;
            else
            {
                var model = new Thread();
                model.Date = DateTime.Now;
                model.Description = Description;
                model.Title = Title;
                model.TopicId = TopicId;
                model.UserId = (int)id;
                model.IsClosed = false;
                return model;
            }
            
        }
    }
    public class PostViewModel : IEntity<Post>
    {
        public int ThreadId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        public Post GetDataEntity()
        {
            int? id  = HttpContext.Current.User.GetId();
            if (id == null)
                return null;
            else
            {
                var model = new Post();
                model.Date = DateTime.Now;
                model.Description = Description;               
                model.ThreadId = ThreadId;
                model.UserId = (int)id;
                return model;
            }

        }
    }
}