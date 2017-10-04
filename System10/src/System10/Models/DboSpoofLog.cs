﻿using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboSpoofLog
    {
        public long BintId { get; set; }
        public long BintActualUserCredentialId { get; set; }
        public long BintSpoofUserCredentialId { get; set; }
        public DateTime DtBegan { get; set; }
        public DateTime? DtExpires { get; set; }
        public DateTime? DtEnded { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual DboCredential BintActualUserCredential { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual DboCredential BintSpoofUserCredential { get; set; }
    }
}
