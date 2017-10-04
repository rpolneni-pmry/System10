using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboDataSourceField
    {
        public long BintId { get; set; }
        public long BintDataSourceId { get; set; }
        public bool BRequired { get; set; }
        public bool BReadOnly { get; set; }
        public bool BEnabled { get; set; }
        public bool BEncrypted { get; set; }
        public string Vchr1024MaskingRegEx { get; set; }
        public string Vchr1024CharacterLimitsRegEx { get; set; }
        public string Vchr128Name { get; set; }
        public int? IOrdinal { get; set; }
        public string Nvch128Caption { get; set; }
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
        public virtual DboDataSource BintDataSource { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
    }
}
