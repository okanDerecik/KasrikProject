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
    public class CartDetailManager : ICartDetailService
    {
        private readonly ICartDetailDal _cartDetailDal;

        public CartDetailManager(ICartDetailDal cartDetailDal)
        {
            _cartDetailDal = cartDetailDal;
        }

        public List<CartDetail> GetList()
        {
            throw new NotImplementedException();
        }

        public void TDelete(CartDetail t)
        {
            throw new NotImplementedException();
        }

        public CartDetail TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(CartDetail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(CartDetail t)
        {
            throw new NotImplementedException();
        }
    }
}
