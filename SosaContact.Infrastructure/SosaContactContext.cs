using SosaContact.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Infrastructure
{
    public class SosaContactContext :DbContext
    {
        public SosaContactContext():base("name=SosaContactContextConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(new SosaContactInitializeDb());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<ContactName> ContactNames { get; set; }
        public DbSet<AuthToken> AuthTokens { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
    }
}
