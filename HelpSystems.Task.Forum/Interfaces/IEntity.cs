using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpSystems.Task.Forum.Interfaces
{
    public interface IEntity<TEntity>
    {
        TEntity GetDataEntity();
    }
}