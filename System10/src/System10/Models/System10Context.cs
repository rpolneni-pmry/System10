using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace System10.Models
{
    public partial class System10Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=HQISWSDW01;Initial Catalog=System10;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex");

                entity.Property(e => e.Id).HasMaxLength(450);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PK_AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(450);

                entity.Property(e => e.ProviderKey).HasMaxLength(450);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserRoles_UserId");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.RoleId).HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PK_AspNetUserTokens");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.LoginProvider).HasMaxLength(450);

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(450);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<DboAction>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_Action_bint_ID");

                entity.ToTable("dbo_Action");

                entity.Property(e => e.BintId)
                    .HasColumnName("bint_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BEnabled).HasColumnName("b_Enabled");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IParameterBasisId).HasColumnName("i_ParameterBasisID");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description).HasColumnName("nvch_4000_Description");

                entity.Property(e => e.NvchMaxHelpText)
                    .IsRequired()
                    .HasColumnName("nvch_max_HelpText");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256Title)
                    .IsRequired()
                    .HasColumnName("vchr_256_Title")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr64Icon)
                    .HasColumnName("vchr_64_Icon")
                    .HasColumnType("varchar(64)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboActionBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Action_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboActionBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Action_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboActionBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Action_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboActionBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Action_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.IParameterBasis)
                    .WithMany(p => p.DboAction)
                    .HasForeignKey(d => d.IParameterBasisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_ParameterBasis_ID_to_dbo_Action_ParameterBasisID");
            });

            modelBuilder.Entity<DboActionParameter>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_ActionParameter_bint_ID");

                entity.ToTable("dbo_ActionParameter");

                entity.HasIndex(e => e.Vchr128Name)
                    .HasName("uq_dbo_ActionParameter_vchr_128_Name")
                    .IsUnique();

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintActionId).HasColumnName("bint_ActionID");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IOrdinal).HasColumnName("i_Ordinal");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Vchr128Name)
                    .IsRequired()
                    .HasColumnName("vchr_128_Name")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintAction)
                    .WithMany(p => p.DboActionParameter)
                    .HasForeignKey(d => d.BintActionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_ActionParameter_ActionID");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboActionParameterBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_ActionParameter_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboActionParameterBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_ActionParameter_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboActionParameterBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_ActionParameter_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboActionParameterBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_ActionParameter_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<DboCredential>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_Credential_bint_ID");

                entity.ToTable("dbo_Credential");

                entity.HasIndex(e => e.Vchr32Name)
                    .HasName("uq_dbo_Credential_vchr_32_Name")
                    .IsUnique();

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BEnabled).HasColumnName("b_Enabled");

                entity.Property(e => e.BIsGroup).HasColumnName("b_IsGroup");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.Bin64PasswordHash)
                    .HasColumnName("bin_64_PasswordHash")
                    .HasColumnType("binary(64)");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr32Name)
                    .IsRequired()
                    .HasColumnName("vchr_32_Name")
                    .HasColumnType("varchar(32)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.InverseBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Credential_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.InverseBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Credential_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.InverseBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Credential_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.InverseBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Credential_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<DboCredentialAlternate>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_CredentialAlternate_bint_ID");

                entity.ToTable("dbo_CredentialAlternate");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintPrimaryCredentialId).HasColumnName("bint_PrimaryCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ICredentialTypeId).HasColumnName("i_CredentialTypeID");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr64UserName)
                    .IsRequired()
                    .HasColumnName("vchr_64_UserName")
                    .HasColumnType("varchar(64)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboCredentialAlternateBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialAlternate_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboCredentialAlternateBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialAlternate_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboCredentialAlternateBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialAlternate_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboCredentialAlternateBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialAlternate_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintPrimaryCredential)
                    .WithMany(p => p.DboCredentialAlternateBintPrimaryCredential)
                    .HasForeignKey(d => d.BintPrimaryCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialAlternate_PrimaryCredentialID");

                entity.HasOne(d => d.ICredentialType)
                    .WithMany(p => p.DboCredentialAlternate)
                    .HasForeignKey(d => d.ICredentialTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_CredentialType_ID_to_dbo_CredentialAlternate_CredentialTypeID");
            });

            modelBuilder.Entity<DboCredentialConfigurationEntry>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_CredentialConfigurationEntry_bint_ID");

                entity.ToTable("dbo_CredentialConfigurationEntry");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintCredentialId).HasColumnName("bint_CredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ICredentialConfigurationId).HasColumnName("i_CredentialConfigurationID");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboCredentialConfigurationEntryBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialConfigurationEntry_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboCredentialConfigurationEntryBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialConfigurationEntry_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboCredentialConfigurationEntryBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialConfigurationEntry_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboCredentialConfigurationEntryBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialConfigurationEntry_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.ICredentialConfiguration)
                    .WithMany(p => p.DboCredentialConfigurationEntry)
                    .HasForeignKey(d => d.ICredentialConfigurationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_CredentialConfiguration_ID_to_dbo_CredentialConfigurationEntry_CredentialConfigurationID");
            });

            modelBuilder.Entity<DboCredentialHierarchy>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_CredentialHierarchy_bint_ID");

                entity.ToTable("dbo_CredentialHierarchy");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintChildCredentialId).HasColumnName("bint_ChildCredentialID");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintParentCredentialId).HasColumnName("bint_ParentCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintChildCredential)
                    .WithMany(p => p.DboCredentialHierarchyBintChildCredential)
                    .HasForeignKey(d => d.BintChildCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialHierarchy_ChildCredentialID");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboCredentialHierarchyBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialHierarchy_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboCredentialHierarchyBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialHierarchy_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboCredentialHierarchyBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialHierarchy_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboCredentialHierarchyBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialHierarchy_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintParentCredential)
                    .WithMany(p => p.DboCredentialHierarchyBintParentCredential)
                    .HasForeignKey(d => d.BintParentCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialHierarchy_ParentCredentialID");
            });

            modelBuilder.Entity<DboCredentialOrganizationInfo>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_CredentialOrganizationInfo_bint_ID");

                entity.ToTable("dbo_CredentialOrganizationInfo");

                entity.HasIndex(e => e.Vchr128EMailDomain)
                    .HasName("uq_dbo_CredentialOrganizationInfo_vchr_128_eMailDomain")
                    .IsUnique();

                entity.HasIndex(e => e.Vchr40Ip)
                    .HasName("uq_dbo_CredentialOrganizationInfo_vchr_40_IP")
                    .IsUnique();

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BAllowEmailAssociation)
                    .HasColumnName("b_AllowEMailAssociation")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BAllowIpsignon)
                    .HasColumnName("b_AllowIPSignon")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BAllowSelfRegistration)
                    .HasColumnName("b_AllowSelfRegistration")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintCredentialId).HasColumnName("bint_CredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IConfirmationValidationComparisonId).HasColumnName("i_ConfirmationValidationComparisonID");

                entity.Property(e => e.IConfirmationValidationCount).HasColumnName("i_ConfirmationValidationCount");

                entity.Property(e => e.IConfirmationValidationUnitId).HasColumnName("i_ConfirmationValidationUnitID");

                entity.Property(e => e.IPasswordResetComparisonId).HasColumnName("i_PasswordResetComparisonID");

                entity.Property(e => e.IPasswordResetCount).HasColumnName("i_PasswordResetCount");

                entity.Property(e => e.IPasswordResetUnitId).HasColumnName("i_PasswordResetUnitID");

                entity.Property(e => e.Vchr128EMailDomain)
                    .IsRequired()
                    .HasColumnName("vchr_128_eMailDomain")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr40Ip)
                    .IsRequired()
                    .HasColumnName("vchr_40_IP")
                    .HasColumnType("varchar(40)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboCredentialOrganizationInfoBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialOrganizationInfo_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboCredentialOrganizationInfoBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialOrganizationInfo_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintCredential)
                    .WithMany(p => p.DboCredentialOrganizationInfoBintCredential)
                    .HasForeignKey(d => d.BintCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialOrganizationInfo_CredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboCredentialOrganizationInfoBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialOrganizationInfo_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboCredentialOrganizationInfoBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialOrganizationInfo_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.IConfirmationValidationComparison)
                    .WithMany(p => p.DboCredentialOrganizationInfoIConfirmationValidationComparison)
                    .HasForeignKey(d => d.IConfirmationValidationComparisonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PeriodicityComparison_ID_to_dbo_CredentialOrganizationInfo_ConfirmationValidationComparisonID");

                entity.HasOne(d => d.IConfirmationValidationUnit)
                    .WithMany(p => p.DboCredentialOrganizationInfoIConfirmationValidationUnit)
                    .HasForeignKey(d => d.IConfirmationValidationUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PeriodicityUnit_ID_to_dbo_CredentialOrganizationInfo_ConfirmationValidationUnitID");

                entity.HasOne(d => d.IPasswordResetComparison)
                    .WithMany(p => p.DboCredentialOrganizationInfoIPasswordResetComparison)
                    .HasForeignKey(d => d.IPasswordResetComparisonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PeriodicityComparison_ID_to_dbo_CredentialOrganizationInfo_PasswordResetComparisonID");

                entity.HasOne(d => d.IPasswordResetUnit)
                    .WithMany(p => p.DboCredentialOrganizationInfoIPasswordResetUnit)
                    .HasForeignKey(d => d.IPasswordResetUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PeriodicityUnit_ID_to_dbo_CredentialOrganizationInfo_PasswordResetUnitID");
            });

            modelBuilder.Entity<DboCredentialRolePermission>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_CredentialRolePermission_bint_ID");

                entity.ToTable("dbo_CredentialRolePermission");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintCredentialId).HasColumnName("bint_CredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintRoleId).HasColumnName("bint_RoleID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IPermissionId).HasColumnName("i_PermissionID");

                entity.Property(e => e.ISystemContextTypeId).HasColumnName("i_SystemContextTypeID");

                entity.Property(e => e.Vchr256Context)
                    .IsRequired()
                    .HasColumnName("vchr_256_Context")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboCredentialRolePermissionBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialRolePermission_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboCredentialRolePermissionBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialRolePermission_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintCredential)
                    .WithMany(p => p.DboCredentialRolePermissionBintCredential)
                    .HasForeignKey(d => d.BintCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialRolePermission_CredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboCredentialRolePermissionBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialRolePermission_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboCredentialRolePermissionBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_CredentialRolePermission_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintRole)
                    .WithMany(p => p.DboCredentialRolePermission)
                    .HasForeignKey(d => d.BintRoleId)
                    .HasConstraintName("fk_dbo_Role_ID_to_dbo_CredentialRolePermission_RoleID");

                entity.HasOne(d => d.IPermission)
                    .WithMany(p => p.DboCredentialRolePermission)
                    .HasForeignKey(d => d.IPermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_Permission_ID_to_dbo_CredentialRolePermission_PermissionID");

                entity.HasOne(d => d.ISystemContextType)
                    .WithMany(p => p.DboCredentialRolePermission)
                    .HasForeignKey(d => d.ISystemContextTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_SystemContextType_ID_to_dbo_CredentialRolePermission_SystemContextTypeID");
            });

            modelBuilder.Entity<DboDataSource>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_DataSource_bint_ID");

                entity.ToTable("dbo_DataSource");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BAllowsRecordAdds).HasColumnName("b_AllowsRecordAdds");

                entity.Property(e => e.BAllowsRecordDeletes).HasColumnName("b_AllowsRecordDeletes");

                entity.Property(e => e.BAllowsRecordEdits).HasColumnName("b_AllowsRecordEdits");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.Bin64PasswordHash)
                    .IsRequired()
                    .HasColumnName("bin_64_PasswordHash")
                    .HasColumnType("binary(64)");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintOriginId).HasColumnName("bint_OriginID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IParameterBasisId).HasColumnName("i_ParameterBasisID");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Vchr128DatabaseName)
                    .IsRequired()
                    .HasColumnName("vchr_128_DatabaseName")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr128DatabaseObject)
                    .IsRequired()
                    .HasColumnName("vchr_128_DatabaseObject")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr128UserName)
                    .IsRequired()
                    .HasColumnName("vchr_128_UserName")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr256ConnectionString)
                    .IsRequired()
                    .HasColumnName("vchr_256_ConnectionString")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr64Server)
                    .IsRequired()
                    .HasColumnName("vchr_64_Server")
                    .HasColumnType("varchar(64)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboDataSourceBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSource_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboDataSourceBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSource_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboDataSourceBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSource_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboDataSourceBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSource_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintOrigin)
                    .WithMany(p => p.InverseBintOrigin)
                    .HasForeignKey(d => d.BintOriginId)
                    .HasConstraintName("fk_dbo_DataSource_ID_to_dbo_DataSource_OriginID");

                entity.HasOne(d => d.IParameterBasis)
                    .WithMany(p => p.DboDataSource)
                    .HasForeignKey(d => d.IParameterBasisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_ParameterBasis_ID_to_dbo_DataSource_ParameterBasisID");
            });

            modelBuilder.Entity<DboDataSourceField>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_DataSourceField_bint_ID");

                entity.ToTable("dbo_DataSourceField");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BEnabled).HasColumnName("b_Enabled");

                entity.Property(e => e.BEncrypted).HasColumnName("b_Encrypted");

                entity.Property(e => e.BReadOnly).HasColumnName("b_ReadOnly");

                entity.Property(e => e.BRequired).HasColumnName("b_Required");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintDataSourceId).HasColumnName("bint_DataSourceID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IOrdinal).HasColumnName("i_Ordinal");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Vchr1024CharacterLimitsRegEx)
                    .HasColumnName("vchr_1024_CharacterLimitsRegEx")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Vchr1024MaskingRegEx)
                    .HasColumnName("vchr_1024_MaskingRegEx")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Vchr128Name)
                    .IsRequired()
                    .HasColumnName("vchr_128_Name")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboDataSourceFieldBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSourceField_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboDataSourceFieldBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSourceField_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintDataSource)
                    .WithMany(p => p.DboDataSourceField)
                    .HasForeignKey(d => d.BintDataSourceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_DataSource_ID_to_dbo_DataSourceField_DataSourceID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboDataSourceFieldBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSourceField_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboDataSourceFieldBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSourceField_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<DboDataSourceParameter>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_DataSourceParameter_bint_ID");

                entity.ToTable("dbo_DataSourceParameter");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintDataSourceId).HasColumnName("bint_DataSourceID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IOrdinal).HasColumnName("i_Ordinal");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description)
                    .IsRequired()
                    .HasColumnName("nvch_4000_Description");

                entity.Property(e => e.Vchr128Name)
                    .IsRequired()
                    .HasColumnName("vchr_128_Name")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboDataSourceParameterBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSourceParameter_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboDataSourceParameterBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSourceParameter_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintDataSource)
                    .WithMany(p => p.DboDataSourceParameter)
                    .HasForeignKey(d => d.BintDataSourceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_DataSource_ID_to_dbo_DataSourceParameter_DataSourceID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboDataSourceParameterBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSourceParameter_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboDataSourceParameterBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DataSourceParameter_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<DboDynamicDataMap>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_DynamicDataMap_bint_ID");

                entity.ToTable("dbo_DynamicDataMap");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IDynamicDataTypeId).HasColumnName("i_DynamicDataTypeID");

                entity.Property(e => e.ISourceEndpointId).HasColumnName("i_SourceEndpointID");

                entity.Property(e => e.ITargetEndpointId).HasColumnName("i_TargetEndpointID");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboDynamicDataMapBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DynamicDataMap_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboDynamicDataMapBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DynamicDataMap_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboDynamicDataMapBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DynamicDataMap_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboDynamicDataMapBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_DynamicDataMap_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.IDynamicDataType)
                    .WithMany(p => p.DboDynamicDataMap)
                    .HasForeignKey(d => d.IDynamicDataTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_DynamicDataType_ID_to_dbo_DynamicDataMap_DynamicDataTypeID");

                entity.HasOne(d => d.ISourceEndpoint)
                    .WithMany(p => p.DboDynamicDataMapISourceEndpoint)
                    .HasForeignKey(d => d.ISourceEndpointId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_DynamicDataEndpoint_ID_to_dbo_DynamicDataMap_SourceEndpointID");

                entity.HasOne(d => d.ITargetEndpoint)
                    .WithMany(p => p.DboDynamicDataMapITargetEndpoint)
                    .HasForeignKey(d => d.ITargetEndpointId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_DynamicDataEndpoint_ID_to_dbo_DynamicDataMap_TargetEndpointID");
            });

            modelBuilder.Entity<DboEmailServer>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_EmailServer_bint_ID");

                entity.ToTable("dbo_EmailServer");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.Bin64PasswordHash)
                    .IsRequired()
                    .HasColumnName("bin_64_PasswordHash")
                    .HasColumnType("binary(64)");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IEmailAccountTypeId).HasColumnName("i_EmailAccountTypeID");

                entity.Property(e => e.Vchr128UserName)
                    .IsRequired()
                    .HasColumnName("vchr_128_UserName")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr64OutgoingMailServer)
                    .IsRequired()
                    .HasColumnName("vchr_64_OutgoingMailServer")
                    .HasColumnType("varchar(64)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboEmailServerBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_EmailServer_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboEmailServerBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_EmailServer_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboEmailServerBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_EmailServer_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboEmailServerBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_EmailServer_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.IEmailAccountType)
                    .WithMany(p => p.DboEmailServer)
                    .HasForeignKey(d => d.IEmailAccountTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_EmailAccountType_ID_to_dbo_EmailServer_EmailAccountTypeID");
            });

            modelBuilder.Entity<DboForm>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_Form_bint_ID");

                entity.ToTable("dbo_Form");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BAllowDirectAccess).HasColumnName("b_AllowDirectAccess");

                entity.Property(e => e.BDefaultAllowAttachments).HasColumnName("b_DefaultAllowAttachments");

                entity.Property(e => e.BEnabled).HasColumnName("b_Enabled");

                entity.Property(e => e.BMobileFriendly).HasColumnName("b_MobileFriendly");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintAction1Id).HasColumnName("bint_Action1ID");

                entity.Property(e => e.BintAction2Id).HasColumnName("bint_Action2ID");

                entity.Property(e => e.BintAction3Id).HasColumnName("bint_Action3ID");

                entity.Property(e => e.BintAction4Id).HasColumnName("bint_Action4ID");

                entity.Property(e => e.BintAction5Id).HasColumnName("bint_Action5ID");

                entity.Property(e => e.BintAction6Id).HasColumnName("bint_Action6ID");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintDataSourceId).HasColumnName("bint_DataSourceID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintOriginId).HasColumnName("bint_OriginID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IAttachmentLimit).HasColumnName("i_AttachmentLimit");

                entity.Property(e => e.IBackingModeId).HasColumnName("i_BackingModeID");

                entity.Property(e => e.ICategoryId).HasColumnName("i_CategoryID");

                entity.Property(e => e.IInterfaceAvailabilityId).HasColumnName("i_InterfaceAvailabilityID");

                entity.Property(e => e.IReExecuteOnNextId).HasColumnName("i_ReExecuteOnNextID");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description)
                    .IsRequired()
                    .HasColumnName("nvch_4000_Description");

                entity.Property(e => e.Nvch4000NextActionDescription).HasColumnName("nvch_4000_NextActionDescription");

                entity.Property(e => e.NvchMaxHelpText)
                    .IsRequired()
                    .HasColumnName("nvch_max_HelpText");

                entity.Property(e => e.Vchr256AccessDeniedPagePath)
                    .HasColumnName("vchr_256_AccessDeniedPagePath")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ErrorPagePath)
                    .HasColumnName("vchr_256_ErrorPagePath")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256Path)
                    .IsRequired()
                    .HasColumnName("vchr_256_Path")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256Title)
                    .IsRequired()
                    .HasColumnName("vchr_256_Title")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr64Icon)
                    .HasColumnName("vchr_64_Icon")
                    .HasColumnType("varchar(64)");

                entity.HasOne(d => d.BintAction1)
                    .WithMany(p => p.DboFormBintAction1)
                    .HasForeignKey(d => d.BintAction1Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Form_Action1ID");

                entity.HasOne(d => d.BintAction2)
                    .WithMany(p => p.DboFormBintAction2)
                    .HasForeignKey(d => d.BintAction2Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Form_Action2ID");

                entity.HasOne(d => d.BintAction3)
                    .WithMany(p => p.DboFormBintAction3)
                    .HasForeignKey(d => d.BintAction3Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Form_Action3ID");

                entity.HasOne(d => d.BintAction4)
                    .WithMany(p => p.DboFormBintAction4)
                    .HasForeignKey(d => d.BintAction4Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Form_Action4ID");

                entity.HasOne(d => d.BintAction5)
                    .WithMany(p => p.DboFormBintAction5)
                    .HasForeignKey(d => d.BintAction5Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Form_Action5ID");

                entity.HasOne(d => d.BintAction6)
                    .WithMany(p => p.DboFormBintAction6)
                    .HasForeignKey(d => d.BintAction6Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Form_Action6ID");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboFormBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Form_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboFormBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Form_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintDataSource)
                    .WithMany(p => p.DboForm)
                    .HasForeignKey(d => d.BintDataSourceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_DataSource_ID_to_dbo_Form_DataSourceID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboFormBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Form_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboFormBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Form_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintOrigin)
                    .WithMany(p => p.InverseBintOrigin)
                    .HasForeignKey(d => d.BintOriginId)
                    .HasConstraintName("fk_dbo_Form_ID_to_dbo_Form_OriginID");

                entity.HasOne(d => d.IBackingMode)
                    .WithMany(p => p.DboForm)
                    .HasForeignKey(d => d.IBackingModeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_BackingMode_ID_to_dbo_Form_BackingModeID");

                entity.HasOne(d => d.ICategory)
                    .WithMany(p => p.DboForm)
                    .HasForeignKey(d => d.ICategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_FormCategory_ID_to_dbo_Form_CategoryID");

                entity.HasOne(d => d.IInterfaceAvailability)
                    .WithMany(p => p.DboForm)
                    .HasForeignKey(d => d.IInterfaceAvailabilityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_InterfaceAvailability_ID_to_dbo_Form_InterfaceAvailabilityID");

                entity.HasOne(d => d.IReExecuteOnNext)
                    .WithMany(p => p.DboForm)
                    .HasForeignKey(d => d.IReExecuteOnNextId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_ReExecuteOnNext_ID_to_dbo_Form_ReExecuteOnNextID");
            });

            modelBuilder.Entity<DboFormAction>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_FormAction_bint_ID");

                entity.ToTable("dbo_FormAction");

                entity.HasIndex(e => e.Vchr128Name)
                    .HasName("uq_dbo_FormAction_vchr_128_Name")
                    .IsUnique();

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintFormId).HasColumnName("bint_FormID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IParameterBasisId).HasColumnName("i_ParameterBasisID");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description)
                    .IsRequired()
                    .HasColumnName("nvch_4000_Description");

                entity.Property(e => e.Vchr128Name)
                    .IsRequired()
                    .HasColumnName("vchr_128_Name")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboFormActionBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormAction_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboFormActionBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormAction_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintForm)
                    .WithMany(p => p.DboFormAction)
                    .HasForeignKey(d => d.BintFormId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Form_ID_to_dbo_FormAction_FormID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboFormActionBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormAction_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboFormActionBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormAction_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.IParameterBasis)
                    .WithMany(p => p.DboFormAction)
                    .HasForeignKey(d => d.IParameterBasisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_ParameterBasis_ID_to_dbo_FormAction_ParameterBasisID");
            });

            modelBuilder.Entity<DboFormFieldConfiguration>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_FormFieldConfiguration_bint_ID");

                entity.ToTable("dbo_FormFieldConfiguration");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BReadOnly).HasColumnName("b_ReadOnly");

                entity.Property(e => e.BRequired).HasColumnName("b_Required");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintCredentialId).HasColumnName("bint_CredentialID");

                entity.Property(e => e.BintFormId).HasColumnName("bint_FormID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description).HasColumnName("nvch_4000_Description");

                entity.Property(e => e.NvchMaxHelpText).HasColumnName("nvch_max_HelpText");

                entity.Property(e => e.Vchr1024CharacterLimitsRegEx)
                    .HasColumnName("vchr_1024_CharacterLimitsRegEx")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Vchr1024MaskingRegEx)
                    .HasColumnName("vchr_1024_MaskingRegEx")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256Title)
                    .IsRequired()
                    .HasColumnName("vchr_256_Title")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboFormFieldConfigurationBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormFieldConfiguration_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboFormFieldConfigurationBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormFieldConfiguration_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintCredential)
                    .WithMany(p => p.DboFormFieldConfigurationBintCredential)
                    .HasForeignKey(d => d.BintCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormFieldConfiguration_CredentialID");

                entity.HasOne(d => d.BintForm)
                    .WithMany(p => p.DboFormFieldConfiguration)
                    .HasForeignKey(d => d.BintFormId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Form_ID_to_dbo_FormFieldConfiguration_FormID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboFormFieldConfigurationBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormFieldConfiguration_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboFormFieldConfigurationBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormFieldConfiguration_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<DboFormFileAttachment>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_FormFileAttachment_bint_ID");

                entity.ToTable("dbo_FormFileAttachment");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintSize).HasColumnName("bint_Size");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description).HasColumnName("nvch_4000_Description");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256Path)
                    .IsRequired()
                    .HasColumnName("vchr_256_Path")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboFormFileAttachmentBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormFileAttachment_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboFormFileAttachmentBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormFileAttachment_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboFormFileAttachmentBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormFileAttachment_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboFormFileAttachmentBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_FormFileAttachment_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<DboModule>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_Module_bint_ID");

                entity.ToTable("dbo_Module");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BEnabled).HasColumnName("b_Enabled");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IInterfaceAvailabilityId).HasColumnName("i_InterfaceAvailabilityID");

                entity.Property(e => e.IOrdinal).HasColumnName("i_Ordinal");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description)
                    .IsRequired()
                    .HasColumnName("nvch_4000_Description");

                entity.Property(e => e.NvchMaxHelpText)
                    .IsRequired()
                    .HasColumnName("nvch_max_HelpText");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256Title)
                    .IsRequired()
                    .HasColumnName("vchr_256_Title")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr64Icon)
                    .HasColumnName("vchr_64_Icon")
                    .HasColumnType("varchar(64)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboModuleBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Module_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboModuleBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Module_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboModuleBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Module_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboModuleBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Module_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.IInterfaceAvailability)
                    .WithMany(p => p.DboModule)
                    .HasForeignKey(d => d.IInterfaceAvailabilityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_InterfaceAvailability_ID_to_dbo_Module_InterfaceAvailabilityID");
            });

            modelBuilder.Entity<DboModuleWorkflow>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_ModuleWorkflow_bint_ID");

                entity.ToTable("dbo_ModuleWorkflow");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BEnabled).HasColumnName("b_Enabled");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintModuleId).HasColumnName("bint_ModuleID");

                entity.Property(e => e.BintWorkflowId).HasColumnName("bint_WorkflowID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IInterfaceAvailabilityId).HasColumnName("i_InterfaceAvailabilityID");

                entity.Property(e => e.IOrdinal).HasColumnName("i_Ordinal");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboModuleWorkflowBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_ModuleWorkflow_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboModuleWorkflowBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_ModuleWorkflow_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboModuleWorkflowBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_ModuleWorkflow_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboModuleWorkflowBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_ModuleWorkflow_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintModule)
                    .WithMany(p => p.DboModuleWorkflow)
                    .HasForeignKey(d => d.BintModuleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Module_ID_to_dbo_ModuleWorkflow_ModuleID");

                entity.HasOne(d => d.BintWorkflow)
                    .WithMany(p => p.DboModuleWorkflow)
                    .HasForeignKey(d => d.BintWorkflowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Workflow_ID_to_dbo_ModuleWorkflow_WorkflowID");

                entity.HasOne(d => d.IInterfaceAvailability)
                    .WithMany(p => p.DboModuleWorkflow)
                    .HasForeignKey(d => d.IInterfaceAvailabilityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_InterfaceAvailability_ID_to_dbo_ModuleWorkflow_InterfaceAvailabilityID");
            });

            modelBuilder.Entity<DboPermissionLog>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_PermissionLog_bint_ID");

                entity.ToTable("dbo_PermissionLog");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCredentialId).HasColumnName("bint_CredentialID");

                entity.Property(e => e.BintSpoofOfCredentialId).HasColumnName("bint_SpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256Context)
                    .IsRequired()
                    .HasColumnName("vchr_256_Context")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCredential)
                    .WithMany(p => p.DboPermissionLogBintCredential)
                    .HasForeignKey(d => d.BintCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PermissionLog_CredentialID");

                entity.HasOne(d => d.BintSpoofOfCredential)
                    .WithMany(p => p.DboPermissionLogBintSpoofOfCredential)
                    .HasForeignKey(d => d.BintSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PermissionLog_SpoofOfCredentialID");
            });

            modelBuilder.Entity<DboPushNotification>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_PushNotification_bint_ID");

                entity.ToTable("dbo_PushNotification");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description)
                    .IsRequired()
                    .HasColumnName("nvch_4000_Description");

                entity.Property(e => e.NvchMaxContentText)
                    .IsRequired()
                    .HasColumnName("nvch_max_ContentText");

                entity.Property(e => e.Vchr256Context)
                    .IsRequired()
                    .HasColumnName("vchr_256_Context")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboPushNotificationBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotification_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboPushNotificationBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotification_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboPushNotificationBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotification_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboPushNotificationBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotification_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<DboPushNotificationDismissal>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_PushNotificationDismissal_bint_ID");

                entity.ToTable("dbo_PushNotificationDismissal");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintPushNotificationId).HasColumnName("bint_PushNotificationID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboPushNotificationDismissalBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotificationDismissal_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboPushNotificationDismissalBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotificationDismissal_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboPushNotificationDismissalBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotificationDismissal_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboPushNotificationDismissalBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotificationDismissal_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintPushNotification)
                    .WithMany(p => p.DboPushNotificationDismissal)
                    .HasForeignKey(d => d.BintPushNotificationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_PushNotification_ID_to_dbo_PushNotificationDismissal_PushNotificationID");
            });

            modelBuilder.Entity<DboPushNotificationTarget>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_PushNotificationTarget_bint_ID");

                entity.ToTable("dbo_PushNotificationTarget");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BDismissable).HasColumnName("b_Dismissable");

                entity.Property(e => e.BShowAsPopup).HasColumnName("b_ShowAsPopup");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintPushNotificationId).HasColumnName("bint_PushNotificationID");

                entity.Property(e => e.BintTargetCredentialId).HasColumnName("bint_TargetCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtEffective)
                    .HasColumnName("dt_Effective")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtExpires)
                    .HasColumnName("dt_Expires")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboPushNotificationTargetBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotificationTarget_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboPushNotificationTargetBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotificationTarget_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboPushNotificationTargetBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotificationTarget_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboPushNotificationTargetBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotificationTarget_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintPushNotification)
                    .WithMany(p => p.DboPushNotificationTarget)
                    .HasForeignKey(d => d.BintPushNotificationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_PushNotification_ID_to_dbo_PushNotificationTarget_PushNotificationID");

                entity.HasOne(d => d.BintTargetCredential)
                    .WithMany(p => p.DboPushNotificationTargetBintTargetCredential)
                    .HasForeignKey(d => d.BintTargetCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_PushNotificationTarget_TargetCredentialID");
            });

            modelBuilder.Entity<DboRole>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_Role_bint_ID");

                entity.ToTable("dbo_Role");

                entity.HasIndex(e => e.Nvch128Caption)
                    .HasName("uq_dbo_Role_nvch_128_Caption")
                    .IsUnique();

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description)
                    .IsRequired()
                    .HasColumnName("nvch_4000_Description");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboRoleBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Role_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboRoleBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Role_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboRoleBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Role_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboRoleBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Role_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<DboRolePermission>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_RolePermission_bint_ID");

                entity.ToTable("dbo_RolePermission");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintRoleId).HasColumnName("bint_RoleID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IPermissionId).HasColumnName("i_PermissionID");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboRolePermissionBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_RolePermission_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboRolePermissionBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_RolePermission_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboRolePermissionBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_RolePermission_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboRolePermissionBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_RolePermission_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintRole)
                    .WithMany(p => p.DboRolePermission)
                    .HasForeignKey(d => d.BintRoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Role_ID_to_dbo_RolePermission_RoleID");

                entity.HasOne(d => d.IPermission)
                    .WithMany(p => p.DboRolePermission)
                    .HasForeignKey(d => d.IPermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_Permission_ID_to_dbo_RolePermission_PermissionID");
            });

            modelBuilder.Entity<DboSocialConversationDismissal>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_SocialConversationDismissal_bint_ID");

                entity.ToTable("dbo_SocialConversationDismissal");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintSocialConversationEntryId).HasColumnName("bint_SocialConversationEntryID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboSocialConversationDismissalBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SocialConversationDismissal_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboSocialConversationDismissalBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SocialConversationDismissal_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboSocialConversationDismissalBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SocialConversationDismissal_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboSocialConversationDismissalBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SocialConversationDismissal_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintSocialConversationEntry)
                    .WithMany(p => p.DboSocialConversationDismissal)
                    .HasForeignKey(d => d.BintSocialConversationEntryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_SocialConversationEntry_ID_to_dbo_SocialConversationDismissal_SocialConversationEntryID");
            });

            modelBuilder.Entity<DboSocialConversationEntry>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_SocialConversationEntry_bint_ID");

                entity.ToTable("dbo_SocialConversationEntry");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintCredentialId).HasColumnName("bint_CredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.NvchMaxContentText)
                    .IsRequired()
                    .HasColumnName("nvch_max_ContentText");

                entity.Property(e => e.Vchr256Context)
                    .IsRequired()
                    .HasColumnName("vchr_256_Context")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboSocialConversationEntryBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SocialConversationEntry_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboSocialConversationEntryBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SocialConversationEntry_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintCredential)
                    .WithMany(p => p.DboSocialConversationEntryBintCredential)
                    .HasForeignKey(d => d.BintCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SocialConversationEntry_CredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboSocialConversationEntryBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SocialConversationEntry_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboSocialConversationEntryBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SocialConversationEntry_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<DboSpoofLog>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_SpoofLog_bint_ID");

                entity.ToTable("dbo_SpoofLog");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintActualUserCredentialId).HasColumnName("bint_ActualUserCredentialID");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintSpoofUserCredentialId).HasColumnName("bint_SpoofUserCredentialID");

                entity.Property(e => e.DtBegan)
                    .HasColumnName("dt_Began")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtEnded)
                    .HasColumnName("dt_Ended")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtExpires)
                    .HasColumnName("dt_Expires")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintActualUserCredential)
                    .WithMany(p => p.DboSpoofLogBintActualUserCredential)
                    .HasForeignKey(d => d.BintActualUserCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SpoofLog_ActualUserCredentialID");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboSpoofLogBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SpoofLog_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboSpoofLogBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SpoofLog_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboSpoofLogBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SpoofLog_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboSpoofLogBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SpoofLog_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintSpoofUserCredential)
                    .WithMany(p => p.DboSpoofLogBintSpoofUserCredential)
                    .HasForeignKey(d => d.BintSpoofUserCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_SpoofLog_SpoofUserCredentialID");
            });

            modelBuilder.Entity<DboWorkflow>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_Workflow_bint_ID");

                entity.ToTable("dbo_Workflow");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BEnabled).HasColumnName("b_Enabled");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintAction1Id).HasColumnName("bint_Action1ID");

                entity.Property(e => e.BintAction2Id).HasColumnName("bint_Action2ID");

                entity.Property(e => e.BintAction3Id).HasColumnName("bint_Action3ID");

                entity.Property(e => e.BintAction4Id).HasColumnName("bint_Action4ID");

                entity.Property(e => e.BintAction5Id).HasColumnName("bint_Action5ID");

                entity.Property(e => e.BintAction6Id).HasColumnName("bint_Action6ID");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintOriginId).HasColumnName("bint_OriginID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ICategoryId).HasColumnName("i_CategoryID");

                entity.Property(e => e.IDataRetentionScheduleId).HasColumnName("i_DataRetentionScheduleID");

                entity.Property(e => e.IInterfaceAvailabilityId).HasColumnName("i_InterfaceAvailabilityID");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description)
                    .IsRequired()
                    .HasColumnName("nvch_4000_Description");

                entity.Property(e => e.NvchMaxHelpText)
                    .IsRequired()
                    .HasColumnName("nvch_max_HelpText");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256Title)
                    .IsRequired()
                    .HasColumnName("vchr_256_Title")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr64Icon)
                    .HasColumnName("vchr_64_Icon")
                    .HasColumnType("varchar(64)");

                entity.HasOne(d => d.BintAction1)
                    .WithMany(p => p.DboWorkflowBintAction1)
                    .HasForeignKey(d => d.BintAction1Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Workflow_Action1ID");

                entity.HasOne(d => d.BintAction2)
                    .WithMany(p => p.DboWorkflowBintAction2)
                    .HasForeignKey(d => d.BintAction2Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Workflow_Action2ID");

                entity.HasOne(d => d.BintAction3)
                    .WithMany(p => p.DboWorkflowBintAction3)
                    .HasForeignKey(d => d.BintAction3Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Workflow_Action3ID");

                entity.HasOne(d => d.BintAction4)
                    .WithMany(p => p.DboWorkflowBintAction4)
                    .HasForeignKey(d => d.BintAction4Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Workflow_Action4ID");

                entity.HasOne(d => d.BintAction5)
                    .WithMany(p => p.DboWorkflowBintAction5)
                    .HasForeignKey(d => d.BintAction5Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Workflow_Action5ID");

                entity.HasOne(d => d.BintAction6)
                    .WithMany(p => p.DboWorkflowBintAction6)
                    .HasForeignKey(d => d.BintAction6Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_Workflow_Action6ID");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboWorkflowBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Workflow_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboWorkflowBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Workflow_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboWorkflowBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Workflow_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboWorkflowBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_Workflow_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintOrigin)
                    .WithMany(p => p.InverseBintOrigin)
                    .HasForeignKey(d => d.BintOriginId)
                    .HasConstraintName("fk_dbo_Workflow_ID_to_dbo_Workflow_OriginID");

                entity.HasOne(d => d.ICategory)
                    .WithMany(p => p.DboWorkflow)
                    .HasForeignKey(d => d.ICategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_WorkflowCategory_ID_to_dbo_Workflow_CategoryID");

                entity.HasOne(d => d.IDataRetentionSchedule)
                    .WithMany(p => p.DboWorkflow)
                    .HasForeignKey(d => d.IDataRetentionScheduleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_DataRetentionSchedule_ID_to_dbo_Workflow_DataRetentionScheduleID");

                entity.HasOne(d => d.IInterfaceAvailability)
                    .WithMany(p => p.DboWorkflow)
                    .HasForeignKey(d => d.IInterfaceAvailabilityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_InterfaceAvailability_ID_to_dbo_Workflow_InterfaceAvailabilityID");
            });

            modelBuilder.Entity<DboWorkflowInstance>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_WorkflowInstance_bint_ID");

                entity.ToTable("dbo_WorkflowInstance");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintAssignedToCredentialId).HasColumnName("bint_AssignedToCredentialID");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintWorkflowId).HasColumnName("bint_WorkflowID");

                entity.Property(e => e.BintWorkflowStepId).HasColumnName("bint_WorkflowStepID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IIteration).HasColumnName("i_Iteration");

                entity.Property(e => e.IRecordNumber).HasColumnName("i_RecordNumber");

                entity.Property(e => e.Vchr256Control)
                    .HasColumnName("vchr_256_Control")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintAssignedToCredential)
                    .WithMany(p => p.DboWorkflowInstanceBintAssignedToCredential)
                    .HasForeignKey(d => d.BintAssignedToCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowInstance_AssignedToCredentialID");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboWorkflowInstanceBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowInstance_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboWorkflowInstanceBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowInstance_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboWorkflowInstanceBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowInstance_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboWorkflowInstanceBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowInstance_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintWorkflow)
                    .WithMany(p => p.DboWorkflowInstance)
                    .HasForeignKey(d => d.BintWorkflowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Workflow_ID_to_dbo_WorkflowInstance_WorkflowID");

                entity.HasOne(d => d.BintWorkflowStep)
                    .WithMany(p => p.DboWorkflowInstance)
                    .HasForeignKey(d => d.BintWorkflowStepId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_WorkflowStep_ID_to_dbo_WorkflowInstance_WorkflowStepID");
            });

            modelBuilder.Entity<DboWorkflowStep>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_WorkflowStep_bint_ID");

                entity.ToTable("dbo_WorkflowStep");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BAllowDirectAccess).HasColumnName("b_AllowDirectAccess");

                entity.Property(e => e.BHighlightWhenActive).HasColumnName("b_HighlightWhenActive");

                entity.Property(e => e.BShowInWorkflowMap).HasColumnName("b_ShowInWorkflowMap");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintAction1Id).HasColumnName("bint_Action1ID");

                entity.Property(e => e.BintAction2Id).HasColumnName("bint_Action2ID");

                entity.Property(e => e.BintAction3Id).HasColumnName("bint_Action3ID");

                entity.Property(e => e.BintAction4Id).HasColumnName("bint_Action4ID");

                entity.Property(e => e.BintAction5Id).HasColumnName("bint_Action5ID");

                entity.Property(e => e.BintAction6Id).HasColumnName("bint_Action6ID");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintWorkflowId).HasColumnName("bint_WorkflowID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IAttachmentLimit).HasColumnName("i_AttachmentLimit");

                entity.Property(e => e.IWorkflowStepTypeId).HasColumnName("i_WorkflowStepTypeID");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description)
                    .IsRequired()
                    .HasColumnName("nvch_4000_Description");

                entity.Property(e => e.NvchMaxHelpText)
                    .IsRequired()
                    .HasColumnName("nvch_max_HelpText");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256Title)
                    .HasColumnName("vchr_256_Title")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintAction1)
                    .WithMany(p => p.DboWorkflowStepBintAction1)
                    .HasForeignKey(d => d.BintAction1Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_WorkflowStep_Action1ID");

                entity.HasOne(d => d.BintAction2)
                    .WithMany(p => p.DboWorkflowStepBintAction2)
                    .HasForeignKey(d => d.BintAction2Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_WorkflowStep_Action2ID");

                entity.HasOne(d => d.BintAction3)
                    .WithMany(p => p.DboWorkflowStepBintAction3)
                    .HasForeignKey(d => d.BintAction3Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_WorkflowStep_Action3ID");

                entity.HasOne(d => d.BintAction4)
                    .WithMany(p => p.DboWorkflowStepBintAction4)
                    .HasForeignKey(d => d.BintAction4Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_WorkflowStep_Action4ID");

                entity.HasOne(d => d.BintAction5)
                    .WithMany(p => p.DboWorkflowStepBintAction5)
                    .HasForeignKey(d => d.BintAction5Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_WorkflowStep_Action5ID");

                entity.HasOne(d => d.BintAction6)
                    .WithMany(p => p.DboWorkflowStepBintAction6)
                    .HasForeignKey(d => d.BintAction6Id)
                    .HasConstraintName("fk_dbo_Action_ID_to_dbo_WorkflowStep_Action6ID");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboWorkflowStepBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowStep_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboWorkflowStepBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowStep_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboWorkflowStepBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowStep_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboWorkflowStepBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowStep_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintWorkflow)
                    .WithMany(p => p.DboWorkflowStep)
                    .HasForeignKey(d => d.BintWorkflowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Workflow_ID_to_dbo_WorkflowStep_WorkflowID");

                entity.HasOne(d => d.IWorkflowStepType)
                    .WithMany(p => p.DboWorkflowStep)
                    .HasForeignKey(d => d.IWorkflowStepTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_WorkflowStepType_ID_to_dbo_WorkflowStep_WorkflowStepTypeID");
            });

            modelBuilder.Entity<DboWorkflowStepFieldConfiguration>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_WorkflowStepFieldConfiguration_bint_ID");

                entity.ToTable("dbo_WorkflowStepFieldConfiguration");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BReadOnly).HasColumnName("b_ReadOnly");

                entity.Property(e => e.BRequired).HasColumnName("b_Required");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintCredentialId).HasColumnName("bint_CredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.BintWorkflowStepId).HasColumnName("bint_WorkflowStepID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Nvch128Caption)
                    .IsRequired()
                    .HasColumnName("nvch_128_Caption")
                    .HasMaxLength(128);

                entity.Property(e => e.Nvch4000Description)
                    .IsRequired()
                    .HasColumnName("nvch_4000_Description");

                entity.Property(e => e.NvchMaxHelpText)
                    .IsRequired()
                    .HasColumnName("nvch_max_HelpText");

                entity.Property(e => e.Vchr1024CharacterLimitsRegEx)
                    .HasColumnName("vchr_1024_CharacterLimitsRegEx")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Vchr1024MaskingRegEx)
                    .HasColumnName("vchr_1024_MaskingRegEx")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256Title)
                    .IsRequired()
                    .HasColumnName("vchr_256_Title")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.DboWorkflowStepFieldConfigurationBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowStepFieldConfiguration_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.DboWorkflowStepFieldConfigurationBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowStepFieldConfiguration_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintCredential)
                    .WithMany(p => p.DboWorkflowStepFieldConfigurationBintCredential)
                    .HasForeignKey(d => d.BintCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowStepFieldConfiguration_CredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.DboWorkflowStepFieldConfigurationBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowStepFieldConfiguration_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.DboWorkflowStepFieldConfigurationBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_dbo_WorkflowStepFieldConfiguration_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.BintWorkflowStep)
                    .WithMany(p => p.DboWorkflowStepFieldConfiguration)
                    .HasForeignKey(d => d.BintWorkflowStepId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_WorkflowStep_ID_to_dbo_WorkflowStepFieldConfiguration_WorkflowStepID");
            });

            modelBuilder.Entity<LkpBackingMode>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_BackingMode_i_ID");

                entity.ToTable("lkp_BackingMode", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpBackingModeBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_BackingMode_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpBackingModeBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_BackingMode_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpBackingModeBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_BackingMode_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpBackingModeBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_BackingMode_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpCredentialConfiguration>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_CredentialConfiguration_i_ID");

                entity.ToTable("lkp_CredentialConfiguration", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpCredentialConfigurationBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_CredentialConfiguration_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpCredentialConfigurationBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_CredentialConfiguration_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpCredentialConfigurationBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_CredentialConfiguration_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpCredentialConfigurationBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_CredentialConfiguration_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpCredentialType>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_CredentialType_i_ID");

                entity.ToTable("lkp_CredentialType", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpCredentialTypeBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_CredentialType_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpCredentialTypeBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_CredentialType_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpCredentialTypeBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_CredentialType_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpCredentialTypeBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_CredentialType_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpDataRetentionSchedule>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_DataRetentionSchedule_i_ID");

                entity.ToTable("lkp_DataRetentionSchedule", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BEnabled).HasColumnName("b_Enabled");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IArchivePeriodicityComparisonId).HasColumnName("i_ArchivePeriodicityComparisonID");

                entity.Property(e => e.IArchivePeriodicityCount).HasColumnName("i_ArchivePeriodicityCount");

                entity.Property(e => e.IArchivePeriodicityUnitId).HasColumnName("i_ArchivePeriodicityUnitID");

                entity.Property(e => e.IDeletePeriodicityComparisonId).HasColumnName("i_DeletePeriodicityComparisonID");

                entity.Property(e => e.IDeletePeriodicityCount).HasColumnName("i_DeletePeriodicityCount");

                entity.Property(e => e.IDeletePeriodicityUnitId).HasColumnName("i_DeletePeriodicityUnitID");

                entity.Property(e => e.IFlagPeriodicityComparisonId).HasColumnName("i_FlagPeriodicityComparisonID");

                entity.Property(e => e.IFlagPeriodicityCount).HasColumnName("i_FlagPeriodicityCount");

                entity.Property(e => e.IFlagPeriodicityUnitId).HasColumnName("i_FlagPeriodicityUnitID");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.IArchivePeriodicityComparison)
                    .WithMany(p => p.LkpDataRetentionScheduleIArchivePeriodicityComparison)
                    .HasForeignKey(d => d.IArchivePeriodicityComparisonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PeriodicityComparison_ID_to_lkp_DataRetentionSchedule_ArchivePeriodicityComparisonID");

                entity.HasOne(d => d.IArchivePeriodicityUnit)
                    .WithMany(p => p.LkpDataRetentionScheduleIArchivePeriodicityUnit)
                    .HasForeignKey(d => d.IArchivePeriodicityUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PeriodicityUnit_ID_to_lkp_DataRetentionSchedule_ArchivePeriodicityUnitID");

                entity.HasOne(d => d.IDeletePeriodicityComparison)
                    .WithMany(p => p.LkpDataRetentionScheduleIDeletePeriodicityComparison)
                    .HasForeignKey(d => d.IDeletePeriodicityComparisonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PeriodicityComparison_ID_to_lkp_DataRetentionSchedule_DeletePeriodicityComparisonID");

                entity.HasOne(d => d.IDeletePeriodicityUnit)
                    .WithMany(p => p.LkpDataRetentionScheduleIDeletePeriodicityUnit)
                    .HasForeignKey(d => d.IDeletePeriodicityUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PeriodicityUnit_ID_to_lkp_DataRetentionSchedule_DeletePeriodicityUnitID");

                entity.HasOne(d => d.IFlagPeriodicityComparison)
                    .WithMany(p => p.LkpDataRetentionScheduleIFlagPeriodicityComparison)
                    .HasForeignKey(d => d.IFlagPeriodicityComparisonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PeriodicityComparison_ID_to_lkp_DataRetentionSchedule_FlagPeriodicityComparisonID");

                entity.HasOne(d => d.IFlagPeriodicityUnit)
                    .WithMany(p => p.LkpDataRetentionScheduleIFlagPeriodicityUnit)
                    .HasForeignKey(d => d.IFlagPeriodicityUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PeriodicityUnit_ID_to_lkp_DataRetentionSchedule_FlagPeriodicityUnitID");
            });

            modelBuilder.Entity<LkpDynamicDataEndpoint>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_DynamicDataEndpoint_i_ID");

                entity.ToTable("lkp_DynamicDataEndpoint", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpDynamicDataEndpointBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataEndpoint_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpDynamicDataEndpointBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataEndpoint_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpDynamicDataEndpointBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataEndpoint_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpDynamicDataEndpointBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataEndpoint_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpDynamicDataHierarchy>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_DynamicDataHierarchy_i_ID");

                entity.ToTable("lkp_DynamicDataHierarchy", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BDefaultChildRecord).HasColumnName("b_DefaultChildRecord");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IChildDynamicDataEndpointId).HasColumnName("i_ChildDynamicDataEndpointID");

                entity.Property(e => e.IParentDynamicDataEndpointId).HasColumnName("i_ParentDynamicDataEndpointID");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpDynamicDataHierarchyBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataHierarchy_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpDynamicDataHierarchyBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataHierarchy_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpDynamicDataHierarchyBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataHierarchy_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpDynamicDataHierarchyBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataHierarchy_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.IChildDynamicDataEndpoint)
                    .WithMany(p => p.LkpDynamicDataHierarchyIChildDynamicDataEndpoint)
                    .HasForeignKey(d => d.IChildDynamicDataEndpointId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_DynamicDataEndpoint_ID_to_lkp_DynamicDataHierarchy_ChildDynamicDataEndpointID");

                entity.HasOne(d => d.IParentDynamicDataEndpoint)
                    .WithMany(p => p.LkpDynamicDataHierarchyIParentDynamicDataEndpoint)
                    .HasForeignKey(d => d.IParentDynamicDataEndpointId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_DynamicDataEndpoint_ID_to_lkp_DynamicDataHierarchy_ParentDynamicDataEndpointID");
            });

            modelBuilder.Entity<LkpDynamicDataType>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_DynamicDataType_i_ID");

                entity.ToTable("lkp_DynamicDataType", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpDynamicDataTypeBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataType_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpDynamicDataTypeBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataType_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpDynamicDataTypeBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataType_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpDynamicDataTypeBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_DynamicDataType_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpEmailAccountType>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_EmailAccountType_i_ID");

                entity.ToTable("lkp_EmailAccountType", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpEmailAccountTypeBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_EmailAccountType_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpEmailAccountTypeBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_EmailAccountType_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpEmailAccountTypeBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_EmailAccountType_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpEmailAccountTypeBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_EmailAccountType_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpEmailTemplate>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_EmailTemplate_i_ID");

                entity.ToTable("lkp_EmailTemplate", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.NvchMaxBody)
                    .IsRequired()
                    .HasColumnName("nvch_max_Body");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpEmailTemplateBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_EmailTemplate_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpEmailTemplateBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_EmailTemplate_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpEmailTemplateBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_EmailTemplate_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpEmailTemplateBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_EmailTemplate_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpErrorPanelFilter>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_ErrorPanelFilter_i_ID");

                entity.ToTable("lkp_ErrorPanelFilter", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpErrorPanelFilterBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ErrorPanelFilter_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpErrorPanelFilterBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ErrorPanelFilter_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpErrorPanelFilterBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ErrorPanelFilter_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpErrorPanelFilterBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ErrorPanelFilter_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpFormCategory>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_FormCategory_i_ID");

                entity.ToTable("lkp_FormCategory", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpFormCategoryBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_FormCategory_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpFormCategoryBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_FormCategory_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpFormCategoryBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_FormCategory_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpFormCategoryBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_FormCategory_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpInterfaceAvailability>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_InterfaceAvailability_i_ID");

                entity.ToTable("lkp_InterfaceAvailability", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpInterfaceAvailabilityBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_InterfaceAvailability_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpInterfaceAvailabilityBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_InterfaceAvailability_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpInterfaceAvailabilityBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_InterfaceAvailability_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpInterfaceAvailabilityBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_InterfaceAvailability_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpLocalization>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_Localization_bint_ID");

                entity.ToTable("lkp_Localization", "lkp");

                entity.HasIndex(e => new { e.ILocalizationSetId, e.BintConcept })
                    .HasName("uq_lkp_Localization_UniqueCombination2")
                    .IsUnique();

                entity.HasIndex(e => new { e.Vchr64LocalizationType, e.ILocalizationSetId, e.Vchr128Name, e.Vchr128Identifier })
                    .HasName("uq_lkp_Localization_UniqueCombination")
                    .IsUnique();

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintConcept).HasColumnName("bint_Concept");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ILocalizationSetId)
                    .HasColumnName("i_LocalizationSetID")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Nvch4000Description).HasColumnName("nvch_4000_Description");

                entity.Property(e => e.NvchMaxText).HasColumnName("nvch_max_Text");

                entity.Property(e => e.Vchr128Identifier)
                    .IsRequired()
                    .HasColumnName("vchr_128_Identifier")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr128Name)
                    .IsRequired()
                    .HasColumnName("vchr_128_Name")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr64LocalizationType)
                    .IsRequired()
                    .HasColumnName("vchr_64_LocalizationType")
                    .HasColumnType("varchar(64)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpLocalizationBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_Localization_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpLocalizationBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_Localization_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpLocalizationBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_Localization_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpLocalizationBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_Localization_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.ILocalizationSet)
                    .WithMany(p => p.LkpLocalization)
                    .HasForeignKey(d => d.ILocalizationSetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_LocalizationSet_ID_to_lkp_Localization_LocalizationSetID");
            });

            modelBuilder.Entity<LkpLocalizationSet>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_LocalizationSet_i_ID");

                entity.ToTable("lkp_LocalizationSet", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpLocalizationSetBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_LocalizationSet_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpLocalizationSetBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_LocalizationSet_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpLocalizationSetBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_LocalizationSet_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpLocalizationSetBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_LocalizationSet_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpNotificationEvent>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_NotificationEvent_i_ID");

                entity.ToTable("lkp_NotificationEvent", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpNotificationEventBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_NotificationEvent_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpNotificationEventBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_NotificationEvent_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpNotificationEventBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_NotificationEvent_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpNotificationEventBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_NotificationEvent_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpOpenLinkMethod>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_OpenLinkMethod_i_ID");

                entity.ToTable("lkp_OpenLinkMethod", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpOpenLinkMethodBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_OpenLinkMethod_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpOpenLinkMethodBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_OpenLinkMethod_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpOpenLinkMethodBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_OpenLinkMethod_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpOpenLinkMethodBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_OpenLinkMethod_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpPanelPosition>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_PanelPosition_i_ID");

                entity.ToTable("lkp_PanelPosition", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpPanelPositionBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PanelPosition_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpPanelPositionBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PanelPosition_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpPanelPositionBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PanelPosition_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpPanelPositionBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PanelPosition_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpParameterBasis>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_ParameterBasis_i_ID");

                entity.ToTable("lkp_ParameterBasis", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpParameterBasisBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ParameterBasis_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpParameterBasisBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ParameterBasis_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpParameterBasisBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ParameterBasis_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpParameterBasisBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ParameterBasis_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpPeriodicityComparison>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_PeriodicityComparison_i_ID");

                entity.ToTable("lkp_PeriodicityComparison", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpPeriodicityComparisonBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PeriodicityComparison_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpPeriodicityComparisonBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PeriodicityComparison_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpPeriodicityComparisonBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PeriodicityComparison_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpPeriodicityComparisonBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PeriodicityComparison_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpPeriodicityUnit>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_PeriodicityUnit_i_ID");

                entity.ToTable("lkp_PeriodicityUnit", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpPeriodicityUnitBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PeriodicityUnit_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpPeriodicityUnitBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PeriodicityUnit_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpPeriodicityUnitBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PeriodicityUnit_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpPeriodicityUnitBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PeriodicityUnit_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpPermission>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_Permission_bint_ID");

                entity.ToTable("lkp_Permission", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IPermissionTypeId).HasColumnName("i_PermissionTypeID");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpPermissionBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_Permission_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpPermissionBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_Permission_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpPermissionBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_Permission_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpPermissionBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_Permission_ModifierSpoofOfCredentialID");

                entity.HasOne(d => d.IPermissionType)
                    .WithMany(p => p.LkpPermission)
                    .HasForeignKey(d => d.IPermissionTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_lkp_PermissionType_ID_to_lkp_Permission_PermissionTypeID");
            });

            modelBuilder.Entity<LkpPermissionType>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_PermissionType_i_ID");

                entity.ToTable("lkp_PermissionType", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpPermissionTypeBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PermissionType_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpPermissionTypeBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PermissionType_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpPermissionTypeBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PermissionType_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpPermissionTypeBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_PermissionType_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpReExecuteOnNext>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_ReExecuteOnNext_i_ID");

                entity.ToTable("lkp_ReExecuteOnNext", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpReExecuteOnNextBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ReExecuteOnNext_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpReExecuteOnNextBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ReExecuteOnNext_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpReExecuteOnNextBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ReExecuteOnNext_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpReExecuteOnNextBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_ReExecuteOnNext_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpSocialConversationScope>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_SocialConversationScope_i_ID");

                entity.ToTable("lkp_SocialConversationScope", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpSocialConversationScopeBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SocialConversationScope_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpSocialConversationScopeBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SocialConversationScope_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpSocialConversationScopeBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SocialConversationScope_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpSocialConversationScopeBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SocialConversationScope_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpSpecialDataReference>(entity =>
            {
                entity.HasKey(e => e.BintId)
                    .HasName("pk_SpecialDataReference_bint_ID");

                entity.ToTable("lkp_SpecialDataReference", "lkp");

                entity.Property(e => e.BintId).HasColumnName("bint_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpSpecialDataReferenceBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SpecialDataReference_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpSpecialDataReferenceBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SpecialDataReference_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpSpecialDataReferenceBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SpecialDataReference_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpSpecialDataReferenceBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SpecialDataReference_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpSystemConfiguration>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_SystemConfiguration_i_ID");

                entity.ToTable("lkp_SystemConfiguration", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpSystemConfigurationBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SystemConfiguration_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpSystemConfigurationBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SystemConfiguration_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpSystemConfigurationBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SystemConfiguration_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpSystemConfigurationBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SystemConfiguration_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpSystemContextType>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_SystemContextType_i_ID");

                entity.ToTable("lkp_SystemContextType", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpSystemContextTypeBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SystemContextType_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpSystemContextTypeBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SystemContextType_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpSystemContextTypeBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SystemContextType_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpSystemContextTypeBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_SystemContextType_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpTemplateTags>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_TemplateTags_i_ID");

                entity.ToTable("lkp_TemplateTags", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpTemplateTagsBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_TemplateTags_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpTemplateTagsBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_TemplateTags_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpTemplateTagsBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_TemplateTags_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpTemplateTagsBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_TemplateTags_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpWorkflowCategory>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_WorkflowCategory_i_ID");

                entity.ToTable("lkp_WorkflowCategory", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpWorkflowCategoryBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_WorkflowCategory_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpWorkflowCategoryBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_WorkflowCategory_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpWorkflowCategoryBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_WorkflowCategory_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpWorkflowCategoryBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_WorkflowCategory_ModifierSpoofOfCredentialID");
            });

            modelBuilder.Entity<LkpWorkflowStepType>(entity =>
            {
                entity.HasKey(e => e.IId)
                    .HasName("pk_WorkflowStepType_i_ID");

                entity.ToTable("lkp_WorkflowStepType", "lkp");

                entity.Property(e => e.IId).HasColumnName("i_ID");

                entity.Property(e => e.BSmokeTest).HasColumnName("b_SmokeTest");

                entity.Property(e => e.BintCreatorCredentialId).HasColumnName("bint_CreatorCredentialID");

                entity.Property(e => e.BintCreatorSpoofOfCredentialId).HasColumnName("bint_CreatorSpoofOfCredentialID");

                entity.Property(e => e.BintModifierCredentialId).HasColumnName("bint_ModifierCredentialID");

                entity.Property(e => e.BintModifierSpoofOfCredentialId).HasColumnName("bint_ModifierSpoofOfCredentialID");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dt_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DtModified)
                    .HasColumnName("dt_Modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Vchr256CreatedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_CreatedContext")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Vchr256ModifiedContext)
                    .IsRequired()
                    .HasColumnName("vchr_256_ModifiedContext")
                    .HasColumnType("varchar(256)");

                entity.HasOne(d => d.BintCreatorCredential)
                    .WithMany(p => p.LkpWorkflowStepTypeBintCreatorCredential)
                    .HasForeignKey(d => d.BintCreatorCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_WorkflowStepType_CreatorCredentialID");

                entity.HasOne(d => d.BintCreatorSpoofOfCredential)
                    .WithMany(p => p.LkpWorkflowStepTypeBintCreatorSpoofOfCredential)
                    .HasForeignKey(d => d.BintCreatorSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_WorkflowStepType_CreatorSpoofOfCredentialID");

                entity.HasOne(d => d.BintModifierCredential)
                    .WithMany(p => p.LkpWorkflowStepTypeBintModifierCredential)
                    .HasForeignKey(d => d.BintModifierCredentialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_WorkflowStepType_ModifierCredentialID");

                entity.HasOne(d => d.BintModifierSpoofOfCredential)
                    .WithMany(p => p.LkpWorkflowStepTypeBintModifierSpoofOfCredential)
                    .HasForeignKey(d => d.BintModifierSpoofOfCredentialId)
                    .HasConstraintName("fk_dbo_Credential_ID_to_lkp_WorkflowStepType_ModifierSpoofOfCredentialID");
            });
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DboAction> DboAction { get; set; }
        public virtual DbSet<DboActionParameter> DboActionParameter { get; set; }
        public virtual DbSet<DboCredential> DboCredential { get; set; }
        public virtual DbSet<DboCredentialAlternate> DboCredentialAlternate { get; set; }
        public virtual DbSet<DboCredentialConfigurationEntry> DboCredentialConfigurationEntry { get; set; }
        public virtual DbSet<DboCredentialHierarchy> DboCredentialHierarchy { get; set; }
        public virtual DbSet<DboCredentialOrganizationInfo> DboCredentialOrganizationInfo { get; set; }
        public virtual DbSet<DboCredentialRolePermission> DboCredentialRolePermission { get; set; }
        public virtual DbSet<DboDataSource> DboDataSource { get; set; }
        public virtual DbSet<DboDataSourceField> DboDataSourceField { get; set; }
        public virtual DbSet<DboDataSourceParameter> DboDataSourceParameter { get; set; }
        public virtual DbSet<DboDynamicDataMap> DboDynamicDataMap { get; set; }
        public virtual DbSet<DboEmailServer> DboEmailServer { get; set; }
        public virtual DbSet<DboForm> DboForm { get; set; }
        public virtual DbSet<DboFormAction> DboFormAction { get; set; }
        public virtual DbSet<DboFormFieldConfiguration> DboFormFieldConfiguration { get; set; }
        public virtual DbSet<DboFormFileAttachment> DboFormFileAttachment { get; set; }
        public virtual DbSet<DboModule> DboModule { get; set; }
        public virtual DbSet<DboModuleWorkflow> DboModuleWorkflow { get; set; }
        public virtual DbSet<DboPermissionLog> DboPermissionLog { get; set; }
        public virtual DbSet<DboPushNotification> DboPushNotification { get; set; }
        public virtual DbSet<DboPushNotificationDismissal> DboPushNotificationDismissal { get; set; }
        public virtual DbSet<DboPushNotificationTarget> DboPushNotificationTarget { get; set; }
        public virtual DbSet<DboRole> DboRole { get; set; }
        public virtual DbSet<DboRolePermission> DboRolePermission { get; set; }
        public virtual DbSet<DboSocialConversationDismissal> DboSocialConversationDismissal { get; set; }
        public virtual DbSet<DboSocialConversationEntry> DboSocialConversationEntry { get; set; }
        public virtual DbSet<DboSpoofLog> DboSpoofLog { get; set; }
        public virtual DbSet<DboWorkflow> DboWorkflow { get; set; }
        public virtual DbSet<DboWorkflowInstance> DboWorkflowInstance { get; set; }
        public virtual DbSet<DboWorkflowStep> DboWorkflowStep { get; set; }
        public virtual DbSet<DboWorkflowStepFieldConfiguration> DboWorkflowStepFieldConfiguration { get; set; }
        public virtual DbSet<LkpBackingMode> LkpBackingMode { get; set; }
        public virtual DbSet<LkpCredentialConfiguration> LkpCredentialConfiguration { get; set; }
        public virtual DbSet<LkpCredentialType> LkpCredentialType { get; set; }
        public virtual DbSet<LkpDataRetentionSchedule> LkpDataRetentionSchedule { get; set; }
        public virtual DbSet<LkpDynamicDataEndpoint> LkpDynamicDataEndpoint { get; set; }
        public virtual DbSet<LkpDynamicDataHierarchy> LkpDynamicDataHierarchy { get; set; }
        public virtual DbSet<LkpDynamicDataType> LkpDynamicDataType { get; set; }
        public virtual DbSet<LkpEmailAccountType> LkpEmailAccountType { get; set; }
        public virtual DbSet<LkpEmailTemplate> LkpEmailTemplate { get; set; }
        public virtual DbSet<LkpErrorPanelFilter> LkpErrorPanelFilter { get; set; }
        public virtual DbSet<LkpFormCategory> LkpFormCategory { get; set; }
        public virtual DbSet<LkpInterfaceAvailability> LkpInterfaceAvailability { get; set; }
        public virtual DbSet<LkpLocalization> LkpLocalization { get; set; }
        public virtual DbSet<LkpLocalizationSet> LkpLocalizationSet { get; set; }
        public virtual DbSet<LkpNotificationEvent> LkpNotificationEvent { get; set; }
        public virtual DbSet<LkpOpenLinkMethod> LkpOpenLinkMethod { get; set; }
        public virtual DbSet<LkpPanelPosition> LkpPanelPosition { get; set; }
        public virtual DbSet<LkpParameterBasis> LkpParameterBasis { get; set; }
        public virtual DbSet<LkpPeriodicityComparison> LkpPeriodicityComparison { get; set; }
        public virtual DbSet<LkpPeriodicityUnit> LkpPeriodicityUnit { get; set; }
        public virtual DbSet<LkpPermission> LkpPermission { get; set; }
        public virtual DbSet<LkpPermissionType> LkpPermissionType { get; set; }
        public virtual DbSet<LkpReExecuteOnNext> LkpReExecuteOnNext { get; set; }
        public virtual DbSet<LkpSocialConversationScope> LkpSocialConversationScope { get; set; }
        public virtual DbSet<LkpSpecialDataReference> LkpSpecialDataReference { get; set; }
        public virtual DbSet<LkpSystemConfiguration> LkpSystemConfiguration { get; set; }
        public virtual DbSet<LkpSystemContextType> LkpSystemContextType { get; set; }
        public virtual DbSet<LkpTemplateTags> LkpTemplateTags { get; set; }
        public virtual DbSet<LkpWorkflowCategory> LkpWorkflowCategory { get; set; }
        public virtual DbSet<LkpWorkflowStepType> LkpWorkflowStepType { get; set; }

        // Unable to generate entity type for table 'tst.tst_Results_GetNameParts'. Please see the warning messages.
        // Unable to generate entity type for table 'tst.tst_Results_GetUserLocalizedValues'. Please see the warning messages.
        // Unable to generate entity type for table 'tst.tst_Data_GetNameParts'. Please see the warning messages.
        // Unable to generate entity type for table 'tst.tst_Data_GetFieldInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'tst.tst_Data_GetUserLocalizedValues'. Please see the warning messages.
        // Unable to generate entity type for table 'tst.tst_Results_GetFieldInfo'. Please see the warning messages.
    }
}