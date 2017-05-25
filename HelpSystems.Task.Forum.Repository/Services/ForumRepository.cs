using HelpSystems.Task.Forum.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpSystems.Task.Forum.Repository.Services
{
    public class ForumRepository : IForumRepository
    {
        private ForumDataContextDataContext _context = new ForumDataContextDataContext();

        public DataStatus IsAvailable<TEntity>(Func<TEntity, bool> predicate)
            where TEntity : class
        {
            var resullt = _context.GetTable<TEntity>().Where(predicate).FirstOrDefault();
            if (resullt == null)
                return DataStatus.NotAvailable;
            else
                return DataStatus.Success;

        }
        public DataStatus Register(User user)
        {
            var isAvailable = IsAvailable<User>(x => x.Username == user.Username);
            if (isAvailable == DataStatus.NotAvailable)
            {
                var result = Insert<User>(user);

                return result;
            }
            else
            {
                return DataStatus.IsRegistered;
            }


        }
        public DataStatus Login(string username, string password)
        {
            var result = IsAvailable<User>(x => x.Username == username && x.Password == password);
            return result;
        }
        public DataStatus CheckAuthRole(string username, string role)
        {
            var result = IsAvailable<User>(x => x.Username == username && x.Roles == role);
            return result;
        }
        public DataStatus SubmitChanges()
        {
            try
            {
                _context.SubmitChanges();
                return DataStatus.Success;
            }
            catch (Exception e)
            {
                return DataStatus.Failed;
            }
           

           
        }

        #region Generic Methods

        public IEnumerable<TEntity> SelectAll<TEntity>() where TEntity : class
        {
            return _context.GetTable<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Select<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
        {
            return _context.GetTable<TEntity>().Where(predicate).ToList();
        }

        public TEntity FirstOrDefault<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
        {
            return _context.GetTable<TEntity>().FirstOrDefault(predicate);
        }

        public DataStatus Insert<TEntity>(TEntity entity) where TEntity : class
        {

            _context.GetTable<TEntity>().InsertOnSubmit(entity);
            return SubmitChanges();


        }

        public DataStatus UpdateDescription(int id,string description) 
        {
            var model = _context.GetTable<Post>().Single(x => x.Id == id);
            model.Description = description;
            
            return SubmitChanges();
        }
        public DataStatus CloseOrOpenThread(int id)
        {
            var model = _context.GetTable<Thread>().Single(x => x.Id == id);
            if (model.IsClosed)
            {
                model.IsClosed = false;
            }
            else
                model.IsClosed = true;
            return SubmitChanges();
        }
        public DataStatus Remove<TEntity>(TEntity entity) where TEntity : class
        {
            _context.GetTable<TEntity>().DeleteOnSubmit(entity);
            return SubmitChanges();
        }
        public DataStatus Remove<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
        {
           var model =  _context.GetTable<TEntity>().Where(predicate).FirstOrDefault();
            _context.GetTable<TEntity>().DeleteOnSubmit(model);
            return SubmitChanges();
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }

   



        #endregion
    }
}