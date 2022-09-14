using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete_Somut
{
    public class Content
    {
        public int ContentId { get; set; }
        public string ContentText { get; set; }

        public int HeadId { get; set; }
        public virtual Head HeadPropV { get; set; }

        public ICollection<Writer> WriterProp{ get; set; }
        public virtual Writer WriterPropV{ get; set; }

    }
}
