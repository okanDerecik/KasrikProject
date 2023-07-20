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
    public class ProductReviewManager : IProductReviewService
    {
        private readonly IProductReviewDal _productReviewDal;

        public ProductReviewManager(IProductReviewDal productReviewDal)
        {
            _productReviewDal = productReviewDal;
        }

        public List<ProductReview> GetList()
        {
            throw new NotImplementedException();
        }

        public void TDelete(ProductReview t)
        {
            throw new NotImplementedException();
        }

        public ProductReview TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(ProductReview t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ProductReview t)
        {
            throw new NotImplementedException();
        }
    }
}
