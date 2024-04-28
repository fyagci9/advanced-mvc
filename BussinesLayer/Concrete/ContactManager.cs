using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class ContactManager : IContactService

    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void contactAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void contactDelete(Contact contact)
        {
            _contactDal.Delete(contact);

        }

        public void contactUpdate(Contact contact)
        {
            _contactDal.Update(contact);

        }

        public Contact GetByID(int id)
        {
            return _contactDal.Get(x=>x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }
    }
}
