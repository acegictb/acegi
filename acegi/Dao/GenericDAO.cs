using acegi.DBA;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acegi.Dao
{
    public abstract class GenericDAO<T, ID>
    {

        public T FindByID(ID id)
        {
            try
            {
                return GetSession().Get<T>(id);
            }
            catch
            {
                throw;
            }
        }

        public T FindByIDLock(ID id)
        {
            try
            {
                return GetSession().Get<T>(id, LockMode.Upgrade);
            }
            catch
            {
                throw;
            }
        }

        public IList<T> FindAll()
        {
            try
            {
                return GetSession().CreateCriteria(typeof(T)).List<T>();
            }
            catch
            {
                throw;
            }
        }

        public void Persist(T entity)
        {
            using (ITransaction transaction = GetSession().BeginTransaction())
            {
                try
                {
                    GetSession().Insert(entity);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void Merge(T entity)
        {
            using (ITransaction transaction = GetSession().BeginTransaction())
            {
                try
                {
                    GetSession().Update(entity);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void Delete(T entity)
        {
            using (ITransaction transaction = GetSession().BeginTransaction())
            {
                try
                {
                    GetSession().Delete(entity);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        protected IStatelessSession GetSession()
        {
            return Dbs.GetSession();
        }

    }
}
