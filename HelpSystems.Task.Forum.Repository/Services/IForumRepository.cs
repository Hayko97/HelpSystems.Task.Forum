using HelpSystems.Task.Forum.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpSystems.Task.Forum.Repository.Services
{
    public interface IForumRepository:IDisposable
    {
        DataStatus IsAvailable<TEntity>(Func<TEntity, bool> predicate) where TEntity : class;

        DataStatus SubmitChanges();

        #region Base Method

        IEnumerable<TEntity> SelectAll<TEntity>() where TEntity : class;
        IEnumerable<TEntity> Select<TEntity>(Func<TEntity, bool> predicate) where TEntity : class;

        TEntity FirstOrDefault<TEntity>(Func<TEntity, bool> predicate) where TEntity : class;

        DataStatus Insert<TEntity>(TEntity entity) where TEntity : class;
       
        DataStatus Remove<TEntity>(TEntity entity) where TEntity : class;
        DataStatus Remove<TEntity>(Func<TEntity, bool> predicate) where TEntity : class;



        //TEntity FirstOrDefault<TEntity>(Func<TEntity, bool> predicate) where TEntity : class;
        //IEnumerable<TEntity> Select<TEntity>(Func<TEntity, bool> predicate) where TEntity : class;

        #endregion

        DataStatus UpdateDescription(int id,string description);
        DataStatus Login(string username, string password);
        DataStatus CloseOrOpenThread(int id);
        DataStatus Register(User user);
        DataStatus CheckAuthRole(string username, string role);
    }
}
