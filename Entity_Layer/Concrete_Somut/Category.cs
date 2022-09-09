using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete_Somut
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryNAme { get; set; }
        public string State { get; set; }
        public bool Statue { get; set; }//İlişkili tablolarda silme işlemi yerine durumunu aktif pasif etme
    }
}
