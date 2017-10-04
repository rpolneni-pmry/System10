using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboPushNotificationTarget
    {
        public long BintId { get; set; }
        public long BintPushNotificationId { get; set; }
        public long BintTargetCredentialId { get; set; }
        public DateTime? DtEffective { get; set; }
        public DateTime? DtExpires { get; set; }
        public bool BDismissable { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }
        public bool BShowAsPopup { get; set; }

        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual DboPushNotification BintPushNotification { get; set; }
        public virtual DboCredential BintTargetCredential { get; set; }
    }
}
