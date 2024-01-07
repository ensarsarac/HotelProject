using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Models
{
    public class AddStaffViewModel
    {

        [Required(ErrorMessage ="Lütfen ad alanını doldurunuz.")]
        [Display(Name ="Adınız")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen ünvan alanını doldurunuz.")]
        [Display(Name = "Ünvan")]
        public string Title { get; set; }
        [Display(Name = "Facebook")]
        public string SocialMedia1 { get; set; }
        [Display(Name = "Instagram")]
        public string SocialMedia2 { get; set; }
        [Display(Name = "Twitter")]
        public string SocialMedia3 { get; set; }
    }
}
