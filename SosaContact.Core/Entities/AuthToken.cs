using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Core.Entities
{
    public class AuthToken
    {
        [Required]
        public int AuthTokenID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Token { get; set; }
        [Required]
        public bool IsValid { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public virtual User User { get; set; }
    }
}
