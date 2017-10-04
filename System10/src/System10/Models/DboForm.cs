using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboForm
    {
        public DboForm()
        {
            DboFormAction = new HashSet<DboFormAction>();
            DboFormFieldConfiguration = new HashSet<DboFormFieldConfiguration>();
        }

        public long BintId { get; set; }
        public string Vchr64Icon { get; set; }
        public string Nvch128Caption { get; set; }
        public string Vchr256Title { get; set; }
        public long? BintOriginId { get; set; }
        public string Nvch4000Description { get; set; }
        public string NvchMaxHelpText { get; set; }
        public int IInterfaceAvailabilityId { get; set; }
        public bool BEnabled { get; set; }
        public int ICategoryId { get; set; }
        public long BintDataSourceId { get; set; }
        public bool BAllowDirectAccess { get; set; }
        public bool BDefaultAllowAttachments { get; set; }
        public bool BMobileFriendly { get; set; }
        public string Vchr256Path { get; set; }
        public int IBackingModeId { get; set; }
        public int IReExecuteOnNextId { get; set; }
        public string Nvch4000NextActionDescription { get; set; }
        public string Vchr256AccessDeniedPagePath { get; set; }
        public string Vchr256ErrorPagePath { get; set; }
        public int IAttachmentLimit { get; set; }
        public long? BintAction1Id { get; set; }
        public long? BintAction2Id { get; set; }
        public long? BintAction3Id { get; set; }
        public long? BintAction4Id { get; set; }
        public long? BintAction5Id { get; set; }
        public long? BintAction6Id { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual ICollection<DboFormAction> DboFormAction { get; set; }
        public virtual ICollection<DboFormFieldConfiguration> DboFormFieldConfiguration { get; set; }
        public virtual DboAction BintAction1 { get; set; }
        public virtual DboAction BintAction2 { get; set; }
        public virtual DboAction BintAction3 { get; set; }
        public virtual DboAction BintAction4 { get; set; }
        public virtual DboAction BintAction5 { get; set; }
        public virtual DboAction BintAction6 { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboDataSource BintDataSource { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual DboForm BintOrigin { get; set; }
        public virtual ICollection<DboForm> InverseBintOrigin { get; set; }
        public virtual LkpBackingMode IBackingMode { get; set; }
        public virtual LkpFormCategory ICategory { get; set; }
        public virtual LkpInterfaceAvailability IInterfaceAvailability { get; set; }
        public virtual LkpReExecuteOnNext IReExecuteOnNext { get; set; }
    }
}
