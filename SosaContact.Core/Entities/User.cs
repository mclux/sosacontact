using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Core.Entities
{
    public class User
    {
        [Required]
        public int UserID { get; set; }
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }
        [Required]
        [MaxLength(500)]
        public string Password { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public virtual ICollection<AuthToken> AuthTokens { get; set; }
        public virtual ICollection<ContactName> ContactNames { get; set; }
    }
}
