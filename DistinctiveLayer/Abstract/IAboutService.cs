using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetAboutMe();

        void AddWriterInfo(About about);

        About GetById(int id);

        void DeleteWriterInfo(About about);

        void UpdateWriterInfo(About about);
    }
}
