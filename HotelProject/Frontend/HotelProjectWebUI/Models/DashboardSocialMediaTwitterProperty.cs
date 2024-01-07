using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Models
{
    public class DashboardSocialMediaTwitterProperty
    {


            public bool success { get; set; }
            public Data data { get; set; }
        

        public class Data
        {
            public string id { get; set; }
            public User_Info user_info { get; set; }
        }

        public class User_Info
        {
            public bool can_dm { get; set; }
            public bool can_media_tag { get; set; }
            public string created_at { get; set; }
            public bool default_profile { get; set; }
            public bool default_profile_image { get; set; }
            public string description { get; set; }
            public Entities entities { get; set; }
            public int fast_followers_count { get; set; }
            public int favourites_count { get; set; }
            public int followers_count { get; set; }
            public int friends_count { get; set; }
            public bool has_custom_timelines { get; set; }
            public bool is_translator { get; set; }
            public int listed_count { get; set; }
            public string location { get; set; }
            public int media_count { get; set; }
            public string name { get; set; }
            public int normal_followers_count { get; set; }
            public object[] pinned_tweet_ids_str { get; set; }
            public bool possibly_sensitive { get; set; }
            public string profile_banner_url { get; set; }
            public string profile_image_url_https { get; set; }
            public string profile_interstitial_type { get; set; }
            public string screen_name { get; set; }
            public int statuses_count { get; set; }
            public string translator_type { get; set; }
            public string url { get; set; }
            public bool verified { get; set; }
            public string verified_type { get; set; }
            public bool want_retweets { get; set; }
            public object[] withheld_in_countries { get; set; }
        }

        public class Entities
        {
            public Description description { get; set; }
            public Url url { get; set; }
        }

        public class Description
        {
            public object[] urls { get; set; }
        }

        public class Url
        {
            public Url1[] urls { get; set; }
        }

        public class Url1
        {
            public string display_url { get; set; }
            public string expanded_url { get; set; }
            public string url { get; set; }
            public int[] indices { get; set; }
        }

    }
}
