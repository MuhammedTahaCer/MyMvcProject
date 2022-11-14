using DataAccess.Abstract;
using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class WritersRepos : IWriterDL
    {

        Context c = new Context();
        DbSet<Writer> _object;
        public void Delete(Writer p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Writer p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Writer> List()
        {
            return _object.ToList();
        }

        public List<Writer> FilterList(Expression<Func<Writer, bool>> filter)
        {
            return _object.ToList();
        }

        public void Update(Writer p)
        {
            c.SaveChanges();
        }

        public Writer Get(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
