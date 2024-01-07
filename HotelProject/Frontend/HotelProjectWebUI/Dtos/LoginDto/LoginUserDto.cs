using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Lütfen mail alanını doldurunuz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen şifre alanını doldurunuz.")]
        public string Password { get; set; }
    }
}
