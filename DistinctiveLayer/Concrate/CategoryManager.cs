using DataAccess.Concrete.Repositories;
using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Concrate
{
    public class CategoryManager
    {
        GenericRepository<Category>repos=new GenericRepository<Category>();
        public List<Category>CategoryGetBL()
        {
            return repos.List();
        }
        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName=="" || p.CategoryName.Length>50 || p.CategoryName.Length<4 ||p.CategoryState=="")
            {
                //
            } 
            else repos.Insert(p);
        }

    }
}
