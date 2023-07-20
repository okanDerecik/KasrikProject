using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasrikProject.EntityLayer.Concrete
{
    public class ProductReview // Kullanıcı Yorumları // 
    {
        public int ProductReviewID { get; set; }
        public int UserID { get; set; }
        public string ProductReviewTitle { get; set;}
        public string Description { get; set;}
        public int Rating { get; set;}
        public DateTime ReviewDate { get; set; }
        public AppUser AppUser { get; set; }
    }
}
