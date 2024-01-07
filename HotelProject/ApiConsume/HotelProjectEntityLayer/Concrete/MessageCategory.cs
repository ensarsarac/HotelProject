using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectEntityLayer.Concrete
{
    public class MessageCategory
    {
        [Key]
        public int MessageCategoryID { get; set; }
        public string MessageCategoryName { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}
