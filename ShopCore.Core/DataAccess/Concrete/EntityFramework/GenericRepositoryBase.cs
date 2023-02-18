using Microsoft.EntityFrameworkCore;
using ShopCore.Core.DataAccess.Abstract;
using ShopCore.Core.Utilities.Return.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.DataAccess.Concrete.EntityFramework
{
    public class GenericRepositoryBase<T, TContext> : IGenericRepository<T>
        where T : class, new()
        where TContext : DbContext, new()
    {
        public T Add(T entity)
        {
            try
            {
                using (var context = new TContext())
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }

            return entity;
        }

        public void Delete(T entity)
        {
            try
            {
                using (var context = new TContext())
                {
                    var deleteEntity = context.Entry(entity);
                    deleteEntity.State = EntityState.Deleted;
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            try
            {
                using (var context = new TContext())
                {
                    return context.Set<T>().SingleOrDefault(filter); ;

                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IQueryable<T> GetQueryableAll(Expression<Func<T, bool>> filter = null)
        {
            try
            {
                using (var context = new TContext())
                {
                    return filter == null ? context.Set<T>()
                        : context.Set<T>().Where(filter);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T GetById(int id)
        {
            try
            {
                using (var context = new TContext())
                {
                    return context.Set<T>().Find(id); ;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<T> GetEnumerableAll(Expression<Func<T, bool>> filter = null)
        {
            try
            {
                using (var context = new TContext())
                {
                    return filter == null ? context.Set<T>().ToList()
                        : context.Set<T>().Where(filter).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Update(T entity)
        {
            try
            {
                using (var context = new TContext())
                {
                    var updateEntity = context.Entry(entity);
                    updateEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return entity;
        }

        private string GetExceptionMessage(Exception ex)
        {
            string retval = "";
            if (ex.InnerException == null)
            {
                retval = ex.Message.ToString();
            }
            else
            {
                retval = GetExceptionMessage(ex.InnerException);
            }
            return retval;
        }
    }
}
