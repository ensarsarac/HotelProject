using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Oda numarası boş bırakılamaz.")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Oda fiyatı boş bırakılamaz.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Oda tipi boş bırakılamaz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Yatak sayısı boş bırakılamaz.")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Banyo sayısı boş bırakılamaz.")]
        public string BathCount { get; set; }
        public string CoverImage { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
        public string Description { get; set; }
    }
}
