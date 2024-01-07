﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Dtos.SendMessage
{
    public class CreateSendMessageDto
    {
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverMail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
