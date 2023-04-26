using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetContact();
        void ContactAdd(Contact contact);
        void ContactRemove(Contact contact);
        void ContactUpdate(Contact contact);
        Contact GetContact(int id);
    }
}
