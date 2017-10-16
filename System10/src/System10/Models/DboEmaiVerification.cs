using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboEmaiVerification
    {
        public long BintId { get; set; }
        public string Nvch128Email { get; set; }
        public string Vchr250Token { get; set; }
        public bool BEnabled { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual DboEmaiVerification BintCreatorCredential { get; set; }
        public virtual ICollection<DboEmaiVerification> InverseBintCreatorCredential { get; set; }
        public virtual DboEmaiVerification BintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboEmaiVerification> InverseBintCreatorSpoofOfCredential { get; set; }
        public virtual DboEmaiVerification BintModifierCredential { get; set; }
        public virtual ICollection<DboEmaiVerification> InverseBintModifierCredential { get; set; }
        public virtual DboEmaiVerification BintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboEmaiVerification> InverseBintModifierSpoofOfCredential { get; set; }
    }
}
