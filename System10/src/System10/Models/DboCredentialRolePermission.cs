using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboCredentialRolePermission
    {
        public long BintId { get; set; }
        public long? BintCredentialId { get; set; }
        public long? BintRoleId { get; set; }
        public int IPermissionId { get; set; }
        public int ISystemContextTypeId { get; set; }
        public string Vchr256Context { get; set; }
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
        public virtual DboCredential BintCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual DboRole BintRole { get; set; }
        public virtual LkpPermission IPermission { get; set; }
        public virtual LkpSystemContextType ISystemContextType { get; set; }
    }
}
