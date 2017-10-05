using System;
using System.Collections.Generic;

namespace System10.Models
{
    public partial class DboCredential
    {
        public DboCredential()
        {
            DboActionBintCreatorCredential = new HashSet<DboAction>();
            DboActionBintCreatorSpoofOfCredential = new HashSet<DboAction>();
            DboActionBintModifierCredential = new HashSet<DboAction>();
            DboActionBintModifierSpoofOfCredential = new HashSet<DboAction>();
            DboActionParameterBintCreatorCredential = new HashSet<DboActionParameter>();
            DboActionParameterBintCreatorSpoofOfCredential = new HashSet<DboActionParameter>();
            DboActionParameterBintModifierCredential = new HashSet<DboActionParameter>();
            DboActionParameterBintModifierSpoofOfCredential = new HashSet<DboActionParameter>();
            DboCredentialAlternateBintCreatorCredential = new HashSet<DboCredentialAlternate>();
            DboCredentialAlternateBintCreatorSpoofOfCredential = new HashSet<DboCredentialAlternate>();
            DboCredentialAlternateBintModifierCredential = new HashSet<DboCredentialAlternate>();
            DboCredentialAlternateBintModifierSpoofOfCredential = new HashSet<DboCredentialAlternate>();
            DboCredentialAlternateBintPrimaryCredential = new HashSet<DboCredentialAlternate>();
            DboCredentialConfigurationEntryBintCreatorCredential = new HashSet<DboCredentialConfigurationEntry>();
            DboCredentialConfigurationEntryBintCreatorSpoofOfCredential = new HashSet<DboCredentialConfigurationEntry>();
            DboCredentialConfigurationEntryBintModifierCredential = new HashSet<DboCredentialConfigurationEntry>();
            DboCredentialConfigurationEntryBintModifierSpoofOfCredential = new HashSet<DboCredentialConfigurationEntry>();
            DboCredentialHierarchyBintChildCredential = new HashSet<DboCredentialHierarchy>();
            DboCredentialHierarchyBintCreatorCredential = new HashSet<DboCredentialHierarchy>();
            DboCredentialHierarchyBintCreatorSpoofOfCredential = new HashSet<DboCredentialHierarchy>();
            DboCredentialHierarchyBintModifierCredential = new HashSet<DboCredentialHierarchy>();
            DboCredentialHierarchyBintModifierSpoofOfCredential = new HashSet<DboCredentialHierarchy>();
            DboCredentialHierarchyBintParentCredential = new HashSet<DboCredentialHierarchy>();
            DboCredentialOrganizationInfoBintCreatorCredential = new HashSet<DboCredentialOrganizationInfo>();
            DboCredentialOrganizationInfoBintCreatorSpoofOfCredential = new HashSet<DboCredentialOrganizationInfo>();
            DboCredentialOrganizationInfoBintCredential = new HashSet<DboCredentialOrganizationInfo>();
            DboCredentialOrganizationInfoBintModifierCredential = new HashSet<DboCredentialOrganizationInfo>();
            DboCredentialOrganizationInfoBintModifierSpoofOfCredential = new HashSet<DboCredentialOrganizationInfo>();
            DboCredentialRolePermissionBintCreatorCredential = new HashSet<DboCredentialRolePermission>();
            DboCredentialRolePermissionBintCreatorSpoofOfCredential = new HashSet<DboCredentialRolePermission>();
            DboCredentialRolePermissionBintCredential = new HashSet<DboCredentialRolePermission>();
            DboCredentialRolePermissionBintModifierCredential = new HashSet<DboCredentialRolePermission>();
            DboCredentialRolePermissionBintModifierSpoofOfCredential = new HashSet<DboCredentialRolePermission>();
            DboDataSourceBintCreatorCredential = new HashSet<DboDataSource>();
            DboDataSourceBintCreatorSpoofOfCredential = new HashSet<DboDataSource>();
            DboDataSourceBintModifierCredential = new HashSet<DboDataSource>();
            DboDataSourceBintModifierSpoofOfCredential = new HashSet<DboDataSource>();
            DboDataSourceFieldBintCreatorCredential = new HashSet<DboDataSourceField>();
            DboDataSourceFieldBintCreatorSpoofOfCredential = new HashSet<DboDataSourceField>();
            DboDataSourceFieldBintModifierCredential = new HashSet<DboDataSourceField>();
            DboDataSourceFieldBintModifierSpoofOfCredential = new HashSet<DboDataSourceField>();
            DboDataSourceParameterBintCreatorCredential = new HashSet<DboDataSourceParameter>();
            DboDataSourceParameterBintCreatorSpoofOfCredential = new HashSet<DboDataSourceParameter>();
            DboDataSourceParameterBintModifierCredential = new HashSet<DboDataSourceParameter>();
            DboDataSourceParameterBintModifierSpoofOfCredential = new HashSet<DboDataSourceParameter>();
            DboDynamicDataMapBintCreatorCredential = new HashSet<DboDynamicDataMap>();
            DboDynamicDataMapBintCreatorSpoofOfCredential = new HashSet<DboDynamicDataMap>();
            DboDynamicDataMapBintModifierCredential = new HashSet<DboDynamicDataMap>();
            DboDynamicDataMapBintModifierSpoofOfCredential = new HashSet<DboDynamicDataMap>();
            DboEmailServerBintCreatorCredential = new HashSet<DboEmailServer>();
            DboEmailServerBintCreatorSpoofOfCredential = new HashSet<DboEmailServer>();
            DboEmailServerBintModifierCredential = new HashSet<DboEmailServer>();
            DboEmailServerBintModifierSpoofOfCredential = new HashSet<DboEmailServer>();
            DboExecutionLogBintCredential = new HashSet<DboExecutionLog>();
            DboExecutionLogBintSpoofOfCredential = new HashSet<DboExecutionLog>();
            DboFormBintCreatorCredential = new HashSet<DboForm>();
            DboFormBintCreatorSpoofOfCredential = new HashSet<DboForm>();
            DboFormBintModifierCredential = new HashSet<DboForm>();
            DboFormBintModifierSpoofOfCredential = new HashSet<DboForm>();
            DboFormActionBintCreatorCredential = new HashSet<DboFormAction>();
            DboFormActionBintCreatorSpoofOfCredential = new HashSet<DboFormAction>();
            DboFormActionBintModifierCredential = new HashSet<DboFormAction>();
            DboFormActionBintModifierSpoofOfCredential = new HashSet<DboFormAction>();
            DboFormFieldConfigurationBintCreatorCredential = new HashSet<DboFormFieldConfiguration>();
            DboFormFieldConfigurationBintCreatorSpoofOfCredential = new HashSet<DboFormFieldConfiguration>();
            DboFormFieldConfigurationBintCredential = new HashSet<DboFormFieldConfiguration>();
            DboFormFieldConfigurationBintModifierCredential = new HashSet<DboFormFieldConfiguration>();
            DboFormFieldConfigurationBintModifierSpoofOfCredential = new HashSet<DboFormFieldConfiguration>();
            DboFormFileAttachmentBintCreatorCredential = new HashSet<DboFormFileAttachment>();
            DboFormFileAttachmentBintCreatorSpoofOfCredential = new HashSet<DboFormFileAttachment>();
            DboFormFileAttachmentBintModifierCredential = new HashSet<DboFormFileAttachment>();
            DboFormFileAttachmentBintModifierSpoofOfCredential = new HashSet<DboFormFileAttachment>();
            DboModuleBintCreatorCredential = new HashSet<DboModule>();
            DboModuleBintCreatorSpoofOfCredential = new HashSet<DboModule>();
            DboModuleBintModifierCredential = new HashSet<DboModule>();
            DboModuleBintModifierSpoofOfCredential = new HashSet<DboModule>();
            DboModuleWorkflowBintCreatorCredential = new HashSet<DboModuleWorkflow>();
            DboModuleWorkflowBintCreatorSpoofOfCredential = new HashSet<DboModuleWorkflow>();
            DboModuleWorkflowBintModifierCredential = new HashSet<DboModuleWorkflow>();
            DboModuleWorkflowBintModifierSpoofOfCredential = new HashSet<DboModuleWorkflow>();
            DboPushNotificationBintCreatorCredential = new HashSet<DboPushNotification>();
            DboPushNotificationBintCreatorSpoofOfCredential = new HashSet<DboPushNotification>();
            DboPushNotificationBintModifierCredential = new HashSet<DboPushNotification>();
            DboPushNotificationBintModifierSpoofOfCredential = new HashSet<DboPushNotification>();
            DboPushNotificationDismissalBintCreatorCredential = new HashSet<DboPushNotificationDismissal>();
            DboPushNotificationDismissalBintCreatorSpoofOfCredential = new HashSet<DboPushNotificationDismissal>();
            DboPushNotificationDismissalBintModifierCredential = new HashSet<DboPushNotificationDismissal>();
            DboPushNotificationDismissalBintModifierSpoofOfCredential = new HashSet<DboPushNotificationDismissal>();
            DboPushNotificationTargetBintCreatorCredential = new HashSet<DboPushNotificationTarget>();
            DboPushNotificationTargetBintCreatorSpoofOfCredential = new HashSet<DboPushNotificationTarget>();
            DboPushNotificationTargetBintModifierCredential = new HashSet<DboPushNotificationTarget>();
            DboPushNotificationTargetBintModifierSpoofOfCredential = new HashSet<DboPushNotificationTarget>();
            DboPushNotificationTargetBintTargetCredential = new HashSet<DboPushNotificationTarget>();
            DboRoleBintCreatorCredential = new HashSet<DboRole>();
            DboRoleBintCreatorSpoofOfCredential = new HashSet<DboRole>();
            DboRoleBintModifierCredential = new HashSet<DboRole>();
            DboRoleBintModifierSpoofOfCredential = new HashSet<DboRole>();
            DboRolePermissionBintCreatorCredential = new HashSet<DboRolePermission>();
            DboRolePermissionBintCreatorSpoofOfCredential = new HashSet<DboRolePermission>();
            DboRolePermissionBintModifierCredential = new HashSet<DboRolePermission>();
            DboRolePermissionBintModifierSpoofOfCredential = new HashSet<DboRolePermission>();
            DboSocialConversationDismissalBintCreatorCredential = new HashSet<DboSocialConversationDismissal>();
            DboSocialConversationDismissalBintCreatorSpoofOfCredential = new HashSet<DboSocialConversationDismissal>();
            DboSocialConversationDismissalBintModifierCredential = new HashSet<DboSocialConversationDismissal>();
            DboSocialConversationDismissalBintModifierSpoofOfCredential = new HashSet<DboSocialConversationDismissal>();
            DboSocialConversationEntryBintCreatorCredential = new HashSet<DboSocialConversationEntry>();
            DboSocialConversationEntryBintCreatorSpoofOfCredential = new HashSet<DboSocialConversationEntry>();
            DboSocialConversationEntryBintCredential = new HashSet<DboSocialConversationEntry>();
            DboSocialConversationEntryBintModifierCredential = new HashSet<DboSocialConversationEntry>();
            DboSocialConversationEntryBintModifierSpoofOfCredential = new HashSet<DboSocialConversationEntry>();
            DboSpoofLogBintActualUserCredential = new HashSet<DboSpoofLog>();
            DboSpoofLogBintCreatorCredential = new HashSet<DboSpoofLog>();
            DboSpoofLogBintCreatorSpoofOfCredential = new HashSet<DboSpoofLog>();
            DboSpoofLogBintModifierCredential = new HashSet<DboSpoofLog>();
            DboSpoofLogBintModifierSpoofOfCredential = new HashSet<DboSpoofLog>();
            DboSpoofLogBintSpoofUserCredential = new HashSet<DboSpoofLog>();
            DboWorkflowBintCreatorCredential = new HashSet<DboWorkflow>();
            DboWorkflowBintCreatorSpoofOfCredential = new HashSet<DboWorkflow>();
            DboWorkflowBintModifierCredential = new HashSet<DboWorkflow>();
            DboWorkflowBintModifierSpoofOfCredential = new HashSet<DboWorkflow>();
            DboWorkflowInstanceBintAssignedToCredential = new HashSet<DboWorkflowInstance>();
            DboWorkflowInstanceBintCreatorCredential = new HashSet<DboWorkflowInstance>();
            DboWorkflowInstanceBintCreatorSpoofOfCredential = new HashSet<DboWorkflowInstance>();
            DboWorkflowInstanceBintModifierCredential = new HashSet<DboWorkflowInstance>();
            DboWorkflowInstanceBintModifierSpoofOfCredential = new HashSet<DboWorkflowInstance>();
            DboWorkflowStepBintCreatorCredential = new HashSet<DboWorkflowStep>();
            DboWorkflowStepBintCreatorSpoofOfCredential = new HashSet<DboWorkflowStep>();
            DboWorkflowStepBintModifierCredential = new HashSet<DboWorkflowStep>();
            DboWorkflowStepBintModifierSpoofOfCredential = new HashSet<DboWorkflowStep>();
            DboWorkflowStepActionBintCreatorCredential = new HashSet<DboWorkflowStepAction>();
            DboWorkflowStepActionBintCreatorSpoofOfCredential = new HashSet<DboWorkflowStepAction>();
            DboWorkflowStepActionBintModifierCredential = new HashSet<DboWorkflowStepAction>();
            DboWorkflowStepActionBintModifierSpoofOfCredential = new HashSet<DboWorkflowStepAction>();
            DboWorkflowStepFieldConfigurationBintCreatorCredential = new HashSet<DboWorkflowStepFieldConfiguration>();
            DboWorkflowStepFieldConfigurationBintCreatorSpoofOfCredential = new HashSet<DboWorkflowStepFieldConfiguration>();
            DboWorkflowStepFieldConfigurationBintCredential = new HashSet<DboWorkflowStepFieldConfiguration>();
            DboWorkflowStepFieldConfigurationBintModifierCredential = new HashSet<DboWorkflowStepFieldConfiguration>();
            DboWorkflowStepFieldConfigurationBintModifierSpoofOfCredential = new HashSet<DboWorkflowStepFieldConfiguration>();
            LkpBackingModeBintCreatorCredential = new HashSet<LkpBackingMode>();
            LkpBackingModeBintCreatorSpoofOfCredential = new HashSet<LkpBackingMode>();
            LkpBackingModeBintModifierCredential = new HashSet<LkpBackingMode>();
            LkpBackingModeBintModifierSpoofOfCredential = new HashSet<LkpBackingMode>();
            LkpCredentialConfigurationBintCreatorCredential = new HashSet<LkpCredentialConfiguration>();
            LkpCredentialConfigurationBintCreatorSpoofOfCredential = new HashSet<LkpCredentialConfiguration>();
            LkpCredentialConfigurationBintModifierCredential = new HashSet<LkpCredentialConfiguration>();
            LkpCredentialConfigurationBintModifierSpoofOfCredential = new HashSet<LkpCredentialConfiguration>();
            LkpCredentialTypeBintCreatorCredential = new HashSet<LkpCredentialType>();
            LkpCredentialTypeBintCreatorSpoofOfCredential = new HashSet<LkpCredentialType>();
            LkpCredentialTypeBintModifierCredential = new HashSet<LkpCredentialType>();
            LkpCredentialTypeBintModifierSpoofOfCredential = new HashSet<LkpCredentialType>();
            LkpDataSourceTypeBintCreatorCredential = new HashSet<LkpDataSourceType>();
            LkpDataSourceTypeBintCreatorSpoofOfCredential = new HashSet<LkpDataSourceType>();
            LkpDataSourceTypeBintModifierCredential = new HashSet<LkpDataSourceType>();
            LkpDataSourceTypeBintModifierSpoofOfCredential = new HashSet<LkpDataSourceType>();
            LkpDynamicDataEndpointBintCreatorCredential = new HashSet<LkpDynamicDataEndpoint>();
            LkpDynamicDataEndpointBintCreatorSpoofOfCredential = new HashSet<LkpDynamicDataEndpoint>();
            LkpDynamicDataEndpointBintModifierCredential = new HashSet<LkpDynamicDataEndpoint>();
            LkpDynamicDataEndpointBintModifierSpoofOfCredential = new HashSet<LkpDynamicDataEndpoint>();
            LkpDynamicDataHierarchyBintCreatorCredential = new HashSet<LkpDynamicDataHierarchy>();
            LkpDynamicDataHierarchyBintCreatorSpoofOfCredential = new HashSet<LkpDynamicDataHierarchy>();
            LkpDynamicDataHierarchyBintModifierCredential = new HashSet<LkpDynamicDataHierarchy>();
            LkpDynamicDataHierarchyBintModifierSpoofOfCredential = new HashSet<LkpDynamicDataHierarchy>();
            LkpDynamicDataTypeBintCreatorCredential = new HashSet<LkpDynamicDataType>();
            LkpDynamicDataTypeBintCreatorSpoofOfCredential = new HashSet<LkpDynamicDataType>();
            LkpDynamicDataTypeBintModifierCredential = new HashSet<LkpDynamicDataType>();
            LkpDynamicDataTypeBintModifierSpoofOfCredential = new HashSet<LkpDynamicDataType>();
            LkpEmailAccountTypeBintCreatorCredential = new HashSet<LkpEmailAccountType>();
            LkpEmailAccountTypeBintCreatorSpoofOfCredential = new HashSet<LkpEmailAccountType>();
            LkpEmailAccountTypeBintModifierCredential = new HashSet<LkpEmailAccountType>();
            LkpEmailAccountTypeBintModifierSpoofOfCredential = new HashSet<LkpEmailAccountType>();
            LkpEmailTemplateBintCreatorCredential = new HashSet<LkpEmailTemplate>();
            LkpEmailTemplateBintCreatorSpoofOfCredential = new HashSet<LkpEmailTemplate>();
            LkpEmailTemplateBintModifierCredential = new HashSet<LkpEmailTemplate>();
            LkpEmailTemplateBintModifierSpoofOfCredential = new HashSet<LkpEmailTemplate>();
            LkpErrorPanelFilterBintCreatorCredential = new HashSet<LkpErrorPanelFilter>();
            LkpErrorPanelFilterBintCreatorSpoofOfCredential = new HashSet<LkpErrorPanelFilter>();
            LkpErrorPanelFilterBintModifierCredential = new HashSet<LkpErrorPanelFilter>();
            LkpErrorPanelFilterBintModifierSpoofOfCredential = new HashSet<LkpErrorPanelFilter>();
            LkpFormCategoryBintCreatorCredential = new HashSet<LkpFormCategory>();
            LkpFormCategoryBintCreatorSpoofOfCredential = new HashSet<LkpFormCategory>();
            LkpFormCategoryBintModifierCredential = new HashSet<LkpFormCategory>();
            LkpFormCategoryBintModifierSpoofOfCredential = new HashSet<LkpFormCategory>();
            LkpInterfaceAvailabilityBintCreatorCredential = new HashSet<LkpInterfaceAvailability>();
            LkpInterfaceAvailabilityBintCreatorSpoofOfCredential = new HashSet<LkpInterfaceAvailability>();
            LkpInterfaceAvailabilityBintModifierCredential = new HashSet<LkpInterfaceAvailability>();
            LkpInterfaceAvailabilityBintModifierSpoofOfCredential = new HashSet<LkpInterfaceAvailability>();
            LkpLocalizationBintCreatorCredential = new HashSet<LkpLocalization>();
            LkpLocalizationBintCreatorSpoofOfCredential = new HashSet<LkpLocalization>();
            LkpLocalizationBintModifierCredential = new HashSet<LkpLocalization>();
            LkpLocalizationBintModifierSpoofOfCredential = new HashSet<LkpLocalization>();
            LkpLocalizationSetBintCreatorCredential = new HashSet<LkpLocalizationSet>();
            LkpLocalizationSetBintCreatorSpoofOfCredential = new HashSet<LkpLocalizationSet>();
            LkpLocalizationSetBintModifierCredential = new HashSet<LkpLocalizationSet>();
            LkpLocalizationSetBintModifierSpoofOfCredential = new HashSet<LkpLocalizationSet>();
            LkpNotificationEventBintCreatorCredential = new HashSet<LkpNotificationEvent>();
            LkpNotificationEventBintCreatorSpoofOfCredential = new HashSet<LkpNotificationEvent>();
            LkpNotificationEventBintModifierCredential = new HashSet<LkpNotificationEvent>();
            LkpNotificationEventBintModifierSpoofOfCredential = new HashSet<LkpNotificationEvent>();
            LkpOpenLinkMethodBintCreatorCredential = new HashSet<LkpOpenLinkMethod>();
            LkpOpenLinkMethodBintCreatorSpoofOfCredential = new HashSet<LkpOpenLinkMethod>();
            LkpOpenLinkMethodBintModifierCredential = new HashSet<LkpOpenLinkMethod>();
            LkpOpenLinkMethodBintModifierSpoofOfCredential = new HashSet<LkpOpenLinkMethod>();
            LkpPanelPositionBintCreatorCredential = new HashSet<LkpPanelPosition>();
            LkpPanelPositionBintCreatorSpoofOfCredential = new HashSet<LkpPanelPosition>();
            LkpPanelPositionBintModifierCredential = new HashSet<LkpPanelPosition>();
            LkpPanelPositionBintModifierSpoofOfCredential = new HashSet<LkpPanelPosition>();
            LkpParameterBasisBintCreatorCredential = new HashSet<LkpParameterBasis>();
            LkpParameterBasisBintCreatorSpoofOfCredential = new HashSet<LkpParameterBasis>();
            LkpParameterBasisBintModifierCredential = new HashSet<LkpParameterBasis>();
            LkpParameterBasisBintModifierSpoofOfCredential = new HashSet<LkpParameterBasis>();
            LkpPeriodicityComparisonBintCreatorCredential = new HashSet<LkpPeriodicityComparison>();
            LkpPeriodicityComparisonBintCreatorSpoofOfCredential = new HashSet<LkpPeriodicityComparison>();
            LkpPeriodicityComparisonBintModifierCredential = new HashSet<LkpPeriodicityComparison>();
            LkpPeriodicityComparisonBintModifierSpoofOfCredential = new HashSet<LkpPeriodicityComparison>();
            LkpPeriodicityUnitBintCreatorCredential = new HashSet<LkpPeriodicityUnit>();
            LkpPeriodicityUnitBintCreatorSpoofOfCredential = new HashSet<LkpPeriodicityUnit>();
            LkpPeriodicityUnitBintModifierCredential = new HashSet<LkpPeriodicityUnit>();
            LkpPeriodicityUnitBintModifierSpoofOfCredential = new HashSet<LkpPeriodicityUnit>();
            LkpPermissionBintCreatorCredential = new HashSet<LkpPermission>();
            LkpPermissionBintCreatorSpoofOfCredential = new HashSet<LkpPermission>();
            LkpPermissionBintModifierCredential = new HashSet<LkpPermission>();
            LkpPermissionBintModifierSpoofOfCredential = new HashSet<LkpPermission>();
            LkpPermissionTypeBintCreatorCredential = new HashSet<LkpPermissionType>();
            LkpPermissionTypeBintCreatorSpoofOfCredential = new HashSet<LkpPermissionType>();
            LkpPermissionTypeBintModifierCredential = new HashSet<LkpPermissionType>();
            LkpPermissionTypeBintModifierSpoofOfCredential = new HashSet<LkpPermissionType>();
            LkpReExecuteOnNextBintCreatorCredential = new HashSet<LkpReExecuteOnNext>();
            LkpReExecuteOnNextBintCreatorSpoofOfCredential = new HashSet<LkpReExecuteOnNext>();
            LkpReExecuteOnNextBintModifierCredential = new HashSet<LkpReExecuteOnNext>();
            LkpReExecuteOnNextBintModifierSpoofOfCredential = new HashSet<LkpReExecuteOnNext>();
            LkpScheduleBasisBintCreatorCredential = new HashSet<LkpScheduleBasis>();
            LkpScheduleBasisBintCreatorSpoofOfCredential = new HashSet<LkpScheduleBasis>();
            LkpScheduleBasisBintModifierCredential = new HashSet<LkpScheduleBasis>();
            LkpScheduleBasisBintModifierSpoofOfCredential = new HashSet<LkpScheduleBasis>();
            LkpSocialConversationScopeBintCreatorCredential = new HashSet<LkpSocialConversationScope>();
            LkpSocialConversationScopeBintCreatorSpoofOfCredential = new HashSet<LkpSocialConversationScope>();
            LkpSocialConversationScopeBintModifierCredential = new HashSet<LkpSocialConversationScope>();
            LkpSocialConversationScopeBintModifierSpoofOfCredential = new HashSet<LkpSocialConversationScope>();
            LkpSpecialDataReferenceBintCreatorCredential = new HashSet<LkpSpecialDataReference>();
            LkpSpecialDataReferenceBintCreatorSpoofOfCredential = new HashSet<LkpSpecialDataReference>();
            LkpSpecialDataReferenceBintModifierCredential = new HashSet<LkpSpecialDataReference>();
            LkpSpecialDataReferenceBintModifierSpoofOfCredential = new HashSet<LkpSpecialDataReference>();
            LkpSystemConfigurationBintCreatorCredential = new HashSet<LkpSystemConfiguration>();
            LkpSystemConfigurationBintCreatorSpoofOfCredential = new HashSet<LkpSystemConfiguration>();
            LkpSystemConfigurationBintModifierCredential = new HashSet<LkpSystemConfiguration>();
            LkpSystemConfigurationBintModifierSpoofOfCredential = new HashSet<LkpSystemConfiguration>();
            LkpSystemContextTypeBintCreatorCredential = new HashSet<LkpSystemContextType>();
            LkpSystemContextTypeBintCreatorSpoofOfCredential = new HashSet<LkpSystemContextType>();
            LkpSystemContextTypeBintModifierCredential = new HashSet<LkpSystemContextType>();
            LkpSystemContextTypeBintModifierSpoofOfCredential = new HashSet<LkpSystemContextType>();
            LkpTemplateTagsBintCreatorCredential = new HashSet<LkpTemplateTags>();
            LkpTemplateTagsBintCreatorSpoofOfCredential = new HashSet<LkpTemplateTags>();
            LkpTemplateTagsBintModifierCredential = new HashSet<LkpTemplateTags>();
            LkpTemplateTagsBintModifierSpoofOfCredential = new HashSet<LkpTemplateTags>();
            LkpWorkflowCategoryBintCreatorCredential = new HashSet<LkpWorkflowCategory>();
            LkpWorkflowCategoryBintCreatorSpoofOfCredential = new HashSet<LkpWorkflowCategory>();
            LkpWorkflowCategoryBintModifierCredential = new HashSet<LkpWorkflowCategory>();
            LkpWorkflowCategoryBintModifierSpoofOfCredential = new HashSet<LkpWorkflowCategory>();
            LkpWorkflowStepTypeBintCreatorCredential = new HashSet<LkpWorkflowStepType>();
            LkpWorkflowStepTypeBintCreatorSpoofOfCredential = new HashSet<LkpWorkflowStepType>();
            LkpWorkflowStepTypeBintModifierCredential = new HashSet<LkpWorkflowStepType>();
            LkpWorkflowStepTypeBintModifierSpoofOfCredential = new HashSet<LkpWorkflowStepType>();
        }

        public long BintId { get; set; }
        public string Nvch128Caption { get; set; }
        public string Vchr32Name { get; set; }
        public byte[] Bin64PasswordHash { get; set; }
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
        public bool BIsGroup { get; set; }

        public virtual ICollection<DboAction> DboActionBintCreatorCredential { get; set; }
        public virtual ICollection<DboAction> DboActionBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboAction> DboActionBintModifierCredential { get; set; }
        public virtual ICollection<DboAction> DboActionBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboActionParameter> DboActionParameterBintCreatorCredential { get; set; }
        public virtual ICollection<DboActionParameter> DboActionParameterBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboActionParameter> DboActionParameterBintModifierCredential { get; set; }
        public virtual ICollection<DboActionParameter> DboActionParameterBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredentialAlternate> DboCredentialAlternateBintCreatorCredential { get; set; }
        public virtual ICollection<DboCredentialAlternate> DboCredentialAlternateBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredentialAlternate> DboCredentialAlternateBintModifierCredential { get; set; }
        public virtual ICollection<DboCredentialAlternate> DboCredentialAlternateBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredentialAlternate> DboCredentialAlternateBintPrimaryCredential { get; set; }
        public virtual ICollection<DboCredentialConfigurationEntry> DboCredentialConfigurationEntryBintCreatorCredential { get; set; }
        public virtual ICollection<DboCredentialConfigurationEntry> DboCredentialConfigurationEntryBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredentialConfigurationEntry> DboCredentialConfigurationEntryBintModifierCredential { get; set; }
        public virtual ICollection<DboCredentialConfigurationEntry> DboCredentialConfigurationEntryBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredentialHierarchy> DboCredentialHierarchyBintChildCredential { get; set; }
        public virtual ICollection<DboCredentialHierarchy> DboCredentialHierarchyBintCreatorCredential { get; set; }
        public virtual ICollection<DboCredentialHierarchy> DboCredentialHierarchyBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredentialHierarchy> DboCredentialHierarchyBintModifierCredential { get; set; }
        public virtual ICollection<DboCredentialHierarchy> DboCredentialHierarchyBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredentialHierarchy> DboCredentialHierarchyBintParentCredential { get; set; }
        public virtual ICollection<DboCredentialOrganizationInfo> DboCredentialOrganizationInfoBintCreatorCredential { get; set; }
        public virtual ICollection<DboCredentialOrganizationInfo> DboCredentialOrganizationInfoBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredentialOrganizationInfo> DboCredentialOrganizationInfoBintCredential { get; set; }
        public virtual ICollection<DboCredentialOrganizationInfo> DboCredentialOrganizationInfoBintModifierCredential { get; set; }
        public virtual ICollection<DboCredentialOrganizationInfo> DboCredentialOrganizationInfoBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredentialRolePermission> DboCredentialRolePermissionBintCreatorCredential { get; set; }
        public virtual ICollection<DboCredentialRolePermission> DboCredentialRolePermissionBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredentialRolePermission> DboCredentialRolePermissionBintCredential { get; set; }
        public virtual ICollection<DboCredentialRolePermission> DboCredentialRolePermissionBintModifierCredential { get; set; }
        public virtual ICollection<DboCredentialRolePermission> DboCredentialRolePermissionBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboDataSource> DboDataSourceBintCreatorCredential { get; set; }
        public virtual ICollection<DboDataSource> DboDataSourceBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboDataSource> DboDataSourceBintModifierCredential { get; set; }
        public virtual ICollection<DboDataSource> DboDataSourceBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboDataSourceField> DboDataSourceFieldBintCreatorCredential { get; set; }
        public virtual ICollection<DboDataSourceField> DboDataSourceFieldBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboDataSourceField> DboDataSourceFieldBintModifierCredential { get; set; }
        public virtual ICollection<DboDataSourceField> DboDataSourceFieldBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboDataSourceParameter> DboDataSourceParameterBintCreatorCredential { get; set; }
        public virtual ICollection<DboDataSourceParameter> DboDataSourceParameterBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboDataSourceParameter> DboDataSourceParameterBintModifierCredential { get; set; }
        public virtual ICollection<DboDataSourceParameter> DboDataSourceParameterBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboDynamicDataMap> DboDynamicDataMapBintCreatorCredential { get; set; }
        public virtual ICollection<DboDynamicDataMap> DboDynamicDataMapBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboDynamicDataMap> DboDynamicDataMapBintModifierCredential { get; set; }
        public virtual ICollection<DboDynamicDataMap> DboDynamicDataMapBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboEmailServer> DboEmailServerBintCreatorCredential { get; set; }
        public virtual ICollection<DboEmailServer> DboEmailServerBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboEmailServer> DboEmailServerBintModifierCredential { get; set; }
        public virtual ICollection<DboEmailServer> DboEmailServerBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboExecutionLog> DboExecutionLogBintCredential { get; set; }
        public virtual ICollection<DboExecutionLog> DboExecutionLogBintSpoofOfCredential { get; set; }
        public virtual ICollection<DboForm> DboFormBintCreatorCredential { get; set; }
        public virtual ICollection<DboForm> DboFormBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboForm> DboFormBintModifierCredential { get; set; }
        public virtual ICollection<DboForm> DboFormBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboFormAction> DboFormActionBintCreatorCredential { get; set; }
        public virtual ICollection<DboFormAction> DboFormActionBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboFormAction> DboFormActionBintModifierCredential { get; set; }
        public virtual ICollection<DboFormAction> DboFormActionBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboFormFieldConfiguration> DboFormFieldConfigurationBintCreatorCredential { get; set; }
        public virtual ICollection<DboFormFieldConfiguration> DboFormFieldConfigurationBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboFormFieldConfiguration> DboFormFieldConfigurationBintCredential { get; set; }
        public virtual ICollection<DboFormFieldConfiguration> DboFormFieldConfigurationBintModifierCredential { get; set; }
        public virtual ICollection<DboFormFieldConfiguration> DboFormFieldConfigurationBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboFormFileAttachment> DboFormFileAttachmentBintCreatorCredential { get; set; }
        public virtual ICollection<DboFormFileAttachment> DboFormFileAttachmentBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboFormFileAttachment> DboFormFileAttachmentBintModifierCredential { get; set; }
        public virtual ICollection<DboFormFileAttachment> DboFormFileAttachmentBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboModule> DboModuleBintCreatorCredential { get; set; }
        public virtual ICollection<DboModule> DboModuleBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboModule> DboModuleBintModifierCredential { get; set; }
        public virtual ICollection<DboModule> DboModuleBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboModuleWorkflow> DboModuleWorkflowBintCreatorCredential { get; set; }
        public virtual ICollection<DboModuleWorkflow> DboModuleWorkflowBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboModuleWorkflow> DboModuleWorkflowBintModifierCredential { get; set; }
        public virtual ICollection<DboModuleWorkflow> DboModuleWorkflowBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboPushNotification> DboPushNotificationBintCreatorCredential { get; set; }
        public virtual ICollection<DboPushNotification> DboPushNotificationBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboPushNotification> DboPushNotificationBintModifierCredential { get; set; }
        public virtual ICollection<DboPushNotification> DboPushNotificationBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboPushNotificationDismissal> DboPushNotificationDismissalBintCreatorCredential { get; set; }
        public virtual ICollection<DboPushNotificationDismissal> DboPushNotificationDismissalBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboPushNotificationDismissal> DboPushNotificationDismissalBintModifierCredential { get; set; }
        public virtual ICollection<DboPushNotificationDismissal> DboPushNotificationDismissalBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboPushNotificationTarget> DboPushNotificationTargetBintCreatorCredential { get; set; }
        public virtual ICollection<DboPushNotificationTarget> DboPushNotificationTargetBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboPushNotificationTarget> DboPushNotificationTargetBintModifierCredential { get; set; }
        public virtual ICollection<DboPushNotificationTarget> DboPushNotificationTargetBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboPushNotificationTarget> DboPushNotificationTargetBintTargetCredential { get; set; }
        public virtual ICollection<DboRole> DboRoleBintCreatorCredential { get; set; }
        public virtual ICollection<DboRole> DboRoleBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboRole> DboRoleBintModifierCredential { get; set; }
        public virtual ICollection<DboRole> DboRoleBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboRolePermission> DboRolePermissionBintCreatorCredential { get; set; }
        public virtual ICollection<DboRolePermission> DboRolePermissionBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboRolePermission> DboRolePermissionBintModifierCredential { get; set; }
        public virtual ICollection<DboRolePermission> DboRolePermissionBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboSocialConversationDismissal> DboSocialConversationDismissalBintCreatorCredential { get; set; }
        public virtual ICollection<DboSocialConversationDismissal> DboSocialConversationDismissalBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboSocialConversationDismissal> DboSocialConversationDismissalBintModifierCredential { get; set; }
        public virtual ICollection<DboSocialConversationDismissal> DboSocialConversationDismissalBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboSocialConversationEntry> DboSocialConversationEntryBintCreatorCredential { get; set; }
        public virtual ICollection<DboSocialConversationEntry> DboSocialConversationEntryBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboSocialConversationEntry> DboSocialConversationEntryBintCredential { get; set; }
        public virtual ICollection<DboSocialConversationEntry> DboSocialConversationEntryBintModifierCredential { get; set; }
        public virtual ICollection<DboSocialConversationEntry> DboSocialConversationEntryBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboSpoofLog> DboSpoofLogBintActualUserCredential { get; set; }
        public virtual ICollection<DboSpoofLog> DboSpoofLogBintCreatorCredential { get; set; }
        public virtual ICollection<DboSpoofLog> DboSpoofLogBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboSpoofLog> DboSpoofLogBintModifierCredential { get; set; }
        public virtual ICollection<DboSpoofLog> DboSpoofLogBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboSpoofLog> DboSpoofLogBintSpoofUserCredential { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflowBintCreatorCredential { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflowBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflowBintModifierCredential { get; set; }
        public virtual ICollection<DboWorkflow> DboWorkflowBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboWorkflowInstance> DboWorkflowInstanceBintAssignedToCredential { get; set; }
        public virtual ICollection<DboWorkflowInstance> DboWorkflowInstanceBintCreatorCredential { get; set; }
        public virtual ICollection<DboWorkflowInstance> DboWorkflowInstanceBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboWorkflowInstance> DboWorkflowInstanceBintModifierCredential { get; set; }
        public virtual ICollection<DboWorkflowInstance> DboWorkflowInstanceBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStepBintCreatorCredential { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStepBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStepBintModifierCredential { get; set; }
        public virtual ICollection<DboWorkflowStep> DboWorkflowStepBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboWorkflowStepAction> DboWorkflowStepActionBintCreatorCredential { get; set; }
        public virtual ICollection<DboWorkflowStepAction> DboWorkflowStepActionBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboWorkflowStepAction> DboWorkflowStepActionBintModifierCredential { get; set; }
        public virtual ICollection<DboWorkflowStepAction> DboWorkflowStepActionBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboWorkflowStepFieldConfiguration> DboWorkflowStepFieldConfigurationBintCreatorCredential { get; set; }
        public virtual ICollection<DboWorkflowStepFieldConfiguration> DboWorkflowStepFieldConfigurationBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboWorkflowStepFieldConfiguration> DboWorkflowStepFieldConfigurationBintCredential { get; set; }
        public virtual ICollection<DboWorkflowStepFieldConfiguration> DboWorkflowStepFieldConfigurationBintModifierCredential { get; set; }
        public virtual ICollection<DboWorkflowStepFieldConfiguration> DboWorkflowStepFieldConfigurationBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpBackingMode> LkpBackingModeBintCreatorCredential { get; set; }
        public virtual ICollection<LkpBackingMode> LkpBackingModeBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpBackingMode> LkpBackingModeBintModifierCredential { get; set; }
        public virtual ICollection<LkpBackingMode> LkpBackingModeBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpCredentialConfiguration> LkpCredentialConfigurationBintCreatorCredential { get; set; }
        public virtual ICollection<LkpCredentialConfiguration> LkpCredentialConfigurationBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpCredentialConfiguration> LkpCredentialConfigurationBintModifierCredential { get; set; }
        public virtual ICollection<LkpCredentialConfiguration> LkpCredentialConfigurationBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpCredentialType> LkpCredentialTypeBintCreatorCredential { get; set; }
        public virtual ICollection<LkpCredentialType> LkpCredentialTypeBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpCredentialType> LkpCredentialTypeBintModifierCredential { get; set; }
        public virtual ICollection<LkpCredentialType> LkpCredentialTypeBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpDataSourceType> LkpDataSourceTypeBintCreatorCredential { get; set; }
        public virtual ICollection<LkpDataSourceType> LkpDataSourceTypeBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpDataSourceType> LkpDataSourceTypeBintModifierCredential { get; set; }
        public virtual ICollection<LkpDataSourceType> LkpDataSourceTypeBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpDynamicDataEndpoint> LkpDynamicDataEndpointBintCreatorCredential { get; set; }
        public virtual ICollection<LkpDynamicDataEndpoint> LkpDynamicDataEndpointBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpDynamicDataEndpoint> LkpDynamicDataEndpointBintModifierCredential { get; set; }
        public virtual ICollection<LkpDynamicDataEndpoint> LkpDynamicDataEndpointBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpDynamicDataHierarchy> LkpDynamicDataHierarchyBintCreatorCredential { get; set; }
        public virtual ICollection<LkpDynamicDataHierarchy> LkpDynamicDataHierarchyBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpDynamicDataHierarchy> LkpDynamicDataHierarchyBintModifierCredential { get; set; }
        public virtual ICollection<LkpDynamicDataHierarchy> LkpDynamicDataHierarchyBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpDynamicDataType> LkpDynamicDataTypeBintCreatorCredential { get; set; }
        public virtual ICollection<LkpDynamicDataType> LkpDynamicDataTypeBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpDynamicDataType> LkpDynamicDataTypeBintModifierCredential { get; set; }
        public virtual ICollection<LkpDynamicDataType> LkpDynamicDataTypeBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpEmailAccountType> LkpEmailAccountTypeBintCreatorCredential { get; set; }
        public virtual ICollection<LkpEmailAccountType> LkpEmailAccountTypeBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpEmailAccountType> LkpEmailAccountTypeBintModifierCredential { get; set; }
        public virtual ICollection<LkpEmailAccountType> LkpEmailAccountTypeBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpEmailTemplate> LkpEmailTemplateBintCreatorCredential { get; set; }
        public virtual ICollection<LkpEmailTemplate> LkpEmailTemplateBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpEmailTemplate> LkpEmailTemplateBintModifierCredential { get; set; }
        public virtual ICollection<LkpEmailTemplate> LkpEmailTemplateBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpErrorPanelFilter> LkpErrorPanelFilterBintCreatorCredential { get; set; }
        public virtual ICollection<LkpErrorPanelFilter> LkpErrorPanelFilterBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpErrorPanelFilter> LkpErrorPanelFilterBintModifierCredential { get; set; }
        public virtual ICollection<LkpErrorPanelFilter> LkpErrorPanelFilterBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpFormCategory> LkpFormCategoryBintCreatorCredential { get; set; }
        public virtual ICollection<LkpFormCategory> LkpFormCategoryBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpFormCategory> LkpFormCategoryBintModifierCredential { get; set; }
        public virtual ICollection<LkpFormCategory> LkpFormCategoryBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpInterfaceAvailability> LkpInterfaceAvailabilityBintCreatorCredential { get; set; }
        public virtual ICollection<LkpInterfaceAvailability> LkpInterfaceAvailabilityBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpInterfaceAvailability> LkpInterfaceAvailabilityBintModifierCredential { get; set; }
        public virtual ICollection<LkpInterfaceAvailability> LkpInterfaceAvailabilityBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpLocalization> LkpLocalizationBintCreatorCredential { get; set; }
        public virtual ICollection<LkpLocalization> LkpLocalizationBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpLocalization> LkpLocalizationBintModifierCredential { get; set; }
        public virtual ICollection<LkpLocalization> LkpLocalizationBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpLocalizationSet> LkpLocalizationSetBintCreatorCredential { get; set; }
        public virtual ICollection<LkpLocalizationSet> LkpLocalizationSetBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpLocalizationSet> LkpLocalizationSetBintModifierCredential { get; set; }
        public virtual ICollection<LkpLocalizationSet> LkpLocalizationSetBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpNotificationEvent> LkpNotificationEventBintCreatorCredential { get; set; }
        public virtual ICollection<LkpNotificationEvent> LkpNotificationEventBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpNotificationEvent> LkpNotificationEventBintModifierCredential { get; set; }
        public virtual ICollection<LkpNotificationEvent> LkpNotificationEventBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpOpenLinkMethod> LkpOpenLinkMethodBintCreatorCredential { get; set; }
        public virtual ICollection<LkpOpenLinkMethod> LkpOpenLinkMethodBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpOpenLinkMethod> LkpOpenLinkMethodBintModifierCredential { get; set; }
        public virtual ICollection<LkpOpenLinkMethod> LkpOpenLinkMethodBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpPanelPosition> LkpPanelPositionBintCreatorCredential { get; set; }
        public virtual ICollection<LkpPanelPosition> LkpPanelPositionBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpPanelPosition> LkpPanelPositionBintModifierCredential { get; set; }
        public virtual ICollection<LkpPanelPosition> LkpPanelPositionBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpParameterBasis> LkpParameterBasisBintCreatorCredential { get; set; }
        public virtual ICollection<LkpParameterBasis> LkpParameterBasisBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpParameterBasis> LkpParameterBasisBintModifierCredential { get; set; }
        public virtual ICollection<LkpParameterBasis> LkpParameterBasisBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpPeriodicityComparison> LkpPeriodicityComparisonBintCreatorCredential { get; set; }
        public virtual ICollection<LkpPeriodicityComparison> LkpPeriodicityComparisonBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpPeriodicityComparison> LkpPeriodicityComparisonBintModifierCredential { get; set; }
        public virtual ICollection<LkpPeriodicityComparison> LkpPeriodicityComparisonBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpPeriodicityUnit> LkpPeriodicityUnitBintCreatorCredential { get; set; }
        public virtual ICollection<LkpPeriodicityUnit> LkpPeriodicityUnitBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpPeriodicityUnit> LkpPeriodicityUnitBintModifierCredential { get; set; }
        public virtual ICollection<LkpPeriodicityUnit> LkpPeriodicityUnitBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpPermission> LkpPermissionBintCreatorCredential { get; set; }
        public virtual ICollection<LkpPermission> LkpPermissionBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpPermission> LkpPermissionBintModifierCredential { get; set; }
        public virtual ICollection<LkpPermission> LkpPermissionBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpPermissionType> LkpPermissionTypeBintCreatorCredential { get; set; }
        public virtual ICollection<LkpPermissionType> LkpPermissionTypeBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpPermissionType> LkpPermissionTypeBintModifierCredential { get; set; }
        public virtual ICollection<LkpPermissionType> LkpPermissionTypeBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpReExecuteOnNext> LkpReExecuteOnNextBintCreatorCredential { get; set; }
        public virtual ICollection<LkpReExecuteOnNext> LkpReExecuteOnNextBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpReExecuteOnNext> LkpReExecuteOnNextBintModifierCredential { get; set; }
        public virtual ICollection<LkpReExecuteOnNext> LkpReExecuteOnNextBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpScheduleBasis> LkpScheduleBasisBintCreatorCredential { get; set; }
        public virtual ICollection<LkpScheduleBasis> LkpScheduleBasisBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpScheduleBasis> LkpScheduleBasisBintModifierCredential { get; set; }
        public virtual ICollection<LkpScheduleBasis> LkpScheduleBasisBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpSocialConversationScope> LkpSocialConversationScopeBintCreatorCredential { get; set; }
        public virtual ICollection<LkpSocialConversationScope> LkpSocialConversationScopeBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpSocialConversationScope> LkpSocialConversationScopeBintModifierCredential { get; set; }
        public virtual ICollection<LkpSocialConversationScope> LkpSocialConversationScopeBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpSpecialDataReference> LkpSpecialDataReferenceBintCreatorCredential { get; set; }
        public virtual ICollection<LkpSpecialDataReference> LkpSpecialDataReferenceBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpSpecialDataReference> LkpSpecialDataReferenceBintModifierCredential { get; set; }
        public virtual ICollection<LkpSpecialDataReference> LkpSpecialDataReferenceBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpSystemConfiguration> LkpSystemConfigurationBintCreatorCredential { get; set; }
        public virtual ICollection<LkpSystemConfiguration> LkpSystemConfigurationBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpSystemConfiguration> LkpSystemConfigurationBintModifierCredential { get; set; }
        public virtual ICollection<LkpSystemConfiguration> LkpSystemConfigurationBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpSystemContextType> LkpSystemContextTypeBintCreatorCredential { get; set; }
        public virtual ICollection<LkpSystemContextType> LkpSystemContextTypeBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpSystemContextType> LkpSystemContextTypeBintModifierCredential { get; set; }
        public virtual ICollection<LkpSystemContextType> LkpSystemContextTypeBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpTemplateTags> LkpTemplateTagsBintCreatorCredential { get; set; }
        public virtual ICollection<LkpTemplateTags> LkpTemplateTagsBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpTemplateTags> LkpTemplateTagsBintModifierCredential { get; set; }
        public virtual ICollection<LkpTemplateTags> LkpTemplateTagsBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpWorkflowCategory> LkpWorkflowCategoryBintCreatorCredential { get; set; }
        public virtual ICollection<LkpWorkflowCategory> LkpWorkflowCategoryBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpWorkflowCategory> LkpWorkflowCategoryBintModifierCredential { get; set; }
        public virtual ICollection<LkpWorkflowCategory> LkpWorkflowCategoryBintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<LkpWorkflowStepType> LkpWorkflowStepTypeBintCreatorCredential { get; set; }
        public virtual ICollection<LkpWorkflowStepType> LkpWorkflowStepTypeBintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<LkpWorkflowStepType> LkpWorkflowStepTypeBintModifierCredential { get; set; }
        public virtual ICollection<LkpWorkflowStepType> LkpWorkflowStepTypeBintModifierSpoofOfCredential { get; set; }
        public virtual DboCredential BintCreatorCredential { get; set; }
        public virtual ICollection<DboCredential> InverseBintCreatorCredential { get; set; }
        public virtual DboCredential BintCreatorSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredential> InverseBintCreatorSpoofOfCredential { get; set; }
        public virtual DboCredential BintModifierCredential { get; set; }
        public virtual ICollection<DboCredential> InverseBintModifierCredential { get; set; }
        public virtual DboCredential BintModifierSpoofOfCredential { get; set; }
        public virtual ICollection<DboCredential> InverseBintModifierSpoofOfCredential { get; set; }
    }
}
