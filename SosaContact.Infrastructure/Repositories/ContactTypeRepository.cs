using SosaContact.Core.Entities;
using SosaContact.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Infrastructure.Repositories
{
    public class ContactTypeRepository:IContactTypeRepository
    {
        SosaContactContext context = new SosaContactContext();
        public IEnumerable<ContactType> GetContactTypes()
        {
            return context.ContactTypes.ToList();
        }
    }
}
