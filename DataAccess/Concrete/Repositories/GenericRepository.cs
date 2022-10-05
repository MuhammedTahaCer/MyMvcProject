using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class//Her interface IRepositoryden değer alıyor. GenericRepository Irepository'den miras alıyor. Her bir Interface bir T değerine denk geliyor
    {
        Context c = new Context();
        DbSet<T> _object; //T değerne karşılık gelen sınıfı tutan field.

        public GenericRepository()
        {
            _object=c.Set<T>();
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public List<T> FilterList(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
        //Peki T değerine karşılık gelen sınıfı nasıl bulurum: Constructor


    }
} 
