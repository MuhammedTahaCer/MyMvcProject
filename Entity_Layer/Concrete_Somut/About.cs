using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete_Somut
{
    internal class About
    {
        public int ID { get; set; }
        public string AboutDetail1 { get; set; }
        public string AboutDetail2 { get; set; }
        public string AboutImage { get; set; }//Resimleri dosya yoluyla ayrı biryerden çekielbilir.
        public string AboutImage2 { get; set; }
    }
}
