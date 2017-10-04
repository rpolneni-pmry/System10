using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class LkpDynamicDataEndpoint
    {
        public LkpDynamicDataEndpoint()
        {
            DboDynamicDataMapISourceEndpoint = new HashSet<DboDynamicDataMap>();
            DboDynamicDataMapITargetEndpoint = new HashSet<DboDynamicDataMap>();
            LkpDynamicDataHierarchyIChildDynamicDataEndpoint = new HashSet<LkpDynamicDataHierarchy>();
            LkpDynamicDataHierarchyIParentDynamicDataEndpoint = new HashSet<LkpDynamicDataHierarchy>();
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

        public virtual ICollection<DboDynamicDataMap> DboDynamicDataMapISourceEndpoint { get; set; }
        public virtual ICollection<DboDynamicDataMap> DboDynamicDataMapITargetEndpoint { get; set; }
        public virtual ICollection<LkpDynamicDataHierarchy> LkpDynamicDataHierarchyIChildDynamicDataEndpoint { get; set; }
        public virtual ICollection<LkpDynamicDataHierarchy> LkpDynamicDataHierarchyIParentDynamicDataEndpoint { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
    }
}
