
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

            typeof(global::Anthropic.JsonConverters.BetaErrorResponseErrorDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaErrorResponseErrorDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaErrorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaErrorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaInputMessageRoleJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaInputMessageRoleNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMCPToolsetCacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMCPToolsetCacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CacheControlVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CacheControlVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageBatchProcessingStatusJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageBatchProcessingStatusNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageBatchIndividualResponseResultDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageBatchIndividualResponseResultDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageStreamEventDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageStreamEventDiscriminatorTypeNullableJsonConverter),

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

            typeof(global::Anthropic.JsonConverters.BetaIterationsUsageVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaIterationsUsageVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.PingTypeJsonConverter),

            typeof(global::Anthropic.JsonConverters.PingTypeNullableJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant1JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant12JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant13JsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationJsonConverter),

            typeof(global::Anthropic.JsonConverters.KeepVariant1JsonConverter),

            typeof(global::Anthropic.JsonConverters.TriggerJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant14JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant15JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant16JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant17JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant18JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant19JsonConverter),

            typeof(global::Anthropic.JsonConverters.DeltaJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBetaContentBlockSourceContentItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlockJsonConverter),

            typeof(global::Anthropic.JsonConverters.EditsItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant110JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant111JsonConverter),

            typeof(global::Anthropic.JsonConverters.ErrorJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant112JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant113JsonConverter),

            typeof(global::Anthropic.JsonConverters.ResultJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaMessageStreamEventJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant114JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant115JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant116JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant117JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant118JsonConverter),

            typeof(global::Anthropic.JsonConverters.SourceJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant119JsonConverter),

            typeof(global::Anthropic.JsonConverters.Source2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant120JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant121JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant122JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant123JsonConverter),

            typeof(global::Anthropic.JsonConverters.CallerJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant124JsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationsVariant1ItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant125JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant126JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant127JsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentVariant2ItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant128JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant129JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant130JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller3JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant131JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller4JsonConverter),

            typeof(global::Anthropic.JsonConverters.AppliedEditsItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.Source3JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller5JsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationsVariant1Item2JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller6JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller7JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller8JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant132JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant133JsonConverter),

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

            typeof(global::Anthropic.JsonConverters.Citation2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant144JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant145JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant146JsonConverter),

            typeof(global::Anthropic.JsonConverters.Delta2JsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentContentBlockSourceContentItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentBlock2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant147JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant148JsonConverter),

            typeof(global::Anthropic.JsonConverters.Error2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant149JsonConverter),

            typeof(global::Anthropic.JsonConverters.Result2JsonConverter),

            typeof(global::Anthropic.JsonConverters.MessageStreamEventJsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant150JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant151JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant152JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant153JsonConverter),

            typeof(global::Anthropic.JsonConverters.Source4JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant154JsonConverter),

            typeof(global::Anthropic.JsonConverters.Source5JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant155JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant156JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller9JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant157JsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationsVariant1Item3JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant158JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant159JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant160JsonConverter),

            typeof(global::Anthropic.JsonConverters.ContentVariant2Item2JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant161JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant162JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller10JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant163JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller11JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant164JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller12JsonConverter),

            typeof(global::Anthropic.JsonConverters.Source6JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller13JsonConverter),

            typeof(global::Anthropic.JsonConverters.CitationsVariant1Item4JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller14JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller15JsonConverter),

            typeof(global::Anthropic.JsonConverters.Caller16JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant165JsonConverter),

            typeof(global::Anthropic.JsonConverters.CacheControlVariant166JsonConverter),

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

            typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CommandJsonConverter),

            typeof(global::Anthropic.JsonConverters.BetaIterationsUsageVariant1ItemJsonConverter),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.KeepVariant1?, string>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>),

            typeof(global::Anthropic.JsonConverters.OneOfJsonConverter<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaContainerParams, string, object>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>),

            typeof(global::Anthropic.JsonConverters.OneOfJsonConverter<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestBashCodeExecutionToolResultError, global::Anthropic.BetaRequestBashCodeExecutionResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestCodeExecutionToolResultError, global::Anthropic.BetaRequestCodeExecutionResultBlock, global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestToolSearchToolResultError, global::Anthropic.BetaRequestToolSearchToolSearchResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestWebFetchToolResultError, global::Anthropic.BetaRequestWebFetchResultBlock>),

            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaRequestWebSearchToolResultError>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AllowedCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AuthenticationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Base64ImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Base64ImageSourceMediaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Base64PDFSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BashCodeExecutionToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BashTool20250124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.AllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlEphemeral))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BashTool20250124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BashTool20250124CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAPIError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAllThinkingTurns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAllowedCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaAuthenticationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBase64ImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBase64ImageSourceMediaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBase64PDFSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashCodeExecutionToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20241022))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCacheControlEphemeral))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20241022CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20241022CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20250124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20250124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBashTool20250124CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBillingError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBodyCreateSkillV1SkillsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaBodyCreateSkillVersionV1SkillsSkillIdVersionsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCacheControlEphemeralTtl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCanceledResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCapabilitySupport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCitationsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Citation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCharLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponsePageLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseContentBlockLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCitationsDeltaCitationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCitationsDeltaCitationDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearThinking20251015))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.KeepVariant1?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.KeepVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingTurns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearThinking20251015KeepVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearThinking20251015KeepVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearToolUses20250919))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputTokensClearAtLeast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.IList<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolUsesKeep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearToolUses20250919KeepDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearToolUses20250919KeepDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Trigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputTokensTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolUsesTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearToolUses20250919TriggerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaClearToolUses20250919TriggerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250522))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250825))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20260120))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCompact20260112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCompactionContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCompactionIterationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20241022))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20250124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20251124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContainer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContainerParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaSkillParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSkillParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputJsonContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSignatureContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBetaContentBlockSourceContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestImageBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseRedactedThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseServerToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebFetchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseMCPToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseMCPToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseContainerUploadBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCompactionBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockStopEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContextManagementCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContextManagementConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.EditsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.EditsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContextManagementConfigEditDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContextManagementConfigEditDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContextManagementResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCountMessageTokensParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant110))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestMCPServerURLDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPServerURLDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaInputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaOutputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaJsonOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSpeed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.OneOf<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.OneOf<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant111))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateMessageParamsCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateMessageParamsCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaContainerParams, string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateMessageParamsServiceTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaCreateSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaDeleteMessageBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaDeleteSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaDeleteSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaDirectCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEffortCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaEffortLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInvalidRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPermissionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRateLimitError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaGatewayTimeoutError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaOverloadedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaErrorResponseErrorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaErrorResponseErrorDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaErrorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaErroredResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaExpiredResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileDocumentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaFileMetadataSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaFileMetadataSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaGetSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaGetSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputContentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputMessageRole))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMCPToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMCPToolDefaultConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMCPToolsetCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMCPToolsetCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaMCPToolConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant113))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaStopReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseContextManagement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageBatchProcessingStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageBatchIndividualResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSucceededResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageDeltaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaIterationsUsageVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaServerToolUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageIterationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageStopEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMessageStreamEventDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaModelCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaPlainTextSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant114))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestBashCodeExecutionToolResultError, global::Anthropic.BetaRequestBashCodeExecutionResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestBashCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCharLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCitationsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant115))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestCodeExecutionToolResultError, global::Anthropic.BetaRequestCodeExecutionResultBlock, global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCompactionBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant116))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestContainerUploadBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant117))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestContentBlockLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestDocumentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant118))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaURLPDFSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestDocumentBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant119))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestImageBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestImageBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaURLImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestImageBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPServerToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant120))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant121))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestPageLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestRedactedThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant122))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant123))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaServerToolCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaServerToolCaller20260120))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestServerToolUseBlockName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant124))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant125))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditorCodeExecutionToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockFileType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolReferenceBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant126))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant127))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant128))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestToolSearchToolResultError, global::Anthropic.BetaRequestToolSearchToolSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolSearchToolSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant129))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestToolUseBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant130))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestWebFetchToolResultError, global::Anthropic.BetaRequestWebFetchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebFetchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant131))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaRequestWebSearchToolResultError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaRequestWebSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseBashCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseBashCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseBashCodeExecutionToolResultError, global::Anthropic.BetaResponseBashCodeExecutionResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseBashCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCitationsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseClearThinking20251015Edit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseClearToolUses20250919Edit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaResponseCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseCodeExecutionToolResultError, global::Anthropic.BetaResponseCodeExecutionResultBlock, global::Anthropic.BetaResponseEncryptedCodeExecutionResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseEncryptedCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.AppliedEditsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AppliedEditsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseDocumentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseDocumentBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseDocumentBlockSourceDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseServerToolUseBlockName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsVariant1Item2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError, global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockFileType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolReferenceBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseToolSearchToolResultError, global::Anthropic.BetaResponseToolSearchToolSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolSearchToolSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaResponseToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseToolUseBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebFetchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebFetchToolResultError, global::Anthropic.BetaResponseWebFetchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebFetchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaResponseWebSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSkillType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaSkillParamsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant132))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20241022CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20241022CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant133))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250124CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant134))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250429CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250429CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant135))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250728CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaTextEditor20250728CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigAdaptive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingDisplayMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant136))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceAuto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant137))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolBM2520251119Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant138))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolSearchToolRegex20251119Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUsageServiceTier2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant139))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant140))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant141))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant142))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant143))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BillingError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BodyCreateSkillV1SkillsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BodyCreateSkillVersionV1SkillsSkillIdVersionsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlEphemeralTtl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CanceledResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CapabilitySupport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Citation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCharLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponsePageLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseContentBlockLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsDeltaCitationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsDeltaCitationDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250522))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant144))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250522CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250522CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250825))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant145))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250825CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20250825CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20260120))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant146))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20260120CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CodeExecutionTool20260120CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Container2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Delta2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputJsonContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.SignatureContentBlockDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentContentBlockSourceContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestImageBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlock2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockStartEventContentBlockDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockStopEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContextManagementCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CountMessageTokensParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant147))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CountMessageTokensParamsCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CountMessageTokensParamsCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.InputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.OutputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.MemoryTool20250818, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.MemoryTool20250818, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant148))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsServiceTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.DeleteMessageBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.DeleteSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.DeleteSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.DirectCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.EffortCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.EffortLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Error2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InvalidRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.PermissionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.NotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RateLimitError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.GatewayTimeoutError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.OverloadedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ErrorResponseErrorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ErrorResponseErrorDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ErrorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ErroredResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ExpiredResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.FileDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.FileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.FileMetadataSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.FileMetadataSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.GetSkillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.GetSkillVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputContentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputMessageRole))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant149))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MemoryTool20250818CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MemoryTool20250818CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ContentBlock3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlock3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.StopReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageBatchProcessingStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageBatchIndividualResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Result2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.SucceededResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageBatchIndividualResponseResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageDeltaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ServerToolUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageStopEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Ping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.MessageStreamEventDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ModelCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.PlainTextSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.RequestBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant150))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.RequestBashCodeExecutionToolResultError, global::Anthropic.RequestBashCodeExecutionResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestBashCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCharLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCitationsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.RequestCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant151))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.RequestCodeExecutionToolResultError, global::Anthropic.RequestCodeExecutionResultBlock, global::Anthropic.RequestEncryptedCodeExecutionResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestEncryptedCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestContainerUploadBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant152))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestContainerUploadBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestContainerUploadBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestContentBlockLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestDocumentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant153))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestDocumentBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestDocumentBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.URLPDFSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestDocumentBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestDocumentBlockSourceDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant154))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestImageBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestImageBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.URLImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestImageBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestImageBlockSourceDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestPageLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestRedactedThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant155))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestSearchResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestSearchResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant156))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ServerToolCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ServerToolCaller20260120))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestServerToolUseBlockName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant157))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsVariant1Item3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchResultLocationCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant158))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.RequestTextEditorCodeExecutionToolResultError, global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditorCodeExecutionToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestTextEditorCodeExecutionViewResultBlockFileType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestThinkingBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolReferenceBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant159))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolReferenceBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolReferenceBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant160))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentVariant2Item2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant161))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.RequestToolSearchToolResultError, global::Anthropic.RequestToolSearchToolSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolSearchToolSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.RequestToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolUseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant162))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolUseBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolUseBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestToolUseBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant163))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.RequestWebFetchToolResultError, global::Anthropic.RequestWebFetchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebFetchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant164))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.RequestWebSearchToolResultError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.RequestWebSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchToolResultErrorCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseBashCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseBashCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ResponseBashCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseBashCodeExecutionToolResultError, global::Anthropic.ResponseBashCodeExecutionResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseBashCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCitationsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCodeExecutionOutputBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ResponseCodeExecutionOutputBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseCodeExecutionToolResultError, global::Anthropic.ResponseCodeExecutionResultBlock, global::Anthropic.ResponseEncryptedCodeExecutionResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseEncryptedCodeExecutionResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseDocumentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Source6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseDocumentBlockSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseDocumentBlockSourceDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseServerToolUseBlockName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CitationsVariant1Item4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseTextEditorCodeExecutionToolResultError, global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlockFileType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolReferenceBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolSearchToolSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ResponseToolReferenceBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolUseBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseToolUseBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebFetchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseWebFetchToolResultError, global::Anthropic.ResponseWebFetchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebFetchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.Caller16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ResponseWebSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant165))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250124CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250124CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant166))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250429CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250429CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant167))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250728CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.TextEditor20250728CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigAdaptive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingDisplayMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant168))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceAuto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant169))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolBM2520251119Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant170))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolSearchToolRegex20251119Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.UsageServiceTier2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.UserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant171))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20250910CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20250910CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant172))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20260209CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20260209CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant173))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20260309CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebFetchTool20260309CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant174))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchTool20250305CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchTool20250305CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant175))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchTool20260209CacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.WebSearchTool20260209CacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsWithoutStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CacheControlVariant176))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsWithoutStreamCacheControlVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsWithoutStreamCacheControlVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.CreateMessageParamsWithoutStreamServiceTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnthropicBeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnthropicBetaEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ThinkingConfigParamDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaThinkingConfigParamDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ToolChoiceDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaToolChoiceDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.ContentBlockDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.InputContentBlockDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaContentBlockDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaInputContentBlockDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818ViewCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818ViewCommandCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CreateCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CreateCommandCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818StrReplaceCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818InsertCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818InsertCommandCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818DeleteCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818RenameCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818RenameCommandCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818Command))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CommandDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaIterationsUsageVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaIterationsUsageVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.BetaIterationsUsageVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.PingType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.OneOf<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatchIndividualRequestParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaFileMetadataSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaInputContentBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaInputContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaSkillVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.BetaapiSchemasSkillsSkill>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.MemoryTool20250818, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>>))]
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