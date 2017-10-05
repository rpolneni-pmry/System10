using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboDataSource
    {
        public DboDataSource()
        {
            DboDataSourceField = new HashSet<DboDataSourceField>();
            DboDataSourceParameter = new HashSet<DboDataSourceParameter>();
            DboForm = new HashSet<DboForm>();
        }

        public long BintId { get; set; }
        public int IDataSourceTypeId { get; set; }
        public string Nvch128Caption { get; set; }
        public long? BintOriginId { get; set; }
        public int IParameterBasisId { get; set; }
        public bool BAllowsRecordAdds { get; set; }
        public bool BAllowsRecordEdits { get; set; }
        public bool BAllowsRecordDeletes { get; set; }
        public string Vchr256ConnectionString { get; set; }
        public string Vchr64Server { get; set; }
        public string Vchr128DatabaseName { get; set; }
        public string Vchr128DatabaseObject { get; set; }
        public string Vchr128UserName { get; set; }
        public byte[] Bin64PasswordHash { get; set; }
        public DateTime DtCreated { get; set; }
        public string Vchr256CreatedContext { get; set; }
        public long BintCreatorCredentialId { get; set; }
        public long? BintCreatorSpoofOfCredentialId { get; set; }
        public DateTime DtModified { get; set; }
        public string Vchr256ModifiedContext { get; set; }
        public long BintModifierCredentialId { get; set; }
        public long? BintModifierSpoofOfCredentialId { get; set; }
        public bool BSmokeTest { get; set; }

        public virtual ICollection<DboDataSourceField> DboDataSourceField { get; set; }
        public virtual ICollection<DboDataSourceParameter> DboDataSourceParameter { get; set; }
        public virtual ICollection<DboForm> DboForm { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual DboDataSource BintOrigin { get; set; }
        public virtual ICollection<DboDataSource> InverseBintOrigin { get; set; }
        public virtual LkpDataSourceType IDataSourceType { get; set; }
        public virtual LkpParameterBasis IParameterBasis { get; set; }
    }
}
