using HelpSystems.Hayk.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpSystems.Task.Forum.Core.Enums;

namespace HelpSystems.Hayk.Core.DataEntuties
{
    class DataEntity
    {
        protected DataEntity(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        protected DataContext dataContext;


    }

    class DataEntity<TEntity> : DataEntity, IRepository<TEntity>
        where TEntity : class
    {
        public DataEntity(DataContext dataContext)
            : base(dataContext)
        { }

        private Table<TEntity> Table
        {
            get { return dataContext.GetTable<TEntity>(); }
        }

        public DataStatus Add(TEntity entity)
        {
            try
            {
                Table.InsertOnSubmit(entity);
                dataContext.SubmitChanges();
                return DataStatus.Success;
            }
            catch (Exception e)
            {
                return DataStatus.Failed;
            }

        }

        public void Dispose()
        {
            dataContext.Dispose();
        }

        public IEnumerable<TEntity> GetProcedureResult()
        {
            throw new NotImplementedException();
        }

        public DataStatus IsAvailable(Func<TEntity, bool> predicate)
        {
            var resullt = Table.Where(predicate).FirstOrDefault();
            if (resullt == null)
                return DataStatus.NotAvailable;
            else
                return DataStatus.Success;

        }


        public DataStatus Remove(Func<TEntity, bool> predicate)
        {
            try
            {
                var model = Table.First(predicate);

                Table.DeleteOnSubmit(model);


                dataContext.SubmitChanges();
                return DataStatus.Success;
            }
            catch (Exception e)
            {
                return DataStatus.Failed;
            }

        }

        public DataStatus SaveChanges()
        {
            try
            {
                dataContext.SubmitChanges();
                return DataStatus.Success;
            }
            catch (Exception e)
            {
                return DataStatus.Failed;
            }
        }

        public IEnumerable<TEntity> Select(Func<TEntity, bool> predicate)
        {
            return Table.Where(predicate);
        }

        public IEnumerable<TEntity> SelectAll()
        {
            return Table.ToList();
        }

        public TEntity Update(Func<TEntity, bool> predicate)
        {
            try
            {
                var model = Table.Single(predicate);

                return model;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
