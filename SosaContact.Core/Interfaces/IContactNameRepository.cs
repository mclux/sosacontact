using SosaContact.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Core.Interfaces
{
    public interface IContactNameRepository
    {
        IEnumerable<ContactName> GetContactsByUserId(int userId);
        ContactName AddContact(ContactName contact);
        //ContactName GetContact(int id);
        //void EditContact(ContactName contact);
        //void DeleteContact(int id);
    }
}
