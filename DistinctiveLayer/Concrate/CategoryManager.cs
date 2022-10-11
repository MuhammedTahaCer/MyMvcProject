using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using DistinctiveLayer.Abstract;
using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Concrate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDL _categoryDL; //Return edilecek değer DataLAyerlardan çekilecek. İlgili dl nin fieldini oluşturdum.

        public CategoryManager(ICategoryDL categoryDL) //generated const from CategoryManager : ICategoryService
        {
            _categoryDL=categoryDL;
        }

        //Burası, Generic Repository ile çekilen verilen çekildiği bölüm. Bunun Yerine Servis Kullanılmaya başlandı
        //GenericRepository<Category>repos=new GenericRepository<Category>();



        //public List<Category>CategoryGetBL()
        //{
        //    return repos.List();
        //}
        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName=="" || p.CategoryName.Length>50 || p.CategoryName.Length<4 ||p.CategoryState=="")
        //    {
        //        //
        //    } else repos.Insert(p);
        //}

        public List<Category> GetMyCategory()
        {
            return _categoryDL.List();
        }
    }
}
