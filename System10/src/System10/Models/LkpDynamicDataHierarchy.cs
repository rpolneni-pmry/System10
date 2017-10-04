﻿using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class LkpDynamicDataHierarchy
    {
        public int IId { get; set; }
        public bool BDefaultChildRecord { get; set; }
        public int IParentDynamicDataEndpointId { get; set; }
        public int IChildDynamicDataEndpointId { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual LkpDynamicDataEndpoint IChildDynamicDataEndpoint { get; set; }
        public virtual LkpDynamicDataEndpoint IParentDynamicDataEndpoint { get; set; }
    }
}
