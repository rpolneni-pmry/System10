using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboWorkflow
    {
        public DboWorkflow()
        {
            DboModuleWorkflow = new HashSet<DboModuleWorkflow>();
            DboWorkflowInstance = new HashSet<DboWorkflowInstance>();
            DboWorkflowStep = new HashSet<DboWorkflowStep>();
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
        public long? BintAction1Id { get; set; }
        public int ICategoryId { get; set; }
        public int IDataRetentionScheduleId { get; set; }
        public int IScheduleBasisId { get; set; }
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

        public virtual ICollection<DboModuleWorkflow> DboModuleWorkflow { get; set; }
        public virtual ICollection<DboWorkflowInstance> DboWorkflowInstance { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStep { get; set; }
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
        public virtual DboWorkflow BintOrigin { get; set; }
        public virtual ICollection<DboWorkflow> InverseBintOrigin { get; set; }
        public virtual LkpWorkflowCategory ICategory { get; set; }
        public virtual LkpDataRetentionSchedule IDataRetentionSchedule { get; set; }
        public virtual LkpInterfaceAvailability IInterfaceAvailability { get; set; }
        public virtual LkpScheduleBasis IScheduleBasis { get; set; }
    }
}
