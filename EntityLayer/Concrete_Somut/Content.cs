using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete_Somut
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [StringLength(1000)]
        public string ContentText { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadId { get; set; }
        public virtual Head Head { get; set; }

       // public ICollection<Writer> WriterProp{ get; set; }
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }//Bire çoklu ilişkilendirme yapıyoruz.
    }
}
