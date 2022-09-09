using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete_Somut
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryState { get; set; }
        public bool CategoryStatue { get; set; }//İlişkili tablolarda silme işlemi yerine durumunu aktif pasif etme

        //Bu sınıfa bağlı olarak oluşturulacak koleksiyon
        public ICollection<Head> MyProperty { get; set; }//<> içerisinde T istiyor. Bu da bir sınıfa karşılık geliyor.. => HEad.cs tarafı da var

        
    }
}
