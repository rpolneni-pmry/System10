using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class LkpDataRetentionSchedule
    {
        public LkpDataRetentionSchedule()
        {
            DboWorkflow = new HashSet<DboWorkflow>();
        }

        public int IId { get; set; }
        public int IFlagPeriodicityComparisonId { get; set; }
        public int IFlagPeriodicityUnitId { get; set; }
        public int IFlagPeriodicityCount { get; set; }
        public int IArchivePeriodicityComparisonId { get; set; }
        public int IArchivePeriodicityUnitId { get; set; }
        public int IArchivePeriodicityCount { get; set; }
        public int IDeletePeriodicityComparisonId { get; set; }
        public int IDeletePeriodicityUnitId { get; set; }
        public int IDeletePeriodicityCount { get; set; }
        public bool BEnabled { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual ICollection<DboWorkflow> DboWorkflow { get; set; }
        public virtual LkpPeriodicityComparison IArchivePeriodicityComparison { get; set; }
        public virtual LkpPeriodicityUnit IArchivePeriodicityUnit { get; set; }
        public virtual LkpPeriodicityComparison IDeletePeriodicityComparison { get; set; }
        public virtual LkpPeriodicityUnit IDeletePeriodicityUnit { get; set; }
        public virtual LkpPeriodicityComparison IFlagPeriodicityComparison { get; set; }
        public virtual LkpPeriodicityUnit IFlagPeriodicityUnit { get; set; }
    }
}
