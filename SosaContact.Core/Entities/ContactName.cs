using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Core.Entities
{
    public class ContactName
    {
        [Required]
        public int ContactNameID { get; set; }

        [Required]
        [MaxLength(50)]
        public string CName { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public virtual ICollection<ContactDetail> ContactDetails { get; set; }

        public virtual User User { get; set; }

    }
}
