using SosaContact.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Core.Interfaces
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        User GetUser(int id);

        User GetUserByUsername(string username);
    }
}
