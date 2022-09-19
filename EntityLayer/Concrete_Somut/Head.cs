using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete_Somut
{
    public class Head
    {
        //property tanımlamamız gerekiyor.
        [Key]
        public int HeadId { get; set; }
        [StringLength(40)]
        public string HeadName { get; set; }
        public DateTime HeadDate { get; set; }

        
        public int CategoryId { get; set; } //ilişki (Collection) tablonun anahtar sütunu ile aynı ada sahip olmalı

        //ilişki içerisinde olup olmadığını nasıl belirliyceM
        public virtual T Category { get; set; } // => Anlamı: Sen Category sınıfından CategoryProp adında bir property oluşturacaksın.  

        public int WriterId { get; set; }// Heading ile başlığı açan kişin id sini görmek için
        public virtual Writer Writer { get; set; }// ^> writer dan property alıcak.

        //Burdan sonra Head'i Content ile ilişkilendirme:
        public ICollection<Content> Contents { get; set; }

    }
}
