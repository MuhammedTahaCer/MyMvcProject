using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete_Somut
{
    public class Head
    {
        //property tanımlamamız gerekiyor.

        public int HeadId { get; set; }
        public string HeadName { get; set; }
        public DateTime HeadDate { get; set; }

        
        public int CategoryId { get; set; } //ilişki (Collection) tablonun anahtar sütunu ile aynı ada sahip olmalı

        //ilişki içerisinde olup olmadığını nasıl belirliyceM
        public virtual Category CategoryPropV { get; set; } // => Anlamı: Sen Category sınıfından CategoryProp adında bir property oluşturacaksın.  

        public int WriterId{get; set;}
        public virtual Writer WriterPropV { get; set; }//Bire çoklu ilişkilendirme yapıyoruz.

        //Burdan sonra Head'i Content ile ilişkilendirme:
        public ICollection<Content> ContentProp { get; set; }

    }
}
