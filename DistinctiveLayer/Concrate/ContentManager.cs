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
    /* Bir Distinct/Business Nasıl Oluşturuyorum
        * Abstract tarafında önceInterface ekliyorum: Burada get ve crud metodları tanımlanıyor. Neye göre? -> Entity katmanındaki seçtiğim tabloya göre.  
        * Concrate tarafında ise bu clası oluşturuyorum. Burada ilk önce Service diye adlandırdığım Interface'i miras alıp, implement ediyorum. 
            *Sonra Bu mirasdan bir nesne türetiyorum ->  IContentDL _content;
            *Sınıfın üzerinde sağ tık generate constructor diyiroum. 
            *Sonra implementleri dolduruyorum
    */
    public class ContentManager : IContentService
    {
        IContentDL _content;

        public ContentManager(IContentDL content)
        {
            _content = content;
        }


        public List<Content> GetContent()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadId(int id)
        {
            return _content.FilterList(x => x.HeadId==id);
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddContent(Content content)
        {
            throw new NotImplementedException();
        }

        public void DeleteContent(Content content)
        {
            throw new NotImplementedException();
        }

        public void UpdateContent(Content content)
        {
            throw new NotImplementedException();
        }

    }
}
