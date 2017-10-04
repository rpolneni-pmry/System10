using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboWorkflowStep
    {
        public DboWorkflowStep()
        {
            DboWorkflowInstance = new HashSet<DboWorkflowInstance>();
            DboWorkflowStepFieldConfiguration = new HashSet<DboWorkflowStepFieldConfiguration>();
        }

        public long BintId { get; set; }
        public long BintWorkflowId { get; set; }
        public string Nvch128Caption { get; set; }
        public string Vchr256Title { get; set; }
        public string NvchMaxHelpText { get; set; }
        public long? BintAction1Id { get; set; }
        public bool BAllowDirectAccess { get; set; }
        public int? IAttachmentLimit { get; set; }
        public bool BShowInWorkflowMap { get; set; }
        public bool BHighlightWhenActive { get; set; }
        public int IWorkflowStepTypeId { get; set; }
        public long? BintAction2Id { get; set; }
        public long? BintAction3Id { get; set; }
        public long? BintAction4Id { get; set; }
        public long? BintAction5Id { get; set; }
        public long? BintAction6Id { get; set; }
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

        public virtual ICollection<DboWorkflowInstance> DboWorkflowInstance { get; set; }
        public virtual ICollection<DboWorkflowStepFieldConfiguration> DboWorkflowStepFieldConfiguration { get; set; }
        public virtual DboAction BintAction1 { get; set; }
        public virtual DboAction BintAction2 { get; set; }
        public virtual DboAction BintAction3 { get; set; }
        public virtual DboAction BintAction4 { get; set; }
        public virtual DboAction BintAction5 { get; set; }
        public virtual DboAction BintAction6 { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual DboWorkflow BintWorkflow { get; set; }
        public virtual LkpWorkflowStepType IWorkflowStepType { get; set; }
    }
}
