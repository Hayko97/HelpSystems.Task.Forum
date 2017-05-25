
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpSystems.Hayk.Core.Interfaces;
using HelpSystems.Task.Forum.Core.DataAccess;
using HelpSystems.Task.Forum.Core.Enums;

namespace HelpSystems.Hayk.Core.Repostories
{
    public sealed class PostRepository : ForumDataEntityRepository<Post>
    {
        public IEnumerable<string> FindTitles()
        {
            return SelectAll().Select(p => p.Title);
        }
        public DataStatus EditDescription(int id ,string Description)
        {
            var post = Update(x => x.Id == id);
            post.Description = Description;
            var result = SaveChanges();
            return result;
        }
    }
}