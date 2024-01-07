using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Models
{
    public class DashboardLinkedinViewModel
    {


            public Data data { get; set; }
            public string message { get; set; }
        

        public class Data
        {
            public string about { get; set; }
            public string city { get; set; }
            public string company { get; set; }
            public string company_domain { get; set; }
            public string company_employee_range { get; set; }
            public string company_industry { get; set; }
            public string company_linkedin_url { get; set; }
            public string company_logo_url { get; set; }
            public string company_website { get; set; }
            public int company_year_founded { get; set; }
            public int connections_count { get; set; }
            public string country { get; set; }
            public object current_company_join_month { get; set; }
            public int current_company_join_year { get; set; }
            public Education[] educations { get; set; }
            public Experience[] experiences { get; set; }
            public string first_name { get; set; }
            public int followers_count { get; set; }
            public string full_name { get; set; }
            public string headline { get; set; }
            public string hq_city { get; set; }
            public string hq_country { get; set; }
            public string hq_region { get; set; }
            public string job_title { get; set; }
            public string last_name { get; set; }
            public string linkedin_url { get; set; }
            public string location { get; set; }
            public string profile_id { get; set; }
            public string profile_image_url { get; set; }
            public string public_id { get; set; }
            public string school { get; set; }
            public string skills { get; set; }
            public string state { get; set; }
        }

        public class Education
        {
            public string activities { get; set; }
            public string date_range { get; set; }
            public string degree { get; set; }
            public string description { get; set; }
            public int eduId { get; set; }
            public string end_month { get; set; }
            public object end_year { get; set; }
            public string field_of_study { get; set; }
            public string grade { get; set; }
            public string school { get; set; }
            public string school_id { get; set; }
            public string school_linkedin_url { get; set; }
            public string start_month { get; set; }
            public object start_year { get; set; }
        }

        public class Experience
        {
            public string company { get; set; }
            public string company_id { get; set; }
            public string company_linkedin_url { get; set; }
            public string company_logo_url { get; set; }
            public string current_company_join_month { get; set; }
            public int current_company_join_year { get; set; }
            public string date_range { get; set; }
            public string description { get; set; }
            public string duration { get; set; }
            public string end_month { get; set; }
            public string end_year { get; set; }
            public bool is_current { get; set; }
            public string location { get; set; }
            public string start_month { get; set; }
            public int start_year { get; set; }
            public string title { get; set; }
        }

    }
}
