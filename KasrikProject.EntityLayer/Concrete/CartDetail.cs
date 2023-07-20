using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasrikProject.EntityLayer.Concrete
{
    public class CartDetail
    {
        public int CartDetailID { get; set; }
        public int? CartID { get; set; }
        public int OrderID { get; set; }
        public int Piece { get; set; }
        public Cart Carts { get; set; }
        public Order Orders { get; set; }
    }
}
