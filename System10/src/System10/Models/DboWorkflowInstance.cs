using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboWorkflowInstance
    {
        public long BintId { get; set; }
        public long BintWorkflowId { get; set; }
        public int IIteration { get; set; }
        public long BintWorkflowStepId { get; set; }
        public string Vchr256Control { get; set; }
        public int? IRecordNumber { get; set; }
        public long? BintAssignedToCredentialId { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual DboCredential BintAssignedToCredential { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual DboWorkflow BintWorkflow { get; set; }
        public virtual DboWorkflowStep BintWorkflowStep { get; set; }
    }
}
