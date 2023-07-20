using KasrikProject.BusinessLayer.Abstract;
using KasrikProject.DataAccessLayer.Abstract;
using KasrikProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasrikProject.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> GetList()
        {
            throw new NotImplementedException();
        }

        public void TDelete(Order t)
        {
            throw new NotImplementedException();
        }

        public Order TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Order t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Order t)
        {
            throw new NotImplementedException();
        }
    }
}
