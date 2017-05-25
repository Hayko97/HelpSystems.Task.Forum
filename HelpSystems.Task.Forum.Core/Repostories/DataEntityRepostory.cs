using HelpSystems.Hayk.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpSystems.Task.Forum.Core.Enums;

namespace HelpSystems.Hayk.Core.Repostories
{
     public class DataEntityRepostory<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DataEntityRepostory(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        private IRepository<TEntity> repository;

        public IEnumerable<TEntity> SelectAll()
        {
            return repository.SelectAll();
        }

        public IEnumerable<TEntity> Select(Func<TEntity, bool> predicate)
        {
            return repository.Select(predicate);
        }

        public DataStatus Add(TEntity entity)
        {
            return repository.Add(entity);
        }

        public DataStatus IsAvailable(Func<TEntity, bool> predicate)
        {
            return repository.IsAvailable(predicate);
        }

        public void Dispose()
        {
            repository.Dispose();
        }

        public IEnumerable<TEntity> GetProcedureResult()
        {
            throw new NotImplementedException();
        }

        public DataStatus Remove(Func<TEntity, bool> predicate)
        {
            return repository.Remove(predicate);
        }

     
        public TEntity Update(Func<TEntity, bool> predicate)
        {
            return repository.Update(predicate);
        }

        public DataStatus SaveChanges()
        {
            return repository.SaveChanges();
        }
    }
}
