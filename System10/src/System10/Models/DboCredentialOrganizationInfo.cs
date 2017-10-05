using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboCredentialOrganizationInfo
    {
        public long BintId { get; set; }
        public long BintCredentialId { get; set; }
        public string Vchr40Ip { get; set; }
        public string Vchr128EMailDomain { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }
        public int IConfirmationValidationComparisonId { get; set; }
        public int IConfirmationValidationUnitId { get; set; }
        public int IConfirmationValidationCount { get; set; }
        public int IPasswordResetComparisonId { get; set; }
        public int IPasswordResetUnitId { get; set; }
        public int IPasswordResetCount { get; set; }
        public bool BAllowIpsignon { get; set; }
        public bool BAllowEmailAssociation { get; set; }
        public bool BAllowSelfRegistration { get; set; }
        public string Vchr64LdaphostName { get; set; }
        public int? ILdapportNumber { get; set; }
        public bool BLdapviaSsl { get; set; }
        public bool BAllowLdapauthentication { get; set; }

        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual LkpPeriodicityComparison IConfirmationValidationComparison { get; set; }
        public virtual LkpPeriodicityUnit IConfirmationValidationUnit { get; set; }
        public virtual LkpPeriodicityComparison IPasswordResetComparison { get; set; }
        public virtual LkpPeriodicityUnit IPasswordResetUnit { get; set; }
    }
}
