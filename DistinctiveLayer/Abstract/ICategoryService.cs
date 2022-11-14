using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetMyCategory();

        void CategoryAdd (Category category);//Icategoryservice implement

        Category GetById(int id); //Category (dediği bir T aslında) tipinde bir metod tanımladım (manager da implement) ; int id tipinde bir değişken alıcaksın (generic repository)

        void CategoryDelete (Category category);//yeni tanımlanan metod, manager da implement

        void CategoryUpdate (Category category);
    }
}
