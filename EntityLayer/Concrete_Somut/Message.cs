﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete_Somut
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        [StringLength(50)]
        public string SenderMail { get; set; }
        [StringLength(50)]
        public string receiverMail { get; set; }
        [StringLength(200)]
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
    