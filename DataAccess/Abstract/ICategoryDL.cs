using DataAccess.Concrete.Repositories;
using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDL: IRepository<Category>
    {
        //List<Category> List();

        //void Insert(Category p);
        //void Update(Category p);
        //void Delete(Category p);
        //// void List(Category p);
    }
}
