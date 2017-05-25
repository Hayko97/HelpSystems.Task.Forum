using HelpSystems.Hayk.Core.Repostories;
using HelpSystems.Task.Forum.Core.DataAccess;
using HelpSystems.Task.Forum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpSystems.Task.Forum.Core.Repostories
{
    public sealed class TopicRepository:ForumDataEntityRepository<Topic>
    {
        public IEnumerable<Topic> GetTopics()
        {
            return SelectAll();
        }
     

    }
}
