using ShopCore.Core.DataAccess.Abstract;
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
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Add(Product entity)
        {
            return _productRepository.Add(entity);
        }

        public void Delete(Product entity)
        {
             _productRepository.Delete(entity);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _productRepository.Get(filter);

        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);

        }

        public IEnumerable<Product> GetEnumerableAll(Expression<Func<Product, bool>> filter = null)
        {
            return _productRepository.GetEnumerableAll(filter);

        }

        public IQueryable<Product> GetQueryableAll(Expression<Func<Product, bool>> filter = null)
        {
            return _productRepository.GetQueryableAll(filter);

        }

        public Product Update(Product entity)
        {
            return _productRepository.Update(entity);
        }
    }
}
