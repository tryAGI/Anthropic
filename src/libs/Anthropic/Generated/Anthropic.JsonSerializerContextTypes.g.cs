
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.APIError? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AllowedCaller? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AuthenticationError? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AvailableToolsLimitExceededErrorDetails? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Base64ImageSource? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Base64ImageSourceMediaType? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Base64PDFSource? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashCodeExecutionToolResultErrorCode? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashTool20250124? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AllowedCaller>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant1? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlEphemeral? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashTool20250124CacheControlVariant1Discriminator? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashTool20250124CacheControlVariant1DiscriminatorType? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JsonValue? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAPIError? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorMessageIterationUsage? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheCreation? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Model? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorToolResultErrorCode? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedCaller>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllowedCaller? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant12? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheControlEphemeral? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1Discriminator? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CachingVariant1? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CachingVariant1Discriminator? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CachingVariant1DiscriminatorType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllThinkingTurns? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAuthenticationError? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAvailableToolsLimitExceededErrorDetails? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBase64ImageSource? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBase64ImageSourceMediaType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBase64PDFSource? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashCodeExecutionToolResultErrorCode? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20241022? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant13? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20241022CacheControlVariant1Discriminator? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20241022CacheControlVariant1DiscriminatorType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJsonValue? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20250124? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant14? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20250124CacheControlVariant1Discriminator? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20250124CacheControlVariant1DiscriminatorType? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBillingError? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBodyCreateSkillV1SkillsPost? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBodyCreateSkillVersionV1SkillsSkillIdVersionsPost? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTarget? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCoordinateTarget? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRefTarget? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTargetDiscriminator? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTargetDiscriminatorType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCloseTabConfig? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCloseTabInput? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserDoubleClickConfig? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserDoubleClickInput? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFileUploadConfig? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFileUploadInput? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFindConfig? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFindInput? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputConfig? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputInput? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputValue? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserGetPageTextConfig? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserGetPageTextInput? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoldKeyConfig? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoldKeyInput? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoverConfig? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoverInput? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserJavascriptExecConfig? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserJavascriptExecInput? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserKeyConfig? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserKeyInput? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickConfig? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickDragConfig? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickDragInput? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickInput? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseDownConfig? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseDownInput? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseUpConfig? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseUpInput? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserListTabsConfig? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserListTabsInput? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMemberInput? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNavigateInput? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNewTabInput? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserSwitchTabInput? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageInput? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadConsoleInput? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadNetworkInput? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollToInput? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScreenshotInput? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserZoomInput? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRightClickInput? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMiddleClickInput? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTripleClickInput? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMouseMoveInput? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollInput? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTypeInput? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserWaitInput? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMiddleClickConfig? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMouseMoveConfig? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNavigateConfig? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNewTabConfig? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadConsoleConfig? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadNetworkConfig? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageConfig? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageFilter? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRightClickConfig? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScreenshotConfig? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollConfig? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollDirection? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollToConfig? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadCompleted? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadFailed? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadStarted? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeTabOpened? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateTabEntry? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserSwitchTabConfig? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolsetConfigs? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTripleClickConfig? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTypeConfig? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserWaitConfig? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserZoomConfig? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant15? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801CacheControlVariant1Discriminator? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801CacheControlVariant1DiscriminatorType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheControlEphemeralTtl? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissMessagesChanged? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissModelChanged? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissPreviousMessageNotFound? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReason? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissSystemChanged? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissToolsChanged? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissUnavailable? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReasonDiscriminator? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReasonDiscriminatorType? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCanceledResult? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCapabilitySupport? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDelta? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Citation? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCharLocationCitation? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponsePageLocationCitation? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContentBlockLocationCitation? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchResultLocationCitation? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseSearchResultLocationCitation? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDeltaCitationDiscriminator? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDeltaCitationDiscriminatorType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeVersionTooOldErrorDetails? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearThinking20251015? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.OneOf<global::Anthropic.BetaThinkingTurns, global::Anthropic.BetaAllThinkingTurns>?, string>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaThinkingTurns, global::Anthropic.BetaAllThinkingTurns>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingTurns? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTokensClearAtLeast? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUsesKeep? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919KeepDiscriminator? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919KeepDiscriminatorType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Trigger? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTokensTrigger? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUsesTrigger? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919TriggerDiscriminator? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919TriggerDiscriminatorType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClientToolUnion? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTool? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfig? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Networking? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnrestrictedNetwork? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLimitedNetwork? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigNetworkingDiscriminator? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigNetworkingDiscriminatorType? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPackages? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParams? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NetworkingVariant1? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLimitedNetworkParams? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParamsNetworkingVariant1Discriminator? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParamsNetworkingVariant1DiscriminatorType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPackagesParams? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekContextUnavailableErrorDetails? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyDisabledErrorDetails? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyUnreachableErrorDetails? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionToolResultErrorCode? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant16? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1Discriminator? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1DiscriminatorType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant17? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1Discriminator? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1DiscriminatorType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant18? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1Discriminator? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1DiscriminatorType? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant19? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521CacheControlVariant1Discriminator? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521CacheControlVariant1DiscriminatorType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompact20260112? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionBlockMisplacedErrorDetails? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionCapability? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfig? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSummarizeCompaction? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfigDiscriminator? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfigDiscriminatorType? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionContentBlockDelta? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionContentMismatchErrorDetails? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionIncompleteTurnErrorDetails? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionIterationUsage? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionSignatureInvalidErrorDetails? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionTooManyToolReferencesErrorDetails? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionUnavailableErrorDetails? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionConfig? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionInput? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickConfig? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickInput? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyConfig? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyInput? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyConfig? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyInput? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickConfig? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragConfig? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragInput? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickInput? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownConfig? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownInput? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpConfig? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpInput? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMemberInput? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeInput? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveInput? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickInput? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickInput? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickInput? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollInput? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitInput? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotInput? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomInput? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickConfig? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveConfig? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickConfig? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotConfig? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollConfig? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollDirection? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolsetConfigs? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickConfig? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeConfig? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitConfig? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomConfig? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant110? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801CacheControlVariant1Discriminator? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801CacheControlVariant1DiscriminatorType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant111? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1Discriminator? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1DiscriminatorType? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant112? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1Discriminator? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant113? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1Discriminator? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1DiscriminatorType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainer? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaContainerSkill>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerSkill? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerParams? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillParams>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillParams? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerSkillType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEvent? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Delta? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextContentBlockDelta? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputJsonContentBlockDelta? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingContentBlockDelta? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignatureContentBlockDelta? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSource? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBetaContentBlockSourceContentItem? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlock? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlock? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminator? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEvent? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlock? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseThinkingBlock? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseRedactedThinkingBlock? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlock? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlock? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlock? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlock? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorToolResultBlock? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionToolResultBlock? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolResultBlock? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolUseBlock? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolResultBlock? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContainerUploadBlock? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlock? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseFallbackBlock? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolListingBlock? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminator? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStopEvent? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementCapability? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfig? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.EditsItem>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EditsItem? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminator? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminatorType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementResponse? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParams? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant114? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1Discriminator? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1DiscriminatorType? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestMCPServerURLDefinition>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPServerURLDefinition? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputMessage>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessage? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputConfig? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJsonOutputFormat? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpeed? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParam? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoice? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolset? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateDreamRequest? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInput? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelParams? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehavior? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageBatchParams? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatchIndividualRequestParams>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualRequestParams? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParams? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant115? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsCacheControlVariant1Discriminator? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsCacheControlVariant1DiscriminatorType? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaContainerParams, string>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDiagnosticsParam? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::Anthropic.BetaFallbackCreditTokenParam>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditTokenParam? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaFallbackConfigV2>, string>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFallbackConfigV2>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMetadata? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsServiceTier? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaToolUnion>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUnion? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTelemetryDestinationRequest? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTracesParams? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParams? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelCertificateRequestBody? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelRequest? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateUserProfileActionUrlRequestBody? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileAction? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateUserProfileRequest? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileAccessType? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserDetailsParams? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCurrency? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteMessageBatchResponse? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedSkill? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedSkillVersion? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedTelemetryDestination? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedTelemetryDestinationWorkspace? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedUserProfile? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDiagnostics? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDirectCaller? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDream? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamType? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamOutput>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutput? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamStatus? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamError? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelConfig? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamUsage? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreInput? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamSessionsInput? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminator? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminatorType? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreInputType? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreOutput? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreOutputType? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelConfigParams? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminator? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminatorType? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamSessionsInputType? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorResponse? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingError? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffortCapability? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffortLevel? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnrollmentUrl? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnrollmentUrlType? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironment? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Config? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfig? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminator? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminatorType? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentScope? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentArchivedErrorDetails? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentCreateDisabledErrorDetails? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentDeleteResponse? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentDeleteResponseType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentListResponse? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaEnvironment>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentUpdateDisabledErrorDetails? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorResponse? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Error? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidRequestError? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPermissionError? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNotFoundError? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitError? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGatewayTimeoutError? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOverloadedError? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorResponseErrorDiscriminator? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorResponseErrorDiscriminatorType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorType? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErroredResult? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExpiredResult? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingVariant1? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigEnabled? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigDisabled? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigBetweenTools? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigAdaptive? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2ThinkingVariant1Discriminator? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2ThinkingVariant1DiscriminatorType? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditNotApplied? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditNotAppliedReason? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditRedeemed? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditTokenParamMode? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsage? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Status? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsageStatusDiscriminator? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsageStatusDiscriminatorType? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackMessageIterationUsage? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackRefusalTrigger? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRefusalCategory? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileDeleteResponse? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileDocumentSource? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileExpiredErrorDetails? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileImageSource? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileListResponse? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFileMetadataSchema>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileMetadataSchema? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileScope? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileNotDownloadableErrorDetails? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaHeartbeatPreconditionFailedErrorDetails? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkLeaseState? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageClearAt? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlock? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemMessageOutputConfig? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageRole? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputSchema? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformation? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformation? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminator? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminatorType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidConfigTypeChangeErrorDetails? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidMetadataErrorDetails? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListDreamsResponse? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDream>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseMessageBatch? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatch>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatch? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseModelInfo? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelInfo>? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelInfo? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsResponse? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillVersion>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillVersion? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsResponse? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkill>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkill? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTelemetryDestinationWorkspacesResponse? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTelemetryDestinationWorkspace>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspace? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTelemetryDestinationsResponse? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTelemetryDestination>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestination? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTunnelCertificatesResponse? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTunnelCertificate>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelCertificate? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTunnelsResponse? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTunnel>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnel? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListUserProfilesResponse? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUserProfile>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfile? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPTool? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolConfig? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolDefaultConfig? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant116? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolsetCacheControlVariant1Discriminator? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolsetCacheControlVariant1DiscriminatorType? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaMCPToolConfig>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMCPTool>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActor? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionActor? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsApiActor? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserActor? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountActor? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminator? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminatorType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResource? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResource? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminator? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminatorType? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParams? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceParams? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminator? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminatorType? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisor? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisorType? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisorParams? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisorParamsType? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgent? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentType? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelConfig? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool>? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentTool? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServer? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkill? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentity? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonErrorType? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedRunError? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedRunErrorType? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminator? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentCustomToolUseEventType? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStruct? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentEvaluatedPermission? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEventType? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlock? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEventType? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluation? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlock? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextBlock? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRedactedBlock? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminator? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminatorType? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageEvent? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageEventType? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentMessageContentBlock>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentParams? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentParamsType? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentReference? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentReferenceType? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThinkingEvent? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThinkingEventType? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEventType? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEventType? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock>? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlock? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEventType? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolset? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomTool? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminator? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminatorType? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnion? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfig? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfig? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfig? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfig? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfig? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfig? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfig? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfig? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminator? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminatorType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfigParams? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfigParams? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfigParams? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfigParams? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfigParams? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfigParams? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminator? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminator? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminatorType? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolName? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParams? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401Params? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetParams? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolParams? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminator? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminatorType? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolResultEvent? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolResultEventType? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolUseEvent? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolUseEventType? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401Type? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfig? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigUnion>? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401ParamsType? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfigParams? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicy? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParams? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2Discriminator? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentWithOverridesParamsType? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelParams? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParams? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParams? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAllowPolicyType? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAskPolicyType? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkill? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkillType? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkillParams? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkillParamsType? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsApiActorType? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponse? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStore? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminator? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAutoPolicy? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64DocumentSource? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64DocumentSourceType? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64ImageSource? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64ImageSourceType? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBillingError? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBillingErrorType? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatus? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBranchCheckout? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBranchCheckoutType? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudget? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetLimit? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminator? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminatorType? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetLimitType? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMonetaryAmount? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCacheCreationUsage? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCommitCheckout? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCommitCheckoutType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsContentSha256Precondition? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsContentSha256PreconditionType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateAgentParams? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParams? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParams? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateCredentialRequestBody? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuth? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateDeploymentParams? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParams? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParams? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryParams? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreRequest? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponse? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminator? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParams? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionParams? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParams? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateVaultRequest? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredential? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialType? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuth? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableAuthResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminator? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminatorType? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminator? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminatorType? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialHostUnreachableErrorType? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParams? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminator? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminator? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialRefreshStatus? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuth? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminator? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminatorType? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidation? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidationType? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidationStatus? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpProbe? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRefreshObject? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronSchedule? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronScheduleType? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.DateTime>? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronScheduleParams? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronScheduleParamsType? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkill? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkillType? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkillParams? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkillParamsType? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolType? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolInputSchema? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolParamsType? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponse? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemoryStore? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminator? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteSessionResource? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteSessionResourceType? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedCredential? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedCredentialType? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemory? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemoryType? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemoryStoreType? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedSession? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedSessionType? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedVault? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedVaultType? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeployment? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentType? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEvent? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceConfig>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfig? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSchedule? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentStatus? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReason? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminator? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminatorType? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEventParams? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEventParams? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminator? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminator? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminatorType? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminator? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentRun? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentRunType? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContext? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunError? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEventType? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSystemContentBlock>? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlock? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEventType? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubric? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserMessageEventType? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentBlock? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentBlockType? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSource? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSource? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLDocumentSource? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileDocumentSource? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminator? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminatorType? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffort? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLow? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMedium? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortHigh? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortXhigh? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMax? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminator? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminatorType? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortHighType? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLevel? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLowType? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMaxType? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMediumType? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortParams? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortXhighType? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonErrorType? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunErrorType? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonErrorType? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunErrorType? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableAuthResponseType? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationResponse? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParamsType? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationParams? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParamsType? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationUpdateParams? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReasonType? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorResponse? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorResponseType? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsError? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEvent? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventType? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDelta? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventContentDeltaType? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminator? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaType? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParams? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEventParams? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEventParams? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminator? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminatorType? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEvent? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventType? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEvent? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreviewType? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreviewType? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminator? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminatorType? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminator? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminatorType? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminator? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminatorType? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileDocumentSourceType? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileImageSource? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileImageSourceType? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonErrorType? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundRunError? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundRunErrorType? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceType? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceConfig? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceConfigType? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceParamsType? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubric? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubricType? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubricParams? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubricParamsType? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponse? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminator? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminatorType? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResource? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResource? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResource? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminator? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminatorType? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceType? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckout? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfigType? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParamsType? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageBlock? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageBlockType? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSource? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLImageSource? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminator? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminatorType? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInlineAgent? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEvent? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEvent? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminator? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminatorType? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParamsType? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponseType? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListAgentVersions? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgent>? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListAgents? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListCredentialsResponse? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsCredential>? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListDeploymentRunsData? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentRun>? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListDeploymentsData? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeployment>? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoriesResult? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryListItem>? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItem? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoryStoresResponse? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryStore>? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoryVersionsResult? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryVersion>? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersion? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListOrder? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionEvents? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEvent>? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEvent? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionResources? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResource>? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResource? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionThreadEvents? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionThreads? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThread>? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThread? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessions? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSession>? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSession? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListVaultsResponse? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsVault>? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVault? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerURLDefinition? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminator? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminatorType? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLMCPServerParams? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminator? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminatorType? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerURLDefinitionType? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolConfig? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolConfigParams? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetType? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfig? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfig>? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfigParams? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetParamsType? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualDeploymentPausedReasonType? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualTriggerContext? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualTriggerContextType? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedErrorType? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpConnectionFailedErrorType? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonErrorType? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunErrorType? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthAuthResponseType? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponse? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthCreateParamsType? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParams? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminator? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminator? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParams? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminator? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorType? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthUpdateParamsType? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRefreshHttpResponse? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemory? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryType? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPrefix? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminator? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminatorType? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPathConflictError? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPathConflictErrorType? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedErrorType? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPrefixType? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreType? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonErrorType? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunErrorType? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceType? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMountMode? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfigType? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceParamType? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersionType? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersionOperation? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryView? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModel? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpeed? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelConfigParams? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelOverloadedError? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelOverloadedErrorType? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRateLimitedError? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRateLimitedErrorType? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRequestFailedError? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRequestFailedErrorType? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinator? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminator? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminatorType? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflows? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagents? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisor? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001Params? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParams? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParams? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabled? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabled? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDiscriminator? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDiscriminatorType? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminator? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorType? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntry>? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntry? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParamsType? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams>? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgents? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminator? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParams? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminator? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminator? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminatorType? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSelfParams? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryDiscriminator? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryDiscriminatorType? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSelfParamsType? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabled? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDiscriminator? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDiscriminatorType? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentReference>? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminator? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminator? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminatorType? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminator? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonErrorType? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledRunErrorType? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOutcomeEvaluationResourceType? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminator? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminatorType? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSourceType? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSourceMediaType? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPrecondition? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminator? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminatorType? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRedactedBlockType? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminator? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminatorType? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCloneError? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusRetrying? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusExhausted? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusTerminal? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminator? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminatorType? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusExhaustedType? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusRetryingType? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusTerminalType? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubric? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminator? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminatorType? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParams? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubricParams? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminator? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminatorType? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedRunError? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownRunError? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminator? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminator? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminatorType? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminator? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminatorType? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleTriggerContext? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleTriggerContextType? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultBlock? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultBlockType? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSearchResultContent>? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultContent? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultCitations? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultContentType? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonErrorType? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunErrorType? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSendSessionEvents? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsInputEvent>? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSendSessionEventsParams? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventParams>? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServerToolUsage? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionType? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatus? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgent? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource>? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsage? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStats? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionActorType? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgentType? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagent? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgentUpdate? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionBudgetReached? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionBudgetReachedType? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunErrorType? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionDeletedEvent? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionDeletedEventType? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEndTurn? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEndTurnType? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEvent? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventType? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventError? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownError? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminator? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageEvent? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventDiscriminator? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventDiscriminatorType? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminator? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminatorType? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagent20261001? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminator? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminatorType? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflows? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagents? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinatorType? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionRosterEntry>? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntry? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminator? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgent? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsEnabled? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsDiscriminator? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRateLimitedRunErrorType? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusal? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetailsCategory? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRequiresAction? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRequiresActionType? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceDiscriminator? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceDiscriminatorType? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminator? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminatorType? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonErrorType? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunErrorType? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminator? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminatorType? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRetriesExhaustedType? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminator? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminatorType? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventType? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetails? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReason? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminator? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEventType? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRunningEventType? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEventType? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminator? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminatorType? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadType? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatus? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntry? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadUsage? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStats? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentType? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntryDiscriminator? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEventType? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventType? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReason? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminator? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEventType? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEventType? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEventType? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEventType? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageEventType? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageSnapshot? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminator? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminatorType? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonErrorType? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundRunErrorType? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminator? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminatorType? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEventType? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelUsage? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestStartEventType? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEventType? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEventType? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEventType? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerAuthResponseType? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerCreateParamsType? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerUpdateParamsType? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEvents? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminator? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminator? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminator? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminatorType? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEventType? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEventParamsType? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextBlockType? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubricType? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubricParamsType? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParamType? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponseType? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParamType? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParamType? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponseType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParamType? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponseType? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParamType? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminator? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminatorType? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminator? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminatorType? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerType? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLDocumentSourceType? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLImageSourceType? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLMCPServerParamsType? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonErrorType? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownErrorType? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownRunErrorType? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParamsType? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponseType? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateAgentParams? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateCredentialRequestBody? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateDeploymentParams? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryParams? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreRequestBody? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminator? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionParams? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResource? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminator? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminatorType? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceParams? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateVaultRequestBody? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserActorType? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminator? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminatorType? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEventType? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParamsType? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventType? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParamsType? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEventType? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEventParamsType? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserLocation? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEventType? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEventParamsType? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEventType? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationResult? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParamsType? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEventType? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEventParamsType? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultType? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonErrorType? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedRunErrorType? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonErrorType? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundRunErrorType? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSources? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourcesParams? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference>? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminator? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterParams? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminator? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputParams? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWorkflowRunPhase>? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhase? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunError? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminator? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResult? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultError? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminator? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminatorType? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonErrorType? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunErrorType? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant117? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CacheControlVariant1Discriminator? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CacheControlVariant1DiscriminatorType? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818Command? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818ViewCommand? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CreateCommand? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818InsertCommand? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818DeleteCommand? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818RenameCommand? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminator? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CreateCommandCommand? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818InsertCommandCommand? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818RenameCommandCommand? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818ViewCommandCommand? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessage? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaContentBlock>? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlock? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopReason? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRefusalStopDetails? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsage? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputTransformation>? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagement? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchProcessingStatus? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCounts? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponse? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Result? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSucceededResult? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminator? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDelta? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDeltaEvent? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDeltaUsage? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaIterationsUsageVariant1Item>? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputTokensDetails? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolUsage? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageIterationUsage? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStartEvent? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStopEvent? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEvent? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminator? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminatorType? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelCapabilities? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolsCapability? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingCapability? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelInfoLifecycle? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelLine? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationOnHoldErrorDetails? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorCreateNew? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorUpdateExisting? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminator? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminatorType? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorCreateNewType? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorUpdateExistingType? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTokenTaskBudget? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPlainTextSource? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequest? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConfigVariant1? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfigParams? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1Discriminator? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestScope? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequest? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConfigVariant12? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1Discriminator? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestScope? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorRedactedResultBlock? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorResultBlock? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlock? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant118? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1Discriminator? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestAdvisorToolResultError, global::Anthropic.BetaRequestAdvisorResultBlock, global::Anthropic.BetaRequestAdvisorRedactedResultBlock>? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultError? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionOutputBlock? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionResultBlock? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant119? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestBashCodeExecutionToolResultError, global::Anthropic.BetaRequestBashCodeExecutionResultBlock>? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultError? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyTooLargeAfterDecodingErrorDetails? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlock? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant120? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockCacheControlVariant1Discriminator? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockCacheControlVariant1DiscriminatorType? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item>? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StateChangesVariant1Item? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminator? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaBrowserStateTabEntry>? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCharLocationCitation? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCitationsConfig? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionOutputBlock? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionResultBlock? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestCodeExecutionOutputBlock>? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlock? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant121? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultError? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlock? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant122? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1Discriminator? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1DiscriminatorType? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChangesVariant1Item? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlock? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlock? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminator? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlock? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant123? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1Discriminator? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1DiscriminatorType? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContentBlockLocationCitation? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlock? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant124? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1Discriminator? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1DiscriminatorType? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaURLPDFSource? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminator? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestFallbackBlock? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestFallbackHopInfo? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant125? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockCacheControlVariant1Discriminator? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockCacheControlVariant1DiscriminatorType? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source2? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaURLImageSource? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminator? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageTransformations? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageTransformationsOversizedImage? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPServerToolConfiguration? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolListingBlock? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlock? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant126? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1Discriminator? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1DiscriminatorType? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlock? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant127? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1Discriminator? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1DiscriminatorType? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestPageLocationCitation? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestRedactedThinkingBlock? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlock? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant128? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1Discriminator? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1DiscriminatorType? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultLocationCitation? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlock? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant129? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1Discriminator? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1DiscriminatorType? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolCaller? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolCaller20260120? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminator? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminatorType? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockName? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant130? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCacheControlVariant1Discriminator? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCacheControlVariant1DiscriminatorType? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item>? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchResultLocationCitation? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminator? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant131? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditorCodeExecutionToolResultErrorCode? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockFileType? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestThinkingBlock? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant132? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockCacheControlVariant1Discriminator? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockCacheControlVariant1DiscriminatorType? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolReference? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolReference? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolsetReference? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolDefinition? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminator? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminatorType? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlock? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant133? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1Discriminator? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1DiscriminatorType? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant134? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1Discriminator? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool2? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminator? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminatorType? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlock? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant135? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1Discriminator? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1DiscriminatorType? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>>? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentVariant2Item? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminator? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlock? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant136? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1Discriminator? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestToolSearchToolResultError, global::Anthropic.BetaRequestToolSearchToolSearchResultBlock>? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultError? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolSearchResultBlock? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolResultErrorCode? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestToolReferenceBlock>? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlock? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant137? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1Discriminator? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1DiscriminatorType? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller2? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCallerDiscriminator? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCallerDiscriminatorType? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchResultBlock? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlock? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant138? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1Discriminator? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller3? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminator? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminatorType? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestWebFetchToolResultError, global::Anthropic.BetaRequestWebFetchResultBlock>? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultError? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchToolResultErrorCode? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchResultBlock? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlock? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant139? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1Discriminator? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller4? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminator? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminatorType? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaRequestWebSearchToolResultError>? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultError? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchToolResultErrorCode? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorRedactedResultBlock? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorResultBlock? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseAdvisorToolResultError, global::Anthropic.BetaResponseAdvisorResultBlock, global::Anthropic.BetaResponseAdvisorRedactedResultBlock>? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorToolResultError? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionOutputBlock? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionResultBlock? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock>? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseBashCodeExecutionToolResultError, global::Anthropic.BetaResponseBashCodeExecutionResultBlock>? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultError? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCaller? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFindToolUseBlock? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserHoverToolUseBlock? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserKeyToolUseBlock? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScrollToolUseBlock? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlock? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnion? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserZoomToolUseBlock? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserTypeToolUseBlock? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserWaitToolUseBlock? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminator? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCitationsConfig? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseClearThinking20251015Edit? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseClearToolUses20250919Edit? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionOutputBlock? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionResultBlock? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseCodeExecutionOutputBlock>? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionToolResultError? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseEncryptedCodeExecutionResultBlock? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item2>? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChangesVariant1Item2? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlock? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlock? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminator? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerKeyToolUseBlock? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerRightClickToolUseBlock? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerScrollToolUseBlock? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlock? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnion? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerTypeToolUseBlock? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerWaitToolUseBlock? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerZoomToolUseBlock? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminator? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AppliedEditsItem>? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AppliedEditsItem? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminator? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlock? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source3? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlockSourceDiscriminator? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlockSourceDiscriminatorType? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseFallbackHopInfo? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPTool? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseMCPTool>? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>>? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller5? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminator? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminatorType? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockName? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item2>? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item2? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminator? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockFileType? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTool? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolInputSchema? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool3? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeToolReference? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeMCPToolReference? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeMCPToolsetReference? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeToolDefinition? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlockToolDiscriminator? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlockToolDiscriminatorType? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUnion? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolReferenceBlock? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool4? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminator? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminatorType? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseToolSearchToolResultError, global::Anthropic.BetaResponseToolSearchToolSearchResultBlock>? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolResultError? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolSearchResultBlock? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseToolReferenceBlock>? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller6? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockCallerDiscriminator? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockCallerDiscriminatorType? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockUnion? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchResultBlock? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller7? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminator? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminatorType? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebFetchToolResultError, global::Anthropic.BetaResponseWebFetchResultBlock>? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultError? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchResultBlock? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller8? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminator? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminatorType? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>>? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultError? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenRequestBody? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWork? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSessionWorkData? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkState? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkHeartbeatResponse? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkHeartbeatResponseState? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkListResponse? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSelfHostedWork>? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkQueueStats? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkStopRequest? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkUpdateRequest? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillSource? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillParamsType? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillReadBlockedUndecryptableErrorDetails? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillSourceType? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageQuotaExceededErrorDetails? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTargetStoreHeldError? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTraces? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationState? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDeliveryHealth? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspaces? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationContentMode? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReason? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminator? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabled? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabled? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminator? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminatorType? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabledParams? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabledParams? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParams? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminator? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminatorType? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTest? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResult? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestFailure? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestSuccess? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminator? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminatorType? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAll? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminator? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminatorType? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminator? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminatorType? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant140? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022CacheControlVariant1Discriminator? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022CacheControlVariant1DiscriminatorType? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant141? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124CacheControlVariant1Discriminator? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124CacheControlVariant1DiscriminatorType? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant142? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429CacheControlVariant1Discriminator? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429CacheControlVariant1DiscriminatorType? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant143? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728CacheControlVariant1Discriminator? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728CacheControlVariant1DiscriminatorType? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingBlockBinding? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingPrefixMismatchBehavior? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingTypes? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDisplayMode? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformationReason? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformationReason? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant144? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolCacheControlVariant1Discriminator? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolCacheControlVariant1DiscriminatorType? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceAny? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceAuto? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceNone? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceTool? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolNameConflictErrorDetails? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolReferenceUnresolvedErrorDetails? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant145? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1Discriminator? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119Type? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant146? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1Discriminator? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119Type? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCallerDiscriminator? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCallerDiscriminatorType? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelToken? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateTelemetryDestinationRequestBody? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserProfileRequestBody? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageServiceTier? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserLocation? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileType? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserDetails? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaUserProfileTrustGrant>? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileTrustGrant? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileEnrollEndUserAction? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminator? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminatorType? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionUrl? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserAccountStatus? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserEntityType? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileListOrder? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileListOrderBy? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileTrustGrantStatus? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant147? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1Discriminator? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1DiscriminatorType? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSources? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant148? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1Discriminator? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1DiscriminatorType? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant149? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1Discriminator? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1DiscriminatorType? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant150? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318CacheControlVariant1Discriminator? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318CacheControlVariant1DiscriminatorType? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318ResponseInclusion? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceAll? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceExcept? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWebFetchUrlSourceToolReference>? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceToolReference? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceNone? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceOnly? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolResults? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesClientToolResultsDiscriminator? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolResults? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminator? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInput? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminator? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminatorType? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant151? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1Discriminator? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1DiscriminatorType? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant152? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1Discriminator? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1DiscriminatorType? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant153? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318CacheControlVariant1Discriminator? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318CacheControlVariant1DiscriminatorType? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318ResponseInclusion? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentArchivedEventData? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentCreatedEventData? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentDeletedEventData? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentUpdatedEventData? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentArchivedEventData? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentCreatedEventData? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentDeletedEventData? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentPausedEventData? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunFailedEventData? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunStartedEventData? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUnpausedEventData? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUpdatedEventData? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentArchivedEventData? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentCreatedEventData? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentDeletedEventData? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnwrapWebhookEvent? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventData? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionCreatedEventData? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionPendingEventData? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRunningEventData? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionIdledEventData? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRequiresActionEventData? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionArchivedEventData? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionDeletedEventData? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusIdledEventData? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadCreatedEventData? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadIdledEventData? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCreatedEventData? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultArchivedEventData? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultDeletedEventData? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionUpdatedEventData? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionBudgetReachedEventData? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminator? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminatorType? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkLeaseStateState? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BillingError? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BodyCreateSkillV1SkillsPost? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BodyCreateSkillVersionV1SkillsSkillIdVersionsPost? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTarget? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCoordinateTarget? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRefTarget? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminator? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminatorType? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabConfig? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabInput? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickConfig? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickInput? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadConfig? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadInput? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindConfig? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindInput? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputConfig? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputInput? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputValue? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextConfig? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextInput? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyConfig? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyInput? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverConfig? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverInput? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecConfig? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecInput? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyConfig? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyInput? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickConfig? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragConfig? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragInput? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickInput? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownConfig? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownInput? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpConfig? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpInput? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsConfig? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsInput? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMemberInput? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateInput? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabInput? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabInput? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageInput? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleInput? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkInput? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToInput? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotInput? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomInput? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickInput? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickInput? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickInput? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveInput? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollInput? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeInput? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitInput? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickConfig? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveConfig? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateConfig? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabConfig? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleConfig? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkConfig? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageConfig? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageFilter? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickConfig? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotConfig? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollConfig? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollDirection? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToConfig? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadCompleted? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadFailed? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadStarted? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeTabOpened? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateTabEntry? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabConfig? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolsetConfigs? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickConfig? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeConfig? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitConfig? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomConfig? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant154? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1Discriminator? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1DiscriminatorType? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlEphemeralTtl? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheCreation? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissMessagesChanged? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissModelChanged? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissPreviousMessageNotFound? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReason? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissSystemChanged? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissToolsChanged? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissUnavailable? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminator? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminatorType? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CanceledResult? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CapabilitySupport? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDelta? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Citation2? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCharLocationCitation? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponsePageLocationCitation? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseContentBlockLocationCitation? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultLocationCitation? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseSearchResultLocationCitation? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminator? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminatorType? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClaudeCodeVersionTooOldErrorDetails? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolUnion? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool5? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekContextUnavailableErrorDetails? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyDisabledErrorDetails? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyNetworkBlockedErrorDetails? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyUnreachableErrorDetails? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionToolResultErrorCode? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant155? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522CacheControlVariant1Discriminator? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522CacheControlVariant1DiscriminatorType? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant156? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825CacheControlVariant1Discriminator? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825CacheControlVariant1DiscriminatorType? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant157? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120CacheControlVariant1Discriminator? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120CacheControlVariant1DiscriminatorType? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant158? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521CacheControlVariant1Discriminator? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521CacheControlVariant1DiscriminatorType? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionBlockAmbiguousErrorDetails? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionBlockMisplacedErrorDetails? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionContentMismatchErrorDetails? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionIncompleteTurnErrorDetails? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionNothingToSummarizeErrorDetails? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionSignatureInvalidErrorDetails? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionTooManyToolReferencesErrorDetails? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionToolChangesMismatchErrorDetails? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionUnavailableErrorDetails? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompletionRequest? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Metadata? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompletionResponse? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionConfig? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionInput? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickConfig? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickInput? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyConfig? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyInput? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyConfig? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyInput? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickConfig? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragConfig? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragInput? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickInput? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownConfig? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownInput? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpConfig? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpInput? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMemberInput? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeInput? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveInput? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickInput? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickInput? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickInput? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollInput? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitInput? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotInput? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomInput? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickConfig? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveConfig? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickConfig? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotConfig? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollConfig? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollDirection? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolsetConfigs? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickConfig? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeConfig? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitConfig? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomConfig? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant159? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801CacheControlVariant1Discriminator? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801CacheControlVariant1DiscriminatorType? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Container2? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContainerSkill>? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerSkill? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerParams? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SkillParams>? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillParams? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerSkillType? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEvent? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Delta2? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextContentBlockDelta? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputJsonContentBlockDelta? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingContentBlockDelta? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SignatureContentBlockDelta? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSource? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>>? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentContentBlockSourceContentItem? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlock? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlock? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminator? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEvent? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock2? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlock? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseThinkingBlock? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseRedactedThinkingBlock? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlock? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlock? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlock? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlock? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionToolResultBlock? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionToolResultBlock? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionToolResultBlock? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolResultBlock? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseContainerUploadBlock? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEventContentBlockDiscriminator? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEventContentBlockDiscriminatorType? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStopEvent? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContextManagementCapability? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParams? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant160? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParamsCacheControlVariant1Discriminator? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParamsCacheControlVariant1DiscriminatorType? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputMessage>? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessage? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OutputConfig? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Speed? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParam? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoice? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensResponse? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageBatchParams? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.MessageBatchIndividualRequestParams>? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualRequestParams? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParams? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant161? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsCacheControlVariant1Discriminator? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsCacheControlVariant1DiscriminatorType? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ContainerParams, string>? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DiagnosticsParam? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsServiceTier? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateUserProfileActionUrlRequestBody? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileAction? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateUserProfileRequest? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileAccessType? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserDetailsParams? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteMessageBatchResponse? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedSkill? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedSkillVersion? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedUserProfile? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Diagnostics? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DirectCaller? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EffortCapability? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EffortLevel? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EnforcedSpendLimitReachedErrorDetails? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponse? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Error2? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InvalidRequestError? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PermissionError? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NotFoundError? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitError? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GatewayTimeoutError? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OverloadedError? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminator? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminatorType? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorType? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErroredResult? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExpiredResult? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileDeleteResponse? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileDocumentSource? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileExpiredErrorDetails? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileImageSource? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileListResponse? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FileMetadataSchema>? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileMetadataSchema? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileNotDownloadableErrorDetails? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>>? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlock? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageRole? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputSchema? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JsonOutputFormat? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseMessageBatch? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.MessageBatch>? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatch? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseModelInfo? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ModelInfo>? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelInfo? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsResponse? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SkillVersion>? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillVersion? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsResponse? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Skill>? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Skill? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListUserProfilesResponse? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfile>? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfile? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant162? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818CacheControlVariant1Discriminator? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818CacheControlVariant1DiscriminatorType? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Message? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlock3>? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock3? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopReason? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalStopDetails? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Usage? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchProcessingStatus? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCounts? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponse? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Result2? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SucceededResult? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminator? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDelta? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDeltaEvent? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDeltaUsage? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OutputTokensDetails? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolUsage? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStartEvent? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStopEvent? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEvent? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Ping? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminator? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminatorType? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelCapabilities? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolsCapability? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingCapability? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelInfoLifecycle? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelLine? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationOnHoldErrorDetails? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PlainTextSource? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalCategory? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionOutputBlock? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionResultBlock? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestBashCodeExecutionOutputBlock>? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlock? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant163? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestBashCodeExecutionToolResultError, global::Anthropic.RequestBashCodeExecutionResultBlock>? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultError? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyEncodingInvalidErrorDetails? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyEncodingUnsupportedErrorDetails? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyTooLargeAfterDecodingErrorDetails? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlock? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant164? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockCacheControlVariant1Discriminator? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockCacheControlVariant1DiscriminatorType? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item2>? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StateChangesVariant1Item2? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminator? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BrowserStateTabEntry>? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCharLocationCitation? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCitationsConfig? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionOutputBlock? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionResultBlock? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestCodeExecutionOutputBlock>? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlock? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant165? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestCodeExecutionToolResultError, global::Anthropic.RequestCodeExecutionResultBlock, global::Anthropic.RequestEncryptedCodeExecutionResultBlock>? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultError? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestEncryptedCodeExecutionResultBlock? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlock? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant166? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlockCacheControlVariant1Discriminator? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlockCacheControlVariant1DiscriminatorType? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContentBlockLocationCitation? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlock? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant167? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockCacheControlVariant1Discriminator? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockCacheControlVariant1DiscriminatorType? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source4? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLPDFSource? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminator? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminatorType? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant168? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockCacheControlVariant1Discriminator? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockCacheControlVariant1DiscriminatorType? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source5? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLImageSource? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminator? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminatorType? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageTransformations? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageTransformationsOversizedImage? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestPageLocationCitation? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestRedactedThinkingBlock? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlock? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant169? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlockCacheControlVariant1Discriminator? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlockCacheControlVariant1DiscriminatorType? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultLocationCitation? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlock? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant170? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCacheControlVariant1Discriminator? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCacheControlVariant1DiscriminatorType? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller9? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolCaller? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolCaller20260120? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCallerDiscriminator? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCallerDiscriminatorType? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockName? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant171? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCacheControlVariant1Discriminator? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCacheControlVariant1DiscriminatorType? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item3>? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item3? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchResultLocationCitation? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminator? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant172? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultError? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditorCodeExecutionToolResultErrorCode? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionViewResultBlockFileType? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestThinkingBlock? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlock? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant173? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlockCacheControlVariant1Discriminator? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlockCacheControlVariant1DiscriminatorType? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlock? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant174? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockCacheControlVariant1Discriminator? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockCacheControlVariant1DiscriminatorType? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>>? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentVariant2Item2? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminator? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlock? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant175? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1Discriminator? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestToolSearchToolResultError, global::Anthropic.RequestToolSearchToolSearchResultBlock>? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultError? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolSearchResultBlock? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolResultErrorCode? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestToolReferenceBlock>? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlock? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant176? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCacheControlVariant1Discriminator? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCacheControlVariant1DiscriminatorType? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller10? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCallerDiscriminator? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCallerDiscriminatorType? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchResultBlock? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlock? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant177? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1Discriminator? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller11? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminator? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminatorType? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestWebFetchToolResultError, global::Anthropic.RequestWebFetchResultBlock>? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultError? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchToolResultErrorCode? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchResultBlock? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlock? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant178? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1Discriminator? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller12? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminator? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminatorType? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.RequestWebSearchToolResultError>? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultError? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchToolResultErrorCode? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionOutputBlock? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionResultBlock? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseBashCodeExecutionOutputBlock>? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseBashCodeExecutionToolResultError, global::Anthropic.ResponseBashCodeExecutionResultBlock>? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionToolResultError? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserCloseTabToolUseBlock? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCaller? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFileUploadToolUseBlock? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFindToolUseBlock? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFormInputToolUseBlock? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoverToolUseBlock? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserKeyToolUseBlock? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickToolUseBlock? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserListTabsToolUseBlock? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNavigateToolUseBlock? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNewTabToolUseBlock? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadPageToolUseBlock? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserRightClickToolUseBlock? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScreenshotToolUseBlock? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToToolUseBlock? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToolUseBlock? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlock? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnion? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserZoomToolUseBlock? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTripleClickToolUseBlock? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTypeToolUseBlock? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserWaitToolUseBlock? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminator? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCitationsConfig? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionOutputBlock? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionResultBlock? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseCodeExecutionOutputBlock>? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionToolResultError? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseEncryptedCodeExecutionResultBlock? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerCursorPositionToolUseBlock? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerDoubleClickToolUseBlock? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerHoldKeyToolUseBlock? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerKeyToolUseBlock? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickToolUseBlock? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMiddleClickToolUseBlock? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMouseMoveToolUseBlock? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerRightClickToolUseBlock? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScreenshotToolUseBlock? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScrollToolUseBlock? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlock? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnion? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTypeToolUseBlock? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTripleClickToolUseBlock? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerWaitToolUseBlock? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerZoomToolUseBlock? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminator? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlock? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source6? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminator? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminatorType? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller13? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockName? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item4>? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item4? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminator? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionToolResultError? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlockFileType? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolReferenceBlock? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolResultError? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolSearchResultBlock? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseToolReferenceBlock>? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller14? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockCallerDiscriminator? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockCallerDiscriminatorType? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockUnion? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchResultBlock? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller15? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminator? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminatorType? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebFetchToolResultError, global::Anthropic.ResponseWebFetchResultBlock>? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultError? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultBlock? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller16? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminator? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminatorType? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>>? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultError? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillSource? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillParamsType? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillReadBlockedUndecryptableErrorDetails? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillSourceType? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StorageQuotaExceededErrorDetails? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant179? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124CacheControlVariant1Discriminator? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124CacheControlVariant1DiscriminatorType? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant180? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429CacheControlVariant1Discriminator? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429CacheControlVariant1DiscriminatorType? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant181? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728CacheControlVariant1Discriminator? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728CacheControlVariant1DiscriminatorType? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingTypes? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigAdaptive? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingDisplayMode? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigBetweenTools? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigDisabled? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigEnabled? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant182? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolCacheControlVariant1Discriminator? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolCacheControlVariant1DiscriminatorType? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceAny? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceAuto? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceNone? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceTool? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolNameConflictErrorDetails? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolReferenceUnresolvedErrorDetails? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant183? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1Discriminator? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119Type? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant184? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1Discriminator? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119Type? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCallerDiscriminator? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCallerDiscriminatorType? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserProfileRequestBody? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UsageServiceTier? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserLocation? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserDetails? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfilePrograms? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnrollEndUserAction? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionDiscriminator? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionDiscriminatorType? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionUrl? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberProgram? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileProgramStatus? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileCyberTier>? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberTier? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberRequirements? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberTierStatus? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsFeature? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsFeatureStatus? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsProgram? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileEfsFeature>? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserAccountStatus? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserEntityType? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileListOrder? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileListOrderBy? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant185? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910CacheControlVariant1Discriminator? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910CacheControlVariant1DiscriminatorType? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSources? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant186? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209CacheControlVariant1Discriminator? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209CacheControlVariant1DiscriminatorType? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant187? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309CacheControlVariant1Discriminator? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309CacheControlVariant1DiscriminatorType? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant188? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318CacheControlVariant1Discriminator? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318CacheControlVariant1DiscriminatorType? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318ResponseInclusion? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceAll? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceExcept? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WebFetchUrlSourceToolReference>? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceToolReference? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceNone? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceOnly? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolResults2? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesClientToolResultsDiscriminator? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesClientToolResultsDiscriminatorType? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolResults2? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminator? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminatorType? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInput2? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminator? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminatorType? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant189? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305CacheControlVariant1Discriminator? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305CacheControlVariant1DiscriminatorType? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant190? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209CacheControlVariant1Discriminator? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209CacheControlVariant1DiscriminatorType? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant191? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318CacheControlVariant1Discriminator? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318CacheControlVariant1DiscriminatorType? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318ResponseInclusion? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceParams? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberParams? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllConnectorsPermissionResource? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllowedInferenceGeo? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAlreadyMemberErrorDetails? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsActivitySummaryResponse? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSingleDayActivitySummary>? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSingleDayActivitySummary? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactActivity? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactsResponse? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsArtifactActivity>? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedChatMetrics? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedMetrics? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedSessionsMetrics? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatMetrics? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeCodeMetrics? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCoreCodeMetrics? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsToolActions? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeTagCategory? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorActivity? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedMetrics? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatMetrics? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorClaudeCodeMetrics? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorCoworkMetrics? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorOfficeMetrics? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorOfficeProductMetrics? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorsResponse? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsConnectorActivity>? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsLinesOfCode? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResponse? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostReportTimeBucket>? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostReportTimeBucket? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResult? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportContextWindow? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostType? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceGeo? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResultSpeed? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTokenType? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostBucketedResult>? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItem? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserActor? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemActorDiscriminator? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemActorDiscriminatorType? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemSpeed? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersOrderBy? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersResponse? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostUsersItem>? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCoworkMetrics? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsDesignMetrics? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOfficeMetrics? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOfficeProductMetrics? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginActivity? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginChatCoworkUnifiedMetrics? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginClaudeCodeMetrics? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginCoworkMetrics? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginsResponse? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsPluginActivity>? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProductFilter? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectActivity? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUser? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectsResponse? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProjectActivity>? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsScienceMetrics? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillActivity? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedMetrics? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatMetrics? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillClaudeCodeMetrics? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillCoworkMetrics? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillOfficeMetrics? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillActivityShareStatus? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedChatMetrics? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillOfficeProductMetrics? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillsResponse? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSkillActivity>? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSortOrder? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsToolActionCounts? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResponse? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageReportTimeBucket>? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageReportTimeBucket? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResult? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolUse? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResultSpeed? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageBucketedResult>? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItem? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemActorDiscriminator? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemActorDiscriminatorType? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemSpeed? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersOrderBy? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersResponse? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageUsersItem>? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserActivity? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsersResponse? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUserActivity>? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKey? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatedBy? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PrincipalVariant1? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUserActor? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyServiceAccountActor? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1Discriminator? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1DiscriminatorType? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyOrganizationScope? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyWorkspaceScope? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminator? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminatorType? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyStatus? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUpdateParams? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUpdateParamsStatus? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApprovalMetrics? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestParams? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitPeriod? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponse? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserActorSchema? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScopedApiKeyActorSchema? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminator? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResolvedByVariant1? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1Discriminator? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1DiscriminatorType? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimit? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummary? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestStatus? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAttachedAttachment? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAwsExternalKeyConfig? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfig? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfigParams? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBillingFrozenErrorDetails? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotInviteEmailsWithUnverifiedDomainsErrorDetails? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotRemoveLastMemberErrorDetails? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeApiActor? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItem? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor2? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUserActor? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminator? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminatorType? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCoreMetrics? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCustomerType? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelBreakdown>? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelBreakdown? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSubscriptionType? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaApprovalMetrics>? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeEnterpriseOrganizationRole? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettings? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsState? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabled? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabled? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDiscriminator? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDiscriminatorType? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabledParams? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabledParams? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParams? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParamsDiscriminator? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParamsDiscriminatorType? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsUpdateParams? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConcurrentMembershipChangeErrorDetails? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorPermissionResource? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorScopePermissionResource? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorToolPermissionResource? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLinesOfCode? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportGroupBy? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportItem? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostType? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportServiceTier? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceGeoFilter? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTimeBucket? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportItem>? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTimeBucketWidth? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteParams? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteParamsRole? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupParams? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelCertificateParams? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberParams? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNoBillingWorkspaceRoleSchema? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatedByType? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidency? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>, string>? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceGeo? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidencyCreateParams? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidencyUpdateParams? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyResponse? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteResponse? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupMemberResponse? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupResponse? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitResponse? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteUserResponse? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberResponse? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDenySpendLimitIncreaseRequestParams? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEmailDomainNotAllowedErrorDetails? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEstimatedCost? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKey? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Attachment? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnattachedAttachment? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminator? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminatorType? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpExternalKeyConfig? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderConfigDiscriminator? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderConfigDiscriminatorType? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParams? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig2? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminator? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminatorType? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyListResponse? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaExternalKey>? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParams? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfigVariant1? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParamsProviderConfigVariant1Discriminator? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuer? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksDiscovery? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksExplicitUrl? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksInline? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerJwksDiscriminator? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerJwksDiscriminatorType? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIssuerPollStatus? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParams? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks2? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminator? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminatorType? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerListResponse? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationIssuer>? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParams? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksVariant1? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1Discriminator? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRule? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRuleMatch? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountTarget? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleCreateParams? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleListResponse? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationRule>? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleUpdateParams? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleWorkspace? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleWorkspaceListResponse? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationRuleWorkspace>? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetClaudeCodeUsageReportResponse? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeUsageReportItem>? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportResponse? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportTimeBucket>? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetMessagesUsageReportResponse? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportTimeBucket>? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportTimeBucket? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteAlreadyExistsErrorDetails? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteSchema? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationRoleSchema? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteStatusSchema? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsResponse? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendSummary>? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseApiKey? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaApiKey>? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseInviteSchema? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInviteSchema>? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseUser? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUser>? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUser? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseWorkspaceMemberSchema? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceMemberSchema>? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceMemberSchema? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseWorkspace? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspace>? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspace? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsResponse? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimit>? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportGroupBy? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportItem? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageReportServiceTier? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportItem>? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTokenUsage? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgApiKeyLimitExceededErrorDetails? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgMemberLimitExceededErrorDetails? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgServiceScope? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationPermissionResource? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationSchema? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationScope? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTypeNotSupportedErrorDetails? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPlugin? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginComponent>? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginComponent? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScan? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByVariant1? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginUserActor? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginApiActor? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1Discriminator? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1DiscriminatorType? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOrganizationInstallationPreference? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Owner? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerOrganization? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerUser? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminator? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminatorType? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginReach? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginComponentType? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScanAssessment? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScanStatus? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginDeleted? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSetting? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingInstallationPreference? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganization? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetRbacGroup? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganizationMember? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingTargetDiscriminator? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingTargetDiscriminatorType? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeleted? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target2? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminator? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminatorType? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingList? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginInstallationSetting>? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginList? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPlugin>? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplace? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Owner2? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceOwnerDiscriminator? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceOwnerDiscriminatorType? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceSource? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceSyncStatus? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceList? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplace>? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginError? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginWarning? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning>? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationReport? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginError>? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings>? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginNameTakenErrorDetails? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShare? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target3? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminator? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminatorType? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareList? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginShare>? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersion? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByVariant12? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionCreatedByVariant1Discriminator? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionCreatedByVariant1DiscriminatorType? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionReach? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionList? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginVersion>? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimit? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitModelGroup? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitBatchGroup? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitTokenCountGroup? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitFilesGroup? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitSkillsGroup? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitWebSearchGroup? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupDiscriminator? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupDiscriminatorType? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupType? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimitValue>? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitValue? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitListResponse? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimit>? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroup? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupSourceType? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupList? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacGroup>? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupMember? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupMemberList? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacGroupMember>? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupScope? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRole? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleList? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacRole>? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermission? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Resource? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminator? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionList? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacRolePermission>? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRegistrationPendingErrorDetails? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRoleSchema? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenParams? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScanFailedErrorDetails? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScanPendingErrorDetails? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSeatTierScope? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccount? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountOrganizationRole? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountCreateParams? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountCreateParamsOrganizationRole? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountListResponse? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaServiceAccount>? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountUpdateParams? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountUpdateParamsOrganizationRole? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMember? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRoleSchema? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberCreateFromSAParams? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberCreateParams? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberDeleteResponse? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberListResponse? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaServiceAccountWorkspaceMember>? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberUpdateParams? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParams? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope2? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserScope? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceScope? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminator? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminatorType? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillNameTakenErrorDetails? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope3? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageTierScope? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminator? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminatorType? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestListResponse? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchema? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor3? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchemaActorDiscriminator? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchemaActorDiscriminatorType? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResolvedByVariant12? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1Discriminator? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor4? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryActorDiscriminator? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryActorDiscriminatorType? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope4? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryScopeDiscriminator? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryScopeDiscriminatorType? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source7? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummarySourceDiscriminator? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummarySourceDiscriminatorType? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnel? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnelCertificate? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelCertificateListResponse? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationTunnelCertificate>? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelListResponse? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationTunnel>? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnelToken? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupParams? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserParams? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserParamsRole? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberParams? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyResponse? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyResponseStatus? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceApiKeyLimitExceededErrorDetails? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceCreateParams? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceMemberLimitExceededErrorDetails? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimit? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group2? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminator? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminatorType? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupType? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitValue>? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValue? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitListResponse? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimit>? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateParams? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitUpdateValue>? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateValue? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateValueType? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source8? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminator? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminatorType? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceUpdateParams? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceParams? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AllowedInferenceGeo? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AlreadyMemberErrorDetails? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKey? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedBy? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PrincipalVariant12? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUserActor? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyServiceAccountActor? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1Discriminator? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1DiscriminatorType? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope5? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyOrganizationScope? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyWorkspaceScope? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminator? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminatorType? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyStatus? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUpdateParams? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUpdateParamsStatus? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AttachedAttachment? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AwsExternalKeyConfig? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfig? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfigParams? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CannotInviteEmailsWithUnverifiedDomainsErrorDetails? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CannotRemoveLastMemberErrorDetails? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettings? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsState? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabled? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabled? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminator? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminatorType? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabledParams? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabledParams? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParams? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminator? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminatorType? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsUpdateParams? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConcurrentMembershipChangeErrorDetails? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteParams? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteParamsRole? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberParams? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NoBillingWorkspaceRoleSchema? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByType? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidency? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>, string>? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InferenceGeo? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceGeo? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidencyCreateParams? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidencyUpdateParams? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyResponse? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteResponse? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteUserResponse? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberResponse? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EmailDomainNotAllowedErrorDetails? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKey? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Attachment2? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnattachedAttachment? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminator? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminatorType? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig3? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GcpExternalKeyConfig? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyProviderConfigDiscriminator? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyProviderConfigDiscriminatorType? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParams? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig4? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminator? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminatorType? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyListResponse? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ExternalKey>? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParams? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfigVariant12? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1Discriminator? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuer? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks3? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksDiscovery? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksExplicitUrl? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksInline? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerJwksDiscriminator? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerJwksDiscriminatorType? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.IssuerPollStatus? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParams? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks4? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminator? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminatorType? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerListResponse? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationIssuer>? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParams? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksVariant12? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParamsJwksVariant1Discriminator? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParamsJwksVariant1DiscriminatorType? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRule? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RuleMatch? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountTarget? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleCreateParams? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleListResponse? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationRule>? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleUpdateParams? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleWorkspace? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleWorkspaceListResponse? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationRuleWorkspace>? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteAlreadyExistsErrorDetails? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteSchema? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationRoleSchema? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteStatusSchema? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseApiKey? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ApiKey>? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseInviteSchema? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InviteSchema>? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseUser? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.User>? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.User? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseWorkspaceMemberSchema? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceMemberSchema>? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceMemberSchema? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseWorkspace? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Workspace>? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Workspace? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgApiKeyLimitExceededErrorDetails? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgMemberLimitExceededErrorDetails? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationSchema? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimit? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group3? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitModelGroup? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitBatchGroup? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitTokenCountGroup? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitFilesGroup? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitSkillsGroup? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitWebSearchGroup? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupDiscriminator? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupDiscriminatorType? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupType? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RateLimitValue>? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitValue? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitListResponse? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RateLimit>? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveFederationRuleWorkspaceResponse? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccount? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountOrganizationRole? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountCreateParams? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountCreateParamsOrganizationRole? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountListResponse? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ServiceAccount>? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountUpdateParams? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountUpdateParamsOrganizationRole? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMember? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRoleSchema? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberCreateFromSAParams? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberCreateParams? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberDeleteResponse? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberListResponse? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ServiceAccountWorkspaceMember>? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberUpdateParams? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserParams? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserParamsRole? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberParams? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyResponse? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyResponseStatus? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceApiKeyLimitExceededErrorDetails? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceCreateParams? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceMemberLimitExceededErrorDetails? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimit? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group4? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminator? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminatorType? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupType? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimitValue>? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValue? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitListResponse? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimit>? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitOrganizationSource? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateParams? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimitUpdateValue>? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateValue? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateValueType? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source9? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitWorkspaceSource? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValueSourceDiscriminator? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValueSourceDiscriminatorType? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceUpdateParams? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsConflictError? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsConflictErrorType? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminator? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminatorType? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminator? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminatorType? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsWithoutStream? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant192? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsWithoutStreamCacheControlVariant1Discriminator? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsWithoutStreamCacheControlVariant1DiscriminatorType? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsWithoutStreamServiceTier? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnthropicBeta? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnthropicBetaEnum? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminator? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminatorType? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminator? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminatorType? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminator? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminatorType? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminator? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminatorType? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminator? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminatorType? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminator? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminatorType? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminator? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminatorType? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminator? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminatorType? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventType? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401BashInput? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401ReadInput? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401WriteInput? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401EditInput? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401GlobInput? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401GrepInput? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageVariant1Item? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminator? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminatorType? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PingType? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostRequest? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostRequest? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostRequest? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequest? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ModelsListLifecycleItem>? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListLifecycleItem? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelsListLifecycleItem>? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListLifecycleItem? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionStatus>? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEventType>? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadStatus>? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamStatus>? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse>? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListApiKeysV1OrganizationsApiKeysGetStatus? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportGroupBy>? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item>? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitIncreaseRequestStatus>? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginsV1OrganizationsPluginsGetOwnerType? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProductFilter>? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item>? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item>? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item>? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item>? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item>? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item>? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item>? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item>? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item>? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillsV1OrganizationsAnalyticsSkillsGetOrder? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item>? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item>? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item>? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse>? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatus? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse2? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError2? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse3? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError3? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse4? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError4? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse5? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError5? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse6? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError6? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompletePostResponse? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompletePostResponseError? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails>? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListResponse? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListResponseError? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsGetResponse? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsGetResponseError? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponse? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponseError? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.CmekKeyDisabledErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails>? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponse2? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponseError2? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesListResponse? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesListResponseError? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesRetrieveResponse? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesRetrieveResponseError? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesDeleteResponse? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesDeleteResponseError? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesCancelResponse? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesCancelResponseError? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesResultsResponse? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesResultsResponseError? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse2? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError2? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse3? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError3? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse4? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError4? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostResponse? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostResponseError? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListFilesV1FilesGetResponse? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListFilesV1FilesGetResponseError? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetFileMetadataV1FilesFileIdGetResponse? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetFileMetadataV1FilesFileIdGetResponseError? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteFileV1FilesFileIdDeleteResponse? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteFileV1FilesFileIdDeleteResponseError? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponse? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponseError? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponse2? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponseError2? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponse? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponseError? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponse2? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponseError2? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsV1SkillsGetResponse? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsV1SkillsGetResponseError? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillV1SkillsSkillIdGetResponse? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillV1SkillsSkillIdGetResponseError? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillV1SkillsSkillIdDeleteResponse? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillV1SkillsSkillIdDeleteResponseError? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponse? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponseError? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponse2? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponseError2? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsV1SkillsSkillIdVersionsGetResponse? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsV1SkillsSkillIdVersionsGetResponseError? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillVersionV1SkillsSkillIdVersionsVersionGetResponse? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillVersionV1SkillsSkillIdVersionsVersionGetResponseError? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponse? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponseError? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse2? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError2? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse3? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError3? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse4? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError4? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse5? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError5? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse6? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError6? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListResponse? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListResponseError? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails>? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsGetResponse? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsGetResponseError? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponse? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponseError? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponse2? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponseError2? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesListResponse? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesListResponseError? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesRetrieveResponse? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesRetrieveResponseError? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesDeleteResponse? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesDeleteResponseError? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesCancelResponse? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesCancelResponseError? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesResultsResponse? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesResultsResponseError? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse2? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError2? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse3? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError3? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse4? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError4? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostResponse? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostResponseError? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListFilesV1FilesGetResponse? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListFilesV1FilesGetResponseError? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetFileMetadataV1FilesFileIdGetResponse? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetFileMetadataV1FilesFileIdGetResponseError? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteFileV1FilesFileIdDeleteResponse? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteFileV1FilesFileIdDeleteResponseError? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponse? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponseError? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponse2? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponseError2? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponse? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponseError? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponse2? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponseError2? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsV1SkillsGetResponse? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsV1SkillsGetResponseError? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponse? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponseError? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillV1SkillsSkillIdDeleteResponse? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillV1SkillsSkillIdDeleteResponseError? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseError? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse2? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseError2? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsV1SkillsSkillIdVersionsGetResponse? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsV1SkillsSkillIdVersionsGetResponseError? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillVersionV1SkillsSkillIdVersionsVersionGetResponse? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillVersionV1SkillsSkillIdVersionsVersionGetResponseError? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponse? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponseError? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponse? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponseError? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponse2? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponseError2? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEnvironmentsV1EnvironmentsGetResponse? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEnvironmentsV1EnvironmentsGetResponseError? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponseError? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponse? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponseError? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponse2? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponseError2? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteResponse? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteResponseError? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveEnvironmentV1EnvironmentsEnvironmentIdArchivePostResponse? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveEnvironmentV1EnvironmentsEnvironmentIdArchivePostResponseError? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentStatsV1EnvironmentsEnvironmentIdWorkStatsGetResponse? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentStatsV1EnvironmentsEnvironmentIdWorkStatsGetResponseError? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRecordHeartbeatV1EnvironmentsEnvironmentIdWorkWorkIdHeartbeatPostResponse? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRecordHeartbeatV1EnvironmentsEnvironmentIdWorkWorkIdHeartbeatPostResponseError? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopWorkV1EnvironmentsEnvironmentIdWorkWorkIdStopPostResponse? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopWorkV1EnvironmentsEnvironmentIdWorkWorkIdStopPostResponseError? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkV1EnvironmentsEnvironmentIdWorkWorkIdGetResponse? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkV1EnvironmentsEnvironmentIdWorkWorkIdGetResponseError? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkV1EnvironmentsEnvironmentIdWorkWorkIdPostResponse? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkV1EnvironmentsEnvironmentIdWorkWorkIdPostResponseError? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponse? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponseError? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse2? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError2? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaOrgApiKeyLimitExceededErrorDetails, global::Anthropic.BetaWorkspaceApiKeyLimitExceededErrorDetails>? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponse? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponseError? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetResponse? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetResponseError? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitV1OrganizationsSpendLimitsPostResponse? Type3704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitV1OrganizationsSpendLimitsPostResponseError? Type3705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaBillingFrozenErrorDetails, global::Anthropic.BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails>? Type3706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSpendLimitV1OrganizationsSpendLimitsSpendLimitIdGetResponse? Type3707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSpendLimitV1OrganizationsSpendLimitsSpendLimitIdGetResponseError? Type3708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteResponse? Type3709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteResponseError? Type3710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse? Type3711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError? Type3712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails>? Type3713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse2? Type3714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError2? Type3715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaPluginNameTakenErrorDetails, global::Anthropic.BetaSkillNameTakenErrorDetails>? Type3716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse3? Type3717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError3? Type3718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse? Type3719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError? Type3720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails, global::Anthropic.BetaScanFailedErrorDetails>? Type3721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse2? Type3722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError2? Type3723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaScanPendingErrorDetails, global::Anthropic.BetaSkillNameTakenErrorDetails>? Type3724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponse? Type3725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponseError? Type3726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse? Type3727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError? Type3728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse2? Type3729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError2? Type3730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse3? Type3731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError3? Type3732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponse? Type3733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponseError? Type3734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponse? Type3735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponseError? Type3736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse? Type3737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError? Type3738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse2? Type3739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError2? Type3740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse? Type3741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError? Type3742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse? Type3743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError? Type3744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse? Type3745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError? Type3746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.OrgApiKeyLimitExceededErrorDetails, global::Anthropic.WorkspaceApiKeyLimitExceededErrorDetails>? Type3747 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AllowedCaller>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAllowedCaller>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.List<string>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaContainerSkill>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkillParams>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBetaContentBlockSourceContentItem>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBetaContentBlockSourceContentItem>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.EditsItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestMCPServerURLDefinition>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInputMessage>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaRequestTextBlock>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestTextBlock>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamInput>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatchIndividualRequestParams>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaFallbackConfigV2>, string>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFallbackConfigV2>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaToolUnion>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamOutput>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaEnvironment>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFileMetadataSchema>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaInputContentBlock>>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInputContentBlock>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDream>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatch>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelInfo>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkillVersion>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkill>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTelemetryDestinationWorkspace>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTelemetryDestination>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTunnelCertificate>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTunnel>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUserProfile>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMCPTool>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentTool>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPServer>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSkill>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentMessageContentBlock>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsUserContentBlock>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolConfigUnion>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolParams>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPServerParams>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSkillParams>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResourceParams>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.DateTime>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResourceConfig>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSystemContentBlock>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgent>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsCredential>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentRun>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeployment>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryListItem>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryStore>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryVersion>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionEvent>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResource>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThread>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSession>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsVault>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPToolConfig>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentRosterEntry>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentReference>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSearchResultContent>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsInputEvent>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsEventParams>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionRosterEntry>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsWorkflowRunPhase>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaContentBlock>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInputTransformation>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaIterationsUsageVariant1Item>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.StateChangesVariant1Item>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaBrowserStateTabEntry>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestCodeExecutionOutputBlock>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ToolChangesVariant1Item>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item>>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestToolReferenceBlock>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaRequestWebSearchToolResultError>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestWebSearchResultBlock>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseCodeExecutionOutputBlock>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ToolChangesVariant1Item2>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AppliedEditsItem>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseMCPTool>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaResponseTextBlock>>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseTextBlock>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item2>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseToolReferenceBlock>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.BetaResponseWebSearchResultBlock>>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseWebSearchResultBlock>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSelfHostedWork>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWebFetchUrlSourceToolReference>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContainerSkill>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SkillParams>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentContentBlockSourceContentItem>>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentContentBlockSourceContentItem>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InputMessage>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.RequestTextBlock>>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestTextBlock>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.MessageBatchIndividualRequestParams>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FileMetadataSchema>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.InputContentBlock>>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InputContentBlock>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.MessageBatch>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ModelInfo>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SkillVersion>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.Skill>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfile>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlock3>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestBashCodeExecutionOutputBlock>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.StateChangesVariant1Item2>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BrowserStateTabEntry>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestCodeExecutionOutputBlock>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item3>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestToolReferenceBlock>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.RequestWebSearchToolResultError>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseBashCodeExecutionOutputBlock>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseCodeExecutionOutputBlock>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item4>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseToolReferenceBlock>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WebFetchUrlSourceToolReference>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSingleDayActivitySummary>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsArtifactActivity>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsConnectorActivity>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostReportTimeBucket>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostBucketedResult>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostUsersItem>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsPluginActivity>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProjectActivity>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSkillActivity>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageReportTimeBucket>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageBucketedResult>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageUsersItem>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUserActivity>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelBreakdown>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportItem>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaAllowedInferenceGeo>, string>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAllowedInferenceGeo>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaExternalKey>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationIssuer>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationRule>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationRuleWorkspace>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeCodeUsageReportItem>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportTimeBucket>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportTimeBucket>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendSummary>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaApiKey>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInviteSchema>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUser>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceMemberSchema>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspace>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimit>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportItem>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginComponent>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginInstallationSetting>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPlugin>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplace>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginError>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginShare>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginVersion>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRateLimitValue>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRateLimit>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacGroup>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacGroupMember>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacRole>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacRolePermission>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaServiceAccount>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaServiceAccountWorkspaceMember>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationTunnelCertificate>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationTunnel>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimitValue>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimit>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimitUpdateValue>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.AllowedInferenceGeo>, string>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AllowedInferenceGeo>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ExternalKey>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationIssuer>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationRule>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationRuleWorkspace>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ApiKey>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InviteSchema>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.User>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceMemberSchema>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.Workspace>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RateLimitValue>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RateLimit>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ServiceAccount>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ServiceAccountWorkspaceMember>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimitValue>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimit>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimitUpdateValue>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnthropicBeta>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ModelsListLifecycleItem>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelsListLifecycleItem>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionStatus>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionEventType>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsEventDeltaType>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThreadStatus>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamStatus>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUsageReportServiceTier>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportContextWindow>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInferenceGeoFilter>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpeed>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportGroupBy>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportGroupBy>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitIncreaseRequestStatus>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProductFilter>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsClaudeTagCategory>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse>? ListType249 { get; set; }
    }
}