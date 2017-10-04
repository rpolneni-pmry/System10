using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboRole
    {
        public DboRole()
        {
            DboCredentialRolePermission = new HashSet<DboCredentialRolePermission>();
            DboRolePermission = new HashSet<DboRolePermission>();
        }

        public long BintId { get; set; }
        public string Nvch128Caption { get; set; }
        public string Nvch4000Description { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual ICollection<DboCredentialRolePermission> DboCredentialRolePermission { get; set; }
        public virtual ICollection<DboRolePermission> DboRolePermission { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
    }
}
