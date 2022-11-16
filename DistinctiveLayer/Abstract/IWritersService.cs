using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Abstract
{
    public interface IWritersService
    {
        List<Writer> GetList();
        void WriterAdd(Writer writer);
        void WriterRemove(Writer writer);
        void WriterUpdate(Writer writer);
        Writer GetWriter(int id );
    }
}
