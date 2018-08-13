using SosaContact.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Core.Interfaces
{
    public interface IContactTypeRepository
    {
        IEnumerable<ContactType> GetContactTypes();
        //ContactType GetContactType(int id);
    }
}
