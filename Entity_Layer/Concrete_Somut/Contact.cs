﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete_Somut
{
    internal class Contact
    {
        public int ContactId { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}
