using SosaContact.Core.Entities;
using SosaContact.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Infrastructure.Repositories
{
    public class UserRepository:IUserRepository
    {
        SosaContactContext context = new SosaContactContext();
        public User GetUser(int id)
        {
            return context.Users.FirstOrDefault(p=>p.UserID==id);
        }

        public User GetUserByUsername(string username)
        {
            return context.Users.FirstOrDefault(p => p.Username == username);
        }

        public bool AddUser(User user)
        {
            context.Users.Add(user);
            if(context.SaveChanges()>0)
            {
                return true;
            }
            return false;
        }

    }
}
