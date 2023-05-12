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
    public class ContactManager: IContactService
    {
        IContactDl _contactDl;

        public ContactManager(IContactDl contactDl)
        {
            _contactDl = contactDl;
        }

        public void ContactAdd(Contact contact)
        {
            _contactDl.Insert(contact);
        }

        public void ContactRemove(Contact contact)
        {
            _contactDl.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _contactDl.Update(contact);
        }

        public List<Contact> GetList()
        {
            return _contactDl.List();
        }

        public Contact GetContact(int id)
        {
            return _contactDl.Get(x=>x.ContactId== id);
        }
    }
}
