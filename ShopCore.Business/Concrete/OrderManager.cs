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
    public class OrderManager : IOrderService
    {
        public Order Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetEnumerableAll(Expression<Func<Order, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetQueryableAll(Expression<Func<Order, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
