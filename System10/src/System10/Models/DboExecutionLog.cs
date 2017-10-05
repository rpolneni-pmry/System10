using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboExecutionLog
    {
        public long BintId { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256Executed { get; set; }
        public string Vchr256Context { get; set; }
        public long BintCredentialId { get; set; }
        public long? BintSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual DboCredential BintCredential { get; set; }
        public virtual DboCredential BintSpoofOfCredential { get; set; }
    }
}
