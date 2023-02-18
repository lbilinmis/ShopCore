
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        T Get(Expression<Func<T, bool>> filter);
        IQueryable<T> GetQueryableAll(Expression<Func<T, bool>> filter = null);
        IEnumerable<T> GetEnumerableAll(Expression<Func<T, bool>> filter = null);

        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);

    }
}
