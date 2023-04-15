using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetContent();
        List<Content> GetListByHeadId(int id);

        void AddContent(Content content);

        //Content GetById(int id);

        void DeleteContent(Content content);

        void UpdateContent(Content content);
    }
}
