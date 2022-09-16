using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete_Somut
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [StringLength(1000)]
        public string AboutDetail1 { get; set; }
        [StringLength(1000)]
        public string AboutDetail2 { get; set; }
        [StringLength(100)]
        public string AboutImage { get; set; }//Resimleri dosya yoluyla ayrı biryerden çekielbilir.
        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
