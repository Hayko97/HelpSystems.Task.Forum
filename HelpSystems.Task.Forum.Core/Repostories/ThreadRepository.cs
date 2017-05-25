using HelpSystems.Hayk.Core.Repostories;
using HelpSystems.Task.Forum.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpSystems.Task.Forum.Core.Repostories
{
    public sealed class ThreadRepository:ForumDataEntityRepository<Thread>
    {
        public IEnumerable<Thread> GetThredsByTopic(int id)
        {
            return Select(x => x.TopicId == id);
        }
    }
}
