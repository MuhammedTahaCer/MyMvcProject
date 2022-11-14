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
            var deletedEntity=c.Entry(p);
            deletedEntity.State=EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public List<T> FilterList(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public T Get(Expression<Func<T, bool>> filter)//birden fazla değer çağıracak metodlar List ile döndürülür, ancak Id gibi tek başına ihtiyaç duyduğumuz değerleri Get ile çağırabiliriz.
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var newEntity = c.Entry(p);
            newEntity.State = EntityState.Added;
            //_object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public void Update(T p)
        {
            var updatedEntity=c.Entry(p);
            updatedEntity.State=EntityState.Modified;
            c.SaveChanges();
        }
        //Peki T değerine karşılık gelen sınıfı nasıl bulurum: Constructor


    }
} 
