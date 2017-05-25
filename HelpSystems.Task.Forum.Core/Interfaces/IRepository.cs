using HelpSystems.Task.Forum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpSystems.Hayk.Core.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {

        DataStatus Add(TEntity entity);
        IEnumerable<TEntity> SelectAll();
        IEnumerable<TEntity> Select(Func<TEntity, bool> predicate);

        DataStatus IsAvailable(Func<TEntity, bool> predicate);
        IEnumerable<TEntity> GetProcedureResult();
        //TEntity FirstOrDefault(int id);
        //TEntity FirstOrDefault(Func<TEntity, bool> predicate);

        //void Add(TEntity entity);
        TEntity Update(Func<TEntity, bool> entity);
        DataStatus Remove(Func<TEntity, bool> entity);
        DataStatus SaveChanges();
       
       
    }
}