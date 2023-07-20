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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }

        public void TDelete(Product t)
        {
            throw new NotImplementedException();
        }

        public Product TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Product t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
