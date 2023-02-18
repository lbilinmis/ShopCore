using ShopCore.Business.Abstract;
using ShopCore.DataAccess.Abstract;
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
        ICategoryRepository _categoryRepository;
        public Category Add(Category entity)
        {
            return _categoryRepository.Add(entity);
        }

        public void Delete(Category entity)
        {
             _categoryRepository.Delete(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _categoryRepository.Get(filter);
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public IEnumerable<Category> GetEnumerableAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryRepository.GetEnumerableAll(filter);
        }

        public IQueryable<Category> GetQueryableAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryRepository.GetQueryableAll(filter);
        }

        public Category Update(Category entity)
        {
            return _categoryRepository.Update(entity);
        }
    }
}
