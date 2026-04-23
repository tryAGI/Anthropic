
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Anthropic.JsonConverters.AllowedCallerJsonConverter),

            typeof(global::Anthropic.JsonConverters.AllowedCallerNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.Base64ImageSourceMediaTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.Base64ImageSourceMediaTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BashCodeExecutionToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BashCodeExecutionToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BashTool20250124CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BashTool20250124CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaAdvisorToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaAdvisorToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaAdvisorTool20260301CachingVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaAdvisorTool20260301CachingVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaAllowedCallerJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaAllowedCallerNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaBase64ImageSourceMediaTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaBase64ImageSourceMediaTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaBashCodeExecutionToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaBashCodeExecutionToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaBashTool20241022CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaBashTool20241022CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaBashTool20250124CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaBashTool20250124CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCacheControlEphemeralTtlJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCacheControlEphemeralTtlNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCitationsDeltaCitationDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCitationsDeltaCitationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaClearThinking20251015KeepVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaClearThinking20251015KeepVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaClearToolUses20250919KeepDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaClearToolUses20250919KeepDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaClearToolUses20250919TriggerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaClearToolUses20250919TriggerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCloudConfigNetworkingDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCloudConfigNetworkingDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCloudConfigParamsNetworkingVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCloudConfigParamsNetworkingVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCodeExecutionToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCodeExecutionToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCodeExecutionTool20250522CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCodeExecutionTool20250522CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCodeExecutionTool20250825CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCodeExecutionTool20250825CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCodeExecutionTool20260120CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCodeExecutionTool20260120CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaComputerUseTool20241022CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaComputerUseTool20241022CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaComputerUseTool20251124CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaComputerUseTool20251124CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContentBlockDeltaEventDeltaDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContentBlockDeltaEventDeltaDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContentBlockStartEventContentBlockDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContentBlockStartEventContentBlockDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContextManagementConfigEditDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContextManagementConfigEditDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCountMessageTokensParamsCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCountMessageTokensParamsCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCreateMessageParamsCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCreateMessageParamsCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCreateMessageParamsServiceTierJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaCreateMessageParamsServiceTierNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaEffortLevelJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaEffortLevelNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaEnrollmentUrlTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaEnrollmentUrlTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaEnvironmentConfigDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaEnvironmentConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaErrorResponseErrorDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaErrorResponseErrorDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaInputMessageRoleJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaInputMessageRoleNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMCPToolsetCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMCPToolsetCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsActorDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsActorDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAddSessionResourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAddSessionResourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAddSessionResourceParamsDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAddSessionResourceParamsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentCustomToolUseEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentCustomToolUseEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentEvaluatedPermissionJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentEvaluatedPermissionNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentMcpToolResultEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentMcpToolResultEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentMcpToolUseEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentMcpToolUseEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentMessageEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentMessageEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentThinkingEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentThinkingEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentThreadContextCompactedEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentThreadContextCompactedEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolNameJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolNameNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolParamsDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolParamsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolResultEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolResultEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolUseEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolUseEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolset20260401TypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolset20260401TypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolset20260401ParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolset20260401ParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAlwaysAllowPolicyTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAlwaysAllowPolicyTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAlwaysAskPolicyTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAlwaysAskPolicyTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAnthropicSkillTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAnthropicSkillTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAnthropicSkillParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAnthropicSkillParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsApiActorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsApiActorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBase64DocumentSourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBase64DocumentSourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBase64ImageSourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBase64ImageSourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBillingErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBillingErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBranchCheckoutTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBranchCheckoutTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCommitCheckoutTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCommitCheckoutTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsContentSha256PreconditionTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsContentSha256PreconditionTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialAuthDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialCreateAuthDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialCreateAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialUpdateAuthDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialUpdateAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomSkillTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomSkillTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomSkillParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomSkillParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomToolTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomToolTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomToolInputSchemaTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomToolInputSchemaTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomToolParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomToolParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeleteSessionResourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeleteSessionResourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedCredentialTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedCredentialTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedMemoryTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedMemoryTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedMemoryStoreTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedMemoryStoreTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedSessionTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedSessionTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedVaultTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedVaultTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDocumentBlockTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDocumentBlockTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDocumentSourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDocumentSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsErrorResponseTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsErrorResponseTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEventParamsDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEventParamsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileDocumentSourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileDocumentSourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileImageSourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileImageSourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileResourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileResourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileResourceParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileResourceParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGetMemoryStoreResponseDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGetMemoryStoreResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGetSessionResourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGetSessionResourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGitHubRepositoryResourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGitHubRepositoryResourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGitHubRepositoryResourceParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGitHubRepositoryResourceParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsImageBlockTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsImageBlockTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsImageSourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsImageSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsInputEventDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsInputEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsListOrderJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsListOrderNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPServerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPServerParamsDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPServerParamsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPServerURLDefinitionTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPServerURLDefinitionTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPToolsetTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPToolsetTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPToolsetParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPToolsetParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpAuthenticationFailedErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpAuthenticationFailedErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpConnectionFailedErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpConnectionFailedErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthAuthResponseTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthAuthResponseTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthCreateParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthCreateParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthUpdateParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthUpdateParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryListItemDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryListItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryPathConflictErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryPathConflictErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryPreconditionFailedErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryPreconditionFailedErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryPrefixTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryPrefixTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryStoreTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryStoreTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryStoreResourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryStoreResourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryStoreResourceParamTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryStoreResourceParamTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryVersionTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryVersionTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryVersionOperationJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryVersionOperationNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryViewJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryViewNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelOverloadedErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelOverloadedErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelRateLimitedErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelRateLimitedErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelRequestFailedErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelRequestFailedErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMountModeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMountModeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPermissionPolicyDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPermissionPolicyDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPlainTextDocumentSourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPlainTextDocumentSourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPlainTextDocumentSourceMediaTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPlainTextDocumentSourceMediaTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPreconditionDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPreconditionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRepositoryCheckoutDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRepositoryCheckoutDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusExhaustedTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusExhaustedTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusRetryingTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusRetryingTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusTerminalTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusTerminalTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionActorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionActorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionAgentTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionAgentTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionDeletedEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionDeletedEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionEndTurnTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionEndTurnTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionErrorEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionErrorEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionErrorEventErrorDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionErrorEventErrorDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionEventDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionRequiresActionTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionRequiresActionTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionResourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionResourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionResourceParamsDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionResourceParamsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionRetriesExhaustedTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionRetriesExhaustedTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusIdleEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusIdleEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusRescheduledEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusRescheduledEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusRunningEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusRunningEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusTerminatedEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusTerminatedEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSkillDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSkillDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSkillParamsDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSkillParamsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpanModelRequestEndEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpanModelRequestEndEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpanModelRequestStartEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpanModelRequestStartEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpeedJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpeedNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStaticBearerAuthResponseTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStaticBearerAuthResponseTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStaticBearerCreateParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStaticBearerCreateParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStaticBearerUpdateParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStaticBearerUpdateParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStreamSessionEventsDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStreamSessionEventsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTextBlockTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTextBlockTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthBasicParamTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthBasicParamTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthBasicResponseTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthBasicResponseTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthBasicUpdateParamTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthBasicUpdateParamTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthNoneParamTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthNoneParamTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthNoneResponseTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthNoneResponseTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthPostParamTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthPostParamTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthPostResponseTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthPostResponseTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthPostUpdateParamTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthPostUpdateParamTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsToolResultContentBlockDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsToolResultContentBlockDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsURLDocumentSourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsURLDocumentSourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsURLImageSourceTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsURLImageSourceTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsURLMCPServerParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsURLMCPServerParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUnknownErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUnknownErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUpdateSessionResourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUpdateSessionResourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserActorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserActorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserContentBlockDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserContentBlockDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserCustomToolResultEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserCustomToolResultEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserCustomToolResultEventParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserCustomToolResultEventParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserInterruptEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserInterruptEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserInterruptEventParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserInterruptEventParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserMessageEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserMessageEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserMessageEventParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserMessageEventParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserToolConfirmationEventTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserToolConfirmationEventTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserToolConfirmationEventParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserToolConfirmationEventParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserToolConfirmationResultJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserToolConfirmationResultNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsVaultTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsVaultTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageBatchProcessingStatusJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageBatchProcessingStatusNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageBatchIndividualResponseResultDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageBatchIndividualResponseResultDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageStreamEventDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageStreamEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRefusalStopDetailsCategory2JsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRefusalStopDetailsCategory2NullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestCompactionBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestCompactionBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestContainerUploadBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestContainerUploadBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestDocumentBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestDocumentBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestDocumentBlockSourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestDocumentBlockSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestImageBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestImageBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestImageBlockSourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestImageBlockSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestMCPToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestMCPToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestMCPToolUseBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestMCPToolUseBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestSearchResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestSearchResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestServerToolUseBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestServerToolUseBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestServerToolUseBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestServerToolUseBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestServerToolUseBlockNameJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestServerToolUseBlockNameNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestTextBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestTextBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestTextEditorCodeExecutionViewResultBlockFileTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestTextEditorCodeExecutionViewResultBlockFileTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolReferenceBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolReferenceBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolUseBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolUseBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolUseBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestToolUseBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestWebFetchToolResultBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestWebFetchToolResultBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestWebSearchToolResultBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaRequestWebSearchToolResultBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseContextManagementAppliedEditDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseContextManagementAppliedEditDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseDocumentBlockSourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseDocumentBlockSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseServerToolUseBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseServerToolUseBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseServerToolUseBlockNameJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseServerToolUseBlockNameNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseTextEditorCodeExecutionViewResultBlockFileTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseTextEditorCodeExecutionViewResultBlockFileTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseToolUseBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseToolUseBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseWebFetchToolResultBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseWebFetchToolResultBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseWebSearchToolResultBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaResponseWebSearchToolResultBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaSkillTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaSkillTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaSkillParamsTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaSkillParamsTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaSpeedJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaSpeedNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaTextEditorCodeExecutionToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaTextEditorCodeExecutionToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaTextEditor20241022CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaTextEditor20241022CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaTextEditor20250124CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaTextEditor20250124CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaTextEditor20250429CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaTextEditor20250429CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaTextEditor20250728CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaTextEditor20250728CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaThinkingDisplayModeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaThinkingDisplayModeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolSearchToolBM2520251119TypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolSearchToolBM2520251119TypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolSearchToolRegex20251119CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolSearchToolRegex20251119CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolSearchToolRegex20251119TypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolSearchToolRegex20251119TypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolSearchToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolSearchToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaUsageServiceTier2JsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaUsageServiceTier2NullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaUserProfileTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaUserProfileTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaUserProfileListOrderJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaUserProfileListOrderNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaUserProfileTrustGrantStatusJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaUserProfileTrustGrantStatusNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebFetchToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebFetchToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebFetchTool20250910CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebFetchTool20250910CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebFetchTool20260209CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebFetchTool20260209CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebFetchTool20260309CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebFetchTool20260309CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebSearchToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebSearchToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebSearchTool20250305CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebSearchTool20250305CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebSearchTool20260209CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaWebSearchTool20260209CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlEphemeralTtlJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlEphemeralTtlNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationsDeltaCitationDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationsDeltaCitationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CodeExecutionToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.CodeExecutionToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CodeExecutionTool20250522CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.CodeExecutionTool20250522CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CodeExecutionTool20250825CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.CodeExecutionTool20250825CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CodeExecutionTool20260120CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.CodeExecutionTool20260120CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlockDeltaEventDeltaDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlockDeltaEventDeltaDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlockStartEventContentBlockDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlockStartEventContentBlockDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CountMessageTokensParamsCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.CountMessageTokensParamsCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CreateMessageParamsCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.CreateMessageParamsCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CreateMessageParamsServiceTierJsonConverter),

            typeof(global::Anthropic.JsonConverters.CreateMessageParamsServiceTierNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.EffortLevelJsonConverter),

            typeof(global::Anthropic.JsonConverters.EffortLevelNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ErrorResponseErrorDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ErrorResponseErrorDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.InputMessageRoleJsonConverter),

            typeof(global::Anthropic.JsonConverters.InputMessageRoleNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.MemoryTool20250818CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.MemoryTool20250818CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.MessageBatchProcessingStatusJsonConverter),

            typeof(global::Anthropic.JsonConverters.MessageBatchProcessingStatusNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.MessageBatchIndividualResponseResultDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.MessageBatchIndividualResponseResultDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.MessageStreamEventDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.MessageStreamEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RefusalStopDetailsCategory2JsonConverter),

            typeof(global::Anthropic.JsonConverters.RefusalStopDetailsCategory2NullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestContainerUploadBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestContainerUploadBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestDocumentBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestDocumentBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestDocumentBlockSourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestDocumentBlockSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestImageBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestImageBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestImageBlockSourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestImageBlockSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestSearchResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestSearchResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestServerToolUseBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestServerToolUseBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestServerToolUseBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestServerToolUseBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestServerToolUseBlockNameJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestServerToolUseBlockNameNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestTextBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestTextBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestTextBlockCitationsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestTextBlockCitationsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestTextEditorCodeExecutionViewResultBlockFileTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestTextEditorCodeExecutionViewResultBlockFileTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolReferenceBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolReferenceBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolResultBlockContentVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolResultBlockContentVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolUseBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolUseBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolUseBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestToolUseBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestWebFetchToolResultBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestWebFetchToolResultBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestWebSearchToolResultBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.RequestWebSearchToolResultBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseDocumentBlockSourceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseDocumentBlockSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseServerToolUseBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseServerToolUseBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseServerToolUseBlockNameJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseServerToolUseBlockNameNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseTextBlockCitationsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseTextBlockCitationsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseTextEditorCodeExecutionViewResultBlockFileTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseTextEditorCodeExecutionViewResultBlockFileTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseToolUseBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseToolUseBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseWebFetchToolResultBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseWebFetchToolResultBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseWebSearchToolResultBlockCallerDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ResponseWebSearchToolResultBlockCallerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.TextEditorCodeExecutionToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.TextEditorCodeExecutionToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.TextEditor20250124CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.TextEditor20250124CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.TextEditor20250429CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.TextEditor20250429CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.TextEditor20250728CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.TextEditor20250728CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ThinkingDisplayModeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ThinkingDisplayModeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolSearchToolBM2520251119CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolSearchToolBM2520251119CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolSearchToolBM2520251119TypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolSearchToolBM2520251119TypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolSearchToolRegex20251119CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolSearchToolRegex20251119CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolSearchToolRegex20251119TypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolSearchToolRegex20251119TypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolSearchToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolSearchToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.UsageServiceTier2JsonConverter),

            typeof(global::Anthropic.JsonConverters.UsageServiceTier2NullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebFetchToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebFetchToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebFetchTool20250910CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebFetchTool20250910CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebFetchTool20260209CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebFetchTool20260209CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebFetchTool20260309CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebFetchTool20260309CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebSearchToolResultErrorCodeJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebSearchToolResultErrorCodeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebSearchTool20250305CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebSearchTool20250305CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebSearchTool20260209CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.WebSearchTool20260209CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsConflictErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsConflictErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsErrorDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsErrorDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CreateMessageParamsWithoutStreamCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.CreateMessageParamsWithoutStreamCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CreateMessageParamsWithoutStreamServiceTierJsonConverter),

            typeof(global::Anthropic.JsonConverters.CreateMessageParamsWithoutStreamServiceTierNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.AnthropicBetaEnumJsonConverter),

            typeof(global::Anthropic.JsonConverters.AnthropicBetaEnumNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ThinkingConfigParamDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ThinkingConfigParamDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaThinkingConfigParamDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaThinkingConfigParamDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolChoiceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolChoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolChoiceDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolChoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlockDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlockDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.InputContentBlockDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.InputContentBlockDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContentBlockDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContentBlockDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaInputContentBlockDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaInputContentBlockDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.StopReasonJsonConverter),

            typeof(global::Anthropic.JsonConverters.StopReasonNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaStopReasonJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaStopReasonNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818ViewCommandCommandJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818ViewCommandCommandNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CreateCommandCommandJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CreateCommandCommandNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818StrReplaceCommandCommandJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818StrReplaceCommandCommandNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818InsertCommandCommandJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818InsertCommandCommandNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818DeleteCommandCommandJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818DeleteCommandCommandNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818RenameCommandCommandJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818RenameCommandCommandNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CommandDiscriminatorCommandJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CommandDiscriminatorCommandNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaIterationsUsageItemsDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaIterationsUsageItemsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.PingTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.PingTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant1JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant12JsonConverter),

            typeof(global::Anthropic.JsonConverters.CachingVariant1JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant13JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant14JsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationJsonConverter),

            typeof(global::Anthropic.JsonConverters.KeepVariant1JsonConverter),

            typeof(global::Anthropic.JsonConverters.TriggerJsonConverter),

            typeof(global::Anthropic.JsonConverters.NetworkingJsonConverter),

            typeof(global::Anthropic.JsonConverters.NetworkingVariant1JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant15JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant16JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant17JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant18JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant19JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant110JsonConverter),

            typeof(global::Anthropic.JsonConverters.DeltaJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBetaContentBlockSourceContentItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlockJsonConverter),

            typeof(global::Anthropic.JsonConverters.EditsItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant111JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant112JsonConverter),

            typeof(global::Anthropic.JsonConverters.ErrorJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant113JsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsActorJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAddSessionResourceJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAddSessionResourceParamsJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolParamsJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentUnionParamsJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentUnionParamsVariant2JsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsArchiveMemoryStoreResponseJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCreateMemoryStoreResponseJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialAuthJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialCreateAuthJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialUpdateAuthJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeleteMemoryStoreResponseJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDocumentSourceJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEventParamsJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGetMemoryStoreResponseJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsGetSessionResourceJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsImageSourceJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsInputEventJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPServerJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMCPServerParamsJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryListItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelParamsJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPermissionPolicyJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPreconditionJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRepositoryCheckoutJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionErrorEventErrorJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionEventJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionResourceJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionResourceParamsJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusIdleEventStopReasonJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSkillJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSkillParamsJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStreamSessionEventsJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsToolResultContentBlockJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUpdateMemoryStoreResponseJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUpdateSessionResourceJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserContentBlockJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant114JsonConverter),

            typeof(global::Anthropic.JsonConverters.ResultJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageStreamEventJsonConverter),

            typeof(global::Anthropic.JsonConverters.ConfigVariant1JsonConverter),

            typeof(global::Anthropic.JsonConverters.ConfigVariant12JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant115JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant116JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant117JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant118JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant119JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant120JsonConverter),

            typeof(global::Anthropic.JsonConverters.SourceJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant121JsonConverter),

            typeof(global::Anthropic.JsonConverters.Source2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant122JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant123JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant124JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant125JsonConverter),

            typeof(global::Anthropic.JsonConverters.CallerJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant126JsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationsVariant1ItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant127JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant128JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant129JsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentVariant2ItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant130JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant131JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant132JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller3JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant133JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller4JsonConverter),

            typeof(global::Anthropic.JsonConverters.AppliedEditsItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.Source3JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller5JsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationsVariant1Item2JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller6JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller7JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller8JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant134JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant135JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant136JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant137JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant138JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant139JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant140JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant141JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant142JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant143JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant144JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant145JsonConverter),

            typeof(global::Anthropic.JsonConverters.Citation2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant146JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant147JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant148JsonConverter),

            typeof(global::Anthropic.JsonConverters.Delta2JsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentContentBlockSourceContentItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlock2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant149JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant150JsonConverter),

            typeof(global::Anthropic.JsonConverters.Error2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant151JsonConverter),

            typeof(global::Anthropic.JsonConverters.Result2JsonConverter),

            typeof(global::Anthropic.JsonConverters.MessageStreamEventJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant152JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant153JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant154JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant155JsonConverter),

            typeof(global::Anthropic.JsonConverters.Source4JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant156JsonConverter),

            typeof(global::Anthropic.JsonConverters.Source5JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant157JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant158JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller9JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant159JsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationsVariant1Item3JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant160JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant161JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant162JsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentVariant2Item2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant163JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant164JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller10JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant165JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller11JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant166JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller12JsonConverter),

            typeof(global::Anthropic.JsonConverters.Source6JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller13JsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationsVariant1Item4JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller14JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller15JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller16JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant167JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant168JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant169JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant170JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant171JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant172JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant173JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant174JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant175JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant176JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant177JsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsErrorJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant178JsonConverter),

            typeof(global::Anthropic.JsonConverters.AnthropicBetaJsonConverter),

            typeof(global::Anthropic.JsonConverters.ThinkingConfigParamJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaThinkingConfigParamJsonConverter),

            typeof(global::Anthropic.JsonConverters.ToolChoiceJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaToolChoiceJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlock3JsonConverter),

            typeof(global::Anthropic.JsonConverters.InputContentBlockJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaContentBlockJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaInputContentBlockJsonConverter),

            typeof(global::Anthropic.JsonConverters.ModelJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CommandJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaIterationsUsageVariant1ItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.KeepVariant1?, string>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>),

            typeof(global::Anthropic.JsonConverters.OneOfJsonConverter<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaAdvisorTool20260301, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaContainerParams, string, object>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>),

            typeof(global::Anthropic.JsonConverters.OneOfJsonConverter<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaAdvisorTool20260301, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestAdvisorToolResultError, global::Anthropic.BetaRequestAdvisorResultBlock, global::Anthropic.BetaRequestAdvisorRedactedResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestBashCodeExecutionToolResultError, global::Anthropic.BetaRequestBashCodeExecutionResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestCodeExecutionToolResultError, global::Anthropic.BetaRequestCodeExecutionResultBlock, global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestToolSearchToolResultError, global::Anthropic.BetaRequestToolSearchToolSearchResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestWebFetchToolResultError, global::Anthropic.BetaRequestWebFetchResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaRequestWebSearchToolResultError>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseAdvisorToolResultError, global::Anthropic.BetaResponseAdvisorResultBlock, global::Anthropic.BetaResponseAdvisorRedactedResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseBashCodeExecutionToolResultError, global::Anthropic.BetaResponseBashCodeExecutionResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseCodeExecutionToolResultError, global::Anthropic.BetaResponseCodeExecutionResultBlock, global::Anthropic.BetaResponseEncryptedCodeExecutionResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError, global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseToolSearchToolResultError, global::Anthropic.BetaResponseToolSearchToolSearchResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseWebFetchToolResultError, global::Anthropic.BetaResponseWebFetchResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>),

            typeof(global::Anthropic.JsonConverters.OneOfJsonConverter<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.MemoryTool20250818, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>),

            typeof(global::Anthropic.JsonConverters.OneOfJsonConverter<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.MemoryTool20250818, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.RequestBashCodeExecutionToolResultError, global::Anthropic.RequestBashCodeExecutionResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.RequestCodeExecutionToolResultError, global::Anthropic.RequestCodeExecutionResultBlock, global::Anthropic.RequestEncryptedCodeExecutionResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.RequestTextEditorCodeExecutionToolResultError, global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.RequestToolSearchToolResultError, global::Anthropic.RequestToolSearchToolSearchResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.RequestWebFetchToolResultError, global::Anthropic.RequestWebFetchResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.RequestWebSearchToolResultError>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseBashCodeExecutionToolResultError, global::Anthropic.ResponseBashCodeExecutionResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseCodeExecutionToolResultError, global::Anthropic.ResponseCodeExecutionResultBlock, global::Anthropic.ResponseEncryptedCodeExecutionResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseTextEditorCodeExecutionToolResultError, global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseWebFetchToolResultError, global::Anthropic.ResponseWebFetchResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>),

            typeof(global::Anthropic.JsonConverters.OneOfJsonConverter<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.MemoryTool20250818, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>),

            typeof(global::Anthropic.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.APIError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AllowedCaller), TypeInfoPropertyName = "AllowedCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AuthenticationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Base64ImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Base64ImageSourceMediaType), TypeInfoPropertyName = "Base64ImageSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Base64PDFSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BashCodeExecutionToolResultErrorCode), TypeInfoPropertyName = "BashCodeExecutionToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BashTool20250124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.AllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlEphemeral))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BashTool20250124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BashTool20250124CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BashTool20250124CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.JsonValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAPIError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAdvisorMessageIterationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Model), TypeInfoPropertyName = "Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAdvisorToolResultErrorCode), TypeInfoPropertyName = "BetaAdvisorToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAdvisorTool20260301))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAllowedCaller), TypeInfoPropertyName = "BetaAllowedCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCacheControlEphemeral))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaAdvisorTool20260301CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CachingVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAdvisorTool20260301CachingVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAdvisorTool20260301CachingVariant1DiscriminatorType), TypeInfoPropertyName = "BetaAdvisorTool20260301CachingVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAllThinkingTurns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAuthenticationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBase64ImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBase64ImageSourceMediaType), TypeInfoPropertyName = "BetaBase64ImageSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBase64PDFSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashCodeExecutionToolResultErrorCode), TypeInfoPropertyName = "BetaBashCodeExecutionToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20241022))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20241022CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20241022CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaBashTool20241022CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaJsonValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20250124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20250124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20250124CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaBashTool20250124CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBillingError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBodyCreateSkillV1SkillsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBodyCreateSkillVersionV1SkillsSkillIdVersionsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCacheControlEphemeralTtl), TypeInfoPropertyName = "BetaCacheControlEphemeralTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCanceledResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCapabilitySupport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCitationsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Citation), TypeInfoPropertyName = "Citation2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCharLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponsePageLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseContentBlockLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCitationsDeltaCitationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCitationsDeltaCitationDiscriminatorType), TypeInfoPropertyName = "BetaCitationsDeltaCitationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearThinking20251015))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.KeepVariant1?, string>), TypeInfoPropertyName = "AnyOfKeepVariant1String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.KeepVariant1), TypeInfoPropertyName = "KeepVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingTurns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearThinking20251015KeepVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearThinking20251015KeepVariant1DiscriminatorType), TypeInfoPropertyName = "BetaClearThinking20251015KeepVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearToolUses20250919))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputTokensClearAtLeast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfBooleanIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolUsesKeep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearToolUses20250919KeepDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearToolUses20250919KeepDiscriminatorType), TypeInfoPropertyName = "BetaClearToolUses20250919KeepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Trigger), TypeInfoPropertyName = "Trigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputTokensTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolUsesTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearToolUses20250919TriggerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearToolUses20250919TriggerDiscriminatorType), TypeInfoPropertyName = "BetaClearToolUses20250919TriggerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCloudConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Networking), TypeInfoPropertyName = "Networking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUnrestrictedNetwork))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaLimitedNetwork))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCloudConfigNetworkingDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCloudConfigNetworkingDiscriminatorType), TypeInfoPropertyName = "BetaCloudConfigNetworkingDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPackages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCloudConfigParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.NetworkingVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaLimitedNetworkParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCloudConfigParamsNetworkingVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCloudConfigParamsNetworkingVariant1DiscriminatorType), TypeInfoPropertyName = "BetaCloudConfigParamsNetworkingVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPackagesParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionToolResultErrorCode), TypeInfoPropertyName = "BetaCodeExecutionToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250522))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaCodeExecutionTool20250522CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250825))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaCodeExecutionTool20250825CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20260120))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaCodeExecutionTool20260120CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCompact20260112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCompactionContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCompactionIterationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20241022))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaComputerUseTool20241022CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20250124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaComputerUseTool20250124CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20251124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant110))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaComputerUseTool20251124CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContainer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContainerParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaSkillParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSkillParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Delta), TypeInfoPropertyName = "Delta2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputJsonContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSignatureContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType), TypeInfoPropertyName = "BetaContentBlockDeltaEventDeltaDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>>), TypeInfoPropertyName = "AnyOfStringIListContentBetaContentBlockSourceContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBetaContentBlockSourceContentItem), TypeInfoPropertyName = "ContentBetaContentBlockSourceContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestImageBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType), TypeInfoPropertyName = "BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlock), TypeInfoPropertyName = "ContentBlock2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseRedactedThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseServerToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebFetchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseAdvisorToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseMCPToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseMCPToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseContainerUploadBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCompactionBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType), TypeInfoPropertyName = "BetaContentBlockStartEventContentBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockStopEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContextManagementCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContextManagementConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.EditsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.EditsItem), TypeInfoPropertyName = "EditsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContextManagementConfigEditDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContextManagementConfigEditDiscriminatorType), TypeInfoPropertyName = "BetaContextManagementConfigEditDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContextManagementResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCountMessageTokensParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant111))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaCountMessageTokensParamsCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestMCPServerURLDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPServerURLDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaInputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaOutputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaJsonOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSpeed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>), TypeInfoPropertyName = "AnyOfStringIListBetaRequestTextBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigParam), TypeInfoPropertyName = "BetaThinkingConfigParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoice), TypeInfoPropertyName = "BetaToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.OneOf<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaAdvisorTool20260301, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>>), TypeInfoPropertyName = "BetaMCPToolset_be5e97dc9376ae47")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.OneOf<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaAdvisorTool20260301, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>), TypeInfoPropertyName = "BetaMCPToolset_3f42a181a958da94")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20241022))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250429))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250728))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchTool20250305))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20250910))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchTool20260209))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20260209))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20260309))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolBM2520251119))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolRegex20251119))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMCPToolset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCountMessageTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateMessageBatchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatchIndividualRequestParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageBatchIndividualRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateMessageParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateMessageParamsCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateMessageParamsCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaCreateMessageParamsCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaContainerParams, string, object>), TypeInfoPropertyName = "AnyOfBetaContainerParamsStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateMessageParamsServiceTier), TypeInfoPropertyName = "BetaCreateMessageParamsServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateUserProfileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaDeleteMessageBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaDeleteSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaDeleteSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaDirectCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEffortCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEffortLevel), TypeInfoPropertyName = "BetaEffortLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEnrollmentUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEnrollmentUrlType), TypeInfoPropertyName = "BetaEnrollmentUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEnvironment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEnvironmentConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEnvironmentConfigDiscriminatorType), TypeInfoPropertyName = "BetaEnvironmentConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEnvironmentDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEnvironmentListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaEnvironment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Error), TypeInfoPropertyName = "Error2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInvalidRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPermissionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRateLimitError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaGatewayTimeoutError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaOverloadedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaErrorResponseErrorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaErrorResponseErrorDiscriminatorType), TypeInfoPropertyName = "BetaErrorResponseErrorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaErrorType), TypeInfoPropertyName = "BetaErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaErroredResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaExpiredResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileDocumentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaFileMetadataSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileMetadataSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaGetSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaGetSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>), TypeInfoPropertyName = "AnyOfStringIListBetaInputContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputContentBlock), TypeInfoPropertyName = "BetaInputContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputMessageRole), TypeInfoPropertyName = "BetaInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaListResponseMessageBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaListResponseModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaListSkillVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaSkillVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSkillVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaListSkillsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaapiSchemasSkillsSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaapiSchemasSkillsSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaListUserProfilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaUserProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUserProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMCPToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMCPToolDefaultConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant113))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMCPToolsetCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMCPToolsetCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaMCPToolsetCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaMCPToolConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsActor), TypeInfoPropertyName = "BetaManagedAgentsActor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsApiActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsActorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsActorDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsActorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAddSessionResource), TypeInfoPropertyName = "BetaManagedAgentsAddSessionResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsFileResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsAddSessionResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAddSessionResourceParams), TypeInfoPropertyName = "BetaManagedAgentsAddSessionResourceParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsFileResourceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsAddSessionResourceParamsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentType), TypeInfoPropertyName = "BetaManagedAgentsAgentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentTool), TypeInfoPropertyName = "BetaManagedAgentsAgentTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPServer), TypeInfoPropertyName = "BetaManagedAgentsMCPServer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSkill), TypeInfoPropertyName = "BetaManagedAgentsSkill2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEventType), TypeInfoPropertyName = "BetaManagedAgentsAgentCustomToolUseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsStruct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentEvaluatedPermission), TypeInfoPropertyName = "BetaManagedAgentsAgentEvaluatedPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEventType), TypeInfoPropertyName = "BetaManagedAgentsAgentMcpToolResultEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsToolResultContentBlock), TypeInfoPropertyName = "BetaManagedAgentsToolResultContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEventType), TypeInfoPropertyName = "BetaManagedAgentsAgentMcpToolUseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentMessageEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentMessageEventType), TypeInfoPropertyName = "BetaManagedAgentsAgentMessageEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentParamsType), TypeInfoPropertyName = "BetaManagedAgentsAgentParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentThinkingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentThinkingEventType), TypeInfoPropertyName = "BetaManagedAgentsAgentThinkingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEventType), TypeInfoPropertyName = "BetaManagedAgentsAgentThreadContextCompactedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolset20260401))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPToolset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCustomTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsAgentToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolName), TypeInfoPropertyName = "BetaManagedAgentsAgentToolName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsPermissionPolicy), TypeInfoPropertyName = "BetaManagedAgentsPermissionPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolConfigParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolParams), TypeInfoPropertyName = "BetaManagedAgentsAgentToolParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolset20260401Params))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPToolsetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCustomToolParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsAgentToolParamsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolResultEventType), TypeInfoPropertyName = "BetaManagedAgentsAgentToolResultEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolUseEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolUseEventType), TypeInfoPropertyName = "BetaManagedAgentsAgentToolUseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolset20260401Type), TypeInfoPropertyName = "BetaManagedAgentsAgentToolset20260401Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolset20260401ParamsType), TypeInfoPropertyName = "BetaManagedAgentsAgentToolset20260401ParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfigParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentUnionParams), TypeInfoPropertyName = "BetaManagedAgentsAgentUnionParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2), TypeInfoPropertyName = "BetaManagedAgentsAgentUnionParamsVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAlwaysAllowPolicyType), TypeInfoPropertyName = "BetaManagedAgentsAlwaysAllowPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAlwaysAskPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAlwaysAskPolicyType), TypeInfoPropertyName = "BetaManagedAgentsAlwaysAskPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAnthropicSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAnthropicSkillType), TypeInfoPropertyName = "BetaManagedAgentsAnthropicSkillType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAnthropicSkillParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsAnthropicSkillParamsType), TypeInfoPropertyName = "BetaManagedAgentsAnthropicSkillParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsApiActorType), TypeInfoPropertyName = "BetaManagedAgentsApiActorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponse), TypeInfoPropertyName = "BetaManagedAgentsArchiveMemoryStoreResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsBase64DocumentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsBase64DocumentSourceType), TypeInfoPropertyName = "BetaManagedAgentsBase64DocumentSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsBase64ImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsBase64ImageSourceType), TypeInfoPropertyName = "BetaManagedAgentsBase64ImageSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsBillingError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsBillingErrorType), TypeInfoPropertyName = "BetaManagedAgentsBillingErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRetryStatus), TypeInfoPropertyName = "BetaManagedAgentsRetryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsBranchCheckout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsBranchCheckoutType), TypeInfoPropertyName = "BetaManagedAgentsBranchCheckoutType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCacheCreationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCommitCheckout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCommitCheckoutType), TypeInfoPropertyName = "BetaManagedAgentsCommitCheckoutType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsContentSha256Precondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsContentSha256PreconditionType), TypeInfoPropertyName = "BetaManagedAgentsContentSha256PreconditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCreateAgentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsModelParams), TypeInfoPropertyName = "BetaManagedAgentsModelParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPServerParams), TypeInfoPropertyName = "BetaManagedAgentsMCPServerParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSkillParams), TypeInfoPropertyName = "BetaManagedAgentsSkillParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCreateCredentialRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredentialCreateAuth), TypeInfoPropertyName = "BetaManagedAgentsCredentialCreateAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCreateMemoryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCreateMemoryStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponse), TypeInfoPropertyName = "BetaManagedAgentsCreateMemoryStoreResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCreateSessionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionResourceParams), TypeInfoPropertyName = "BetaManagedAgentsSessionResourceParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCreateVaultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredentialType), TypeInfoPropertyName = "BetaManagedAgentsCredentialType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredentialAuth), TypeInfoPropertyName = "BetaManagedAgentsCredentialAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsCredentialAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsStaticBearerCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsCredentialCreateAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredentialUpdateAuth), TypeInfoPropertyName = "BetaManagedAgentsCredentialUpdateAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsCredentialUpdateAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCustomSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCustomSkillType), TypeInfoPropertyName = "BetaManagedAgentsCustomSkillType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCustomSkillParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCustomSkillParamsType), TypeInfoPropertyName = "BetaManagedAgentsCustomSkillParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCustomToolType), TypeInfoPropertyName = "BetaManagedAgentsCustomToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCustomToolInputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCustomToolInputSchemaType), TypeInfoPropertyName = "BetaManagedAgentsCustomToolInputSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsCustomToolParamsType), TypeInfoPropertyName = "BetaManagedAgentsCustomToolParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponse), TypeInfoPropertyName = "BetaManagedAgentsDeleteMemoryStoreResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeletedMemoryStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeleteSessionResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeleteSessionResourceType), TypeInfoPropertyName = "BetaManagedAgentsDeleteSessionResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeletedCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeletedCredentialType), TypeInfoPropertyName = "BetaManagedAgentsDeletedCredentialType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeletedMemory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeletedMemoryType), TypeInfoPropertyName = "BetaManagedAgentsDeletedMemoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeletedMemoryStoreType), TypeInfoPropertyName = "BetaManagedAgentsDeletedMemoryStoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeletedSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeletedSessionType), TypeInfoPropertyName = "BetaManagedAgentsDeletedSessionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeletedVault))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDeletedVaultType), TypeInfoPropertyName = "BetaManagedAgentsDeletedVaultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDocumentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDocumentBlockType), TypeInfoPropertyName = "BetaManagedAgentsDocumentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDocumentSource), TypeInfoPropertyName = "BetaManagedAgentsDocumentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsPlainTextDocumentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsURLDocumentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsFileDocumentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsDocumentSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsErrorResponseType), TypeInfoPropertyName = "BetaManagedAgentsErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsError), TypeInfoPropertyName = "BetaManagedAgentsError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsEventParams), TypeInfoPropertyName = "BetaManagedAgentsEventParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserMessageEventParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserInterruptEventParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsEventParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsEventParamsDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsEventParamsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsFileDocumentSourceType), TypeInfoPropertyName = "BetaManagedAgentsFileDocumentSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsFileImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsFileImageSourceType), TypeInfoPropertyName = "BetaManagedAgentsFileImageSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsFileResourceType), TypeInfoPropertyName = "BetaManagedAgentsFileResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsFileResourceParamsType), TypeInfoPropertyName = "BetaManagedAgentsFileResourceParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsGetMemoryStoreResponse), TypeInfoPropertyName = "BetaManagedAgentsGetMemoryStoreResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsGetMemoryStoreResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsGetSessionResource), TypeInfoPropertyName = "BetaManagedAgentsGetSessionResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsGitHubRepositoryResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryStoreResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsGetSessionResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceType), TypeInfoPropertyName = "BetaManagedAgentsGitHubRepositoryResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRepositoryCheckout), TypeInfoPropertyName = "BetaManagedAgentsRepositoryCheckout2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParamsType), TypeInfoPropertyName = "BetaManagedAgentsGitHubRepositoryResourceParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsImageBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsImageBlockType), TypeInfoPropertyName = "BetaManagedAgentsImageBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsImageSource), TypeInfoPropertyName = "BetaManagedAgentsImageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsURLImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsImageSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsImageSourceDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsImageSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsInputEvent), TypeInfoPropertyName = "BetaManagedAgentsInputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserMessageEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserInterruptEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsInputEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsInputEventDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsInputEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListAgentVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListAgents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsCredential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListMemoriesResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryListItem), TypeInfoPropertyName = "BetaManagedAgentsMemoryListItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListMemoryStoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListMemoryVersionsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListOrder), TypeInfoPropertyName = "BetaManagedAgentsListOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListSessionEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionEvent), TypeInfoPropertyName = "BetaManagedAgentsSessionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListSessionResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionResource), TypeInfoPropertyName = "BetaManagedAgentsSessionResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListSessions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsListVaultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsVault>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsVault))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPServerURLDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPServerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPServerDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsMCPServerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsURLMCPServerParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsMCPServerParamsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPServerURLDefinitionType), TypeInfoPropertyName = "BetaManagedAgentsMCPServerURLDefinitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPToolConfigParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPToolsetType), TypeInfoPropertyName = "BetaManagedAgentsMCPToolsetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfigParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMCPToolsetParamsType), TypeInfoPropertyName = "BetaManagedAgentsMCPToolsetParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedErrorType), TypeInfoPropertyName = "BetaManagedAgentsMcpAuthenticationFailedErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpConnectionFailedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpConnectionFailedErrorType), TypeInfoPropertyName = "BetaManagedAgentsMcpConnectionFailedErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthAuthResponseType), TypeInfoPropertyName = "BetaManagedAgentsMcpOauthAuthResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthCreateParamsType), TypeInfoPropertyName = "BetaManagedAgentsMcpOauthCreateParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth), TypeInfoPropertyName = "BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth), TypeInfoPropertyName = "BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth), TypeInfoPropertyName = "BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMcpOauthUpdateParamsType), TypeInfoPropertyName = "BetaManagedAgentsMcpOauthUpdateParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryType), TypeInfoPropertyName = "BetaManagedAgentsMemoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryPrefix))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsMemoryListItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryPathConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryPathConflictErrorType), TypeInfoPropertyName = "BetaManagedAgentsMemoryPathConflictErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedErrorType), TypeInfoPropertyName = "BetaManagedAgentsMemoryPreconditionFailedErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryPrefixType), TypeInfoPropertyName = "BetaManagedAgentsMemoryPrefixType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryStoreType), TypeInfoPropertyName = "BetaManagedAgentsMemoryStoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryStoreResourceType), TypeInfoPropertyName = "BetaManagedAgentsMemoryStoreResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMountMode), TypeInfoPropertyName = "BetaManagedAgentsMountMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryStoreResourceParamType), TypeInfoPropertyName = "BetaManagedAgentsMemoryStoreResourceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryVersionType), TypeInfoPropertyName = "BetaManagedAgentsMemoryVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryVersionOperation), TypeInfoPropertyName = "BetaManagedAgentsMemoryVersionOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsMemoryView), TypeInfoPropertyName = "BetaManagedAgentsMemoryView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsModel), TypeInfoPropertyName = "BetaManagedAgentsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSpeed), TypeInfoPropertyName = "BetaManagedAgentsSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsModelConfigParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsModelOverloadedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsModelOverloadedErrorType), TypeInfoPropertyName = "BetaManagedAgentsModelOverloadedErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsModelRateLimitedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsModelRateLimitedErrorType), TypeInfoPropertyName = "BetaManagedAgentsModelRateLimitedErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsModelRequestFailedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsModelRequestFailedErrorType), TypeInfoPropertyName = "BetaManagedAgentsModelRequestFailedErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsPermissionPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsPlainTextDocumentSourceType), TypeInfoPropertyName = "BetaManagedAgentsPlainTextDocumentSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsPlainTextDocumentSourceMediaType), TypeInfoPropertyName = "BetaManagedAgentsPlainTextDocumentSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsPrecondition), TypeInfoPropertyName = "BetaManagedAgentsPrecondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsPreconditionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsPreconditionDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsPreconditionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsRepositoryCheckoutDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRetryStatusRetrying))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRetryStatusExhausted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRetryStatusTerminal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRetryStatusDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRetryStatusDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsRetryStatusDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRetryStatusExhaustedType), TypeInfoPropertyName = "BetaManagedAgentsRetryStatusExhaustedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRetryStatusRetryingType), TypeInfoPropertyName = "BetaManagedAgentsRetryStatusRetryingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsRetryStatusTerminalType), TypeInfoPropertyName = "BetaManagedAgentsRetryStatusTerminalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSendSessionEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsInputEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSendSessionEventsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionType), TypeInfoPropertyName = "BetaManagedAgentsSessionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatus), TypeInfoPropertyName = "BetaManagedAgentsSessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionActorType), TypeInfoPropertyName = "BetaManagedAgentsSessionActorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionAgentType), TypeInfoPropertyName = "BetaManagedAgentsSessionAgentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionDeletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionDeletedEventType), TypeInfoPropertyName = "BetaManagedAgentsSessionDeletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionEndTurn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionEndTurnType), TypeInfoPropertyName = "BetaManagedAgentsSessionEndTurnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionErrorEventType), TypeInfoPropertyName = "BetaManagedAgentsSessionErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionErrorEventError), TypeInfoPropertyName = "BetaManagedAgentsSessionErrorEventError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUnknownError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsSessionErrorEventErrorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionEventDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsSessionEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionRequiresAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionRequiresActionType), TypeInfoPropertyName = "BetaManagedAgentsSessionRequiresActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionResourceDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsSessionResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsSessionResourceParamsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionRetriesExhausted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionRetriesExhaustedType), TypeInfoPropertyName = "BetaManagedAgentsSessionRetriesExhaustedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEventType), TypeInfoPropertyName = "BetaManagedAgentsSessionStatusIdleEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReason), TypeInfoPropertyName = "BetaManagedAgentsSessionStatusIdleEventStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEventType), TypeInfoPropertyName = "BetaManagedAgentsSessionStatusRescheduledEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusRunningEventType), TypeInfoPropertyName = "BetaManagedAgentsSessionStatusRunningEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEventType), TypeInfoPropertyName = "BetaManagedAgentsSessionStatusTerminatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSkillDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSkillDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsSkillDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSkillParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSkillParamsDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsSkillParamsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEventType), TypeInfoPropertyName = "BetaManagedAgentsSpanModelRequestEndEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSpanModelUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEventType), TypeInfoPropertyName = "BetaManagedAgentsSpanModelRequestStartEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsStaticBearerAuthResponseType), TypeInfoPropertyName = "BetaManagedAgentsStaticBearerAuthResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsStaticBearerCreateParamsType), TypeInfoPropertyName = "BetaManagedAgentsStaticBearerCreateParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsStaticBearerUpdateParamsType), TypeInfoPropertyName = "BetaManagedAgentsStaticBearerUpdateParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsStreamSessionEvents), TypeInfoPropertyName = "BetaManagedAgentsStreamSessionEvents2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsStreamSessionEventsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTextBlockType), TypeInfoPropertyName = "BetaManagedAgentsTextBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParamType), TypeInfoPropertyName = "BetaManagedAgentsTokenEndpointAuthBasicParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponseType), TypeInfoPropertyName = "BetaManagedAgentsTokenEndpointAuthBasicResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParamType), TypeInfoPropertyName = "BetaManagedAgentsTokenEndpointAuthBasicUpdateParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParamType), TypeInfoPropertyName = "BetaManagedAgentsTokenEndpointAuthNoneParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponseType), TypeInfoPropertyName = "BetaManagedAgentsTokenEndpointAuthNoneResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParamType), TypeInfoPropertyName = "BetaManagedAgentsTokenEndpointAuthPostParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponseType), TypeInfoPropertyName = "BetaManagedAgentsTokenEndpointAuthPostResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParamType), TypeInfoPropertyName = "BetaManagedAgentsTokenEndpointAuthPostUpdateParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsToolResultContentBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsURLDocumentSourceType), TypeInfoPropertyName = "BetaManagedAgentsURLDocumentSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsURLImageSourceType), TypeInfoPropertyName = "BetaManagedAgentsURLImageSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsURLMCPServerParamsType), TypeInfoPropertyName = "BetaManagedAgentsURLMCPServerParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUnknownErrorType), TypeInfoPropertyName = "BetaManagedAgentsUnknownErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateAgentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateCredentialRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateMemoryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateMemoryStoreRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse), TypeInfoPropertyName = "BetaManagedAgentsUpdateMemoryStoreResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateSessionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateSessionResource), TypeInfoPropertyName = "BetaManagedAgentsUpdateSessionResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsUpdateSessionResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateSessionResourceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUpdateVaultRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserActorType), TypeInfoPropertyName = "BetaManagedAgentsUserActorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserContentBlock), TypeInfoPropertyName = "BetaManagedAgentsUserContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsUserContentBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEventType), TypeInfoPropertyName = "BetaManagedAgentsUserCustomToolResultEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParamsType), TypeInfoPropertyName = "BetaManagedAgentsUserCustomToolResultEventParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserInterruptEventType), TypeInfoPropertyName = "BetaManagedAgentsUserInterruptEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserInterruptEventParamsType), TypeInfoPropertyName = "BetaManagedAgentsUserInterruptEventParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserMessageEventType), TypeInfoPropertyName = "BetaManagedAgentsUserMessageEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserMessageEventParamsType), TypeInfoPropertyName = "BetaManagedAgentsUserMessageEventParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEventType), TypeInfoPropertyName = "BetaManagedAgentsUserToolConfirmationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationResult), TypeInfoPropertyName = "BetaManagedAgentsUserToolConfirmationResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParamsType), TypeInfoPropertyName = "BetaManagedAgentsUserToolConfirmationEventParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsVaultType), TypeInfoPropertyName = "BetaManagedAgentsVaultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant114))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaMemoryTool20250818CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlock), TypeInfoPropertyName = "BetaContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaStopReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRefusalStopDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseContextManagement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageBatchProcessingStatus), TypeInfoPropertyName = "BetaMessageBatchProcessingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageBatchIndividualResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Result), TypeInfoPropertyName = "Result2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSucceededResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType), TypeInfoPropertyName = "BetaMessageBatchIndividualResponseResultDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageDeltaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaIterationsUsageVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaServerToolUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageIterationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageStopEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageStreamEvent), TypeInfoPropertyName = "BetaMessageStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageStreamEventDiscriminatorType), TypeInfoPropertyName = "BetaMessageStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaModelCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTokenTaskBudget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPlainTextSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPublicEnvironmentCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType), TypeInfoPropertyName = "BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPublicEnvironmentUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ConfigVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType), TypeInfoPropertyName = "BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRefusalStopDetailsCategory2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestAdvisorRedactedResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestAdvisorResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestAdvisorToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant115))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestAdvisorToolResultError, global::Anthropic.BetaRequestAdvisorResultBlock, global::Anthropic.BetaRequestAdvisorRedactedResultBlock>), TypeInfoPropertyName = "AnyOfBetaRequestAdvisorToolResultErrorBetaRequestAdvisorResultBlockBetaRequestAdvisorRedactedResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestAdvisorToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant116))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestBashCodeExecutionToolResultError, global::Anthropic.BetaRequestBashCodeExecutionResultBlock>), TypeInfoPropertyName = "AnyOfBetaRequestBashCodeExecutionToolResultErrorBetaRequestBashCodeExecutionResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCharLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCitationsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant117))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestCodeExecutionToolResultError, global::Anthropic.BetaRequestCodeExecutionResultBlock, global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock>), TypeInfoPropertyName = "BetaRequestEncryptedCodeExecutionResultBlock_ccea967330b7225d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCompactionBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant118))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestCompactionBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestContainerUploadBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant119))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestContainerUploadBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestContentBlockLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestDocumentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant120))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestDocumentBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source), TypeInfoPropertyName = "Source2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaURLPDFSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestDocumentBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType), TypeInfoPropertyName = "BetaRequestDocumentBlockSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant121))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestImageBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestImageBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestImageBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source2), TypeInfoPropertyName = "Source22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaURLImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestImageBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType), TypeInfoPropertyName = "BetaRequestImageBlockSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPServerToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant122))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestMCPToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant123))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestMCPToolUseBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestPageLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestRedactedThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestSearchResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant125))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestServerToolUseBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller), TypeInfoPropertyName = "Caller2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaServerToolCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaServerToolCaller20260120))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminatorType), TypeInfoPropertyName = "BetaRequestServerToolUseBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlockName), TypeInfoPropertyName = "BetaRequestServerToolUseBlockName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant126))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestTextBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsVariant1Item), TypeInfoPropertyName = "CitationsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant127))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock>), TypeInfoPropertyName = "BetaRequestTextEditorCodeExecutionStrReplaceResultBlock_a55442ede1c55cb3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditorCodeExecutionToolResultErrorCode), TypeInfoPropertyName = "BetaTextEditorCodeExecutionToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockFileType), TypeInfoPropertyName = "BetaRequestTextEditorCodeExecutionViewResultBlockFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolReferenceBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant128))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestToolReferenceBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant129))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>>), TypeInfoPropertyName = "AnyOfStringIListContentVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentVariant2Item), TypeInfoPropertyName = "ContentVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType), TypeInfoPropertyName = "BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant130))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestToolSearchToolResultError, global::Anthropic.BetaRequestToolSearchToolSearchResultBlock>), TypeInfoPropertyName = "AnyOfBetaRequestToolSearchToolResultErrorBetaRequestToolSearchToolSearchResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolSearchToolSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolResultErrorCode), TypeInfoPropertyName = "BetaToolSearchToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant131))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestToolUseBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller2), TypeInfoPropertyName = "Caller22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolUseBlockCallerDiscriminatorType), TypeInfoPropertyName = "BetaRequestToolUseBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant132))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller3), TypeInfoPropertyName = "Caller32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminatorType), TypeInfoPropertyName = "BetaRequestWebFetchToolResultBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestWebFetchToolResultError, global::Anthropic.BetaRequestWebFetchResultBlock>), TypeInfoPropertyName = "AnyOfBetaRequestWebFetchToolResultErrorBetaRequestWebFetchResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchToolResultErrorCode), TypeInfoPropertyName = "BetaWebFetchToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant133))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaRequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller4), TypeInfoPropertyName = "Caller42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminatorType), TypeInfoPropertyName = "BetaRequestWebSearchToolResultBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaRequestWebSearchToolResultError>), TypeInfoPropertyName = "AnyOfIListBetaRequestWebSearchResultBlockBetaRequestWebSearchToolResultError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchToolResultErrorCode), TypeInfoPropertyName = "BetaWebSearchToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseAdvisorRedactedResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseAdvisorResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseAdvisorToolResultError, global::Anthropic.BetaResponseAdvisorResultBlock, global::Anthropic.BetaResponseAdvisorRedactedResultBlock>), TypeInfoPropertyName = "AnyOfBetaResponseAdvisorToolResultErrorBetaResponseAdvisorResultBlockBetaResponseAdvisorRedactedResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseAdvisorToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseBashCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseBashCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseBashCodeExecutionToolResultError, global::Anthropic.BetaResponseBashCodeExecutionResultBlock>), TypeInfoPropertyName = "AnyOfBetaResponseBashCodeExecutionToolResultErrorBetaResponseBashCodeExecutionResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseBashCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCitationsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseClearThinking20251015Edit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseClearToolUses20250919Edit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaResponseCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseCodeExecutionToolResultError, global::Anthropic.BetaResponseCodeExecutionResultBlock, global::Anthropic.BetaResponseEncryptedCodeExecutionResultBlock>), TypeInfoPropertyName = "BetaResponseEncryptedCodeExecutionResultBlock_77cb3ad942bc7610")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseEncryptedCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.AppliedEditsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AppliedEditsItem), TypeInfoPropertyName = "AppliedEditsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType), TypeInfoPropertyName = "BetaResponseContextManagementAppliedEditDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseDocumentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source3), TypeInfoPropertyName = "Source32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseDocumentBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseDocumentBlockSourceDiscriminatorType), TypeInfoPropertyName = "BetaResponseDocumentBlockSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>>), TypeInfoPropertyName = "AnyOfStringIListBetaResponseTextBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller5), TypeInfoPropertyName = "Caller52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminatorType), TypeInfoPropertyName = "BetaResponseServerToolUseBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseServerToolUseBlockName), TypeInfoPropertyName = "BetaResponseServerToolUseBlockName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsVariant1Item2), TypeInfoPropertyName = "CitationsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError, global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock>), TypeInfoPropertyName = "BetaResponseTextEditorCodeExecutionStrReplaceResultBlock_2d5fb6ba63c18178")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockFileType), TypeInfoPropertyName = "BetaResponseTextEditorCodeExecutionViewResultBlockFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolReferenceBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseToolSearchToolResultError, global::Anthropic.BetaResponseToolSearchToolSearchResultBlock>), TypeInfoPropertyName = "AnyOfBetaResponseToolSearchToolResultErrorBetaResponseToolSearchToolSearchResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolSearchToolSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaResponseToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller6), TypeInfoPropertyName = "Caller62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolUseBlockCallerDiscriminatorType), TypeInfoPropertyName = "BetaResponseToolUseBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebFetchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller7), TypeInfoPropertyName = "Caller72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminatorType), TypeInfoPropertyName = "BetaResponseWebFetchToolResultBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebFetchToolResultError, global::Anthropic.BetaResponseWebFetchResultBlock>), TypeInfoPropertyName = "AnyOfBetaResponseWebFetchToolResultErrorBetaResponseWebFetchResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebFetchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller8), TypeInfoPropertyName = "Caller82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminatorType), TypeInfoPropertyName = "BetaResponseWebSearchToolResultBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>>), TypeInfoPropertyName = "AnyOfBetaResponseWebSearchToolResultErrorIListBetaResponseWebSearchResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSkillType), TypeInfoPropertyName = "BetaSkillType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSkillParamsType), TypeInfoPropertyName = "BetaSkillParamsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant134))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20241022CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20241022CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaTextEditor20241022CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant135))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250124CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaTextEditor20250124CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant136))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250429CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250429CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaTextEditor20250429CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant137))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250728CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250728CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaTextEditor20250728CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigAdaptive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingDisplayMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant138))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaToolCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceAuto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant139))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolBM2520251119Type), TypeInfoPropertyName = "BetaToolSearchToolBM2520251119Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant140))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolRegex20251119Type), TypeInfoPropertyName = "BetaToolSearchToolRegex20251119Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUpdateUserProfileRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUsageServiceTier2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUserProfileType), TypeInfoPropertyName = "BetaUserProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaUserProfileTrustGrant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUserProfileTrustGrant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUserProfileListOrder), TypeInfoPropertyName = "BetaUserProfileListOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUserProfileTrustGrantStatus), TypeInfoPropertyName = "BetaUserProfileTrustGrantStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant141))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaWebFetchTool20250910CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant142))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaWebFetchTool20260209CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant143))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaWebFetchTool20260309CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant144))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaWebSearchTool20250305CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant145))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "BetaWebSearchTool20260209CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BillingError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BodyCreateSkillV1SkillsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BodyCreateSkillVersionV1SkillsSkillIdVersionsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlEphemeralTtl), TypeInfoPropertyName = "CacheControlEphemeralTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CanceledResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CapabilitySupport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Citation2), TypeInfoPropertyName = "Citation22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCharLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponsePageLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseContentBlockLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsDeltaCitationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsDeltaCitationDiscriminatorType), TypeInfoPropertyName = "CitationsDeltaCitationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionToolResultErrorCode), TypeInfoPropertyName = "CodeExecutionToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250522))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant146))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250522CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250522CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "CodeExecutionTool20250522CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250825))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant147))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250825CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250825CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "CodeExecutionTool20250825CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20260120))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant148))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20260120CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20260120CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "CodeExecutionTool20260120CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Container2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Delta2), TypeInfoPropertyName = "Delta22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputJsonContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.SignatureContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType), TypeInfoPropertyName = "ContentBlockDeltaEventDeltaDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>>), TypeInfoPropertyName = "AnyOfStringIListContentContentBlockSourceContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentContentBlockSourceContentItem), TypeInfoPropertyName = "ContentContentBlockSourceContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestImageBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType), TypeInfoPropertyName = "ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlock2), TypeInfoPropertyName = "ContentBlock22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseRedactedThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseServerToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebFetchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseBashCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseContainerUploadBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockStartEventContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockStartEventContentBlockDiscriminatorType), TypeInfoPropertyName = "ContentBlockStartEventContentBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockStopEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContextManagementCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CountMessageTokensParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant149))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CountMessageTokensParamsCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CountMessageTokensParamsCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "CountMessageTokensParamsCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.InputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.OutputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>), TypeInfoPropertyName = "AnyOfStringIListRequestTextBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigParam), TypeInfoPropertyName = "ThinkingConfigParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoice), TypeInfoPropertyName = "ToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.MemoryTool20250818, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>>), TypeInfoPropertyName = "ToolSearchToolRegex20251119_3fcab28a27956080")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.MemoryTool20250818, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>), TypeInfoPropertyName = "ToolSearchToolRegex20251119_564eff8d1cb1fb31")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MemoryTool20250818))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250429))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250728))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchTool20250305))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20250910))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchTool20260209))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20260209))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20260309))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolBM2520251119))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolRegex20251119))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CountMessageTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageBatchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.MessageBatchIndividualRequestParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageBatchIndividualRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant150))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "CreateMessageParamsCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsServiceTier), TypeInfoPropertyName = "CreateMessageParamsServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.DeleteMessageBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.DeleteSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.DeleteSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.DirectCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.EffortCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.EffortLevel), TypeInfoPropertyName = "EffortLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Error2), TypeInfoPropertyName = "Error22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InvalidRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.PermissionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.NotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RateLimitError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.GatewayTimeoutError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.OverloadedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ErrorResponseErrorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ErrorResponseErrorDiscriminatorType), TypeInfoPropertyName = "ErrorResponseErrorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ErrorType), TypeInfoPropertyName = "ErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ErroredResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ExpiredResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.FileDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.FileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.FileMetadataSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.FileMetadataSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.GetSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.GetSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>>), TypeInfoPropertyName = "AnyOfStringIListInputContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputContentBlock), TypeInfoPropertyName = "InputContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputMessageRole), TypeInfoPropertyName = "InputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.JsonOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ListResponseMessageBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.MessageBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ListResponseModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ListSkillVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.SkillVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.SkillVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ListSkillsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.Skill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Skill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant151))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MemoryTool20250818CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MemoryTool20250818CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "MemoryTool20250818CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ContentBlock3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlock3), TypeInfoPropertyName = "ContentBlock32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.StopReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RefusalStopDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageBatchProcessingStatus), TypeInfoPropertyName = "MessageBatchProcessingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageBatchIndividualResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Result2), TypeInfoPropertyName = "Result22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.SucceededResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageBatchIndividualResponseResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType), TypeInfoPropertyName = "MessageBatchIndividualResponseResultDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageDeltaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ServerToolUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageStopEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageStreamEvent), TypeInfoPropertyName = "MessageStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Ping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageStreamEventDiscriminatorType), TypeInfoPropertyName = "MessageStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ModelCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.PlainTextSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RefusalStopDetailsCategory2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.RequestBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant152))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.RequestBashCodeExecutionToolResultError, global::Anthropic.RequestBashCodeExecutionResultBlock>), TypeInfoPropertyName = "AnyOfRequestBashCodeExecutionToolResultErrorRequestBashCodeExecutionResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCharLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCitationsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.RequestCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant153))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.RequestCodeExecutionToolResultError, global::Anthropic.RequestCodeExecutionResultBlock, global::Anthropic.RequestEncryptedCodeExecutionResultBlock>), TypeInfoPropertyName = "AnyOfRequestCodeExecutionToolResultErrorRequestCodeExecutionResultBlockRequestEncryptedCodeExecutionResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestEncryptedCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestContainerUploadBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant154))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestContainerUploadBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestContainerUploadBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestContainerUploadBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestContentBlockLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestDocumentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant155))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestDocumentBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestDocumentBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestDocumentBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source4), TypeInfoPropertyName = "Source42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.URLPDFSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestDocumentBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestDocumentBlockSourceDiscriminatorType), TypeInfoPropertyName = "RequestDocumentBlockSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant156))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestImageBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestImageBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestImageBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source5), TypeInfoPropertyName = "Source52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.URLImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestImageBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestImageBlockSourceDiscriminatorType), TypeInfoPropertyName = "RequestImageBlockSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestPageLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestRedactedThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant157))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestSearchResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestSearchResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestSearchResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant158))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestServerToolUseBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller9), TypeInfoPropertyName = "Caller92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ServerToolCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ServerToolCaller20260120))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlockCallerDiscriminatorType), TypeInfoPropertyName = "RequestServerToolUseBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlockName), TypeInfoPropertyName = "RequestServerToolUseBlockName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant159))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestTextBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsVariant1Item3), TypeInfoPropertyName = "CitationsVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "RequestTextBlockCitationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant160))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.RequestTextEditorCodeExecutionToolResultError, global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock>), TypeInfoPropertyName = "RequestTextEditorCodeExecutionStrReplaceResultBlock_3711f29b52a9f3bf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditorCodeExecutionToolResultErrorCode), TypeInfoPropertyName = "TextEditorCodeExecutionToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionViewResultBlockFileType), TypeInfoPropertyName = "RequestTextEditorCodeExecutionViewResultBlockFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolReferenceBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant161))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolReferenceBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolReferenceBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestToolReferenceBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant162))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>>), TypeInfoPropertyName = "AnyOfStringIListContentVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentVariant2Item2), TypeInfoPropertyName = "ContentVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType), TypeInfoPropertyName = "RequestToolResultBlockContentVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant163))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.RequestToolSearchToolResultError, global::Anthropic.RequestToolSearchToolSearchResultBlock>), TypeInfoPropertyName = "AnyOfRequestToolSearchToolResultErrorRequestToolSearchToolSearchResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolSearchToolSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolResultErrorCode), TypeInfoPropertyName = "ToolSearchToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.RequestToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant164))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolUseBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolUseBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestToolUseBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller10), TypeInfoPropertyName = "Caller102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolUseBlockCallerDiscriminatorType), TypeInfoPropertyName = "RequestToolUseBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant165))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller11), TypeInfoPropertyName = "Caller112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminatorType), TypeInfoPropertyName = "RequestWebFetchToolResultBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.RequestWebFetchToolResultError, global::Anthropic.RequestWebFetchResultBlock>), TypeInfoPropertyName = "AnyOfRequestWebFetchToolResultErrorRequestWebFetchResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchToolResultErrorCode), TypeInfoPropertyName = "WebFetchToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant166))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "RequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller12), TypeInfoPropertyName = "Caller122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminatorType), TypeInfoPropertyName = "RequestWebSearchToolResultBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.RequestWebSearchToolResultError>), TypeInfoPropertyName = "AnyOfIListRequestWebSearchResultBlockRequestWebSearchToolResultError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchToolResultErrorCode), TypeInfoPropertyName = "WebSearchToolResultErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseBashCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseBashCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ResponseBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseBashCodeExecutionToolResultError, global::Anthropic.ResponseBashCodeExecutionResultBlock>), TypeInfoPropertyName = "AnyOfResponseBashCodeExecutionToolResultErrorResponseBashCodeExecutionResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseBashCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCitationsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ResponseCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseCodeExecutionToolResultError, global::Anthropic.ResponseCodeExecutionResultBlock, global::Anthropic.ResponseEncryptedCodeExecutionResultBlock>), TypeInfoPropertyName = "AnyOfResponseCodeExecutionToolResultErrorResponseCodeExecutionResultBlockResponseEncryptedCodeExecutionResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseEncryptedCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseDocumentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source6), TypeInfoPropertyName = "Source62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseDocumentBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseDocumentBlockSourceDiscriminatorType), TypeInfoPropertyName = "ResponseDocumentBlockSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller13), TypeInfoPropertyName = "Caller132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType), TypeInfoPropertyName = "ResponseServerToolUseBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseServerToolUseBlockName), TypeInfoPropertyName = "ResponseServerToolUseBlockName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsVariant1Item4), TypeInfoPropertyName = "CitationsVariant1Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "ResponseTextBlockCitationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseTextEditorCodeExecutionToolResultError, global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock>), TypeInfoPropertyName = "ResponseTextEditorCodeExecutionStrReplaceResultBlock_0520d2c6f22ae164")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlockFileType), TypeInfoPropertyName = "ResponseTextEditorCodeExecutionViewResultBlockFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolReferenceBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>), TypeInfoPropertyName = "AnyOfResponseToolSearchToolResultErrorResponseToolSearchToolSearchResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolSearchToolSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ResponseToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller14), TypeInfoPropertyName = "Caller142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolUseBlockCallerDiscriminatorType), TypeInfoPropertyName = "ResponseToolUseBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebFetchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller15), TypeInfoPropertyName = "Caller152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminatorType), TypeInfoPropertyName = "ResponseWebFetchToolResultBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseWebFetchToolResultError, global::Anthropic.ResponseWebFetchResultBlock>), TypeInfoPropertyName = "AnyOfResponseWebFetchToolResultErrorResponseWebFetchResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebFetchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller16), TypeInfoPropertyName = "Caller162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminatorType), TypeInfoPropertyName = "ResponseWebSearchToolResultBlockCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>>), TypeInfoPropertyName = "AnyOfResponseWebSearchToolResultErrorIListResponseWebSearchResultBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant167))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250124CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "TextEditor20250124CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant168))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250429CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250429CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "TextEditor20250429CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant169))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250728CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250728CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "TextEditor20250728CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigAdaptive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingDisplayMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant170))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "ToolCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceAuto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant171))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "ToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolBM2520251119Type), TypeInfoPropertyName = "ToolSearchToolBM2520251119Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant172))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "ToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolRegex20251119Type), TypeInfoPropertyName = "ToolSearchToolRegex20251119Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.UsageServiceTier2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.UserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant173))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20250910CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20250910CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "WebFetchTool20250910CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant174))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20260209CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20260209CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "WebFetchTool20260209CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant175))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20260309CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20260309CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "WebFetchTool20260309CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant176))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchTool20250305CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchTool20250305CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "WebSearchTool20250305CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant177))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchTool20260209CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchTool20260209CacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "WebSearchTool20260209CacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsConflictErrorType), TypeInfoPropertyName = "BetaManagedAgentsConflictErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsErrorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaManagedAgentsErrorDiscriminatorType), TypeInfoPropertyName = "BetaManagedAgentsErrorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsWithoutStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant178))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsWithoutStreamCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsWithoutStreamCacheControlVariant1DiscriminatorType), TypeInfoPropertyName = "CreateMessageParamsWithoutStreamCacheControlVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsWithoutStreamServiceTier), TypeInfoPropertyName = "CreateMessageParamsWithoutStreamServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnthropicBeta), TypeInfoPropertyName = "AnthropicBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnthropicBetaEnum), TypeInfoPropertyName = "AnthropicBetaEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigParamDiscriminatorType), TypeInfoPropertyName = "ThinkingConfigParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigParamDiscriminatorType), TypeInfoPropertyName = "BetaThinkingConfigParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceDiscriminatorType), TypeInfoPropertyName = "ToolChoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceDiscriminatorType), TypeInfoPropertyName = "BetaToolChoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockDiscriminatorType), TypeInfoPropertyName = "ContentBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputContentBlockDiscriminatorType), TypeInfoPropertyName = "InputContentBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockDiscriminatorType), TypeInfoPropertyName = "BetaContentBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputContentBlockDiscriminatorType), TypeInfoPropertyName = "BetaInputContentBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818ViewCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818ViewCommandCommand), TypeInfoPropertyName = "BetaMemoryTool20250818ViewCommandCommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CreateCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CreateCommandCommand), TypeInfoPropertyName = "BetaMemoryTool20250818CreateCommandCommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818StrReplaceCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand), TypeInfoPropertyName = "BetaMemoryTool20250818StrReplaceCommandCommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818InsertCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818InsertCommandCommand), TypeInfoPropertyName = "BetaMemoryTool20250818InsertCommandCommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818DeleteCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand), TypeInfoPropertyName = "BetaMemoryTool20250818DeleteCommandCommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818RenameCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818RenameCommandCommand), TypeInfoPropertyName = "BetaMemoryTool20250818RenameCommandCommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818Command), TypeInfoPropertyName = "BetaMemoryTool20250818Command2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CommandDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand), TypeInfoPropertyName = "BetaMemoryTool20250818CommandDiscriminatorCommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaIterationsUsageVariant1Item), TypeInfoPropertyName = "BetaIterationsUsageVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaIterationsUsageItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaIterationsUsageItemsDiscriminatorType), TypeInfoPropertyName = "BetaIterationsUsageItemsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.PingType), TypeInfoPropertyName = "PingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.UploadFileV1FilesPostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUploadFileV1FilesPostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.AllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaAllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaSkillParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBetaContentBlockSourceContentItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.ContentBetaContentBlockSourceContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.EditsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaRequestMCPServerURLDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaInputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaRequestTextBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaRequestTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.OneOf<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaAdvisorTool20260301, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>>), TypeInfoPropertyName = "BetaMCPToolset_76a0de788be47fdb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatchIndividualRequestParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaEnvironment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaFileMetadataSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaInputContentBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaInputContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaSkillVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaapiSchemasSkillsSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaUserProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsToolResultContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolConfigParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPServerParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSkillParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResourceParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsCredential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsVault>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPToolConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsInputEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsEventParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsUserContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaIterationsUsageVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaRequestCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaRequestToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaRequestWebSearchToolResultError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaRequestWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaResponseCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.AppliedEditsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaResponseTextBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaResponseTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaResponseToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.BetaResponseWebSearchResultBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaResponseWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentContentBlockSourceContentItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.ContentContentBlockSourceContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.InputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.RequestTextBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.RequestTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.MemoryTool20250818, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>>), TypeInfoPropertyName = "ToolSearchToolRegex20251119_7c0ca429a2c0a25b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.MessageBatchIndividualRequestParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.FileMetadataSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.InputContentBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.InputContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.MessageBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.SkillVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.Skill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.ContentBlock3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.RequestBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.RequestCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.RequestToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.RequestWebSearchToolResultError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.ResponseBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.ResponseCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.ResponseToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseWebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}