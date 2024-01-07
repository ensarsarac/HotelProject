using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Dtos.ContactDto
{
    public class CreateContactDto
    {
        [Required(ErrorMessage ="Lütfen ad alanını doldurunuz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen mail alanını doldurunuz.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen konu alanını doldurunuz.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Lütfen mesaj alanını doldurunuz.")]
        public string Message { get; set; }
        public string MessageCategoryID { get; set; }
        public DateTime Date { get; set; }
    }
}
