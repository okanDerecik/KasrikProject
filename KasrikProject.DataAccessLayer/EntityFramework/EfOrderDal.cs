using KasrikProject.DataAccessLayer.Abstract;
using KasrikProject.DataAccessLayer.Repositories;
using KasrikProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasrikProject.DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
    }
}
