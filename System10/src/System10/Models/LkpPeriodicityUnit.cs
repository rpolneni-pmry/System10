using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class LkpPeriodicityUnit
    {
        public LkpPeriodicityUnit()
        {
            DboCredentialOrganizationInfoIConfirmationValidationUnit = new HashSet<DboCredentialOrganizationInfo>();
            DboCredentialOrganizationInfoIPasswordResetUnit = new HashSet<DboCredentialOrganizationInfo>();
            LkpDataRetentionScheduleIArchivePeriodicityUnit = new HashSet<LkpDataRetentionSchedule>();
            LkpDataRetentionScheduleIDeletePeriodicityUnit = new HashSet<LkpDataRetentionSchedule>();
            LkpDataRetentionScheduleIFlagPeriodicityUnit = new HashSet<LkpDataRetentionSchedule>();
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

        public virtual ICollection<DboCredentialOrganizationInfo> DboCredentialOrganizationInfoIConfirmationValidationUnit { get; set; }
        public virtual ICollection<DboCredentialOrganizationInfo> DboCredentialOrganizationInfoIPasswordResetUnit { get; set; }
        public virtual ICollection<LkpDataRetentionSchedule> LkpDataRetentionScheduleIArchivePeriodicityUnit { get; set; }
        public virtual ICollection<LkpDataRetentionSchedule> LkpDataRetentionScheduleIDeletePeriodicityUnit { get; set; }
        public virtual ICollection<LkpDataRetentionSchedule> LkpDataRetentionScheduleIFlagPeriodicityUnit { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
    }
}
