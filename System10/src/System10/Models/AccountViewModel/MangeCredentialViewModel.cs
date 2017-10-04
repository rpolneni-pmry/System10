using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace System10.Models
{
    public class MangeCredentialViewModel
    {
        [Required]
        //[EmailAddress]
        public string Password { get; set; }

        public string UserName { get; set; }
    }
}
