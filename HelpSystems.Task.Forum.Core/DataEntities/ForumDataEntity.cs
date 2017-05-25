
using HelpSystems.Task.Forum.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpSystems.Hayk.Core.DataEntuties
{
    class ForumDataEntity<TEntity> : DataEntity<TEntity> 
        where TEntity : class
    {
        public ForumDataEntity()
            : base(new ForumDataAccessDataContext())
        { }
    }
}
