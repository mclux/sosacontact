using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Core.Interfaces
{
    public interface IContactDetailsRepository
    {
        void DeleteContactDetails(int id);
    }
}
