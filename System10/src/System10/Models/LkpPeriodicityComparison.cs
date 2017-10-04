using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class LkpPeriodicityComparison
    {
        public LkpPeriodicityComparison()
        {
            DboCredentialOrganizationInfoIConfirmationValidationComparison = new HashSet<DboCredentialOrganizationInfo>();
            DboCredentialOrganizationInfoIPasswordResetComparison = new HashSet<DboCredentialOrganizationInfo>();
            LkpDataRetentionScheduleIArchivePeriodicityComparison = new HashSet<LkpDataRetentionSchedule>();
            LkpDataRetentionScheduleIDeletePeriodicityComparison = new HashSet<LkpDataRetentionSchedule>();
            LkpDataRetentionScheduleIFlagPeriodicityComparison = new HashSet<LkpDataRetentionSchedule>();
        }

        public int IId { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual ICollection<DboCredentialOrganizationInfo> DboCredentialOrganizationInfoIConfirmationValidationComparison { get; set; }
        public virtual ICollection<DboCredentialOrganizationInfo> DboCredentialOrganizationInfoIPasswordResetComparison { get; set; }
        public virtual ICollection<LkpDataRetentionSchedule> LkpDataRetentionScheduleIArchivePeriodicityComparison { get; set; }
        public virtual ICollection<LkpDataRetentionSchedule> LkpDataRetentionScheduleIDeletePeriodicityComparison { get; set; }
        public virtual ICollection<LkpDataRetentionSchedule> LkpDataRetentionScheduleIFlagPeriodicityComparison { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
    }
}
