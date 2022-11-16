using DataAccess.Abstract;
using DistinctiveLayer.Abstract;
using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Concrate
{
    public class WriterManager : IWritersService
    {
        IWriterDL _writerDL;

        public WriterManager(IWriterDL writerDL)
        {
            _writerDL = writerDL;
        }

        public List<Writer> GetList()
        {
            return _writerDL.List();
        }

        public Writer GetWriter(int id)
        {
            return _writerDL.Get(x => x.WriterId == id);
        }

        public void WriterAdd(Writer writer)
        {
             _writerDL.Insert(writer);
        }

        public void WriterRemove(Writer writer)
        {
            _writerDL.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writerDL.Update(writer);
        }
    }
}
