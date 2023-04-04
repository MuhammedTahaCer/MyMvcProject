using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Abstract
{
    public interface IHeadsService
    {
        List<Head> GetHeads();

        void HeadAdd(Head head);

        Head GetById(int id);

        void HeadDelete(Head head);

        void HeadUpdate(Head head);
    }
}
