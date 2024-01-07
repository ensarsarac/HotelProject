using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Models
{
    public class MovieApiViewModel
    {
        public int rank { get; set; }
        public string title{ get; set; }
        public string image{ get; set; }
        public int year{ get; set; }
        public string rating{ get; set; }
        public string trailer{ get; set; }
    }
}
