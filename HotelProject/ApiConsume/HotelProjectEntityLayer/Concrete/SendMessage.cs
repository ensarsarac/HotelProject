﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectEntityLayer.Concrete
{
    public class SendMessage
    {
        [Key]
        public int SendMessageID { get; set; }        
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverMail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date{ get; set; }
    }
}
