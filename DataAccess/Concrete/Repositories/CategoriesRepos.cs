using DataAccess.Abstract;
using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class Categories:IRepository<T>//IGenericRepository içindeki t; diğer reposlarda değiştirebilrisin
    {
       // Context c = new Context();
        //DbSet<Category> categories;

        public List<T> CategoryList()
        {
            //  return T.ToList();
            return null;
        }

        public void Delete(T p)
        {
            throw new NotImplementedException();
        }

        public void Instert(T p)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public void Update(T p)
        {
            throw new NotImplementedException();
        }
    }
}
