﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete_Somut
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        public int Password { get; set; }

        public ICollection<Head> Heads{ get; set; }

        public ICollection<Content> Contents{ get; set; }
    }
}