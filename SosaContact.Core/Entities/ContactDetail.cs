using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Core.Entities
{
    public class ContactDetail
    {
        [Required]
        public int ContactDetailID { get; set; }
        [Required]
        public int ContactNameID { get; set; }
        [Required]
        //[ForeignKey("File")]
        public int ContactTypeID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Content { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public virtual ContactName ContactName { get; set; }
        public virtual ContactType ContactType { get; set; }
    }
}
