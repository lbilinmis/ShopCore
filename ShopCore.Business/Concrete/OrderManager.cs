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
    public class OrderManager : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order Add(Order entity)
        {
            return _orderRepository.Add(entity);
        }

        public void Delete(Order entity)
        {
             _orderRepository.Delete(entity);

        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            return _orderRepository.Get(filter);

        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public IEnumerable<Order> GetEnumerableAll(Expression<Func<Order, bool>> filter = null)
        {
            return _orderRepository.GetEnumerableAll(filter);
        }

        public IQueryable<Order> GetQueryableAll(Expression<Func<Order, bool>> filter = null)
        {
            return _orderRepository.GetQueryableAll(filter);
        }

        public Order Update(Order entity)
        {
            return _orderRepository.Update(entity);
        }
    }
}
