using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace System10.Models
{
    public class MangeCredentialViewModel
    {
        [Required]
        //[EmailAddress]
        public string Password { get; set; }

        public string UserName { get; set; }

        [Required]
        public string NewPassword { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }

        public List<DboCredentialAlternate> dboAlternAte { get; set; }
        public List<LkpLocalization> localization { get; set; }
    }
}
