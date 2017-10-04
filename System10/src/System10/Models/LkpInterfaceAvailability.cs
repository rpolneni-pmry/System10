using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class LkpInterfaceAvailability
    {
        public LkpInterfaceAvailability()
        {
            DboForm = new HashSet<DboForm>();
            DboModule = new HashSet<DboModule>();
            DboModuleWorkflow = new HashSet<DboModuleWorkflow>();
            DboWorkflow = new HashSet<DboWorkflow>();
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

        public virtual ICollection<DboForm> DboForm { get; set; }
        public virtual ICollection<DboModule> DboModule { get; set; }
        public virtual ICollection<DboModuleWorkflow> DboModuleWorkflow { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflow { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
    }
}
