
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::Anthropic.AnthropicBeta? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnthropicBetaEnum? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AssistantInputMessage? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageContent? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AuthenticationError? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AvailableToolsLimitExceededErrorDetails? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Base64ImageSource? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Base64ImageSourceMediaType? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Base64PDFSource? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashCodeExecutionToolResultErrorCode? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashTool20250124? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AllowedCaller>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant1? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlEphemeral? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashTool20250124CacheControlVariant1Discriminator? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashTool20250124CacheControlVariant1DiscriminatorType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JsonValue? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAPIError? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorMessageIterationUsage? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheCreation? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Model? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorToolResultErrorCode? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedCaller>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllowedCaller? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant12? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheControlEphemeral? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1Discriminator? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CachingVariant1? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CachingVariant1Discriminator? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CachingVariant1DiscriminatorType? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllThinkingTurns? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeMissingErrorDetails? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAssistantInputMessage? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageContent? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAuthenticationError? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAvailableToolsLimitExceededErrorDetails? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBase64ImageSource? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBase64ImageSourceMediaType? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBase64PDFSource? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashCodeExecutionToolResultErrorCode? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20241022? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant13? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20241022CacheControlVariant1Discriminator? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20241022CacheControlVariant1DiscriminatorType? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJsonValue? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20250124? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant14? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20250124CacheControlVariant1Discriminator? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20250124CacheControlVariant1DiscriminatorType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBillingError? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBodyCreateSkillV1SkillsPost? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBodyCreateSkillVersionV1SkillsSkillIdVersionsPost? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTarget? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCoordinateTarget? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRefTarget? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTargetDiscriminator? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTargetDiscriminatorType? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCloseTabConfig? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCloseTabInput? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserDoubleClickConfig? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserDoubleClickInput? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFileUploadConfig? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFileUploadInput? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFindConfig? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFindInput? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputConfig? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputInput? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputValue? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserGetPageTextConfig? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserGetPageTextInput? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoldKeyConfig? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoldKeyInput? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoverConfig? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoverInput? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserJavascriptExecConfig? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserJavascriptExecInput? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserKeyConfig? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserKeyInput? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickConfig? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickDragConfig? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickDragInput? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickInput? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseDownConfig? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseDownInput? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseUpConfig? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseUpInput? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserListTabsConfig? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserListTabsInput? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMemberInput? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNavigateInput? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNewTabInput? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserSwitchTabInput? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageInput? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadConsoleInput? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadNetworkInput? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollToInput? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScreenshotInput? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserZoomInput? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRightClickInput? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMiddleClickInput? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTripleClickInput? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMouseMoveInput? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollInput? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTypeInput? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserWaitInput? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMiddleClickConfig? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMouseMoveConfig? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNavigateConfig? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNewTabConfig? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadConsoleConfig? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadNetworkConfig? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageConfig? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageFilter? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRightClickConfig? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScreenshotConfig? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollConfig? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollDirection? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollToConfig? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadCompleted? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadFailed? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadStarted? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeTabOpened? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateTabEntry? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserSwitchTabConfig? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolsetConfigs? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTripleClickConfig? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTypeConfig? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserWaitConfig? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserZoomConfig? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant15? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801CacheControlVariant1Discriminator? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801CacheControlVariant1DiscriminatorType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheControlEphemeralTtl? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissMessagesChanged? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissModelChanged? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissPreviousMessageNotFound? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReason? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissSystemChanged? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissToolsChanged? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissUnavailable? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReasonDiscriminator? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReasonDiscriminatorType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCanceledResult? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCapabilitySupport? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDelta? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Citation? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCharLocationCitation? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponsePageLocationCitation? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContentBlockLocationCitation? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchResultLocationCitation? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseSearchResultLocationCitation? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDeltaCitationDiscriminator? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDeltaCitationDiscriminatorType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeVersionTooOldErrorDetails? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundle? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundleTarget? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTarget? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundleTargetDiscriminator? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundleTargetDiscriminatorType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBody? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminator? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateSlackChannelRequest? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelIdentifiers? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingsCreate? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagDefaultSettingSource? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagDeletedBundleTarget? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagDeletedSlackChannel? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicy? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyAllow? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyRestrict? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyDiscriminator? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyDiscriminatorType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListBundleTargetsResponse? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagBundleTarget>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListBundlesResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagBundle>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListSlackChannelsResponse? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSlackChannel>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannel? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListSlackWorkspacesResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSlackWorkspace>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspace? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSource? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelSettingSource? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackDefaultSettingSource? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSourceDiscriminator? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSources? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSettingSource>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettings? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingsUpdate? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceIdentifiers? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagUpdateSlackChannelRequestBody? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagUpdateSlackWorkspaceRequestBody? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearThinking20251015? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.OneOf<global::Anthropic.BetaThinkingTurns, global::Anthropic.BetaAllThinkingTurns>?, string>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaThinkingTurns, global::Anthropic.BetaAllThinkingTurns>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingTurns? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTokensClearAtLeast? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUsesKeep? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919KeepDiscriminator? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919KeepDiscriminatorType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Trigger? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTokensTrigger? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUsesTrigger? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919TriggerDiscriminator? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919TriggerDiscriminatorType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClientToolUnion? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTool? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfig? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Networking? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnrestrictedNetwork? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLimitedNetwork? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigNetworkingDiscriminator? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigNetworkingDiscriminatorType? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPackages? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParams? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NetworkingVariant1? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLimitedNetworkParams? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParamsNetworkingVariant1Discriminator? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParamsNetworkingVariant1DiscriminatorType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPackagesParams? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekContextUnavailableErrorDetails? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyDisabledErrorDetails? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyUnreachableErrorDetails? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionToolResultErrorCode? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant16? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1Discriminator? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1DiscriminatorType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant17? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1Discriminator? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1DiscriminatorType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant18? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1Discriminator? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1DiscriminatorType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant19? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521CacheControlVariant1Discriminator? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521CacheControlVariant1DiscriminatorType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompact20260112? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionBlockMisplacedErrorDetails? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionCapability? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfig? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSummarizeCompaction? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfigDiscriminator? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfigDiscriminatorType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionContentBlockDelta? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionContentMismatchErrorDetails? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionIncompleteTurnErrorDetails? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionIterationUsage? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionSignatureInvalidErrorDetails? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionTooManyToolReferencesErrorDetails? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionUnavailableErrorDetails? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceConfigurationRestrictedErrorDetails? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionConfig? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionInput? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickConfig? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickInput? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyConfig? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyInput? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyConfig? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyInput? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickConfig? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragConfig? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragInput? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickInput? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownConfig? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownInput? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpConfig? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpInput? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMemberInput? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeInput? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveInput? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickInput? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickInput? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickInput? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollInput? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitInput? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotInput? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomInput? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickConfig? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveConfig? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickConfig? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotConfig? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollConfig? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollDirection? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolsetConfigs? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickConfig? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeConfig? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitConfig? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomConfig? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant110? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801CacheControlVariant1Discriminator? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801CacheControlVariant1DiscriminatorType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant111? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1Discriminator? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1DiscriminatorType? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant112? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1Discriminator? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant113? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1Discriminator? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1DiscriminatorType? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainer? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaContainerSkill>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerSkill? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerParams? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillParams>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillParams? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerSkillType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlock? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlock? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseThinkingBlock? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseRedactedThinkingBlock? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlock? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlock? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlock? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlock? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorToolResultBlock? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionToolResultBlock? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolResultBlock? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolUseBlock? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolResultBlock? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContainerUploadBlock? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlock? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseFallbackBlock? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolListingBlock? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminator? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminatorType? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEvent? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Delta? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextContentBlockDelta? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputJsonContentBlockDelta? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingContentBlockDelta? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignatureContentBlockDelta? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSource? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBetaContentBlockSourceContentItem? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlock? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlock? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminator? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEvent? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminator? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStopEvent? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementCapability? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfig? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.EditsItem>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EditsItem? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminator? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminatorType? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementResponse? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParams? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant114? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1Discriminator? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1DiscriminatorType? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestMCPServerURLDefinition>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPServerURLDefinition? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputMessageUnion>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnion? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputConfig? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJsonOutputFormat? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpeed? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParam? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoice? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolset? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensResponse? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateDreamRequest? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInput? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelParams? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehavior? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageBatchParams? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatchIndividualRequestParams>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualRequestParams? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParams? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant115? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsCacheControlVariant1Discriminator? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsCacheControlVariant1DiscriminatorType? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaContainerParams, string>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDiagnosticsParam? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::Anthropic.BetaFallbackCreditTokenParam>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditTokenParam? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaFallbackConfigV2>, string>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFallbackConfigV2>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMetadata? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsServiceTier? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadVariant1? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadCreateParams? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadContinueParams? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsThreadVariant1Discriminator? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsThreadVariant1DiscriminatorType? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaToolUnion>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUnion? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTelemetryDestinationRequest? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTracesParams? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParams? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelCertificateRequestBody? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelRequest? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateUserProfileActionUrlRequestBody? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileAction? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateUserProfileRequest? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileAccessType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserDetailsParams? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCurrency? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteMessageBatchResponse? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedSkill? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedSkillVersion? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedTelemetryDestination? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedTelemetryDestinationWorkspace? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedUserProfile? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDiagnostics? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDirectCaller? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDream? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamOutput>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutput? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamStatus? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamError? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelConfig? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamUsage? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreInput? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamSessionsInput? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminator? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminatorType? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreOutput? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelConfigParams? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminator? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminatorType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingError? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidRequestError? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPermissionError? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNotFoundError? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitError? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGatewayTimeoutError? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOverloadedError? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTargetStoreHeldError? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminator? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminatorType? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorResponse? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffortCapability? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffortLevel? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnrollmentUrl? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironment? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Config? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfig? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminator? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminatorType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentScope? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentArchivedErrorDetails? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentCreateDisabledErrorDetails? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentDeleteResponse? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentListResponse? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaEnvironment>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentNotFoundErrorDetails? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentUpdateDisabledErrorDetails? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorResponse? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Error? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorResponseErrorDiscriminator? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorResponseErrorDiscriminatorType? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorType? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErroredResult? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExpiredResult? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingVariant1? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigEnabled? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigDisabled? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigBetweenTools? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigAdaptive? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2ThinkingVariant1Discriminator? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2ThinkingVariant1DiscriminatorType? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditNotApplied? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditNotAppliedReason? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditRedeemed? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditTokenParamMode? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsage? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Status? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsageStatusDiscriminator? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsageStatusDiscriminatorType? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackMessageIterationUsage? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackRefusalTrigger? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRefusalCategory? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileDeleteResponse? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileDocumentSource? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileExpiredErrorDetails? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileImageSource? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileListResponse? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFileMetadataSchema>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileMetadataSchema? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileScope? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileNotDownloadableErrorDetails? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaHeartbeatPreconditionFailedErrorDetails? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkLeaseState? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlock? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlock? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlock? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestThinkingBlock? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestRedactedThinkingBlock? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlock? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlock? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlock? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlock? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlock? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlock? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlock? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlock? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlock? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlock? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlock? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlock? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlock? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlock? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolListingBlock? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestFallbackBlock? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminator? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminatorType? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserInputMessage? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessage? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnionDiscriminator? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnionDiscriminatorRole? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputSchema? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformation? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformation? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminator? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminatorType? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidConfigTypeChangeErrorDetails? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidMetadataErrorDetails? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaIterationsUsageVariant1Item>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageVariant1Item? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageIterationUsage? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminator? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminatorType? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListDreamsResponse? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDream>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseMessageBatch? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatch>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatch? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseModelInfo? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelInfo>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelInfo? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsResponse? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillVersion>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillVersion? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsResponse? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkill>? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkill? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTelemetryDestinationWorkspacesResponse? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTelemetryDestinationWorkspace>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspace? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTelemetryDestinationsResponse? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTelemetryDestination>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestination? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTunnelCertificatesResponse? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTunnelCertificate>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelCertificate? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTunnelsResponse? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTunnel>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnel? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListUserProfilesResponse? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUserProfile>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfile? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPTool? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolConfig? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolDefaultConfig? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant116? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolsetCacheControlVariant1Discriminator? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolsetCacheControlVariant1DiscriminatorType? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaMCPToolConfig>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMCPTool>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActor? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionActor? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsApiActor? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserActor? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountActor? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminator? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminatorType? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResource? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResource? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminator? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminatorType? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParams? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceParams? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminator? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminatorType? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisor? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisorParams? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgent? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelConfig? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool>? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentTool? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServer? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkill? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentity? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedRunError? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminator? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStruct? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentEvaluatedPermission? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlock? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluation? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlock? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextBlock? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRedactedBlock? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminator? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminatorType? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageEvent? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentMessageContentBlock>? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentParams? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentReference? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThinkingEvent? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlock? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolset? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomTool? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminator? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminatorType? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnion? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfig? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfig? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfig? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfig? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfig? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfig? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfig? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfig? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminator? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminatorType? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfigParams? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfigParams? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfigParams? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfigParams? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfigParams? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfigParams? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminator? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminator? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminatorType? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolName? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParams? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401Params? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetParams? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolParams? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminator? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminatorType? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolResultEvent? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolUseEvent? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfig? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigUnion>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfigParams? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401BashInput? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401EditInput? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401GlobInput? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401GrepInput? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401ReadInput? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401WriteInput? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicy? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParams? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2Discriminator? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelParams? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParams? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParams? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkill? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkillParams? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponse? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStore? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminator? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAutoPolicy? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64DocumentSource? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64ImageSource? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBillingError? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatus? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBranchCheckout? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudget? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetLimit? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminator? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminatorType? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMonetaryAmount? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCacheCreationUsage? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCommitCheckout? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCompactionLimitReachedError? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsContentSha256Precondition? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateAgentParams? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParams? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParams? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateCredentialRequestBody? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuth? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateDeploymentParams? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParams? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParams? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryParams? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreRequest? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponse? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminator? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParams? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionParams? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParams? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateVaultRequest? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredential? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuth? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableAuthResponse? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminator? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminatorType? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminator? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminatorType? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParams? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminator? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminator? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialRefreshStatus? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuth? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminator? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminatorType? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidation? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidationStatus? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpProbe? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRefreshObject? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronSchedule? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.DateTime>? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronScheduleParams? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkill? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkillParams? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolInputSchema? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponse? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemoryStore? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminator? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteSessionResource? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedCredential? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemory? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedSession? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedVault? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeployment? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent>? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEvent? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceConfig>? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfig? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSchedule? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentStatus? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReason? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminator? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminatorType? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEventParams? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEventParams? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminator? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminator? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminatorType? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminator? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentRun? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContext? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunError? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSystemContentBlock>? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlock? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubric? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentBlock? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSource? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSource? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLDocumentSource? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileDocumentSource? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminator? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminatorType? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffort? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLow? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMedium? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortHigh? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortXhigh? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMax? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminator? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminatorType? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLevel? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortParams? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationResponse? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationParams? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationUpdateParams? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsError? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPathConflictError? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsConflictError? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminator? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminatorType? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorResponse? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEvent? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDelta? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminator? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaType? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParams? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEventParams? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEventParams? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminator? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminatorType? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEvent? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEvent? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminator? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminatorType? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminator? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminatorType? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminator? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminatorType? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileImageSource? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundRunError? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceConfig? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubric? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubricParams? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponse? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminator? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminatorType? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResource? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResource? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResource? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminator? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminatorType? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckout? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageBlock? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSource? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLImageSource? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminator? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminatorType? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInlineAgent? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEvent? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEvent? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminator? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminatorType? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListAgentVersions? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgent>? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListAgents? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListCredentialsResponse? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsCredential>? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListDeploymentRunsData? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentRun>? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListDeploymentsData? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeployment>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoriesResult? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryListItem>? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItem? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoryStoresResponse? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryStore>? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoryVersionsResult? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryVersion>? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersion? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListOrder? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionEvents? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEvent>? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEvent? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionResources? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResource>? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResource? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionThreadEvents? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionThreads? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThread>? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThread? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessions? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSession>? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSession? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListVaultsResponse? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsVault>? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVault? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerURLDefinition? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminator? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminatorType? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLMCPServerParams? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminator? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminatorType? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolConfig? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolConfigParams? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfig? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfig>? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfigParams? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualTriggerContext? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponse? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParams? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminator? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminator? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParams? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminator? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorType? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRefreshHttpResponse? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemory? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPrefix? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminator? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminatorType? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMountMode? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersionOperation? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryView? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModel? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpeed? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelConfigParams? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelOverloadedError? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRateLimitedError? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRequestFailedError? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinator? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminator? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminatorType? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflows? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagents? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisor? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001Params? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParams? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParams? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabled? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabled? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDiscriminator? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDiscriminatorType? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminator? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntry>? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntry? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams>? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgents? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminator? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParams? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminator? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminator? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminatorType? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSelfParams? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryDiscriminator? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryDiscriminatorType? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabled? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDiscriminator? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDiscriminatorType? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentReference>? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminator? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminator? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminatorType? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminator? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminator? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminatorType? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPrecondition? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminator? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminatorType? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminator? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminatorType? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCloneError? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusRetrying? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusExhausted? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusTerminal? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminator? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminatorType? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubric? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminator? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminatorType? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParams? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubricParams? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminator? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminatorType? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedRunError? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownRunError? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminator? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminator? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminatorType? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminator? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminatorType? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleTriggerContext? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultBlock? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSearchResultContent>? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultContent? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultCitations? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSendSessionEvents? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsInputEvent>? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSendSessionEventsParams? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventParams>? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServerToolUsage? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatus? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgent? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource>? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsage? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStats? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagent? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgentUpdate? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionBudgetReached? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionDeletedEvent? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEndTurn? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEvent? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventError? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownError? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolUseLimitReachedError? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminator? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageEvent? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventDiscriminator? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventDiscriminatorType? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminator? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminatorType? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagent20261001? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminator? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminatorType? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflows? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagents? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionRosterEntry>? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntry? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminator? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgent? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsEnabled? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsDiscriminator? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusal? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetailsCategory? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRequiresAction? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceDiscriminator? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceDiscriminatorType? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminator? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminatorType? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminator? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminatorType? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminator? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminatorType? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetails? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReason? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminator? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminator? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminatorType? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatus? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntry? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadUsage? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStats? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntryDiscriminator? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReason? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminator? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageSnapshot? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminator? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminatorType? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminator? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminatorType? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelUsage? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEvents? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminator? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminator? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminator? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminatorType? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminator? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminatorType? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminator? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminatorType? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerType? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateAgentParams? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateCredentialRequestBody? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateDeploymentParams? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryParams? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreRequestBody? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminator? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionParams? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResource? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminator? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminatorType? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceParams? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateVaultRequestBody? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminator? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminatorType? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserLocation? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationResult? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSources? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourcesParams? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference>? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminator? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterParams? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminator? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputParams? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWorkflowRunPhase>? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhase? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunError? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminator? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResult? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultError? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminator? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminatorType? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant117? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CacheControlVariant1Discriminator? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CacheControlVariant1DiscriminatorType? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818Command? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818ViewCommand? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CreateCommand? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818InsertCommand? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818DeleteCommand? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818RenameCommand? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminator? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CreateCommandCommand? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818InsertCommandCommand? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818RenameCommandCommand? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818ViewCommandCommand? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessage? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaContentBlock>? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopReason? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRefusalStopDetails? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsage? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputTransformation>? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagement? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchProcessingStatus? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCounts? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponse? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Result? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSucceededResult? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminator? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDelta? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDeltaEvent? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDeltaUsage? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputTokensDetails? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolUsage? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStartEvent? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStopEvent? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEvent? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Ping? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminator? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminatorType? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelCapabilities? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolsCapability? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingCapability? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelInfoLifecycle? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelLine? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationLevelScopedApiKeyRequiredErrorDetails? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationOnHoldErrorDetails? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorCreateNew? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorUpdateExisting? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminator? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminatorType? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTokenTaskBudget? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPlainTextSource? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequest? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConfigVariant1? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfigParams? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1Discriminator? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestScope? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequest? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConfigVariant12? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1Discriminator? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestScope? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRampLimitExceededErrorDetails? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorRedactedResultBlock? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorResultBlock? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant118? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1Discriminator? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestAdvisorToolResultError, global::Anthropic.BetaRequestAdvisorResultBlock, global::Anthropic.BetaRequestAdvisorRedactedResultBlock>? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultError? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionOutputBlock? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionResultBlock? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant119? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestBashCodeExecutionToolResultError, global::Anthropic.BetaRequestBashCodeExecutionResultBlock>? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultError? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyTooLargeAfterDecodingErrorDetails? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlock? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant120? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockCacheControlVariant1Discriminator? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockCacheControlVariant1DiscriminatorType? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item>? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StateChangesVariant1Item? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminator? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaBrowserStateTabEntry>? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCharLocationCitation? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCitationsConfig? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionOutputBlock? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionResultBlock? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestCodeExecutionOutputBlock>? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant121? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultError? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant122? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1Discriminator? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1DiscriminatorType? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item>? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChangesVariant1Item? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminator? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant123? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1Discriminator? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1DiscriminatorType? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContentBlockLocationCitation? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant124? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1Discriminator? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1DiscriminatorType? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaURLPDFSource? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminator? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestFallbackHopInfo? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant125? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockCacheControlVariant1Discriminator? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockCacheControlVariant1DiscriminatorType? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source2? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaURLImageSource? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminator? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageTransformations? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageTransformationsOversizedImage? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPServerToolConfiguration? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant126? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1Discriminator? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1DiscriminatorType? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant127? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1Discriminator? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1DiscriminatorType? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestPageLocationCitation? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant128? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1Discriminator? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1DiscriminatorType? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultLocationCitation? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant129? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1Discriminator? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1DiscriminatorType? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolCaller? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolCaller20260120? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminator? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminatorType? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockName? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant130? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCacheControlVariant1Discriminator? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCacheControlVariant1DiscriminatorType? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item>? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchResultLocationCitation? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminator? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant131? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditorCodeExecutionToolResultErrorCode? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockFileType? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant132? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockCacheControlVariant1Discriminator? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockCacheControlVariant1DiscriminatorType? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolReference? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolReference? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolsetReference? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolDefinition? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminator? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminatorType? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlock? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant133? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1Discriminator? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1DiscriminatorType? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant134? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1Discriminator? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool2? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminator? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminatorType? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant135? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1Discriminator? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1DiscriminatorType? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>>? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentVariant2Item? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminator? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant136? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1Discriminator? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestToolSearchToolResultError, global::Anthropic.BetaRequestToolSearchToolSearchResultBlock>? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultError? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolSearchResultBlock? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolResultErrorCode? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestToolReferenceBlock>? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant137? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1Discriminator? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1DiscriminatorType? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller2? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCallerDiscriminator? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCallerDiscriminatorType? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchResultBlock? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant138? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1Discriminator? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller3? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminator? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminatorType? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestWebFetchToolResultError, global::Anthropic.BetaRequestWebFetchResultBlock>? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultError? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchToolResultErrorCode? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchResultBlock? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant139? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1Discriminator? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller4? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminator? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminatorType? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaRequestWebSearchToolResultError>? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultError? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchToolResultErrorCode? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorRedactedResultBlock? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorResultBlock? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseAdvisorToolResultError, global::Anthropic.BetaResponseAdvisorResultBlock, global::Anthropic.BetaResponseAdvisorRedactedResultBlock>? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorToolResultError? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionOutputBlock? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionResultBlock? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock>? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseBashCodeExecutionToolResultError, global::Anthropic.BetaResponseBashCodeExecutionResultBlock>? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultError? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCaller? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFindToolUseBlock? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserHoverToolUseBlock? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserKeyToolUseBlock? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScrollToolUseBlock? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlock? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnion? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserZoomToolUseBlock? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserTypeToolUseBlock? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserWaitToolUseBlock? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminator? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCitationsConfig? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseClearThinking20251015Edit? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseClearToolUses20250919Edit? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionOutputBlock? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionResultBlock? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseCodeExecutionOutputBlock>? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionToolResultError? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseEncryptedCodeExecutionResultBlock? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item2>? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChangesVariant1Item2? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlock? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlock? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminator? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerKeyToolUseBlock? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerRightClickToolUseBlock? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerScrollToolUseBlock? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlock? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnion? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerTypeToolUseBlock? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerWaitToolUseBlock? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerZoomToolUseBlock? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminator? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AppliedEditsItem>? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AppliedEditsItem? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminator? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlock? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source3? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlockSourceDiscriminator? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlockSourceDiscriminatorType? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseFallbackHopInfo? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPTool? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseMCPTool>? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>>? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller5? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminator? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminatorType? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockName? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item2>? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item2? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminator? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockFileType? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTool? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolInputSchema? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool3? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeToolReference? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeMCPToolReference? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeMCPToolsetReference? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeToolDefinition? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlockToolDiscriminator? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlockToolDiscriminatorType? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUnion? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolReferenceBlock? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool4? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminator? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminatorType? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseToolSearchToolResultError, global::Anthropic.BetaResponseToolSearchToolSearchResultBlock>? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolResultError? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolSearchResultBlock? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseToolReferenceBlock>? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller6? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockCallerDiscriminator? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockCallerDiscriminatorType? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockUnion? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchResultBlock? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller7? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminator? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminatorType? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebFetchToolResultError, global::Anthropic.BetaResponseWebFetchResultBlock>? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultError? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchResultBlock? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller8? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminator? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminatorType? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>>? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultError? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenRequestBody? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWork? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSessionWorkData? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkState? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkHeartbeatResponse? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkHeartbeatResponseState? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkListResponse? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSelfHostedWork>? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkQueueStats? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkStopRequest? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkUpdateRequest? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillSource? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillParamsType? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillReadBlockedUndecryptableErrorDetails? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillSourceType? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSlackChannelSetUpSettingsConflictErrorDetails? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSlackChannelSetUpSettingsRefusedErrorDetails? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageQuotaExceededErrorDetails? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageClearAt? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem>>? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem>? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlocksItem? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageContentBlockDiscriminator? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageContentBlockDiscriminatorType? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemMessageOutputConfig? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTraces? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationState? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDeliveryHealth? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspaces? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationContentMode? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReason? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminator? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabled? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabled? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminator? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminatorType? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabledParams? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabledParams? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParams? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminator? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminatorType? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTest? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResult? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestFailure? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestSuccess? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminator? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminatorType? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAll? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminator? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminatorType? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminator? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminatorType? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant140? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022CacheControlVariant1Discriminator? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022CacheControlVariant1DiscriminatorType? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant141? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124CacheControlVariant1Discriminator? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124CacheControlVariant1DiscriminatorType? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant142? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429CacheControlVariant1Discriminator? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429CacheControlVariant1DiscriminatorType? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant143? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728CacheControlVariant1Discriminator? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728CacheControlVariant1DiscriminatorType? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingBlockBinding? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingPrefixMismatchBehavior? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingTypes? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDisplayMode? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminator? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminatorType? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformationReason? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformationReason? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadAlreadyContinuedErrorDetails? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadContinueInFlightErrorDetails? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadFingerprintMismatchErrorDetails? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadNotFoundErrorDetails? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadUnsupportedRequestErrorDetails? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant144? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolCacheControlVariant1Discriminator? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolCacheControlVariant1DiscriminatorType? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceAuto? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceAny? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceTool? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceNone? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminator? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminatorType? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolNameConflictErrorDetails? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolReferenceUnresolvedErrorDetails? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant145? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1Discriminator? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119Type? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant146? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1Discriminator? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119Type? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCallerDiscriminator? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCallerDiscriminatorType? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelToken? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateTelemetryDestinationRequestBody? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserProfileRequestBody? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageServiceTier? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserLocation? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserDetails? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaUserProfileTrustGrant>? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileTrustGrant? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileEnrollEndUserAction? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminator? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminatorType? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionUrl? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserAccountStatus? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserEntityType? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileListOrder? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileListOrderBy? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileTrustGrantStatus? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant147? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1Discriminator? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1DiscriminatorType? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSources? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant148? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1Discriminator? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1DiscriminatorType? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant149? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1Discriminator? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1DiscriminatorType? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant150? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318CacheControlVariant1Discriminator? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318CacheControlVariant1DiscriminatorType? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318ResponseInclusion? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceAll? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceExcept? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWebFetchUrlSourceToolReference>? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceToolReference? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceNone? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceOnly? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolResults? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesClientToolResultsDiscriminator? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolResults? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminator? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInput? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminator? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminatorType? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant151? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1Discriminator? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1DiscriminatorType? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant152? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1Discriminator? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1DiscriminatorType? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant153? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318CacheControlVariant1Discriminator? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318CacheControlVariant1DiscriminatorType? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318ResponseInclusion? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentArchivedEventData? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentCreatedEventData? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentDeletedEventData? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentUpdatedEventData? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentArchivedEventData? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentCreatedEventData? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentDeletedEventData? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentPausedEventData? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunFailedEventData? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunStartedEventData? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUnpausedEventData? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUpdatedEventData? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentArchivedEventData? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentCreatedEventData? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentDeletedEventData? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnwrapWebhookEvent? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventData? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionCreatedEventData? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionPendingEventData? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRunningEventData? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionIdledEventData? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRequiresActionEventData? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionArchivedEventData? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionDeletedEventData? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusIdledEventData? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadCreatedEventData? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadIdledEventData? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCreatedEventData? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultArchivedEventData? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultDeletedEventData? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionUpdatedEventData? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionBudgetReachedEventData? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileEnforcementActionOpenedEventData? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileEnforcementActionResolvedEventData? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileProgramStatusUpdatedEventData? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminator? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminatorType? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkLeaseStateState? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BillingError? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BodyCreateSkillV1SkillsPost? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BodyCreateSkillVersionV1SkillsSkillIdVersionsPost? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTarget? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCoordinateTarget? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRefTarget? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminator? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminatorType? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabConfig? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabInput? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickConfig? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickInput? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadConfig? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadInput? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindConfig? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindInput? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputConfig? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputInput? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputValue? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextConfig? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextInput? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyConfig? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyInput? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverConfig? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverInput? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecConfig? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecInput? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyConfig? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyInput? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickConfig? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragConfig? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragInput? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickInput? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownConfig? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownInput? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpConfig? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpInput? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsConfig? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsInput? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMemberInput? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateInput? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabInput? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabInput? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageInput? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleInput? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkInput? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToInput? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotInput? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomInput? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickInput? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickInput? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickInput? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveInput? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollInput? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeInput? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitInput? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickConfig? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveConfig? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateConfig? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabConfig? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleConfig? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkConfig? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageConfig? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageFilter? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickConfig? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotConfig? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollConfig? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollDirection? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToConfig? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadCompleted? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadFailed? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadStarted? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeTabOpened? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateTabEntry? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabConfig? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolsetConfigs? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickConfig? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeConfig? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitConfig? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomConfig? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant154? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1Discriminator? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1DiscriminatorType? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlEphemeralTtl? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheCreation? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissMessagesChanged? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissModelChanged? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissPreviousMessageNotFound? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReason? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissSystemChanged? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissToolsChanged? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissUnavailable? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminator? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminatorType? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CanceledResult? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CapabilitySupport? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDelta? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Citation2? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCharLocationCitation? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponsePageLocationCitation? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseContentBlockLocationCitation? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultLocationCitation? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseSearchResultLocationCitation? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminator? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminatorType? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClaudeCodeVersionTooOldErrorDetails? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolUnion? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool5? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekContextUnavailableErrorDetails? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyDisabledErrorDetails? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyNetworkBlockedErrorDetails? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyUnreachableErrorDetails? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionToolResultErrorCode? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant155? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522CacheControlVariant1Discriminator? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522CacheControlVariant1DiscriminatorType? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant156? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825CacheControlVariant1Discriminator? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825CacheControlVariant1DiscriminatorType? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant157? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120CacheControlVariant1Discriminator? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120CacheControlVariant1DiscriminatorType? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant158? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521CacheControlVariant1Discriminator? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521CacheControlVariant1DiscriminatorType? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionBlockAmbiguousErrorDetails? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionBlockMisplacedErrorDetails? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionContentMismatchErrorDetails? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionIncompleteTurnErrorDetails? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionNothingToSummarizeErrorDetails? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionSignatureInvalidErrorDetails? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionTooManyToolReferencesErrorDetails? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionToolChangesMismatchErrorDetails? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionUnavailableErrorDetails? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionConfig? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionInput? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickConfig? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickInput? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyConfig? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyInput? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyConfig? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyInput? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickConfig? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragConfig? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragInput? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickInput? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownConfig? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownInput? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpConfig? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpInput? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMemberInput? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeInput? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveInput? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickInput? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickInput? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickInput? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollInput? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitInput? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotInput? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomInput? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickConfig? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveConfig? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickConfig? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotConfig? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollConfig? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollDirection? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolsetConfigs? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickConfig? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeConfig? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitConfig? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomConfig? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant159? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801CacheControlVariant1Discriminator? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801CacheControlVariant1DiscriminatorType? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Container2? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContainerSkill>? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerSkill? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerParams? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SkillParams>? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillParams? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerSkillType? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock2? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlock? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseThinkingBlock? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseRedactedThinkingBlock? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlock? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlock? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlock? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlock? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionToolResultBlock? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionToolResultBlock? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionToolResultBlock? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolResultBlock? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseContainerUploadBlock? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminator? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminatorType? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEvent? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Delta2? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextContentBlockDelta? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputJsonContentBlockDelta? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingContentBlockDelta? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SignatureContentBlockDelta? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSource? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>>? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentContentBlockSourceContentItem? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlock? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlock? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminator? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEvent? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock3? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEventContentBlockDiscriminator? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEventContentBlockDiscriminatorType? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStopEvent? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContextManagementCapability? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParams? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant160? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParamsCacheControlVariant1Discriminator? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParamsCacheControlVariant1DiscriminatorType? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputMessageUnion>? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnion? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OutputConfig? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Speed? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParam? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoice? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensResponse? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageBatchParams? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.MessageBatchIndividualRequestParams>? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualRequestParams? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParams? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant161? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsCacheControlVariant1Discriminator? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsCacheControlVariant1DiscriminatorType? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ContainerParams, string>? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DiagnosticsParam? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Metadata? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsServiceTier? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateUserProfileActionUrlRequestBody? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileAction? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateUserProfileRequest? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileAccessType? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserDetailsParams? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteMessageBatchResponse? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedSkill? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedSkillVersion? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedUserProfile? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Diagnostics? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DirectCaller? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EffortCapability? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EffortLevel? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EnforcedSpendLimitReachedErrorDetails? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponse? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Error2? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InvalidRequestError? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PermissionError? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NotFoundError? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitError? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GatewayTimeoutError? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OverloadedError? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminator? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminatorType? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorType? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErroredResult? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExpiredResult? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileDeleteResponse? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileDocumentSource? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileExpiredErrorDetails? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileImageSource? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileListResponse? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FileMetadataSchema>? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileMetadataSchema? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileNotDownloadableErrorDetails? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlock? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlock? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlock? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestThinkingBlock? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestRedactedThinkingBlock? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlock? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlock? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlock? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlock? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlock? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlock? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlock? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlock? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlock? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminator? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminatorType? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInputMessage? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessage? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnionDiscriminator? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnionDiscriminatorRole? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputSchema? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JsonOutputFormat? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseMessageBatch? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.MessageBatch>? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatch? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseModelInfo? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ModelInfo>? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelInfo? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsResponse? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SkillVersion>? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillVersion? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsResponse? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Skill>? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Skill? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListUserProfilesResponse? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfile>? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfile? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant162? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818CacheControlVariant1Discriminator? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818CacheControlVariant1DiscriminatorType? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Message? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlock2>? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopReason? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalStopDetails? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Usage? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchProcessingStatus? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCounts? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponse? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Result2? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SucceededResult? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminator? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDelta? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDeltaEvent? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDeltaUsage? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OutputTokensDetails? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolUsage? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStartEvent? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStopEvent? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEvent? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminator? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminatorType? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelCapabilities? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolsCapability? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingCapability? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelInfoLifecycle? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelLine? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationOnHoldErrorDetails? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PlainTextSource? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RampLimitExceededErrorDetails? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalCategory? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionOutputBlock? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionResultBlock? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestBashCodeExecutionOutputBlock>? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant163? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestBashCodeExecutionToolResultError, global::Anthropic.RequestBashCodeExecutionResultBlock>? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultError? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyEncodingInvalidErrorDetails? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyEncodingUnsupportedErrorDetails? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyTooLargeAfterDecodingErrorDetails? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlock? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant164? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockCacheControlVariant1Discriminator? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockCacheControlVariant1DiscriminatorType? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item2>? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StateChangesVariant1Item2? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminator? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BrowserStateTabEntry>? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCharLocationCitation? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCitationsConfig? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionOutputBlock? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionResultBlock? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestCodeExecutionOutputBlock>? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant165? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestCodeExecutionToolResultError, global::Anthropic.RequestCodeExecutionResultBlock, global::Anthropic.RequestEncryptedCodeExecutionResultBlock>? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultError? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestEncryptedCodeExecutionResultBlock? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant166? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlockCacheControlVariant1Discriminator? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlockCacheControlVariant1DiscriminatorType? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContentBlockLocationCitation? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant167? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockCacheControlVariant1Discriminator? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockCacheControlVariant1DiscriminatorType? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source4? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLPDFSource? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminator? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminatorType? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant168? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockCacheControlVariant1Discriminator? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockCacheControlVariant1DiscriminatorType? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source5? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLImageSource? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminator? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminatorType? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageTransformations? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageTransformationsOversizedImage? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestPageLocationCitation? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant169? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlockCacheControlVariant1Discriminator? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlockCacheControlVariant1DiscriminatorType? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultLocationCitation? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant170? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCacheControlVariant1Discriminator? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCacheControlVariant1DiscriminatorType? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller9? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolCaller? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolCaller20260120? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCallerDiscriminator? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCallerDiscriminatorType? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockName? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant171? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCacheControlVariant1Discriminator? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCacheControlVariant1DiscriminatorType? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item3>? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item3? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchResultLocationCitation? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminator? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant172? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultError? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditorCodeExecutionToolResultErrorCode? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionViewResultBlockFileType? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlock? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant173? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlockCacheControlVariant1Discriminator? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlockCacheControlVariant1DiscriminatorType? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant174? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockCacheControlVariant1Discriminator? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockCacheControlVariant1DiscriminatorType? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>>? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentVariant2Item2? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminator? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant175? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1Discriminator? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestToolSearchToolResultError, global::Anthropic.RequestToolSearchToolSearchResultBlock>? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultError? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolSearchResultBlock? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolResultErrorCode? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestToolReferenceBlock>? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant176? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCacheControlVariant1Discriminator? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCacheControlVariant1DiscriminatorType? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller10? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCallerDiscriminator? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCallerDiscriminatorType? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchResultBlock? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant177? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1Discriminator? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller11? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminator? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminatorType? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestWebFetchToolResultError, global::Anthropic.RequestWebFetchResultBlock>? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultError? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchToolResultErrorCode? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchResultBlock? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant178? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1Discriminator? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller12? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminator? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminatorType? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.RequestWebSearchToolResultError>? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultError? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchToolResultErrorCode? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionOutputBlock? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionResultBlock? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseBashCodeExecutionOutputBlock>? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseBashCodeExecutionToolResultError, global::Anthropic.ResponseBashCodeExecutionResultBlock>? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionToolResultError? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserCloseTabToolUseBlock? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCaller? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFileUploadToolUseBlock? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFindToolUseBlock? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFormInputToolUseBlock? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoverToolUseBlock? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserKeyToolUseBlock? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickToolUseBlock? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserListTabsToolUseBlock? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNavigateToolUseBlock? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNewTabToolUseBlock? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadPageToolUseBlock? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserRightClickToolUseBlock? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScreenshotToolUseBlock? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToToolUseBlock? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToolUseBlock? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlock? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnion? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserZoomToolUseBlock? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTripleClickToolUseBlock? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTypeToolUseBlock? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserWaitToolUseBlock? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminator? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCitationsConfig? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionOutputBlock? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionResultBlock? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseCodeExecutionOutputBlock>? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionToolResultError? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseEncryptedCodeExecutionResultBlock? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerCursorPositionToolUseBlock? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerDoubleClickToolUseBlock? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerHoldKeyToolUseBlock? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerKeyToolUseBlock? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickToolUseBlock? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMiddleClickToolUseBlock? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMouseMoveToolUseBlock? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerRightClickToolUseBlock? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScreenshotToolUseBlock? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScrollToolUseBlock? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlock? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnion? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTypeToolUseBlock? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTripleClickToolUseBlock? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerWaitToolUseBlock? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerZoomToolUseBlock? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminator? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlock? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source6? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminator? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminatorType? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller13? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockName? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item4>? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item4? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminator? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionToolResultError? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlockFileType? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolReferenceBlock? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolResultError? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolSearchResultBlock? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseToolReferenceBlock>? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller14? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockCallerDiscriminator? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockCallerDiscriminatorType? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockUnion? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchResultBlock? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller15? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminator? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminatorType? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebFetchToolResultError, global::Anthropic.ResponseWebFetchResultBlock>? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultError? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultBlock? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller16? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminator? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminatorType? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>>? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultError? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillSource? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillParamsType? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillReadBlockedUndecryptableErrorDetails? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillSourceType? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StorageQuotaExceededErrorDetails? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem2>>? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem2>? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlocksItem2? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessageContentBlockDiscriminator? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessageContentBlockDiscriminatorType? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant179? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124CacheControlVariant1Discriminator? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124CacheControlVariant1DiscriminatorType? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant180? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429CacheControlVariant1Discriminator? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429CacheControlVariant1DiscriminatorType? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant181? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728CacheControlVariant1Discriminator? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728CacheControlVariant1DiscriminatorType? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingTypes? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigAdaptive? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingDisplayMode? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigBetweenTools? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigDisabled? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigEnabled? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminator? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminatorType? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadAlreadyContinuedErrorDetails? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadContinueInFlightErrorDetails? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadFingerprintMismatchErrorDetails? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadNotFoundErrorDetails? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadUnsupportedRequestErrorDetails? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant182? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolCacheControlVariant1Discriminator? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolCacheControlVariant1DiscriminatorType? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceAuto? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceAny? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceTool? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceNone? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminator? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminatorType? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolNameConflictErrorDetails? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolReferenceUnresolvedErrorDetails? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant183? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1Discriminator? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119Type? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant184? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1Discriminator? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119Type? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCallerDiscriminator? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCallerDiscriminatorType? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserProfileRequestBody? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UsageServiceTier? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserLocation? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserDetails? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementStatus? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementAction>? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementAction? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfilePrograms? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnrollEndUserAction? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionDiscriminator? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionDiscriminatorType? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionUrl? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberProgram? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileProgramStatus? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileCyberTier>? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberTier? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberRequirements? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberTierStatus? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsFeature? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsFeatureStatus? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsProgram? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileEfsFeature>? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionRestriction? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionBan? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionDiscriminator? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionDiscriminatorType? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionReason? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionNextStep? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserAccountStatus? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserEntityType? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileListOrder? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileListOrderBy? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant185? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910CacheControlVariant1Discriminator? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910CacheControlVariant1DiscriminatorType? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSources? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant186? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209CacheControlVariant1Discriminator? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209CacheControlVariant1DiscriminatorType? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant187? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309CacheControlVariant1Discriminator? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309CacheControlVariant1DiscriminatorType? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant188? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318CacheControlVariant1Discriminator? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318CacheControlVariant1DiscriminatorType? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318ResponseInclusion? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceAll? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceExcept? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WebFetchUrlSourceToolReference>? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceToolReference? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceNone? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceOnly? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolResults2? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesClientToolResultsDiscriminator? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesClientToolResultsDiscriminatorType? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolResults2? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminator? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminatorType? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInput2? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminator? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminatorType? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant189? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305CacheControlVariant1Discriminator? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305CacheControlVariant1DiscriminatorType? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant190? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209CacheControlVariant1Discriminator? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209CacheControlVariant1DiscriminatorType? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant191? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318CacheControlVariant1Discriminator? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318CacheControlVariant1DiscriminatorType? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318ResponseInclusion? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventType? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceParams? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberParams? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllConnectorsPermissionResource? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllowedInferenceGeo? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAlreadyMemberErrorDetails? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsActivitySummaryResponse? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSingleDayActivitySummary>? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSingleDayActivitySummary? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsActorType? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsApiActor? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactActivity? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactGroupBy? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactsResponse? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsArtifactActivity>? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedChatMetrics? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedMetrics? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedSessionsMetrics? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatMetrics? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeCodeMetrics? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCoreCodeMetrics? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsToolActions? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeTagCategory? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorActivity? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedMetrics? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatMetrics? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorClaudeCodeMetrics? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorCoworkMetrics? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorOfficeMetrics? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorGroupBy? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorOfficeProductMetrics? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorsResponse? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsConnectorActivity>? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsLinesOfCode? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResponse? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostReportTimeBucket>? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostReportTimeBucket? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResult? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportContextWindow? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostType? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceGeo? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResultSpeed? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTokenType? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostGroupBy? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostBucketedResult>? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItem? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserActor? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemActorDiscriminator? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemActorDiscriminatorType? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemSpeed? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersOrderBy? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersResponse? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostUsersItem>? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCoworkMetrics? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsDesignMetrics? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActor? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProvider? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminator? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminatorType? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostGroup? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActor? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostCostType? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostInferenceGeo? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageReportServiceTier? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSpeed? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostItem? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostMetrics? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostOrderBy? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostResponse? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsFlatCostItem>? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatGroup? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageItem? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageMetrics? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolUse? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageOrderBy? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageResponse? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsFlatUsageItem>? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOfficeMetrics? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOfficeProductMetrics? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOrder? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginActivity? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginChatCoworkUnifiedMetrics? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginClaudeCodeMetrics? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginCoworkMetrics? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginGroupBy? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginsResponse? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsPluginActivity>? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProductFilter? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectActivity? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUser? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectGroupBy? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectsResponse? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProjectActivity>? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportUserActor? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsServiceAccountActor? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActorDiscriminator? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActorDiscriminatorType? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsScienceMetrics? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillActivity? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedMetrics? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatMetrics? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillClaudeCodeMetrics? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillCoworkMetrics? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillOfficeMetrics? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillActivityShareStatus? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedChatMetrics? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillGroupBy? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillOfficeProductMetrics? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillsResponse? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSkillActivity>? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSortOrder? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsTimeBucketWidth? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsToolActionCounts? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResponse? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageReportTimeBucket>? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageReportTimeBucket? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResult? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResultSpeed? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostProductFilter? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostSortOrder? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageGroupBy? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageBucketedResult>? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItem? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemActorDiscriminator? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemActorDiscriminatorType? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemSpeed? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersOrderBy? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersResponse? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageUsersItem>? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserActivity? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserGroupBy? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsersResponse? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUserActivity>? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKey? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatedBy? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PrincipalVariant1? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUserActor? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyServiceAccountActor? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1Discriminator? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1DiscriminatorType? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyOrganizationScope? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyWorkspaceScope? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminator? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminatorType? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyStatus? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUpdateParams? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUpdateParamsStatus? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApprovalMetrics? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestParams? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitPeriod? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponse? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestActor? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestResolvedBy? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimit? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummary? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestStatus? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAttachedAttachment? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAwsExternalKeyConfig? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfig? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfigParams? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotInviteEmailsWithUnverifiedDomainsErrorDetails? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotRemoveLastMemberErrorDetails? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutManagedMemberErrorDetails? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutMembershipAdminErrorDetails? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutOwnerErrorDetails? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutPrimaryOwnerErrorDetails? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutPrivilegedMemberErrorDetails? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutSelfErrorDetails? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeApiActor? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItem? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUserActor? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminator? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminatorType? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCoreMetrics? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCustomerType? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelBreakdown>? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelBreakdown? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSubscriptionType? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaApprovalMetrics>? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeEnterpriseOrganizationRole? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettings? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsState? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabled? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabled? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDiscriminator? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDiscriminatorType? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabledParams? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabledParams? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParams? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParamsDiscriminator? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParamsDiscriminatorType? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsUpdateParams? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConcurrentMembershipChangeErrorDetails? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorPermissionResource? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorScopePermissionResource? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorToolPermissionResource? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLinesOfCode? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportGroupBy? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportItem? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostType? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportServiceTier? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceGeoFilter? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTimeBucket? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportItem>? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTimeBucketWidth? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteParams? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteParamsRole? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupParams? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelCertificateParams? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberParams? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNoBillingWorkspaceRoleSchema? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatedByType? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidency? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>, string>? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceGeo? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidencyCreateParams? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidencyUpdateParams? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyResponse? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteResponse? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupMemberResponse? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupResponse? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitResponse? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteUserResponse? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberResponse? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedOrganizationWebhookEndpoint? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDenySpendLimitIncreaseRequestParams? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEmailDomainNotAllowedErrorDetails? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEstimatedCost? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKey? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Attachment? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnattachedAttachment? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminator? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminatorType? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpExternalKeyConfig? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderConfigDiscriminator? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderConfigDiscriminatorType? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyChangedErrorDetails? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParams? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig2? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminator? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminatorType? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyInWorkspacePolicyErrorDetails? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyListResponse? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaExternalKey>? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParams? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfigVariant1? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParamsProviderConfigVariant1Discriminator? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyValidationFailedErrorDetails? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuer? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksDiscovery? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksExplicitUrl? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksInline? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerJwksDiscriminator? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerJwksDiscriminatorType? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIssuerPollStatus? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParams? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks2? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminator? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminatorType? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerListResponse? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationIssuer>? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParams? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksVariant1? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1Discriminator? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRule? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRuleMatch? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountTarget? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleCreateParams? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleListResponse? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationRule>? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleUpdateParams? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleWorkspace? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleWorkspaceListResponse? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationRuleWorkspace>? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetClaudeCodeUsageReportResponse? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeUsageReportItem>? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportResponse? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportTimeBucket>? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetMessagesUsageReportResponse? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportTimeBucket>? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportTimeBucket? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteAlreadyExistsErrorDetails? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteSchema? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationRoleSchema? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteStatusSchema? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaKeyProfileMismatchErrorDetails? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsResponse? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendSummary>? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseApiKey? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaApiKey>? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseInviteSchema? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInviteSchema>? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseUser? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUser>? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUser? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseWorkspaceMemberSchema? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceMemberSchema>? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceMemberSchema? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseWorkspace? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspace>? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspace? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsResponse? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimit>? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportGroupBy? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportItem? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportItem>? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTokenUsage? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNewOrganizationWebhookEndpoint? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent>? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointState? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgApiKeyLimitExceededErrorDetails? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgMemberLimitExceededErrorDetails? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgServiceScope? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationNotEnrolledInBetaErrorDetails? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationPermissionResource? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationSchema? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationScope? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTypeNotSupportedErrorDetails? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpoint? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent>? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointList? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationWebhookEndpoint>? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointSigningSecret? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPlugin? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginComponent>? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginComponent? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScan? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByVariant1? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginUserActor? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginApiActor? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1Discriminator? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1DiscriminatorType? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOrganizationInstallationPreference? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Owner? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerOrganization? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerUser? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminator? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminatorType? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginReach? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginComponentType? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScanAssessment? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScanStatus? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginDeleted? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSetting? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingInstallationPreference? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganization? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetRbacGroup? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganizationMember? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingTargetDiscriminator? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingTargetDiscriminatorType? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeleted? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target2? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminator? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminatorType? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingList? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginInstallationSetting>? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginList? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPlugin>? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplace? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Owner2? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceOwnerDiscriminator? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceOwnerDiscriminatorType? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceSource? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceSyncStatus? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceList? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplace>? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginError? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginWarning? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning>? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationReport? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginError>? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings>? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginNameTakenErrorDetails? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShare? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target3? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminator? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminatorType? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareList? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginShare>? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersion? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByVariant12? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionCreatedByVariant1Discriminator? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionCreatedByVariant1DiscriminatorType? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionReach? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionList? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginVersion>? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimit? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitModelGroup? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitBatchGroup? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitTokenCountGroup? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitFilesGroup? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitSkillsGroup? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitWebSearchGroup? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupDiscriminator? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupDiscriminatorType? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimitValue>? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitValue? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitListResponse? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimit>? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroup? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupSourceType? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupList? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacGroup>? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupMember? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupMemberList? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacGroupMember>? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupScope? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRole? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleList? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacRole>? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermission? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Resource? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminator? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionList? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacRolePermission>? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRegistrationPendingErrorDetails? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRoleSchema? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenParams? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSandboxEgressRestrictedErrorDetails? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScanFailedErrorDetails? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScanPendingErrorDetails? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScopedApiKeyActorSchema? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSeatTierScope? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccount? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountOrganizationRole? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountCreateParams? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountCreateParamsOrganizationRole? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountListResponse? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaServiceAccount>? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountUpdateParams? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountUpdateParamsOrganizationRole? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMember? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRoleSchema? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberCreateFromSAParams? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberCreateParams? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberDeleteResponse? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberListResponse? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaServiceAccountWorkspaceMember>? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberUpdateParams? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParams? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope2? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserScope? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceScope? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminator? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminatorType? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillNameTakenErrorDetails? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope3? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageTierScope? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminator? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminatorType? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserActorSchema? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestActorDiscriminator? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestActorDiscriminatorType? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestListResponse? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchema? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestResolvedByDiscriminator? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestResolvedByDiscriminatorType? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor2? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryActorDiscriminator? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryActorDiscriminatorType? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope4? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryScopeDiscriminator? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryScopeDiscriminatorType? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source7? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummarySourceDiscriminator? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummarySourceDiscriminatorType? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnel? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnelCertificate? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelCertificateListResponse? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationTunnelCertificate>? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelListResponse? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationTunnel>? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnelToken? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnsupportedCharsetErrorDetails? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupParams? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserParams? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserParamsRole? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberParams? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileNotFoundErrorDetails? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyResponse? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyResponseStatus? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceApiKeyLimitExceededErrorDetails? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceCreateParams? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceMemberLimitExceededErrorDetails? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspacePolicyField? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspacePolicyViolationErrorDetails? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimit? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group2? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminator? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminatorType? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitValue>? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValue? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitListResponse? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimit>? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateParams? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitUpdateValue>? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateValue? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateValueType? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source8? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminator? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminatorType? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceUpdateParams? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceParams? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberParams? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AllConnectorsPermissionResource? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AllowedInferenceGeo? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AlreadyMemberErrorDetails? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsActivitySummaryResponse? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsSingleDayActivitySummary>? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSingleDayActivitySummary? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsArtifactActivity? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsArtifactGroupBy? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsArtifactsResponse? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsArtifactActivity>? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatCoworkUnifiedChatMetrics? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatCoworkUnifiedMetrics? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatCoworkUnifiedSessionsMetrics? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatMetrics? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsClaudeCodeMetrics? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsCoreCodeMetrics? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsToolActions? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorActivity? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatCoworkUnifiedMetrics? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatMetrics? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorClaudeCodeMetrics? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorCoworkMetrics? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorOfficeMetrics? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatCoworkUnifiedChatMetrics? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatCoworkUnifiedSessionsMetrics? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorGroupBy? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorOfficeProductMetrics? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorsResponse? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsConnectorActivity>? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsLinesOfCode? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsCoworkMetrics? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsDesignMetrics? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsOfficeMetrics? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsOfficeProductMetrics? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsOrder? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginActivity? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginChatCoworkUnifiedMetrics? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginClaudeCodeMetrics? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginCoworkMetrics? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginGroupBy? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginsResponse? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsPluginActivity>? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsProjectActivity? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUser? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsProjectGroupBy? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsProjectsResponse? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsProjectActivity>? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsScienceMetrics? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillActivity? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatCoworkUnifiedMetrics? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatMetrics? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillClaudeCodeMetrics? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillCoworkMetrics? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillOfficeMetrics? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillActivityShareStatus? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatCoworkUnifiedChatMetrics? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatCoworkUnifiedSessionsMetrics? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillGroupBy? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillOfficeProductMetrics? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillsResponse? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsSkillActivity>? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsToolActionCounts? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUserActivity? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUserGroupBy? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUsersResponse? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsUserActivity>? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKey? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedBy? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PrincipalVariant12? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUserActor? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyServiceAccountActor? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1Discriminator? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1DiscriminatorType? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope5? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyOrganizationScope? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyWorkspaceScope? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminator? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminatorType? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyStatus? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUpdateParams? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUpdateParamsStatus? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApproveSpendLimitIncreaseRequestParams? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitPeriod? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApproveSpendLimitIncreaseRequestResponse? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestActor? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestResolvedBy? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimit? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummary? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestStatus? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AttachedAttachment? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AwsExternalKeyConfig? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfig? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfigParams? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CannotInviteEmailsWithUnverifiedDomainsErrorDetails? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CannotRemoveLastMemberErrorDetails? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettings? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsState? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabled? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabled? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminator? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminatorType? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabledParams? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabledParams? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParams? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminator? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminatorType? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsUpdateParams? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConcurrentMembershipChangeErrorDetails? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorPermissionResource? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorScopePermissionResource? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorToolPermissionResource? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteParams? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteParamsRole? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateRbacGroupParams? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberParams? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NoBillingWorkspaceRoleSchema? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByType? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidency? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>, string>? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InferenceGeo? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceGeo? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidencyCreateParams? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidencyUpdateParams? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyResponse? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteResponse? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupMemberResponse? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupResponse? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteUserResponse? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberResponse? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DenySpendLimitIncreaseRequestParams? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EmailDomainNotAllowedErrorDetails? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKey? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Attachment2? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnattachedAttachment? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminator? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminatorType? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig3? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GcpExternalKeyConfig? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyProviderConfigDiscriminator? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyProviderConfigDiscriminatorType? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyChangedErrorDetails? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParams? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig4? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminator? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminatorType? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyInWorkspacePolicyErrorDetails? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyListResponse? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ExternalKey>? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParams? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfigVariant12? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1Discriminator? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyValidationFailedErrorDetails? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyValidationTimedOutErrorDetails? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuer? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks3? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksDiscovery? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksExplicitUrl? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksInline? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerJwksDiscriminator? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerJwksDiscriminatorType? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.IssuerPollStatus? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParams? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks4? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminator? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminatorType? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerListResponse? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationIssuer>? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParams? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksVariant12? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParamsJwksVariant1Discriminator? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParamsJwksVariant1DiscriminatorType? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRule? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RuleMatch? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountTarget? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleCreateParams? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleListResponse? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationRule>? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleUpdateParams? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleWorkspace? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleWorkspaceListResponse? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationRuleWorkspace>? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteAlreadyExistsErrorDetails? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteSchema? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationRoleSchema? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteStatusSchema? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.KeyProfileMismatchErrorDetails? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListEffectiveSpendLimitsResponse? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendSummary>? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseApiKey? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ApiKey>? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseInviteSchema? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InviteSchema>? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseUser? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.User>? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.User? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseWorkspaceMemberSchema? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceMemberSchema>? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceMemberSchema? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseWorkspace? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Workspace>? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Workspace? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgApiKeyLimitExceededErrorDetails? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgMemberLimitExceededErrorDetails? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgServiceScope? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationPermissionResource? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationSchema? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationScope? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationTypeNotSupportedErrorDetails? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimit? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group3? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitModelGroup? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitBatchGroup? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitTokenCountGroup? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitFilesGroup? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitSkillsGroup? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitWebSearchGroup? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupDiscriminator? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupDiscriminatorType? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RateLimitValue>? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitValue? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitListResponse? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RateLimit>? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroup? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupSourceType? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupList? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacGroup>? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupMember? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupMemberList? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacGroupMember>? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupScope? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRole? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleList? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacRole>? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermission? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Resource2? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermissionResourceDiscriminator? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermissionResourceDiscriminatorType? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermissionList? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacRolePermission>? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveFederationRuleWorkspaceResponse? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SandboxEgressRestrictedErrorDetails? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ScopedApiKeyActorSchema? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SeatTierScope? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccount? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountOrganizationRole? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountCreateParams? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountCreateParamsOrganizationRole? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountListResponse? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ServiceAccount>? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountUpdateParams? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountUpdateParamsOrganizationRole? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMember? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRoleSchema? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberCreateFromSAParams? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberCreateParams? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberDeleteResponse? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberListResponse? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ServiceAccountWorkspaceMember>? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberUpdateParams? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope6? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserScope? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceScope? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UsageTierScope? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitScopeDiscriminator? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitScopeDiscriminatorType? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserActorSchema? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestActorDiscriminator? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestActorDiscriminatorType? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestListResponse? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendLimitIncreaseRequestSchema>? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestSchema? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestResolvedByDiscriminator? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestResolvedByDiscriminatorType? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor3? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryActorDiscriminator? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryActorDiscriminatorType? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope7? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryScopeDiscriminator? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryScopeDiscriminatorType? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source9? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummarySourceDiscriminator? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummarySourceDiscriminatorType? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateRbacGroupParams? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserParams? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserParamsRole? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberParams? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileNotFoundErrorDetails? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyResponse? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyResponseStatus? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceApiKeyLimitExceededErrorDetails? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceCreateParams? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceMemberLimitExceededErrorDetails? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspacePolicyField? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspacePolicyViolationErrorDetails? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimit? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group4? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminator? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminatorType? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimitValue>? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValue? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitListResponse? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimit>? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitOrganizationSource? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateParams? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimitUpdateValue>? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateValue? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateValueType? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source10? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitWorkspaceSource? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValueSourceDiscriminator? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValueSourceDiscriminatorType? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceUpdateParams? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PingType? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostRequest? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostRequest? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostRequest? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequest? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent>? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequest? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent>? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ModelsListLifecycleItem>? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListLifecycleItem? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelsListLifecycleItem>? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListLifecycleItem? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementStatus>? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionStatus>? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEventType>? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadStatus>? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamStatus>? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse>? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListApiKeysV1OrganizationsApiKeysGetStatus? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportGroupBy>? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitPeriod>? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitIncreaseRequestStatus>? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginsV1OrganizationsPluginsGetOwnerType? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProductFilter>? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item>? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item>? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item>? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item>? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item>? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item>? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSpeed>? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsActorType>? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageGroupBy>? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostGroupBy>? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUserGroupBy>? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProjectGroupBy>? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSkillGroupBy>? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsConnectorGroupBy>? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsPluginGroupBy>? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsArtifactGroupBy>? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse>? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatus? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendLimitPeriod>? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendLimitIncreaseRequestStatus>? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsUserGroupBy>? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsProjectGroupBy>? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsSkillGroupBy>? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsConnectorGroupBy>? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsPluginGroupBy>? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsArtifactGroupBy>? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse2? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError2? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse3? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError3? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse4? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError4? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse5? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError5? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.EnforcedSpendLimitReachedErrorDetails, global::Anthropic.RampLimitExceededErrorDetails>? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse6? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError6? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse7? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError7? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListResponse? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListResponseError? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails>? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsGetResponse? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsGetResponseError? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponse? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponseError? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.CmekKeyDisabledErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails>? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponse2? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponseError2? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesListResponse? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesListResponseError? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesRetrieveResponse? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesRetrieveResponseError? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesDeleteResponse? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesDeleteResponseError? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesCancelResponse? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesCancelResponseError? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesResultsResponse? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesResultsResponseError? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse2? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError2? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse3? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError3? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse4? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError4? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostResponse? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostResponseError? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListFilesV1FilesGetResponse? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListFilesV1FilesGetResponseError? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetFileMetadataV1FilesFileIdGetResponse? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetFileMetadataV1FilesFileIdGetResponseError? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteFileV1FilesFileIdDeleteResponse? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteFileV1FilesFileIdDeleteResponseError? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponse? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponseError? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponse2? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponseError2? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponse? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponseError? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponse2? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponseError2? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsV1SkillsGetResponse? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsV1SkillsGetResponseError? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillV1SkillsSkillIdGetResponse? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillV1SkillsSkillIdGetResponseError? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillV1SkillsSkillIdDeleteResponse? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillV1SkillsSkillIdDeleteResponseError? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponse? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponseError? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponse2? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponseError2? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsV1SkillsSkillIdVersionsGetResponse? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsV1SkillsSkillIdVersionsGetResponseError? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillVersionV1SkillsSkillIdVersionsVersionGetResponse? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillVersionV1SkillsSkillIdVersionsVersionGetResponseError? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponse? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponseError? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse2? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError2? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse3? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError3? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse4? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError4? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse5? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError5? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails, global::Anthropic.BetaRampLimitExceededErrorDetails>? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse6? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError6? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse7? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError7? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListResponse? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListResponseError? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails>? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsGetResponse? Type3704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsGetResponseError? Type3705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponse? Type3706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponseError? Type3707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponse2? Type3708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponseError2? Type3709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesListResponse? Type3710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesListResponseError? Type3711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesRetrieveResponse? Type3712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesRetrieveResponseError? Type3713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesDeleteResponse? Type3714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesDeleteResponseError? Type3715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesCancelResponse? Type3716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesCancelResponseError? Type3717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesResultsResponse? Type3718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesResultsResponseError? Type3719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse? Type3720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError? Type3721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse2? Type3722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError2? Type3723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse3? Type3724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError3? Type3725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse4? Type3726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError4? Type3727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostResponse? Type3728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostResponseError? Type3729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListFilesV1FilesGetResponse? Type3730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListFilesV1FilesGetResponseError? Type3731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetFileMetadataV1FilesFileIdGetResponse? Type3732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetFileMetadataV1FilesFileIdGetResponseError? Type3733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteFileV1FilesFileIdDeleteResponse? Type3734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteFileV1FilesFileIdDeleteResponseError? Type3735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponse? Type3736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponseError? Type3737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponse2? Type3738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponseError2? Type3739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponse? Type3740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponseError? Type3741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponse2? Type3742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponseError2? Type3743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsV1SkillsGetResponse? Type3744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsV1SkillsGetResponseError? Type3745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponse? Type3746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponseError? Type3747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillV1SkillsSkillIdDeleteResponse? Type3748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillV1SkillsSkillIdDeleteResponseError? Type3749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse? Type3750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseError? Type3751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse2? Type3752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseError2? Type3753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsV1SkillsSkillIdVersionsGetResponse? Type3754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsV1SkillsSkillIdVersionsGetResponseError? Type3755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillVersionV1SkillsSkillIdVersionsVersionGetResponse? Type3756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillVersionV1SkillsSkillIdVersionsVersionGetResponseError? Type3757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponse? Type3758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponseError? Type3759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponse? Type3760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponseError? Type3761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponse2? Type3762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponseError2? Type3763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEnvironmentsV1EnvironmentsGetResponse? Type3764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEnvironmentsV1EnvironmentsGetResponseError? Type3765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse? Type3766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponseError? Type3767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponse? Type3768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponseError? Type3769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponse2? Type3770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponseError2? Type3771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteResponse? Type3772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteResponseError? Type3773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveEnvironmentV1EnvironmentsEnvironmentIdArchivePostResponse? Type3774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveEnvironmentV1EnvironmentsEnvironmentIdArchivePostResponseError? Type3775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentStatsV1EnvironmentsEnvironmentIdWorkStatsGetResponse? Type3776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentStatsV1EnvironmentsEnvironmentIdWorkStatsGetResponseError? Type3777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRecordHeartbeatV1EnvironmentsEnvironmentIdWorkWorkIdHeartbeatPostResponse? Type3778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRecordHeartbeatV1EnvironmentsEnvironmentIdWorkWorkIdHeartbeatPostResponseError? Type3779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopWorkV1EnvironmentsEnvironmentIdWorkWorkIdStopPostResponse? Type3780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopWorkV1EnvironmentsEnvironmentIdWorkWorkIdStopPostResponseError? Type3781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkV1EnvironmentsEnvironmentIdWorkWorkIdGetResponse? Type3782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkV1EnvironmentsEnvironmentIdWorkWorkIdGetResponseError? Type3783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkV1EnvironmentsEnvironmentIdWorkWorkIdPostResponse? Type3784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkV1EnvironmentsEnvironmentIdWorkWorkIdPostResponseError? Type3785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse? Type3786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError? Type3787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse2? Type3788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError2? Type3789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse3? Type3790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError3? Type3791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaEnvironmentNotFoundErrorDetails, global::Anthropic.BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails>? Type3792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse4? Type3793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError4? Type3794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackChannelsResponse? Type3795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackChannelsResponseError? Type3796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackChannelResponse? Type3797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackChannelResponseError? Type3798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponse? Type3799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponseError? Type3800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponse2? Type3801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponseError2? Type3802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponse3? Type3803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponseError3? Type3804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponse? Type3805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponseError? Type3806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponse2? Type3807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponseError2? Type3808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackWorkspacesResponse? Type3809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackWorkspacesResponseError? Type3810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackWorkspaceResponse? Type3811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackWorkspaceResponseError? Type3812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponse? Type3813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponseError? Type3814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponse2? Type3815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponseError2? Type3816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponse3? Type3817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponseError3? Type3818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundlesResponse? Type3819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundlesResponseError? Type3820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleResponse? Type3821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleResponseError? Type3822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundleTargetsResponse? Type3823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundleTargetsResponseError? Type3824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateBundleTargetResponse? Type3825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateBundleTargetResponseError? Type3826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleTargetResponse? Type3827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleTargetResponseError? Type3828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteBundleTargetResponse? Type3829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteBundleTargetResponseError? Type3830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponse? Type3831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponseError? Type3832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponse2? Type3833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponseError2? Type3834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteV1OrganizationsInvitesInviteIdDeleteResponse? Type3835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteV1OrganizationsInvitesInviteIdDeleteResponseError? Type3836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserV1OrganizationsUsersUserIdPostResponse? Type3837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserV1OrganizationsUsersUserIdPostResponseError? Type3838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse? Type3839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError? Type3840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse2? Type3841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError2? Type3842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse3? Type3843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError3? Type3844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponse? Type3845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponseError? Type3846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponse2? Type3847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponseError2? Type3848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse? Type3849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError? Type3850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse2? Type3851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError2? Type3852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse3? Type3853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError3? Type3854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse? Type3855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError? Type3856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse2? Type3857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError2? Type3858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse3? Type3859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError3? Type3860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponse? Type3861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponseError? Type3862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse? Type3863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError? Type3864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse2? Type3865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError2? Type3866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponse? Type3867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponseError? Type3868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse? Type3869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError? Type3870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse2? Type3871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError2? Type3872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse? Type3873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError? Type3874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaOrgApiKeyLimitExceededErrorDetails, global::Anthropic.BetaWorkspaceApiKeyLimitExceededErrorDetails>? Type3875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse2? Type3876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError2? Type3877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponse? Type3878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponseError? Type3879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponse2? Type3880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponseError2? Type3881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse? Type3882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError? Type3883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse2? Type3884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError2? Type3885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse? Type3886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError? Type3887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse2? Type3888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError2? Type3889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponse? Type3890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponseError? Type3891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponse? Type3892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponseError? Type3893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponse? Type3894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponseError? Type3895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponse? Type3896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponseError? Type3897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetResponse? Type3898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetResponseError? Type3899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitV1OrganizationsSpendLimitsPostResponse? Type3900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitV1OrganizationsSpendLimitsPostResponseError? Type3901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaSandboxEgressRestrictedErrorDetails, global::Anthropic.BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails>? Type3902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSpendLimitV1OrganizationsSpendLimitsSpendLimitIdGetResponse? Type3903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSpendLimitV1OrganizationsSpendLimitsSpendLimitIdGetResponseError? Type3904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteResponse? Type3905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteResponseError? Type3906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountV1OrganizationsServiceAccountsPostResponse? Type3907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountV1OrganizationsServiceAccountsPostResponseError? Type3908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponse? Type3909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponseError? Type3910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponse? Type3911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponseError? Type3912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponse? Type3913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponseError? Type3914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponse? Type3915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponseError? Type3916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationIssuerV1OrganizationsFederationIssuersPostResponse? Type3917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationIssuerV1OrganizationsFederationIssuersPostResponseError? Type3918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponse? Type3919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponseError? Type3920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponse? Type3921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponseError? Type3922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse? Type3923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponseError? Type3924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponse? Type3925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponseError? Type3926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponse? Type3927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponseError? Type3928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponse? Type3929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponseError? Type3930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveTunnelV1OrganizationsTunnelsTunnelIdArchivePostResponse? Type3931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveTunnelV1OrganizationsTunnelsTunnelIdArchivePostResponseError? Type3932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRevealTunnelTokenV1OrganizationsTunnelsTunnelIdRevealTokenPostResponse? Type3933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRevealTunnelTokenV1OrganizationsTunnelsTunnelIdRevealTokenPostResponseError? Type3934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenV1OrganizationsTunnelsTunnelIdRotateTokenPostResponse? Type3935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenV1OrganizationsTunnelsTunnelIdRotateTokenPostResponseError? Type3936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateCertificateV1OrganizationsTunnelsTunnelIdCertificatesPostResponse? Type3937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateCertificateV1OrganizationsTunnelsTunnelIdCertificatesPostResponseError? Type3938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveCertificateV1OrganizationsTunnelsTunnelIdCertificatesCertificateIdArchivePostResponse? Type3939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveCertificateV1OrganizationsTunnelsTunnelIdCertificatesCertificateIdArchivePostResponseError? Type3940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupV1OrganizationsRbacGroupsPostResponse? Type3941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupV1OrganizationsRbacGroupsPostResponseError? Type3942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse? Type3943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponseError? Type3944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse? Type3945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError? Type3946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails>? Type3947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse2? Type3948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError2? Type3949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse? Type3950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError? Type3951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse2? Type3952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError2? Type3953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse? Type3954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError? Type3955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse2? Type3956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError2? Type3957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse? Type3958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError? Type3959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails, global::Anthropic.BetaUnsupportedCharsetErrorDetails>? Type3960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse2? Type3961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError2? Type3962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaPluginNameTakenErrorDetails, global::Anthropic.BetaSkillNameTakenErrorDetails>? Type3963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse3? Type3964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError3? Type3965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse? Type3966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError? Type3967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails, global::Anthropic.BetaScanFailedErrorDetails>? Type3968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse2? Type3969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError2? Type3970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaScanPendingErrorDetails, global::Anthropic.BetaSkillNameTakenErrorDetails>? Type3971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponse? Type3972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponseError? Type3973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse? Type3974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError? Type3975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse2? Type3976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError2? Type3977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse3? Type3978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError3? Type3979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponse? Type3980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponseError? Type3981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails>? Type3982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse? Type3983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponseError? Type3984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdDeleteResponse? Type3985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdDeleteResponseError? Type3986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponse? Type3987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponseError? Type3988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponse2? Type3989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponseError2? Type3990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteV1OrganizationsInvitesInviteIdDeleteResponse? Type3991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteV1OrganizationsInvitesInviteIdDeleteResponseError? Type3992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserV1OrganizationsUsersUserIdPostResponse? Type3993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserV1OrganizationsUsersUserIdPostResponseError? Type3994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse? Type3995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError? Type3996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse2? Type3997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError2? Type3998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse3? Type3999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError3? Type4000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse? Type4001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError? Type4002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse2? Type4003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError2? Type4004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse3? Type4005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError3? Type4006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse? Type4007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError? Type4008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse2? Type4009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError2? Type4010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse3? Type4011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError3? Type4012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponse? Type4013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponseError? Type4014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse? Type4015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError? Type4016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse2? Type4017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError2? Type4018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponse? Type4019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponseError? Type4020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse? Type4021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError? Type4022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse2? Type4023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError2? Type4024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse? Type4025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError? Type4026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.OrgApiKeyLimitExceededErrorDetails, global::Anthropic.WorkspaceApiKeyLimitExceededErrorDetails>? Type4027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse2? Type4028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError2? Type4029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponse? Type4030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponseError? Type4031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponse2? Type4032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponseError2? Type4033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse? Type4034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError? Type4035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse2? Type4036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError2? Type4037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse? Type4038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError? Type4039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse2? Type4040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError2? Type4041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponse? Type4042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponseError? Type4043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponse? Type4044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponseError? Type4045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponse? Type4046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponseError? Type4047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponse? Type4048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponseError? Type4049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountV1OrganizationsServiceAccountsPostResponse? Type4050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountV1OrganizationsServiceAccountsPostResponseError? Type4051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponse? Type4052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponseError? Type4053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponse? Type4054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponseError? Type4055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponse? Type4056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponseError? Type4057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponse? Type4058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponseError? Type4059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationIssuerV1OrganizationsFederationIssuersPostResponse? Type4060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationIssuerV1OrganizationsFederationIssuersPostResponseError? Type4061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponse? Type4062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponseError? Type4063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponse? Type4064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponseError? Type4065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationRuleV1OrganizationsFederationRulesPostResponse? Type4066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationRuleV1OrganizationsFederationRulesPostResponseError? Type4067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponse? Type4068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponseError? Type4069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponse? Type4070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponseError? Type4071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponse? Type4072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponseError? Type4073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteResponse? Type4074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateRbacGroupV1OrganizationsRbacGroupsPostResponse? Type4075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateRbacGroupV1OrganizationsRbacGroupsPostResponseError? Type4076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse? Type4077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponseError? Type4078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse? Type4079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError? Type4080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails>? Type4081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse2? Type4082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError2? Type4083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse? Type4084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError? Type4085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse2? Type4086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError2? Type4087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse? Type4088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError? Type4089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse2? Type4090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError2? Type4091 { get; set; }

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
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeTagBundleTarget>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeTagBundle>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeTagSlackChannel>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeTagSlackWorkspace>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeTagSettingSource>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.List<string>>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaContainerSkill>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkillParams>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBetaContentBlockSourceContentItem>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBetaContentBlockSourceContentItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.EditsItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestMCPServerURLDefinition>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInputMessageUnion>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaRequestTextBlock>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestTextBlock>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamInput>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatchIndividualRequestParams>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaFallbackConfigV2>, string>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFallbackConfigV2>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaToolUnion>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamOutput>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaEnvironment>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFileMetadataSchema>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInputContentBlock>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaIterationsUsageVariant1Item>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDream>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatch>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelInfo>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkillVersion>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkill>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTelemetryDestinationWorkspace>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTelemetryDestination>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTunnelCertificate>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTunnel>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUserProfile>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMCPTool>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentTool>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPServer>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSkill>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentMessageContentBlock>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsUserContentBlock>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolConfigUnion>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolParams>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPServerParams>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSkillParams>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResourceParams>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.DateTime>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResourceConfig>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSystemContentBlock>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgent>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsCredential>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentRun>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeployment>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryListItem>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryStore>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryVersion>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionEvent>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResource>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThread>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSession>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsVault>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPToolConfig>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentRosterEntry>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentReference>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSearchResultContent>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsInputEvent>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsEventParams>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionRosterEntry>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsWorkflowRunPhase>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaContentBlock>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInputTransformation>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.StateChangesVariant1Item>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaBrowserStateTabEntry>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestCodeExecutionOutputBlock>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ToolChangesVariant1Item>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item>>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestToolReferenceBlock>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaRequestWebSearchToolResultError>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestWebSearchResultBlock>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseCodeExecutionOutputBlock>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ToolChangesVariant1Item2>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AppliedEditsItem>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseMCPTool>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaResponseTextBlock>>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseTextBlock>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item2>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseToolReferenceBlock>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.BetaResponseWebSearchResultBlock>>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseWebSearchResultBlock>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSelfHostedWork>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem>>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWebFetchUrlSourceToolReference>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContainerSkill>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SkillParams>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentContentBlockSourceContentItem>>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentContentBlockSourceContentItem>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InputMessageUnion>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.RequestTextBlock>>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestTextBlock>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.MessageBatchIndividualRequestParams>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FileMetadataSchema>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InputContentBlock>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.MessageBatch>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ModelInfo>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SkillVersion>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.Skill>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfile>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlock2>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestBashCodeExecutionOutputBlock>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.StateChangesVariant1Item2>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BrowserStateTabEntry>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestCodeExecutionOutputBlock>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item3>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestToolReferenceBlock>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.RequestWebSearchToolResultError>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseBashCodeExecutionOutputBlock>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseCodeExecutionOutputBlock>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item4>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseToolReferenceBlock>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem2>>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem2>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfileEnforcementAction>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WebFetchUrlSourceToolReference>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSingleDayActivitySummary>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsArtifactActivity>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsConnectorActivity>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostReportTimeBucket>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostBucketedResult>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostUsersItem>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsFlatCostItem>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsFlatUsageItem>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsPluginActivity>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProjectActivity>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSkillActivity>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageReportTimeBucket>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageBucketedResult>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageUsersItem>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUserActivity>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelBreakdown>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportItem>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaAllowedInferenceGeo>, string>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAllowedInferenceGeo>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaExternalKey>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationIssuer>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationRule>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationRuleWorkspace>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeCodeUsageReportItem>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportTimeBucket>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportTimeBucket>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendSummary>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaApiKey>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInviteSchema>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUser>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceMemberSchema>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspace>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimit>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportItem>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationWebhookEndpoint>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginComponent>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginInstallationSetting>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPlugin>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplace>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginError>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginShare>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginVersion>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRateLimitValue>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRateLimit>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacGroup>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacGroupMember>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacRole>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacRolePermission>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaServiceAccount>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaServiceAccountWorkspaceMember>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationTunnelCertificate>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationTunnel>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimitValue>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimit>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimitUpdateValue>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsSingleDayActivitySummary>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsArtifactActivity>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsConnectorActivity>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsPluginActivity>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsProjectActivity>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsSkillActivity>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsUserActivity>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.AllowedInferenceGeo>, string>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AllowedInferenceGeo>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ExternalKey>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationIssuer>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationRule>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationRuleWorkspace>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendSummary>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ApiKey>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InviteSchema>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.User>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceMemberSchema>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.Workspace>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RateLimitValue>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RateLimit>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacGroup>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacGroupMember>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacRole>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacRolePermission>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ServiceAccount>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ServiceAccountWorkspaceMember>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendLimitIncreaseRequestSchema>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimitValue>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimit>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimitUpdateValue>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ModelsListLifecycleItem>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnthropicBeta>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelsListLifecycleItem>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfileEnforcementStatus>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionStatus>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionEventType>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsEventDeltaType>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThreadStatus>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamStatus>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUsageReportServiceTier>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportContextWindow>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInferenceGeoFilter>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpeed>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportGroupBy>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportGroupBy>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitPeriod>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitIncreaseRequestStatus>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProductFilter>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsClaudeTagCategory>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSpeed>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsActorType>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageGroupBy>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostGroupBy>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUserGroupBy>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProjectGroupBy>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSkillGroupBy>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsConnectorGroupBy>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsPluginGroupBy>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsArtifactGroupBy>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendLimitPeriod>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendLimitIncreaseRequestStatus>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsUserGroupBy>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsProjectGroupBy>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsSkillGroupBy>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsConnectorGroupBy>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsPluginGroupBy>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsArtifactGroupBy>? ListType293 { get; set; }
    }
}