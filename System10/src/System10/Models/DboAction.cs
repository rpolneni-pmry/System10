using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboAction
    {
        public DboAction()
        {
            DboActionParameter = new HashSet<DboActionParameter>();
            DboFormBintAction1 = new HashSet<DboForm>();
            DboFormBintAction2 = new HashSet<DboForm>();
            DboFormBintAction3 = new HashSet<DboForm>();
            DboFormBintAction4 = new HashSet<DboForm>();
            DboFormBintAction5 = new HashSet<DboForm>();
            DboFormBintAction6 = new HashSet<DboForm>();
            DboWorkflowBintAction1 = new HashSet<DboWorkflow>();
            DboWorkflowBintAction2 = new HashSet<DboWorkflow>();
            DboWorkflowBintAction3 = new HashSet<DboWorkflow>();
            DboWorkflowBintAction4 = new HashSet<DboWorkflow>();
            DboWorkflowBintAction5 = new HashSet<DboWorkflow>();
            DboWorkflowBintAction6 = new HashSet<DboWorkflow>();
            DboWorkflowStepBintAction1 = new HashSet<DboWorkflowStep>();
            DboWorkflowStepBintAction2 = new HashSet<DboWorkflowStep>();
            DboWorkflowStepBintAction3 = new HashSet<DboWorkflowStep>();
            DboWorkflowStepBintAction4 = new HashSet<DboWorkflowStep>();
            DboWorkflowStepBintAction5 = new HashSet<DboWorkflowStep>();
            DboWorkflowStepBintAction6 = new HashSet<DboWorkflowStep>();
        }

        public long BintId { get; set; }
        public string Vchr64Icon { get; set; }
        public string Nvch128Caption { get; set; }
        public string Vchr256Title { get; set; }
        public string Nvch4000Description { get; set; }
        public string NvchMaxHelpText { get; set; }
        public bool BEnabled { get; set; }
        public int IParameterBasisId { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual ICollection<DboActionParameter> DboActionParameter { get; set; }
        public virtual ICollection<DboForm> DboFormBintAction1 { get; set; }
        public virtual ICollection<DboForm> DboFormBintAction2 { get; set; }
        public virtual ICollection<DboForm> DboFormBintAction3 { get; set; }
        public virtual ICollection<DboForm> DboFormBintAction4 { get; set; }
        public virtual ICollection<DboForm> DboFormBintAction5 { get; set; }
        public virtual ICollection<DboForm> DboFormBintAction6 { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflowBintAction1 { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflowBintAction2 { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflowBintAction3 { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflowBintAction4 { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflowBintAction5 { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflowBintAction6 { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStepBintAction1 { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStepBintAction2 { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStepBintAction3 { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStepBintAction4 { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStepBintAction5 { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStepBintAction6 { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual LkpParameterBasis IParameterBasis { get; set; }
    }
}
