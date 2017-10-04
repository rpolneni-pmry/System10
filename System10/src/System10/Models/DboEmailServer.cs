using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboEmailServer
    {
        public long BintId { get; set; }
        public int IEmailAccountTypeId { get; set; }
        public string Vchr64OutgoingMailServer { get; set; }
        public string Vchr128UserName { get; set; }
        public byte[] Bin64PasswordHash { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual LkpEmailAccountType IEmailAccountType { get; set; }
    }
}
