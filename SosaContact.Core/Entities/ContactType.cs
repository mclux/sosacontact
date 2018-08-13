using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Core.Entities
{
    public class ContactType
    {
        public int ContactTypeID { get; set; }
        public string Type { get; set; }

        //public virtual ContactDetail ContactDetail { get; set; }
    }
}
