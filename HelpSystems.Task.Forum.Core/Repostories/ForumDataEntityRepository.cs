using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpSystems.Hayk.Core.Interfaces;
using HelpSystems.Hayk.Core.DataEntuties;

namespace HelpSystems.Hayk.Core.Repostories
{
     public class ForumDataEntityRepository<TEntity> : DataEntityRepostory<TEntity>
        where TEntity : class
    {
      
        protected ForumDataEntityRepository()
            : base(new ForumDataEntity<TEntity>())
        { }
    }
}