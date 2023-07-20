using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasrikProject.EntityLayer.Concrete
{
    public class Cart // Alışveriş Sapeti //
    {
        public int CartID { get; set; }
        public int UserID { get; set; }
        public AppUser AppUser { get; set; }
        public List<CartDetail> CartDetails { get; set; }
    }
}
