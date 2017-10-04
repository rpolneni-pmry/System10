using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboModule
    {
        public DboModule()
        {
            DboModuleWorkflow = new HashSet<DboModuleWorkflow>();
        }

        public long BintId { get; set; }
        public string Vchr64Icon { get; set; }
        public string Nvch128Caption { get; set; }
        public string Vchr256Title { get; set; }
        public string Nvch4000Description { get; set; }
        public string NvchMaxHelpText { get; set; }
        public int IInterfaceAvailabilityId { get; set; }
        public bool BEnabled { get; set; }
        public int? IOrdinal { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual ICollection<DboModuleWorkflow> DboModuleWorkflow { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual LkpInterfaceAvailability IInterfaceAvailability { get; set; }
    }
}
