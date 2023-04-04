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
    public class HeadMenager : IHeadsService
    {
        IHeadDL _headingdal;

        public HeadMenager(IHeadDL headDL)
        {
            _headingdal = headDL;
        }

        public Head GetById(int id)
        {
            return _headingdal.Get(x=>x.HeadId == id);
        }

        public List<Head> GetHeads()
        {
            return _headingdal.List();
        }

        public void HeadAdd(Head head)
        {
            _headingdal.Insert(head);
        }

        public void HeadDelete(Head head)
        {
            _headingdal.Delete(head);
        }

        public void HeadUpdate(Head head)
        {
            _headingdal.Update(head);
        }
    }
}
