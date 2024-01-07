using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Models
{
    public class DashboardSocialMediaInsta
    {
            public string id { get; set; }
            public string fbid { get; set; }
            public string username { get; set; }
            public string full_name { get; set; }
            public string bio { get; set; }
            public int followers { get; set; }
            public int following { get; set; }
            public string category_name { get; set; }
            public bool is_private { get; set; }
            public bool is_verified { get; set; }
            public bool is_business { get; set; }
            public string profile_pic_url { get; set; }
            public string profile_pic_url_proxy { get; set; }
            public string profile_pic_url_hd { get; set; }
            public string profile_pic_url_hd_proxy { get; set; }
        }
    
}
