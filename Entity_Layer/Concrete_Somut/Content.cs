using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete_Somut
{
    public class Content
    {
        [Key]public int ContentId { get; set; }
        [StringLength(1000)]public string ContentText { get; set; }

        public int HeadId { get; set; }
        public virtual Head HeadPropV { get; set; }

        public ICollection<Writer> WriterProp{ get; set; }
        public virtual Writer WriterPropV{ get; set; }

    }
}
