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
    public class AboutManager:IAboutService
    {

        IAboutDL _aboutDL;

        public AboutManager(IAboutDL aboutDL)
        {
            _aboutDL = aboutDL;
        }

        public void AddWriterInfo(About about)
        {
            _aboutDL.Insert(about);
        }

        public void DeleteWriterInfo(About about)
        {
            _aboutDL.Delete(about);
        }

        public List<About> GetAboutMe()
        {
            return _aboutDL.List();
        }

        public About GetById(int id)
        {
            return _aboutDL.Get(x => x.AboutId == id);
        }

        public void UpdateWriterInfo(About about)
        {
            _aboutDL.Update(about);
        }
    }
}
