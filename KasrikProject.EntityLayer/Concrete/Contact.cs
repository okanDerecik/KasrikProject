using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasrikProject.EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string SenderFullName { get; set; }
        public string SenderEmail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
