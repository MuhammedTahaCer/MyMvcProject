using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete_Somut
{
    public class T
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(20)]
        public string CategoryName { get; set; }
        [StringLength(100)]
        public string CategoryState { get; set; }
        public bool CategoryStatue { get; set; }//İlişkili tablolarda silme işlemi yerine durumunu aktif pasif etme

        //Bu sınıfa bağlı olarak oluşturulacak koleksiyon
        public ICollection<Head> Heads { get; set; }//<> içerisinde T istiyor. Bu da bir sınıfa karşılık geliyor.. => Head.cs tarafı da var
       
    }
}
