using SosaContact.Core.Entities;
using SosaContact.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace SosaContact.Infrastructure.Repositories
{
    public class ContactNameRepository:IContactNameRepository
    {
        SosaContactContext context = new SosaContactContext();
        public IEnumerable<ContactName> GetContactsByUserId(int userId)
        {
            return context.ContactNames
                .Include(p => p.ContactDetails.Select(q=>q.ContactType))
                .Where(p=>p.UserID==userId);
        }
        public ContactName AddContact(ContactName contact)
        {
            context.ContactNames.Add(contact);
            if (context.SaveChanges() > 0)
            {
                return contact;
            }
            return null;
        }
    }
}
