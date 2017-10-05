using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboWorkflowStepAction
    {
        public long BintId { get; set; }
        public bool BFormListensFor { get; set; }
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
        public long BintWorkflowStepId { get; set; }
        public long BintActionId { get; set; }

        public virtual DboAction BintAction { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual DboWorkflowStep BintWorkflowStep { get; set; }
        public virtual LkpParameterBasis IParameterBasis { get; set; }
    }
}
