using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete_Somut
{
    public class ICollection
    {
        //property tanımlamamız gerekiyor.

        public int HeadId { get; set; }
        public string HeadName { get; set; }
        public DateTime HeadDate { get; set; }

        
        public int CategoryId { get; set; } //ilişki (Collection) tablonun anahtar sütunu ile aynı ada sahip olmalı

        //ilişki içerisinde olup olmadığını nasıl belirliyceM
        public virtual Category CategoryProp { get; set; } // => Anlamı: Sen Category sınıfından CategoryProp adında bir property oluşturacaksın.  

        //Burdan sonra Head'i Content ile ilişkilendirme:
        public ICollection<Content> ContentProp { get; set; }

    }
}
