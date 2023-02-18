using ShopCore.Business.Abstract;
using ShopCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public Category Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetEnumerableAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetQueryableAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
