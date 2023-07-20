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
    public class CartManager : ICartService
    {
        private readonly ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public List<Cart> GetList()
        {
            throw new NotImplementedException();
        }

        public void TDelete(Cart t)
        {
            throw new NotImplementedException();
        }

        public Cart TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Cart t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Cart t)
        {
            throw new NotImplementedException();
        }
    }
}
