using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasrikProject.EntityLayer.Concrete
{
    public class Order 
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int CustomerTC { get; set; }
        public int CustomerPhone { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerDistict { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public bool DeliveryStatus { get; set; }
        public string CustomerNotes { get; set; }
        public string BillAddress { get; set; }
        public decimal OrderAmount { get; set; }
        public Product Products { get; set; }
        public AppUser AppUser { get; set; }
        public List<CartDetail> CartDetails { get; set; }
    }
}
