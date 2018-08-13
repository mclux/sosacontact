using SosaContact.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Infrastructure
{
    public class SosaContactInitializeDb :DropCreateDatabaseIfModelChanges<SosaContactContext>
    {
        protected override void Seed(SosaContactContext context)
        {
            context.ContactTypes.Add(new ContactType {
                Type="Phone"
            });
            context.ContactTypes.Add(new ContactType
            {
                Type = "Email"
            });

            base.Seed(context);
            context.SaveChanges();
        }
    }
}
