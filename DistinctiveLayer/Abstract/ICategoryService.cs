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
    }
}
