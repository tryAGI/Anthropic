
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
        public global::Anthropic.CacheControlVariant13? Type16 { get; set; }
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
        public global::Anthropic.CacheControlVariant132? Type33 { get; set; }
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
        public global::Anthropic.CacheControlVariant113? Type51 { get; set; }
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
        public global::Anthropic.CacheControlVariant114? Type56 { get; set; }
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
        public global::Anthropic.BetaBillTo? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBillingError? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBillingPolicy? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBodyCreateSkillV1SkillsPost? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBodyCreateSkillVersionV1SkillsSkillIdVersionsPost? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTarget? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCoordinateTarget? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRefTarget? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTargetDiscriminator? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTargetDiscriminatorType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCloseTabConfig? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCloseTabInput? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserDoubleClickConfig? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserDoubleClickInput? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFileUploadConfig? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFileUploadInput? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFindConfig? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFindInput? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputConfig? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputInput? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputValue? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserGetPageTextConfig? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserGetPageTextInput? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoldKeyConfig? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoldKeyInput? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoverConfig? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoverInput? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserJavascriptExecConfig? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserJavascriptExecInput? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserKeyConfig? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserKeyInput? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickConfig? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickDragConfig? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickDragInput? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickInput? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseDownConfig? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseDownInput? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseUpConfig? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseUpInput? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserListTabsConfig? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserListTabsInput? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMemberInput? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNavigateInput? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNewTabInput? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserSwitchTabInput? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageInput? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadConsoleInput? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadNetworkInput? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollToInput? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScreenshotInput? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserZoomInput? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRightClickInput? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMiddleClickInput? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTripleClickInput? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMouseMoveInput? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollInput? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTypeInput? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserWaitInput? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMiddleClickConfig? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMouseMoveConfig? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNavigateConfig? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNewTabConfig? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadConsoleConfig? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadNetworkConfig? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageConfig? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageFilter? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRightClickConfig? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScreenshotConfig? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollConfig? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollDirection? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollToConfig? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadCompleted? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadFailed? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadStarted? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeTabOpened? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateTabEntry? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserSwitchTabConfig? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolsetConfigs? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTripleClickConfig? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTypeConfig? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserWaitConfig? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserZoomConfig? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant154? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801CacheControlVariant1Discriminator? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801CacheControlVariant1DiscriminatorType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBundleAttachmentNotSupportedErrorDetails? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBundleOnCallErrorDetails? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheControlEphemeralTtl? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissMessagesChanged? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissModelChanged? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissPreviousMessageNotFound? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReason? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissSystemChanged? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissToolsChanged? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissUnavailable? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReasonDiscriminator? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReasonDiscriminatorType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCanceledResult? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCapabilitySupport? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDelta? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Citation2? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCharLocationCitation? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponsePageLocationCitation? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContentBlockLocationCitation? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchResultLocationCitation? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseSearchResultLocationCitation? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDeltaCitationDiscriminator? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDeltaCitationDiscriminatorType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeVersionTooOldErrorDetails? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundle? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundleTarget? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTarget? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundleTargetDiscriminator? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundleTargetDiscriminatorType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBody? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminator? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateSlackChannelRequest? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelIdentifiers? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingsCreate? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagDefaultSettingSource? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagDeletedBundleTarget? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagDeletedSlackChannel? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicy? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyAllow? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyRestrict? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyDiscriminator? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyDiscriminatorType? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListBundleTargetsResponse? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagBundleTarget>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListBundlesResponse? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagBundle>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListSlackChannelsResponse? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSlackChannel>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannel? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListSlackWorkspacesResponse? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSlackWorkspace>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspace? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyMode? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeAutomatic? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeMentionOnly? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeThread? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeDiscriminator? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeDiscriminatorType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSource? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelSettingSource? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackDefaultSettingSource? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSourceDiscriminator? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSources? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSettingSource>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettings? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingsUpdate? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceIdentifiers? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagUpdateBundleRequestBody? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagUpdateSlackChannelRequestBody? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagUpdateSlackWorkspaceRequestBody? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearThinking20251015? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.KeepVariant1?, string>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.KeepVariant1? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingTurns? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearThinking20251015KeepVariant1Discriminator? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearThinking20251015KeepVariant1DiscriminatorType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTokensClearAtLeast? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUsesKeep? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919KeepDiscriminator? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919KeepDiscriminatorType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Trigger? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTokensTrigger? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUsesTrigger? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919TriggerDiscriminator? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919TriggerDiscriminatorType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClientToolUnion? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTool? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfig? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Networking? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnrestrictedNetwork? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLimitedNetwork? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigNetworkingDiscriminator? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigNetworkingDiscriminatorType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPackages? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParams? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NetworkingVariant1? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLimitedNetworkParams? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParamsNetworkingVariant1Discriminator? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParamsNetworkingVariant1DiscriminatorType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPackagesParams? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekContextUnavailableErrorDetails? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyDisabledErrorDetails? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyUnreachableErrorDetails? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionToolResultErrorCode? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant170? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1Discriminator? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1DiscriminatorType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant171? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1Discriminator? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1DiscriminatorType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant172? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1Discriminator? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1DiscriminatorType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant173? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521CacheControlVariant1Discriminator? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521CacheControlVariant1DiscriminatorType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompact20260112? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionBlockMisplacedErrorDetails? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionCapability? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfig? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSummarizeCompaction? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfigDiscriminator? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfigDiscriminatorType? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionContentBlockDelta? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionContentMismatchErrorDetails? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionIncompleteTurnErrorDetails? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionIterationUsage? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionSignatureInvalidErrorDetails? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionTooManyToolReferencesErrorDetails? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionUnavailableErrorDetails? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceConfigurationRestrictedErrorDetails? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionConfig? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionInput? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickConfig? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickInput? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyConfig? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyInput? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyConfig? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyInput? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickConfig? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragConfig? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragInput? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickInput? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownConfig? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownInput? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpConfig? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpInput? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMemberInput? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeInput? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveInput? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickInput? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickInput? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickInput? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollInput? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitInput? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotInput? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomInput? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickConfig? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveConfig? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickConfig? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotConfig? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollConfig? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollDirection? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolsetConfigs? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickConfig? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeConfig? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitConfig? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomConfig? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant158? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801CacheControlVariant1Discriminator? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801CacheControlVariant1DiscriminatorType? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant159? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1Discriminator? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1DiscriminatorType? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant160? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1Discriminator? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorType? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant161? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1Discriminator? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1DiscriminatorType? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainer? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaContainerSkill>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerSkill? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerParams? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillParams>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillParams? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerSkillType? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlock? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlock? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseThinkingBlock? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseRedactedThinkingBlock? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlock? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlock? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlock? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlock? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorToolResultBlock? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionToolResultBlock? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolResultBlock? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolUseBlock? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolResultBlock? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContainerUploadBlock? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlock? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseFallbackBlock? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolListingBlock? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminator? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminatorType? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEvent? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Delta2? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextContentBlockDelta? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputJsonContentBlockDelta? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingContentBlockDelta? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignatureContentBlockDelta? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSource? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBetaContentBlockSourceContentItem? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlock? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlock? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminator? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEvent? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock2? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminator? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStopEvent? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementCapability? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfig? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.EditsItem>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EditsItem? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminator? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminatorType? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementResponse? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContractSpendLimitReachedErrorDetails? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParams? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant162? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1Discriminator? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1DiscriminatorType? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestMCPServerURLDefinition>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPServerURLDefinition? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputMessageUnion>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnion? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputConfig? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJsonOutputFormat? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpeed? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParam? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoice? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolset? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensResponse? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateDreamRequest? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInput? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelParams? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehavior? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageBatchParams? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatchIndividualRequestParams>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualRequestParams? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParams? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant124? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsCacheControlVariant1Discriminator? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsCacheControlVariant1DiscriminatorType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaContainerParams, string>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDiagnosticsParam? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::Anthropic.BetaFallbackCreditTokenParam>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditTokenParam? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaFallbackConfigV2>, string>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFallbackConfigV2>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMetadata? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsServiceTier? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadVariant1? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadCreateParams? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadContinueParams? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsThreadVariant1Discriminator? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsThreadVariant1DiscriminatorType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaToolUnion>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUnion? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTelemetryDestinationRequest? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTracesParams? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParams? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelCertificateRequestBody? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelRequest? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateUserProfileActionUrlRequestBody? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileAction? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateUserProfileRequest? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileAccessType? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserDetailsParams? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCurrency? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteMessageBatchResponse? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedSkill? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedSkillVersion? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedTelemetryDestination? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedTelemetryDestinationWorkspace? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedUserProfile? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDiagnostics? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDirectCaller? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDream? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamOutput>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutput? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamStatus? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamError? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelConfig? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamUsage? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreInput? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamSessionsInput? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminator? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminatorType? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreOutput? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelConfigParams? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminator? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminatorType? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingError? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidRequestError? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPermissionError? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNotFoundError? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitError? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGatewayTimeoutError? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOverloadedError? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTargetStoreHeldError? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminator? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminatorType? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorResponse? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffortCapability? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffortLevel? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnrollmentUrl? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironment? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Config? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfig? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminator? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminatorType? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentScope? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentArchivedErrorDetails? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentCreateDisabledErrorDetails? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentDeleteResponse? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentListResponse? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaEnvironment>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentNotFoundErrorDetails? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentUpdateDisabledErrorDetails? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorResponse? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Error2? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorDiscriminator? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorDiscriminatorType? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorType? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErroredResult? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExpiredResult? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingVariant1? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigEnabled? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigDisabled? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigBetweenTools? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigAdaptive? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2ThinkingVariant1Discriminator? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2ThinkingVariant1DiscriminatorType? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditNotApplied? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditNotAppliedReason? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditRedeemed? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditTokenParamMode? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsage? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Status? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsageStatusDiscriminator? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsageStatusDiscriminatorType? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackMessageIterationUsage? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackRefusalTrigger? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRefusalCategory? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileDeleteResponse? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileDocumentSource? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileExpiredErrorDetails? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileImageSource? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileListResponse? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFileMetadataSchema>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileMetadataSchema? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileScope? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileNotDownloadableErrorDetails? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaHeartbeatPreconditionFailedErrorDetails? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkLeaseState? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaImageDimensionsTooLargeErrorDetails? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlock? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlock? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlock? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestThinkingBlock? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestRedactedThinkingBlock? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlock? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlock? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlock? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlock? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlock? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlock? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlock? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlock? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlock? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlock? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlock? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlock? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlock? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlock? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolListingBlock? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestFallbackBlock? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminator? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminatorType? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserInputMessage? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessage? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnionDiscriminator? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnionDiscriminatorRole? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputSchema? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformation? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformation? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminator? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminatorType? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidConfigTypeChangeErrorDetails? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidMetadataErrorDetails? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaIterationsUsageVariant1Item>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageVariant1Item? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageIterationUsage? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminator? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminatorType? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLinkedOrganizationBillingUnavailableErrorDetails? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLinkedOrganizationSpendLimitReachedErrorDetails? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListDreamsResponse? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDream>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseMessageBatch? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatch>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatch? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseModelInfo? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelInfo>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelInfo? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsResponse? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillVersion>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillVersion? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsResponse? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkill>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkill? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTelemetryDestinationWorkspacesResponse? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTelemetryDestinationWorkspace>? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspace? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTelemetryDestinationsResponse? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTelemetryDestination>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestination? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTunnelCertificatesResponse? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTunnelCertificate>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelCertificate? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTunnelsResponse? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTunnel>? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnel? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListUserProfilesResponse? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUserProfile>? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfile? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPTool? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolConfig? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolDefaultConfig? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant1? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolsetCacheControlVariant1Discriminator? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolsetCacheControlVariant1DiscriminatorType? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaMCPToolConfig>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMCPTool>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActor? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionActor? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsApiActor? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserActor? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountActor? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminator? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminatorType? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResource? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResource? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminator? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminatorType? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParams? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceParams? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminator? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminatorType? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisor? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisorParams? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgent? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelConfig? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentTool? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServer? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkill? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentity? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedRunError? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminator? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStruct? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentEvaluatedPermission? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlock? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluation? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlock? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextBlock? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRedactedBlock? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminator? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminatorType? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageEvent? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentMessageContentBlock>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentParams? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentReference? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThinkingEvent? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlock? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolset? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomTool? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminator? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminatorType? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnion? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfig? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfig? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfig? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfig? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfig? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfig? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfig? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfig? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminator? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminatorType? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfigParams? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfigParams? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfigParams? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfigParams? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfigParams? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfigParams? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminator? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminator? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminatorType? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolName? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParams? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401Params? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetParams? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolParams? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminator? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminatorType? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolResultEvent? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolUseEvent? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfig? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigUnion>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfigParams? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams>? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401BashInput? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401EditInput? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401GlobInput? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401GrepInput? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401ReadInput? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401WriteInput? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicy? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParams? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2Discriminator? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelParams? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParams? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParams? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkill? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkillParams? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponse? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStore? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminator? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAutoPolicy? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64DocumentSource? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64ImageSource? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBillingError? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatus? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBranchCheckout? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudget? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetLimit? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminator? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminatorType? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMonetaryAmount? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCacheCreationUsage? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCommitCheckout? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCompactionLimitReachedError? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsContentSha256Precondition? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateAgentParams? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParams? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParams? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateCredentialRequestBody? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuth? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateDeploymentParams? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParams? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParams? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryParams? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreRequest? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponse? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminator? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParams? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParamsVariant2? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParamsVariant2Discriminator? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionParams? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParams? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateVaultRequest? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredential? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuth? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableAuthResponse? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminator? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminatorType? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminator? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminatorType? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParams? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminator? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminator? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialRefreshStatus? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuth? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminator? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminatorType? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidation? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidationStatus? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpProbe? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRefreshObject? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronSchedule? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.DateTime>? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronScheduleParams? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkill? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkillParams? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolInputSchema? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponse? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemoryStore? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminator? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteSessionResource? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedCredential? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemory? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedSession? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedVault? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeployment? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent>? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEvent? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceConfig>? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfig? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSchedule? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentStatus? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReason? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminator? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminatorType? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEventParams? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEventParams? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminator? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminator? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminatorType? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminator? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentRun? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContext? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunError? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSystemContentBlock>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlock? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubric? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentBlock? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSource? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSource? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLDocumentSource? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileDocumentSource? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminator? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminatorType? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffort? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLow? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMedium? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortHigh? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortXhigh? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMax? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminator? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminatorType? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLevel? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortParams? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationResponse? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationParams? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationUpdateParams? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsError? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPathConflictError? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsConflictError? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminator? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminatorType? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorResponse? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEvent? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDelta? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminator? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaType? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParams? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEventParams? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEventParams? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminator? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminatorType? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEvent? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEvent? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminator? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminatorType? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminator? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminatorType? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminator? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminatorType? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileImageSource? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundRunError? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceConfig? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubric? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubricParams? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponse? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminator? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminatorType? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResource? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResource? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResource? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminator? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminatorType? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckout? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageBlock? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSource? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLImageSource? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminator? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminatorType? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInlineAgent? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEvent? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEvent? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminator? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminatorType? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListAgentVersions? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgent>? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListAgents? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListCredentialsResponse? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsCredential>? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListDeploymentRunsData? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentRun>? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListDeploymentsData? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeployment>? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoriesResult? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryListItem>? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItem? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoryStoresResponse? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryStore>? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoryVersionsResult? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryVersion>? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersion? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListOrder? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionEvents? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEvent>? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEvent? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionResources? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResource>? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResource? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionThreadEvents? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionThreads? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThread>? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThread? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessions? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSession>? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSession? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListVaultsResponse? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsVault>? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVault? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerURLDefinition? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminator? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminatorType? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLMCPServerParams? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminator? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminatorType? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolConfig? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolConfigParams? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfig? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfig>? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfigParams? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualTriggerContext? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponse? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParams? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminator? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminator? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParams? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminator? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorType? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRefreshHttpResponse? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemory? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPrefix? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminator? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminatorType? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMountMode? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersionOperation? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryView? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModel? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpeed? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelConfigParams? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelOverloadedError? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRateLimitedError? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRequestFailedError? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinator? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminator? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminatorType? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflows? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagents? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisor? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001Params? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParams? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParams? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabled? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabled? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDiscriminator? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDiscriminatorType? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminator? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntry>? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntry? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams>? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgents? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminator? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParams? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminator? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminator? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminatorType? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSelfParams? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2Discriminator? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2DiscriminatorType? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryDiscriminator? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryDiscriminatorType? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParamsVariant2? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParamsVariant2Discriminator? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabled? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDiscriminator? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDiscriminatorType? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentReference>? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminator? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminator? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminatorType? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminator? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminator? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminatorType? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPrecondition? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminator? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminatorType? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminator? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminatorType? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCloneError? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusRetrying? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusExhausted? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusTerminal? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminator? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminatorType? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubric? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminator? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminatorType? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParams? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubricParams? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminator? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminatorType? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedRunError? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownRunError? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminator? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminator? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminatorType? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminator? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminatorType? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleTriggerContext? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultBlock? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSearchResultContent>? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultContent? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultCitations? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSendSessionEvents? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsInputEvent>? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSendSessionEventsParams? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventParams>? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServerToolUsage? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatus? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgent? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource>? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsage? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStats? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagent? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgentUpdate? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionBudgetReached? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionDeletedEvent? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEndTurn? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEvent? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventError? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownError? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolUseLimitReachedError? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminator? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageEvent? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventDiscriminator? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventDiscriminatorType? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminator? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminatorType? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagent20261001? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminator? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminatorType? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflows? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagents? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionRosterEntry>? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntry? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminator? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgent? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsEnabled? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsDiscriminator? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusal? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetailsCategory? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRequiresAction? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceDiscriminator? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceDiscriminatorType? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminator? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminatorType? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminator? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminatorType? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminator? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminatorType? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetails? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReason? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminator? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminator? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminatorType? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatus? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntry? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadUsage? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStats? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntryDiscriminator? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReason? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminator? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageSnapshot? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminator? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminatorType? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminator? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminatorType? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelUsage? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEvents? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminator? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminator? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminator? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminatorType? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminator? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminatorType? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminator? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminatorType? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerType? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateAgentParams? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateCredentialRequestBody? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateDeploymentParams? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryParams? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreRequestBody? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminator? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionParams? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResource? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminator? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminatorType? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceParams? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateVaultRequestBody? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminator? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminatorType? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserLocation? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationResult? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSources? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourcesParams? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference>? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminator? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterParams? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminator? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputParams? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWorkflowRunPhase>? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhase? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunError? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminator? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResult? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultError? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminator? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminatorType? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant125? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CacheControlVariant1Discriminator? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CacheControlVariant1DiscriminatorType? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818Command? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818ViewCommand? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CreateCommand? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818InsertCommand? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818DeleteCommand? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818RenameCommand? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminator? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CreateCommandCommand? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818InsertCommandCommand? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818RenameCommandCommand? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818ViewCommandCommand? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessage? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaContentBlock>? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopReason? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopDetails? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsage? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputTransformation>? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagement? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchProcessingStatus? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCounts? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponse? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Result2? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSucceededResult? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminator? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDelta? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDeltaEvent? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDeltaUsage? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputTokensDetails? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolUsage? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStartEvent? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStopEvent? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEvent? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Ping? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminator? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminatorType? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelCapabilities? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolsCapability? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingCapability? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelInfoLifecycle? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelLine? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationLevelScopedApiKeyRequiredErrorDetails? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationOnHoldErrorDetails? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorCreateNew? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorUpdateExisting? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminator? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminatorType? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTokenTaskBudget? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPlainTextSource? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequest? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConfigVariant1? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfigParams? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1Discriminator? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestScope? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequest? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConfigVariant12? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1Discriminator? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestScope? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRampLimitExceededErrorDetails? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRefusalStopDetails? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorRedactedResultBlock? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorResultBlock? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant180? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1Discriminator? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestAdvisorToolResultError, global::Anthropic.BetaRequestAdvisorResultBlock, global::Anthropic.BetaRequestAdvisorRedactedResultBlock>? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultError? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionOutputBlock? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionResultBlock? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant187? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestBashCodeExecutionToolResultError, global::Anthropic.BetaRequestBashCodeExecutionResultBlock>? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultError? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyTooLargeAfterDecodingErrorDetails? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlock? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant163? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockCacheControlVariant1Discriminator? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockCacheControlVariant1DiscriminatorType? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item2>? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StateChangesVariant1Item2? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminator? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaBrowserStateTabEntry>? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCharLocationCitation? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCitationsConfig? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionOutputBlock? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionResultBlock? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestCodeExecutionOutputBlock>? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant185? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultError? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant144? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1Discriminator? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1DiscriminatorType? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item>? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChangesVariant1Item? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminator? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant175? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1Discriminator? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1DiscriminatorType? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContentBlockLocationCitation? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant133? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1Discriminator? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1DiscriminatorType? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source8? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaURLPDFSource? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminator? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestFallbackHopInfo? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant115? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockCacheControlVariant1Discriminator? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockCacheControlVariant1DiscriminatorType? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source5? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaURLImageSource? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminator? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageTransformations? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageTransformationsOversizedImage? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPServerToolConfiguration? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant167? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1Discriminator? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1DiscriminatorType? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant145? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1Discriminator? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1DiscriminatorType? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestPageLocationCitation? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant164? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1Discriminator? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1DiscriminatorType? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultLocationCitation? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant168? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1Discriminator? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1DiscriminatorType? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller7? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolCaller? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolCaller20260120? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminator? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminatorType? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockName? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant111? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCacheControlVariant1Discriminator? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCacheControlVariant1DiscriminatorType? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item3>? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item3? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchResultLocationCitation? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminator? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant189? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditorCodeExecutionToolResultErrorCode? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockFileType? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant165? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockCacheControlVariant1Discriminator? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockCacheControlVariant1DiscriminatorType? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool3? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolReference? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolReference? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolsetReference? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolDefinition? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminator? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminatorType? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlock? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant169? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1Discriminator? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1DiscriminatorType? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant155? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1Discriminator? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool2? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminator? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminatorType? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant146? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1Discriminator? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1DiscriminatorType? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentVariant2Item2? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminator? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant184? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1Discriminator? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestToolSearchToolResultError, global::Anthropic.BetaRequestToolSearchToolSearchResultBlock>? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultError? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolSearchResultBlock? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolResultErrorCode? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestToolReferenceBlock>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant126? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1Discriminator? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1DiscriminatorType? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller3? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCallerDiscriminator? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCallerDiscriminatorType? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchResultBlock? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant181? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1Discriminator? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller13? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminator? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminatorType? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestWebFetchToolResultError, global::Anthropic.BetaRequestWebFetchResultBlock>? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultError? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchToolResultErrorCode? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchResultBlock? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant182? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1Discriminator? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller14? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminator? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminatorType? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaWebSearchToolRequestError>? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchToolRequestError? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchToolResultErrorCode? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorRedactedResultBlock? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorResultBlock? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaAdvisorToolResultError, global::Anthropic.BetaResponseAdvisorResultBlock, global::Anthropic.BetaResponseAdvisorRedactedResultBlock>? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorToolResultError? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionOutputBlock? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionResultBlock? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock>? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaBashCodeExecutionToolResultError, global::Anthropic.BetaResponseBashCodeExecutionResultBlock>? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashCodeExecutionToolResultError? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCaller? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFindToolUseBlock? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserHoverToolUseBlock? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserKeyToolUseBlock? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScrollToolUseBlock? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlock? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnion? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserZoomToolUseBlock? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserTypeToolUseBlock? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserWaitToolUseBlock? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminator? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCitationsConfig? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseClearThinking20251015Edit? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseClearToolUses20250919Edit? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionOutputBlock? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionResultBlock? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseCodeExecutionOutputBlock>? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionToolResultError? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseEncryptedCodeExecutionResultBlock? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item2>? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChangesVariant1Item2? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlock? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlock? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminator? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerKeyToolUseBlock? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerRightClickToolUseBlock? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerScrollToolUseBlock? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlock? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnion? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerTypeToolUseBlock? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerWaitToolUseBlock? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerZoomToolUseBlock? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminator? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AppliedEditsItem>? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AppliedEditsItem? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminator? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlock? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source9? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlockSourceDiscriminator? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlockSourceDiscriminatorType? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseFallbackHopInfo? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPTool? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseMCPTool>? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>>? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller8? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminator? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminatorType? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockName? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item4>? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item4? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminator? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditorCodeExecutionToolResultError? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockFileType? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTool? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolInputSchema? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool5? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeToolReference? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeMCPToolReference? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeMCPToolsetReference? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeToolDefinition? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlockToolDiscriminator? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlockToolDiscriminatorType? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUnion? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolReferenceBlock? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool4? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminator? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminatorType? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaToolSearchToolResultError, global::Anthropic.BetaResponseToolSearchToolSearchResultBlock>? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolResultError? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolSearchResultBlock? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseToolReferenceBlock>? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller4? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockCallerDiscriminator? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockCallerDiscriminatorType? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockUnion? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchResultBlock? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller15? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminator? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminatorType? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebFetchToolResultError, global::Anthropic.BetaResponseWebFetchResultBlock>? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultError? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchResultBlock? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller16? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminator? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminatorType? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>>? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchToolResultError? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenRequestBody? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWork? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSessionWorkData? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkState? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkHeartbeatResponse? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkHeartbeatResponseState? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkListResponse? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSelfHostedWork>? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkQueueStats? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkStopRequest? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkUpdateRequest? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillSource? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillParamsType? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillReadBlockedUndecryptableErrorDetails? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillSourceType? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSlackChannelSetUpSettingsConflictErrorDetails? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSlackChannelSetUpSettingsRefusedErrorDetails? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopDetailsDiscriminator? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopDetailsDiscriminatorType? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageQuotaExceededErrorDetails? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageClearAt? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem2>>? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem2>? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlocksItem2? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageContentBlockDiscriminator? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageContentBlockDiscriminatorType? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemMessageOutputConfig? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTraces? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationState? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDeliveryHealth? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspaces? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationContentMode? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReason? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminator? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabled? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabled? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminator? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminatorType? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabledParams? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabledParams? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParams? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminator? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminatorType? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTest? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResult? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestFailure? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestSuccess? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminator? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminatorType? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAll? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminator? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminatorType? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminator? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminatorType? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant127? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022CacheControlVariant1Discriminator? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022CacheControlVariant1DiscriminatorType? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant128? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124CacheControlVariant1Discriminator? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124CacheControlVariant1DiscriminatorType? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant129? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429CacheControlVariant1Discriminator? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429CacheControlVariant1DiscriminatorType? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant130? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728CacheControlVariant1Discriminator? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728CacheControlVariant1DiscriminatorType? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingBlockBinding? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingPrefixMismatchBehavior? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingTypes? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDisplayMode? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminator? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminatorType? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformationReason? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformationReason? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadAlreadyContinuedErrorDetails? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadContinueInFlightErrorDetails? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadFingerprintMismatchErrorDetails? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadNotFoundErrorDetails? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadUnsupportedRequestErrorDetails? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant191? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolCacheControlVariant1Discriminator? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolCacheControlVariant1DiscriminatorType? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceAuto? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceAny? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceTool? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceNone? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminator? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminatorType? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolNameConflictErrorDetails? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolReferenceUnresolvedErrorDetails? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant176? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1Discriminator? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119Type? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant178? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1Discriminator? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119Type? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCallerDiscriminator? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCallerDiscriminatorType? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelToken? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateTelemetryDestinationRequestBody? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserProfileRequestBody? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageServiceTier? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserLocation? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserDetails? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaUserProfileTrustGrant>? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileTrustGrant? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileEnrollEndUserAction? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminator? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminatorType? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionUrl? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileBillingNotAuthorizedErrorDetails? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserAccountStatus? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserEntityType? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileListOrder? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileListOrderBy? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileNotBillableErrorDetails? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileRequiredErrorDetails? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileTrustGrantStatus? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant138? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1Discriminator? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1DiscriminatorType? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSources? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant139? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1Discriminator? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1DiscriminatorType? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant140? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1Discriminator? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1DiscriminatorType? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant141? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318CacheControlVariant1Discriminator? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318CacheControlVariant1DiscriminatorType? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318ResponseInclusion? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceAll? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceExcept? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWebFetchUrlSourceToolReference>? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceToolReference? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceNone? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceOnly? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolResults2? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesClientToolResultsDiscriminator? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolResults2? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminator? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInput2? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminator? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminatorType? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant147? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1Discriminator? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1DiscriminatorType? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant148? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1Discriminator? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1DiscriminatorType? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant149? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318CacheControlVariant1Discriminator? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318CacheControlVariant1DiscriminatorType? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318ResponseInclusion? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentArchivedEventData? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentCreatedEventData? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentDeletedEventData? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentUpdatedEventData? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentArchivedEventData? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentCreatedEventData? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentDeletedEventData? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentPausedEventData? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunFailedEventData? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunStartedEventData? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUnpausedEventData? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUpdatedEventData? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentArchivedEventData? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentCreatedEventData? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentDeletedEventData? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnwrapWebhookEvent? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventData? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionCreatedEventData? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionPendingEventData? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRunningEventData? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionIdledEventData? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRequiresActionEventData? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionArchivedEventData? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionDeletedEventData? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusIdledEventData? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadCreatedEventData? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadIdledEventData? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCreatedEventData? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultArchivedEventData? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultDeletedEventData? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionUpdatedEventData? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionBudgetReachedEventData? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileEnforcementActionOpenedEventData? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileEnforcementActionResolvedEventData? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileProgramStatusUpdatedEventData? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookExternalKeyFailedEventData? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookExternalKeyRecoveredEventData? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminator? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminatorType? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkLeaseStateState? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BillingError? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BodyCreateSkillV1SkillsPost? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BodyCreateSkillVersionV1SkillsSkillIdVersionsPost? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTarget? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCoordinateTarget? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRefTarget? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminator? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminatorType? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabConfig? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabInput? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickConfig? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickInput? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadConfig? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadInput? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindConfig? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindInput? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputConfig? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputInput? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputValue? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextConfig? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextInput? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyConfig? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyInput? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverConfig? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverInput? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecConfig? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecInput? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyConfig? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyInput? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickConfig? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragConfig? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragInput? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickInput? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownConfig? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownInput? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpConfig? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpInput? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsConfig? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsInput? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMemberInput? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateInput? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabInput? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabInput? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageInput? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleInput? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkInput? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToInput? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotInput? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomInput? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickInput? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickInput? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickInput? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveInput? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollInput? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeInput? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitInput? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickConfig? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveConfig? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateConfig? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabConfig? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleConfig? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkConfig? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageConfig? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageFilter? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickConfig? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotConfig? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollConfig? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollDirection? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToConfig? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadCompleted? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadFailed? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadStarted? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeTabOpened? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateTabEntry? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabConfig? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolsetConfigs? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickConfig? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeConfig? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitConfig? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomConfig? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant131? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1Discriminator? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1DiscriminatorType? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlEphemeralTtl? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheCreation? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissMessagesChanged? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissModelChanged? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissPreviousMessageNotFound? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReason? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissSystemChanged? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissToolsChanged? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissUnavailable? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminator? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminatorType? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CanceledResult? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CapabilitySupport? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDelta? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Citation? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCharLocationCitation? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponsePageLocationCitation? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseContentBlockLocationCitation? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultLocationCitation? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseSearchResultLocationCitation? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminator? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminatorType? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClaudeCodeVersionTooOldErrorDetails? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolUnion? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekContextUnavailableErrorDetails? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyDisabledErrorDetails? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyNetworkBlockedErrorDetails? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyUnreachableErrorDetails? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionToolResultErrorCode? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant150? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522CacheControlVariant1Discriminator? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522CacheControlVariant1DiscriminatorType? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant151? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825CacheControlVariant1Discriminator? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825CacheControlVariant1DiscriminatorType? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant152? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120CacheControlVariant1Discriminator? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120CacheControlVariant1DiscriminatorType? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant153? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521CacheControlVariant1Discriminator? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521CacheControlVariant1DiscriminatorType? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionBlockAmbiguousErrorDetails? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionBlockMisplacedErrorDetails? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionContentMismatchErrorDetails? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionIncompleteTurnErrorDetails? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionNothingToSummarizeErrorDetails? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionSignatureInvalidErrorDetails? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionTooManyToolReferencesErrorDetails? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionToolChangesMismatchErrorDetails? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionUnavailableErrorDetails? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionConfig? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionInput? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickConfig? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickInput? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyConfig? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyInput? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyConfig? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyInput? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickConfig? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragConfig? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragInput? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickInput? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownConfig? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownInput? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpConfig? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpInput? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMemberInput? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeInput? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveInput? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickInput? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickInput? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickInput? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollInput? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitInput? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotInput? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomInput? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickConfig? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveConfig? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickConfig? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotConfig? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollConfig? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollDirection? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolsetConfigs? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickConfig? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeConfig? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitConfig? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomConfig? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant134? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801CacheControlVariant1Discriminator? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801CacheControlVariant1DiscriminatorType? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Container? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContainerSkill>? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerSkill? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerParams? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SkillParams>? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillParams? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerSkillType? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlock? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseThinkingBlock? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseRedactedThinkingBlock? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlock? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlock? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlock? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlock? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionToolResultBlock? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionToolResultBlock? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionToolResultBlock? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolResultBlock? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseContainerUploadBlock? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminator? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminatorType? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEvent? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Delta? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextContentBlockDelta? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputJsonContentBlockDelta? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingContentBlockDelta? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SignatureContentBlockDelta? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSource? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>>? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentContentBlockSourceContentItem? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlock? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlock? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminator? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEvent? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEventContentBlockDiscriminator? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEventContentBlockDiscriminatorType? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStopEvent? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContextManagementCapability? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContractSpendLimitReachedErrorDetails? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParams? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant135? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParamsCacheControlVariant1Discriminator? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParamsCacheControlVariant1DiscriminatorType? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputMessageUnion>? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnion? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OutputConfig? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Speed? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParam? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoice? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensResponse? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageBatchParams? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.MessageBatchIndividualRequestParams>? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualRequestParams? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParams? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant15? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsCacheControlVariant1Discriminator? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsCacheControlVariant1DiscriminatorType? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ContainerParams, string>? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DiagnosticsParam? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Metadata? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsServiceTier? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateUserProfileActionUrlRequestBody? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileAction? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateUserProfileRequest? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileAccessType? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserDetailsParams? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteMessageBatchResponse? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedSkill? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedSkillVersion? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedUserProfile? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Diagnostics? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DirectCaller? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EffortCapability? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EffortLevel? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EnforcedSpendLimitReachedErrorDetails? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponse? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Error? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InvalidRequestError? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PermissionError? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NotFoundError? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitError? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GatewayTimeoutError? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OverloadedError? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminator? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminatorType? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorType? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErroredResult? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExpiredResult? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileDeleteResponse? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileDocumentSource? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileExpiredErrorDetails? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileImageSource? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileListResponse? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FileMetadataSchema>? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileMetadataSchema? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileNotDownloadableErrorDetails? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ImageDimensionsTooLargeErrorDetails? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlock? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlock? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlock? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestThinkingBlock? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestRedactedThinkingBlock? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlock? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlock? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlock? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlock? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlock? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlock? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlock? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlock? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlock? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminator? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminatorType? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInputMessage? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessage? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnionDiscriminator? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnionDiscriminatorRole? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputSchema? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JsonOutputFormat? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.LinkedOrganizationBillingUnavailableErrorDetails? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.LinkedOrganizationSpendLimitReachedErrorDetails? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseMessageBatch? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.MessageBatch>? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatch? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseModelInfo? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ModelInfo>? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelInfo? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsResponse? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SkillVersion>? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillVersion? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsResponse? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Skill>? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Skill? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListUserProfilesResponse? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfile>? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfile? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant16? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818CacheControlVariant1Discriminator? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818CacheControlVariant1DiscriminatorType? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Message? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlock>? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopReason? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopDetails? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Usage? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchProcessingStatus? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCounts? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponse? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Result? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SucceededResult? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminator? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDelta? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDeltaEvent? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDeltaUsage? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OutputTokensDetails? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolUsage? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStartEvent? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStopEvent? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEvent? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminator? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminatorType? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelCapabilities? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolsCapability? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingCapability? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelInfoLifecycle? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelLine? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationOnHoldErrorDetails? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PlainTextSource? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RampLimitExceededErrorDetails? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalCategory? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalStopDetails? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionOutputBlock? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionResultBlock? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestBashCodeExecutionOutputBlock>? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant186? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestBashCodeExecutionToolResultError, global::Anthropic.RequestBashCodeExecutionResultBlock>? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultError? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyEncodingInvalidErrorDetails? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyEncodingUnsupportedErrorDetails? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyTooLargeAfterDecodingErrorDetails? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlock? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant136? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockCacheControlVariant1Discriminator? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockCacheControlVariant1DiscriminatorType? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item>? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StateChangesVariant1Item? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminator? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BrowserStateTabEntry>? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCharLocationCitation? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCitationsConfig? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionOutputBlock? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionResultBlock? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestCodeExecutionOutputBlock>? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant183? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestCodeExecutionToolResultError, global::Anthropic.RequestCodeExecutionResultBlock, global::Anthropic.RequestEncryptedCodeExecutionResultBlock>? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultError? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestEncryptedCodeExecutionResultBlock? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant156? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlockCacheControlVariant1Discriminator? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlockCacheControlVariant1DiscriminatorType? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContentBlockLocationCitation? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant112? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockCacheControlVariant1Discriminator? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockCacheControlVariant1DiscriminatorType? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source4? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLPDFSource? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminator? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminatorType? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant14? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockCacheControlVariant1Discriminator? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockCacheControlVariant1DiscriminatorType? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source3? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLImageSource? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminator? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminatorType? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageTransformations? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageTransformationsOversizedImage? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestPageLocationCitation? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant137? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlockCacheControlVariant1Discriminator? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlockCacheControlVariant1DiscriminatorType? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultLocationCitation? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant142? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCacheControlVariant1Discriminator? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCacheControlVariant1DiscriminatorType? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller5? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolCaller? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolCaller20260120? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCallerDiscriminator? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCallerDiscriminatorType? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockName? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant12? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCacheControlVariant1Discriminator? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCacheControlVariant1DiscriminatorType? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item>? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchResultLocationCitation? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminator? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant188? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultError? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditorCodeExecutionToolResultErrorCode? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionViewResultBlockFileType? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlock? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant143? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlockCacheControlVariant1Discriminator? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlockCacheControlVariant1DiscriminatorType? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant120? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockCacheControlVariant1Discriminator? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockCacheControlVariant1DiscriminatorType? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>>? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentVariant2Item? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminator? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant179? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1Discriminator? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestToolSearchToolResultError, global::Anthropic.RequestToolSearchToolSearchResultBlock>? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultError? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolSearchResultBlock? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolResultErrorCode? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestToolReferenceBlock>? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant17? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCacheControlVariant1Discriminator? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCacheControlVariant1DiscriminatorType? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCallerDiscriminator? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCallerDiscriminatorType? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchResultBlock? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant174? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1Discriminator? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller9? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminator? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminatorType? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestWebFetchToolResultError, global::Anthropic.RequestWebFetchResultBlock>? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultError? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchToolResultErrorCode? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchResultBlock? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant177? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1Discriminator? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller10? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminator? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminatorType? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.WebSearchToolRequestError>? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchToolRequestError? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchToolResultErrorCode? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionOutputBlock? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionResultBlock? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseBashCodeExecutionOutputBlock>? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BashCodeExecutionToolResultError, global::Anthropic.ResponseBashCodeExecutionResultBlock>? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashCodeExecutionToolResultError? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserCloseTabToolUseBlock? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCaller? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFileUploadToolUseBlock? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFindToolUseBlock? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFormInputToolUseBlock? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoverToolUseBlock? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserKeyToolUseBlock? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickToolUseBlock? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserListTabsToolUseBlock? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNavigateToolUseBlock? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNewTabToolUseBlock? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadPageToolUseBlock? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserRightClickToolUseBlock? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScreenshotToolUseBlock? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToToolUseBlock? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToolUseBlock? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlock? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnion? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserZoomToolUseBlock? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTripleClickToolUseBlock? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTypeToolUseBlock? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserWaitToolUseBlock? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminator? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCitationsConfig? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionOutputBlock? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionResultBlock? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseCodeExecutionOutputBlock>? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.CodeExecutionToolResultError, global::Anthropic.ResponseCodeExecutionResultBlock, global::Anthropic.ResponseEncryptedCodeExecutionResultBlock>? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionToolResultError? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseEncryptedCodeExecutionResultBlock? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerCursorPositionToolUseBlock? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerDoubleClickToolUseBlock? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerHoldKeyToolUseBlock? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerKeyToolUseBlock? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickToolUseBlock? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMiddleClickToolUseBlock? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMouseMoveToolUseBlock? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerRightClickToolUseBlock? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScreenshotToolUseBlock? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScrollToolUseBlock? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlock? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnion? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTypeToolUseBlock? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTripleClickToolUseBlock? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerWaitToolUseBlock? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerZoomToolUseBlock? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminator? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlock? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source6? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminator? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminatorType? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller6? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockName? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item2>? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item2? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminator? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditorCodeExecutionToolResultError? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlockFileType? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolReferenceBlock? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolResultError? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolSearchResultBlock? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseToolReferenceBlock>? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller2? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockCallerDiscriminator? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockCallerDiscriminatorType? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockUnion? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchResultBlock? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller11? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminator? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminatorType? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebFetchToolResultError, global::Anthropic.ResponseWebFetchResultBlock>? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultError? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultBlock? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller12? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminator? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminatorType? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.WebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>>? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchToolResultError? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillSource? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillParamsType? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillReadBlockedUndecryptableErrorDetails? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillSourceType? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopDetailsDiscriminator? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopDetailsDiscriminatorType? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StorageQuotaExceededErrorDetails? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem>>? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem>? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlocksItem? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessageContentBlockDiscriminator? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessageContentBlockDiscriminatorType? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant18? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124CacheControlVariant1Discriminator? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124CacheControlVariant1DiscriminatorType? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant19? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429CacheControlVariant1Discriminator? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429CacheControlVariant1DiscriminatorType? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant110? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728CacheControlVariant1Discriminator? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728CacheControlVariant1DiscriminatorType? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingTypes? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigAdaptive? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingDisplayMode? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigBetweenTools? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigDisabled? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigEnabled? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminator? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminatorType? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadAlreadyContinuedErrorDetails? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadContinueInFlightErrorDetails? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadFingerprintMismatchErrorDetails? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadNotFoundErrorDetails? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadUnsupportedRequestErrorDetails? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant190? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolCacheControlVariant1Discriminator? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolCacheControlVariant1DiscriminatorType? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceAuto? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceAny? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceTool? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceNone? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminator? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminatorType? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolNameConflictErrorDetails? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolReferenceUnresolvedErrorDetails? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant157? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1Discriminator? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119Type? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant166? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1Discriminator? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119Type? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCallerDiscriminator? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCallerDiscriminatorType? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserProfileRequestBody? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UsageServiceTier? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserLocation? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserDetails? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementStatus? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementAction>? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementAction? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfilePrograms? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnrollEndUserAction? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionDiscriminator? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionDiscriminatorType? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionUrl? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileBillingNotAuthorizedErrorDetails? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberProgram? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileProgramStatus? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileCyberTier>? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberTier? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberRequirements? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberTierStatus? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsFeature? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsFeatureStatus? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsProgram? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileEfsFeature>? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionRestriction? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionBan? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionDiscriminator? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionDiscriminatorType? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionReason? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionNextStep? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserAccountStatus? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserEntityType? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileListOrder? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileListOrderBy? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileNotBillableErrorDetails? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileRequiredErrorDetails? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant116? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910CacheControlVariant1Discriminator? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910CacheControlVariant1DiscriminatorType? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSources? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant117? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209CacheControlVariant1Discriminator? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209CacheControlVariant1DiscriminatorType? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant118? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309CacheControlVariant1Discriminator? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309CacheControlVariant1DiscriminatorType? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant119? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318CacheControlVariant1Discriminator? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318CacheControlVariant1DiscriminatorType? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318ResponseInclusion? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceAll? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceExcept? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WebFetchUrlSourceToolReference>? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceToolReference? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceNone? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceOnly? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolResults? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesClientToolResultsDiscriminator? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesClientToolResultsDiscriminatorType? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolResults? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminator? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminatorType? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInput? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminator? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminatorType? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant121? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305CacheControlVariant1Discriminator? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305CacheControlVariant1DiscriminatorType? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant122? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209CacheControlVariant1Discriminator? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209CacheControlVariant1DiscriminatorType? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant123? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318CacheControlVariant1Discriminator? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318CacheControlVariant1DiscriminatorType? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318ResponseInclusion? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventType? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceParams? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberParams? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllConnectorsPermissionResource? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllowedInferenceGeo? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAlreadyMemberErrorDetails? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsActivitySummaryResponse? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSingleDayActivitySummary>? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSingleDayActivitySummary? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsActorType? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsApiActor? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactActivity? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactGroupBy? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactsResponse? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsArtifactActivity>? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedChatMetrics? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedMetrics? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedSessionsMetrics? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatMetrics? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeCodeMetrics? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCoreCodeMetrics? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsToolActions? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeTagCategory? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeTagMetrics? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorActivity? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedMetrics? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatMetrics? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorClaudeCodeMetrics? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorCoworkMetrics? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorOfficeMetrics? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorGroupBy? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorOfficeProductMetrics? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorsResponse? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsConnectorActivity>? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsLinesOfCode? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResponse? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostReportTimeBucket>? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostReportTimeBucket? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResult? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportContextWindow? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostType? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceGeo? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResultSpeed? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTokenType? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostGroupBy? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostBucketedResult>? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItem? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserActor? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemActorDiscriminator? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemActorDiscriminatorType? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemSpeed? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersOrderBy? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersResponse? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostUsersItem>? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCoworkMetrics? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsDesignMetrics? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActor? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProvider? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminator? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminatorType? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostGroup? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActor? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostCostType? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostInferenceGeo? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageReportServiceTier? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSpeed? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostItem? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostMetrics? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostOrderBy? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostResponse? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsFlatCostItem>? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatGroup? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageItem? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageMetrics? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolUse? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageOrderBy? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageResponse? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsFlatUsageItem>? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOfficeMetrics? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOfficeProductMetrics? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOrder? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginActivity? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginChatCoworkUnifiedMetrics? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginClaudeCodeMetrics? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginCoworkMetrics? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginGroupBy? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginsResponse? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsPluginActivity>? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProductFilter? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectActivity? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUser? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectGroupBy? Type2804 { get; set; }
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
        public global::Anthropic.BetaAnalyticsReportUserActor? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsServiceAccountActor? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActorDiscriminator? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActorDiscriminatorType? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsScienceMetrics? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillActivity? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedMetrics? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatMetrics? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillClaudeCodeMetrics? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillCoworkMetrics? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillOfficeMetrics? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillActivityShareStatus? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedChatMetrics? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillGroupBy? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillOfficeProductMetrics? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillsResponse? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSkillActivity>? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSortOrder? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsTimeBucketWidth? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsToolActionCounts? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResponse? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageReportTimeBucket>? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageReportTimeBucket? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResult? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResultSpeed? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostProductFilter? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostSortOrder? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageGroupBy? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageBucketedResult>? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItem? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemActorDiscriminator? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemActorDiscriminatorType? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemSpeed? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersOrderBy? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersResponse? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageUsersItem>? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserActivity? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserGroupBy? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsersResponse? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUserActivity>? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKey? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatedBy? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PrincipalVariant1? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUserActor? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyServiceAccountActor? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1Discriminator? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1DiscriminatorType? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyOrganizationScope? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyWorkspaceScope? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminator? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminatorType? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyStatus? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUpdateParams? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUpdateParamsStatus? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApprovalMetrics? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestParams? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitPeriod? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponse? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestActor? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestResolvedBy? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimit? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummary? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestStatus? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAttachedAttachment? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAwsExternalKeyConfig? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfig? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfigParams? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotInviteEmailsWithUnverifiedDomainsErrorDetails? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotRemoveLastMemberErrorDetails? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutManagedMemberErrorDetails? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutMembershipAdminErrorDetails? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutOwnerErrorDetails? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutPrimaryOwnerErrorDetails? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutPrivilegedMemberErrorDetails? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutSelfErrorDetails? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeApiActor? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsConfiguration? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsMode? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsConfigurationUpdateParams? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeParams? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminator? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminatorType? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminator? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupDefaultManagedSettings? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupDefaultManagedSettingsUpdateParams? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupManagedSettings? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatus? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsDeleted? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsList? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSummary>? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSummary? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSetParams? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusActive? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminator? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminatorType? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItem? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor3? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUserActor? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminator? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminatorType? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCoreMetrics? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCustomerType? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelBreakdown>? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelBreakdown? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSubscriptionType? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaApprovalMetrics>? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeEnterpriseOrganizationRole? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekFeatureUnsupportedErrorDetails? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettings? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsState? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabled? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabled? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDiscriminator? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDiscriminatorType? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabledParams? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabledParams? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParams? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParamsDiscriminator? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParamsDiscriminatorType? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsUpdateParams? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConcurrentMembershipChangeErrorDetails? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorPermissionResource? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorScopePermissionResource? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorToolPermissionResource? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLinesOfCode? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportGroupBy? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportItem? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostType? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportServiceTier? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceGeoFilter? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTimeBucket? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportItem>? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTimeBucketWidth? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteParams? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteParamsRole? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupParams? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelCertificateParams? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberParams? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNoBillingWorkspaceRoleSchema? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatedByType? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidency? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>, string>? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceGeo? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidencyCreateParams? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidencyUpdateParams? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyResponse? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteResponse? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupMemberResponse? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupResponse? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitResponse? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteUserResponse? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberResponse? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedOrganizationWebhookEndpoint? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDenySpendLimitIncreaseRequestParams? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEmailDomainNotAllowedErrorDetails? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEstimatedCost? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKey? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Attachment2? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnattachedAttachment? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminator? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminatorType? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig2? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpExternalKeyConfig? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderConfigDiscriminator? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderConfigDiscriminatorType? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyChangedErrorDetails? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParams? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig4? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminator? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminatorType? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyInWorkspacePolicyErrorDetails? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyListResponse? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaExternalKey>? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParams? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfigVariant12? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParamsProviderConfigVariant1Discriminator? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyValidationFailedErrorDetails? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuer? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks2? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksDiscovery? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksExplicitUrl? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksInline? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerJwksDiscriminator? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerJwksDiscriminatorType? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIssuerPollStatus? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParams? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks4? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminator? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminatorType? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerListResponse? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationIssuer>? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParams? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksVariant12? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1Discriminator? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRule? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRuleMatch? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountTarget? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleCreateParams? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleListResponse? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationRule>? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleUpdateParams? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleWorkspace? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleWorkspaceListResponse? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationRuleWorkspace>? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetClaudeCodeUsageReportResponse? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeUsageReportItem>? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportResponse? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportTimeBucket>? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetMessagesUsageReportResponse? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportTimeBucket>? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportTimeBucket? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteAlreadyExistsErrorDetails? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteSchema? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationRoleSchema? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteStatusSchema? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaKeyProfileMismatchErrorDetails? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsResponse? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendSummary>? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseApiKey? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaApiKey>? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseInviteSchema? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInviteSchema>? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseUser? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUser>? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUser? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseWorkspaceMemberSchema? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceMemberSchema>? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceMemberSchema? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseWorkspace? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspace>? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspace? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsResponse? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimit>? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportGroupBy? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportItem? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportItem>? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTokenUsage? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNewOrganizationWebhookEndpoint? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent>? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointState? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgApiKeyLimitExceededErrorDetails? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgMemberLimitExceededErrorDetails? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgServiceScope? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationNotEnrolledInBetaErrorDetails? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationPermissionResource? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationSchema? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationScope? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTypeNotSupportedErrorDetails? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpoint? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent>? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointList? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationWebhookEndpoint>? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointSigningSecret? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaParentOrganizationRequiredErrorDetails? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPlugin? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginComponent>? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginComponent? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScan? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByVariant1? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginUserActor? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginApiActor? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1Discriminator? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1DiscriminatorType? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOrganizationInstallationPreference? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Owner? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerOrganization? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerUser? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminator? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminatorType? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginReach? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginComponentType? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScanAssessment? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScanStatus? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginDeleted? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSetting? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingInstallationPreference? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target2? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganization? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetRbacGroup? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganizationMember? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingTargetDiscriminator? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingTargetDiscriminatorType? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeleted? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target3? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminator? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminatorType? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingList? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginInstallationSetting>? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginList? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPlugin>? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplace? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Owner2? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceOwnerDiscriminator? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceOwnerDiscriminatorType? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceSource? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceSyncStatus? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceList? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplace>? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginError? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginWarning? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning>? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationReport? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginError>? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings>? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginNameTakenErrorDetails? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShare? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminator? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminatorType? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareList? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginShare>? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersion? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByVariant12? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionCreatedByVariant1Discriminator? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionCreatedByVariant1DiscriminatorType? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionReach? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionList? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginVersion>? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimit? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitModelGroup? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitBatchGroup? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitTokenCountGroup? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitFilesGroup? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitSkillsGroup? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitWebSearchGroup? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupDiscriminator? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupDiscriminatorType? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimitValue>? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitValue? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitListResponse? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimit>? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroup? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupSourceType? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupList? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacGroup>? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupManagedSettingsNotFoundErrorDetails? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupMember? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupMemberList? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacGroupMember>? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupNotFoundErrorDetails? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupOrderLimitExceededErrorDetails? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupScope? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRole? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSource? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleList? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacRole>? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleNotFoundErrorDetails? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermission? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Resource2? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminator? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionList? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacRolePermission>? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceBuiltIn? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceCustom? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceDiscriminator? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceDiscriminatorType? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRegistrationPendingErrorDetails? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyTimeoutErrorDetails? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRoleSchema? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenParams? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSandboxEgressRestrictedErrorDetails? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScanFailedErrorDetails? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScanPendingErrorDetails? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScopedApiKeyActorSchema? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSeatTierScope? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccount? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountOrganizationRole? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountCreateParams? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountCreateParamsOrganizationRole? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountListResponse? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaServiceAccount>? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountUpdateParams? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountUpdateParamsOrganizationRole? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMember? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRoleSchema? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberCreateFromSAParams? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberCreateParams? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberDeleteResponse? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberListResponse? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaServiceAccountWorkspaceMember>? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberUpdateParams? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParams? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope6? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserScope? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceScope? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminator? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminatorType? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSettingsDocumentLimitExceededErrorDetails? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSettingsHistoryLimitExceededErrorDetails? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillNameTakenErrorDetails? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope4? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageTierScope? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminator? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminatorType? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserActorSchema? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestActorDiscriminator? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestActorDiscriminatorType? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestListResponse? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchema? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestResolvedByDiscriminator? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestResolvedByDiscriminatorType? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor2? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryActorDiscriminator? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryActorDiscriminatorType? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope5? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryScopeDiscriminator? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryScopeDiscriminatorType? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source2? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummarySourceDiscriminator? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummarySourceDiscriminatorType? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnel? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnelCertificate? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelCertificateListResponse? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationTunnelCertificate>? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelListResponse? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationTunnel>? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnelToken? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnsupportedCharsetErrorDetails? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupParams? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserParams? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserParamsRole? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberParams? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileNotFoundErrorDetails? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyResponse? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyResponseStatus? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceApiKeyLimitExceededErrorDetails? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceCreateParams? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceMemberLimitExceededErrorDetails? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspacePolicyField? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspacePolicyViolationErrorDetails? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimit? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group3? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminator? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminatorType? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitValue>? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValue? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitListResponse? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimit>? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateParams? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitUpdateValue>? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateValue? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateValueType? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source10? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminator? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminatorType? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceUpdateParams? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceParams? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberParams? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AllConnectorsPermissionResource? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AllowedInferenceGeo? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AlreadyMemberErrorDetails? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsActivitySummaryResponse? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsSingleDayActivitySummary>? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSingleDayActivitySummary? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsArtifactActivity? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsArtifactGroupBy? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsArtifactsResponse? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsArtifactActivity>? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatCoworkUnifiedChatMetrics? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatCoworkUnifiedMetrics? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatCoworkUnifiedSessionsMetrics? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatMetrics? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsClaudeCodeMetrics? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsCoreCodeMetrics? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsToolActions? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsClaudeTagMetrics? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorActivity? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatCoworkUnifiedMetrics? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatMetrics? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorClaudeCodeMetrics? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorCoworkMetrics? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorOfficeMetrics? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatCoworkUnifiedChatMetrics? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatCoworkUnifiedSessionsMetrics? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorGroupBy? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorOfficeProductMetrics? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorsResponse? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsConnectorActivity>? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsLinesOfCode? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsCoworkMetrics? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsDesignMetrics? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsOfficeMetrics? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsOfficeProductMetrics? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsOrder? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginActivity? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginChatCoworkUnifiedMetrics? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginClaudeCodeMetrics? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginCoworkMetrics? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginGroupBy? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginsResponse? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsPluginActivity>? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsProjectActivity? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUser? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsProjectGroupBy? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsProjectsResponse? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsProjectActivity>? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsScienceMetrics? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillActivity? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatCoworkUnifiedMetrics? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatMetrics? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillClaudeCodeMetrics? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillCoworkMetrics? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillOfficeMetrics? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillActivityShareStatus? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatCoworkUnifiedChatMetrics? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatCoworkUnifiedSessionsMetrics? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillGroupBy? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillOfficeProductMetrics? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillsResponse? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsSkillActivity>? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsToolActionCounts? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUserActivity? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUserGroupBy? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUsersResponse? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsUserActivity>? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKey? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedBy? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PrincipalVariant12? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUserActor? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyServiceAccountActor? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1Discriminator? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1DiscriminatorType? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope7? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyOrganizationScope? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyWorkspaceScope? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminator? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminatorType? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyStatus? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUpdateParams? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUpdateParamsStatus? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApproveSpendLimitIncreaseRequestParams? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitPeriod? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApproveSpendLimitIncreaseRequestResponse? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestActor? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestResolvedBy? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimit? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummary? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestStatus? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AttachedAttachment? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AwsExternalKeyConfig? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfig? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfigParams? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CannotInviteEmailsWithUnverifiedDomainsErrorDetails? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CannotRemoveLastMemberErrorDetails? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettings? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsState? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabled? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabled? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminator? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminatorType? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabledParams? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabledParams? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParams? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminator? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminatorType? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsUpdateParams? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConcurrentMembershipChangeErrorDetails? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorPermissionResource? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorScopePermissionResource? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorToolPermissionResource? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteParams? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteParamsRole? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateRbacGroupParams? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberParams? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NoBillingWorkspaceRoleSchema? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByType? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidency? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>, string>? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InferenceGeo? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceGeo? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidencyCreateParams? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidencyUpdateParams? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyResponse? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteResponse? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupMemberResponse? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupResponse? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteUserResponse? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberResponse? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DenySpendLimitIncreaseRequestParams? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EmailDomainNotAllowedErrorDetails? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKey? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Attachment? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnattachedAttachment? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminator? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminatorType? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GcpExternalKeyConfig? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyProviderConfigDiscriminator? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyProviderConfigDiscriminatorType? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyChangedErrorDetails? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParams? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig3? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminator? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminatorType? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyInWorkspacePolicyErrorDetails? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyListResponse? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ExternalKey>? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParams? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfigVariant1? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1Discriminator? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyValidationFailedErrorDetails? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyValidationTimedOutErrorDetails? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuer? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksDiscovery? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksExplicitUrl? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksInline? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerJwksDiscriminator? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerJwksDiscriminatorType? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.IssuerPollStatus? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParams? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks3? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminator? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminatorType? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerListResponse? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationIssuer>? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParams? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksVariant1? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParamsJwksVariant1Discriminator? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParamsJwksVariant1DiscriminatorType? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRule? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RuleMatch? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountTarget? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleCreateParams? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleListResponse? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationRule>? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleUpdateParams? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleWorkspace? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleWorkspaceListResponse? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationRuleWorkspace>? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteAlreadyExistsErrorDetails? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteSchema? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationRoleSchema? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteStatusSchema? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.KeyProfileMismatchErrorDetails? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListEffectiveSpendLimitsResponse? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendSummary>? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseApiKey? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ApiKey>? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseInviteSchema? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InviteSchema>? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseUser? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.User>? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.User? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseWorkspaceMemberSchema? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceMemberSchema>? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceMemberSchema? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseWorkspace? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Workspace>? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Workspace? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgApiKeyLimitExceededErrorDetails? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgMemberLimitExceededErrorDetails? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgServiceScope? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationPermissionResource? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationSchema? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationScope? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationTypeNotSupportedErrorDetails? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ParentOrganizationRequiredErrorDetails? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimit? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group4? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitModelGroup? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitBatchGroup? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitTokenCountGroup? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitFilesGroup? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitSkillsGroup? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitWebSearchGroup? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupDiscriminator? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupDiscriminatorType? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RateLimitValue>? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitValue? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitListResponse? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RateLimit>? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroup? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupSourceType? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupList? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacGroup>? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupMember? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupMemberList? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacGroupMember>? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupScope? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRole? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSource? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleList? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacRole>? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleNotFoundErrorDetails? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermission? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Resource? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermissionResourceDiscriminator? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermissionResourceDiscriminatorType? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermissionList? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacRolePermission>? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceBuiltIn? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceCustom? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceDiscriminator? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceDiscriminatorType? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveFederationRuleWorkspaceResponse? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SandboxEgressRestrictedErrorDetails? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ScopedApiKeyActorSchema? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SeatTierScope? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccount? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountOrganizationRole? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountCreateParams? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountCreateParamsOrganizationRole? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountListResponse? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ServiceAccount>? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountUpdateParams? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountUpdateParamsOrganizationRole? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMember? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRoleSchema? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberCreateFromSAParams? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberCreateParams? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberDeleteResponse? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberListResponse? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ServiceAccountWorkspaceMember>? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberUpdateParams? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope2? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserScope? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceScope? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UsageTierScope? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitScopeDiscriminator? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitScopeDiscriminatorType? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserActorSchema? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestActorDiscriminator? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestActorDiscriminatorType? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestListResponse? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendLimitIncreaseRequestSchema>? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestSchema? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestResolvedByDiscriminator? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestResolvedByDiscriminatorType? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryActorDiscriminator? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryActorDiscriminatorType? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope3? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryScopeDiscriminator? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryScopeDiscriminatorType? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummarySourceDiscriminator? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummarySourceDiscriminatorType? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateRbacGroupParams? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserParams? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserParamsRole? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberParams? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileNotFoundErrorDetails? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyResponse? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyResponseStatus? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceApiKeyLimitExceededErrorDetails? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceCreateParams? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceMemberLimitExceededErrorDetails? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspacePolicyField? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspacePolicyViolationErrorDetails? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimit? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group2? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminator? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminatorType? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimitValue>? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValue? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitListResponse? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimit>? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitOrganizationSource? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateParams? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimitUpdateValue>? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateValue? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateValueType? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source7? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitWorkspaceSource? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValueSourceDiscriminator? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValueSourceDiscriminatorType? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceUpdateParams? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PingType? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostRequest? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostRequest? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostRequest? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequest? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent>? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequest? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent>? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ModelsListLifecycleItem>? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListLifecycleItem? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelsListLifecycleItem>? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListLifecycleItem? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementStatus>? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionStatus>? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEventType>? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadStatus>? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamStatus>? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse>? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListApiKeysV1OrganizationsApiKeysGetStatus? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportGroupBy>? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitPeriod>? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitIncreaseRequestStatus>? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginsV1OrganizationsPluginsGetOwnerType? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProductFilter>? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item>? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item>? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item>? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item>? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item>? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item>? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSpeed>? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsActorType>? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageGroupBy>? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostGroupBy>? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUserGroupBy>? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProjectGroupBy>? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSkillGroupBy>? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsConnectorGroupBy>? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsPluginGroupBy>? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsArtifactGroupBy>? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse>? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatus? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendLimitPeriod>? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendLimitIncreaseRequestStatus>? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsUserGroupBy>? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsProjectGroupBy>? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsSkillGroupBy>? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsConnectorGroupBy>? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsPluginGroupBy>? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsArtifactGroupBy>? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse2? Type3704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError2? Type3705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.LinkedOrganizationBillingUnavailableErrorDetails, global::Anthropic.LinkedOrganizationSpendLimitReachedErrorDetails>? Type3706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse3? Type3707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError3? Type3708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.UserProfileBillingNotAuthorizedErrorDetails, global::Anthropic.UserProfileNotBillableErrorDetails>? Type3709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse4? Type3710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError4? Type3711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse5? Type3712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError5? Type3713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse6? Type3714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError6? Type3715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse7? Type3716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError7? Type3717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ContractSpendLimitReachedErrorDetails, global::Anthropic.EnforcedSpendLimitReachedErrorDetails, global::Anthropic.RampLimitExceededErrorDetails>? Type3718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse8? Type3719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError8? Type3720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse9? Type3721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError9? Type3722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListResponse? Type3723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListResponseError? Type3724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails>? Type3725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsGetResponse? Type3726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsGetResponseError? Type3727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponse? Type3728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponseError? Type3729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.CmekKeyDisabledErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails>? Type3730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponse2? Type3731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponseError2? Type3732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesListResponse? Type3733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesListResponseError? Type3734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesRetrieveResponse? Type3735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesRetrieveResponseError? Type3736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesDeleteResponse? Type3737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesDeleteResponseError? Type3738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesCancelResponse? Type3739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesCancelResponseError? Type3740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesResultsResponse? Type3741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesResultsResponseError? Type3742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse? Type3743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError? Type3744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse2? Type3745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError2? Type3746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse3? Type3747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError3? Type3748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse4? Type3749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError4? Type3750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostResponse? Type3751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostResponseError? Type3752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListFilesV1FilesGetResponse? Type3753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListFilesV1FilesGetResponseError? Type3754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetFileMetadataV1FilesFileIdGetResponse? Type3755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetFileMetadataV1FilesFileIdGetResponseError? Type3756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteFileV1FilesFileIdDeleteResponse? Type3757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteFileV1FilesFileIdDeleteResponseError? Type3758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponse? Type3759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponseError? Type3760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponse2? Type3761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponseError2? Type3762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponse? Type3763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponseError? Type3764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponse2? Type3765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponseError2? Type3766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsV1SkillsGetResponse? Type3767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsV1SkillsGetResponseError? Type3768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillV1SkillsSkillIdGetResponse? Type3769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillV1SkillsSkillIdGetResponseError? Type3770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillV1SkillsSkillIdDeleteResponse? Type3771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillV1SkillsSkillIdDeleteResponseError? Type3772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponse? Type3773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponseError? Type3774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponse2? Type3775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponseError2? Type3776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsV1SkillsSkillIdVersionsGetResponse? Type3777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsV1SkillsSkillIdVersionsGetResponseError? Type3778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillVersionV1SkillsSkillIdVersionsVersionGetResponse? Type3779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillVersionV1SkillsSkillIdVersionsVersionGetResponseError? Type3780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponse? Type3781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponseError? Type3782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse? Type3783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError? Type3784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse2? Type3785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError2? Type3786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaLinkedOrganizationBillingUnavailableErrorDetails, global::Anthropic.BetaLinkedOrganizationSpendLimitReachedErrorDetails>? Type3787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse3? Type3788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError3? Type3789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaUserProfileBillingNotAuthorizedErrorDetails, global::Anthropic.BetaUserProfileNotBillableErrorDetails>? Type3790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse4? Type3791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError4? Type3792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse5? Type3793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError5? Type3794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse6? Type3795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError6? Type3796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse7? Type3797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError7? Type3798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse8? Type3799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError8? Type3800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse9? Type3801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError9? Type3802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListResponse? Type3803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListResponseError? Type3804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails>? Type3805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsGetResponse? Type3806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsGetResponseError? Type3807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponse? Type3808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponseError? Type3809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponse2? Type3810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponseError2? Type3811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesListResponse? Type3812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesListResponseError? Type3813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesRetrieveResponse? Type3814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesRetrieveResponseError? Type3815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesDeleteResponse? Type3816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesDeleteResponseError? Type3817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesCancelResponse? Type3818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesCancelResponseError? Type3819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesResultsResponse? Type3820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesResultsResponseError? Type3821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse? Type3822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError? Type3823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse2? Type3824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError2? Type3825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse3? Type3826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError3? Type3827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse4? Type3828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError4? Type3829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostResponse? Type3830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostResponseError? Type3831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListFilesV1FilesGetResponse? Type3832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListFilesV1FilesGetResponseError? Type3833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetFileMetadataV1FilesFileIdGetResponse? Type3834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetFileMetadataV1FilesFileIdGetResponseError? Type3835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteFileV1FilesFileIdDeleteResponse? Type3836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteFileV1FilesFileIdDeleteResponseError? Type3837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponse? Type3838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponseError? Type3839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponse2? Type3840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponseError2? Type3841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponse? Type3842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponseError? Type3843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponse2? Type3844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponseError2? Type3845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsV1SkillsGetResponse? Type3846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsV1SkillsGetResponseError? Type3847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponse? Type3848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponseError? Type3849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillV1SkillsSkillIdDeleteResponse? Type3850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillV1SkillsSkillIdDeleteResponseError? Type3851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse? Type3852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseError? Type3853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse2? Type3854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseError2? Type3855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsV1SkillsSkillIdVersionsGetResponse? Type3856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsV1SkillsSkillIdVersionsGetResponseError? Type3857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillVersionV1SkillsSkillIdVersionsVersionGetResponse? Type3858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillVersionV1SkillsSkillIdVersionsVersionGetResponseError? Type3859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponse? Type3860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponseError? Type3861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponse? Type3862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponseError? Type3863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponse2? Type3864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponseError2? Type3865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEnvironmentsV1EnvironmentsGetResponse? Type3866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEnvironmentsV1EnvironmentsGetResponseError? Type3867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse? Type3868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponseError? Type3869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponse? Type3870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponseError? Type3871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponse2? Type3872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponseError2? Type3873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteResponse? Type3874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteResponseError? Type3875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveEnvironmentV1EnvironmentsEnvironmentIdArchivePostResponse? Type3876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveEnvironmentV1EnvironmentsEnvironmentIdArchivePostResponseError? Type3877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentStatsV1EnvironmentsEnvironmentIdWorkStatsGetResponse? Type3878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentStatsV1EnvironmentsEnvironmentIdWorkStatsGetResponseError? Type3879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRecordHeartbeatV1EnvironmentsEnvironmentIdWorkWorkIdHeartbeatPostResponse? Type3880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRecordHeartbeatV1EnvironmentsEnvironmentIdWorkWorkIdHeartbeatPostResponseError? Type3881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopWorkV1EnvironmentsEnvironmentIdWorkWorkIdStopPostResponse? Type3882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopWorkV1EnvironmentsEnvironmentIdWorkWorkIdStopPostResponseError? Type3883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkV1EnvironmentsEnvironmentIdWorkWorkIdGetResponse? Type3884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkV1EnvironmentsEnvironmentIdWorkWorkIdGetResponseError? Type3885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkV1EnvironmentsEnvironmentIdWorkWorkIdPostResponse? Type3886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkV1EnvironmentsEnvironmentIdWorkWorkIdPostResponseError? Type3887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse? Type3888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError? Type3889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse2? Type3890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError2? Type3891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse3? Type3892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError3? Type3893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaEnvironmentNotFoundErrorDetails, global::Anthropic.BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails>? Type3894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse4? Type3895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError4? Type3896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackChannelsResponse? Type3897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackChannelsResponseError? Type3898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackChannelResponse? Type3899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackChannelResponseError? Type3900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponse? Type3901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponseError? Type3902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponse2? Type3903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponseError2? Type3904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponse3? Type3905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponseError3? Type3906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponse? Type3907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponseError? Type3908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponse2? Type3909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponseError2? Type3910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackWorkspacesResponse? Type3911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackWorkspacesResponseError? Type3912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackWorkspaceResponse? Type3913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackWorkspaceResponseError? Type3914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponse? Type3915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponseError? Type3916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponse2? Type3917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponseError2? Type3918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponse3? Type3919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponseError3? Type3920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundlesResponse? Type3921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundlesResponseError? Type3922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleResponse? Type3923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleResponseError? Type3924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponse? Type3925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponseError? Type3926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaBundleAttachmentNotSupportedErrorDetails, global::Anthropic.BetaBundleOnCallErrorDetails>? Type3927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponse2? Type3928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponseError2? Type3929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponse3? Type3930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponseError3? Type3931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundleTargetsResponse? Type3932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundleTargetsResponseError? Type3933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateBundleTargetResponse? Type3934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateBundleTargetResponseError? Type3935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleTargetResponse? Type3936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleTargetResponseError? Type3937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteBundleTargetResponse? Type3938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteBundleTargetResponseError? Type3939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponse? Type3940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponseError? Type3941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponse2? Type3942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponseError2? Type3943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteV1OrganizationsInvitesInviteIdDeleteResponse? Type3944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteV1OrganizationsInvitesInviteIdDeleteResponseError? Type3945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserV1OrganizationsUsersUserIdPostResponse? Type3946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserV1OrganizationsUsersUserIdPostResponseError? Type3947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse? Type3948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError? Type3949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse2? Type3950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError2? Type3951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse3? Type3952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError3? Type3953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponse? Type3954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponseError? Type3955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponse2? Type3956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponseError2? Type3957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse? Type3958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError? Type3959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse2? Type3960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError2? Type3961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse3? Type3962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError3? Type3963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse? Type3964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError? Type3965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse2? Type3966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError2? Type3967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse3? Type3968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError3? Type3969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponse? Type3970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponseError? Type3971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse? Type3972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError? Type3973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse2? Type3974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError2? Type3975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponse? Type3976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponseError? Type3977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse? Type3978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError? Type3979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse2? Type3980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError2? Type3981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse? Type3982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError? Type3983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaOrgApiKeyLimitExceededErrorDetails, global::Anthropic.BetaWorkspaceApiKeyLimitExceededErrorDetails>? Type3984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse2? Type3985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError2? Type3986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponse? Type3987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponseError? Type3988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponse2? Type3989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponseError2? Type3990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse? Type3991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError? Type3992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse2? Type3993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError2? Type3994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse? Type3995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError? Type3996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse2? Type3997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError2? Type3998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponse? Type3999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponseError? Type4000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponse? Type4001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponseError? Type4002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponse? Type4003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponseError? Type4004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponse? Type4005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponseError? Type4006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetResponse? Type4007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetResponseError? Type4008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitV1OrganizationsSpendLimitsPostResponse? Type4009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitV1OrganizationsSpendLimitsPostResponseError? Type4010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaSandboxEgressRestrictedErrorDetails, global::Anthropic.BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails>? Type4011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSpendLimitV1OrganizationsSpendLimitsSpendLimitIdGetResponse? Type4012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSpendLimitV1OrganizationsSpendLimitsSpendLimitIdGetResponseError? Type4013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteResponse? Type4014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteResponseError? Type4015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountV1OrganizationsServiceAccountsPostResponse? Type4016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountV1OrganizationsServiceAccountsPostResponseError? Type4017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponse? Type4018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponseError? Type4019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponse? Type4020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponseError? Type4021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponse? Type4022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponseError? Type4023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponse? Type4024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponseError? Type4025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationIssuerV1OrganizationsFederationIssuersPostResponse? Type4026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationIssuerV1OrganizationsFederationIssuersPostResponseError? Type4027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponse? Type4028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponseError? Type4029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponse? Type4030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponseError? Type4031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse? Type4032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponseError? Type4033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponse? Type4034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponseError? Type4035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponse? Type4036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponseError? Type4037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponse? Type4038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponseError? Type4039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveTunnelV1OrganizationsTunnelsTunnelIdArchivePostResponse? Type4040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveTunnelV1OrganizationsTunnelsTunnelIdArchivePostResponseError? Type4041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRevealTunnelTokenV1OrganizationsTunnelsTunnelIdRevealTokenPostResponse? Type4042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRevealTunnelTokenV1OrganizationsTunnelsTunnelIdRevealTokenPostResponseError? Type4043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenV1OrganizationsTunnelsTunnelIdRotateTokenPostResponse? Type4044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenV1OrganizationsTunnelsTunnelIdRotateTokenPostResponseError? Type4045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateCertificateV1OrganizationsTunnelsTunnelIdCertificatesPostResponse? Type4046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateCertificateV1OrganizationsTunnelsTunnelIdCertificatesPostResponseError? Type4047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveCertificateV1OrganizationsTunnelsTunnelIdCertificatesCertificateIdArchivePostResponse? Type4048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveCertificateV1OrganizationsTunnelsTunnelIdCertificatesCertificateIdArchivePostResponseError? Type4049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupV1OrganizationsRbacGroupsPostResponse? Type4050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupV1OrganizationsRbacGroupsPostResponseError? Type4051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse? Type4052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponseError? Type4053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse? Type4054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError? Type4055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails>? Type4056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse2? Type4057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError2? Type4058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse? Type4059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError? Type4060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse2? Type4061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError2? Type4062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse? Type4063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError? Type4064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse2? Type4065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError2? Type4066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolesV1OrganizationsRbacRolesGetResponse? Type4067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolesV1OrganizationsRbacRolesGetResponseError? Type4068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaOrganizationTypeNotSupportedErrorDetails, global::Anthropic.BetaParentOrganizationRequiredErrorDetails>? Type4069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponse? Type4070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponseError? Type4071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponse2? Type4072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponseError2? Type4073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponse? Type4074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponseError? Type4075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponse2? Type4076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponseError2? Type4077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse? Type4078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError? Type4079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails, global::Anthropic.BetaUnsupportedCharsetErrorDetails>? Type4080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse2? Type4081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError2? Type4082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse3? Type4083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError3? Type4084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaPluginNameTakenErrorDetails, global::Anthropic.BetaSkillNameTakenErrorDetails>? Type4085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse4? Type4086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError4? Type4087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse? Type4088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError? Type4089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails, global::Anthropic.BetaScanFailedErrorDetails>? Type4090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse2? Type4091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError2? Type4092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse3? Type4093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError3? Type4094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaScanPendingErrorDetails, global::Anthropic.BetaSkillNameTakenErrorDetails>? Type4095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponse? Type4096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponseError? Type4097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponse2? Type4098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponseError2? Type4099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse? Type4100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError? Type4101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse2? Type4102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError2? Type4103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse3? Type4104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError3? Type4105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse4? Type4106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError4? Type4107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponse? Type4108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponseError? Type4109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails>? Type4110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponse2? Type4111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponseError2? Type4112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostResponse? Type4113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostResponseError? Type4114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse? Type4115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponseError? Type4116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2? Type4117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponseError2? Type4118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostResponse? Type4119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostResponseError? Type4120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemovePluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetDeleteResponse? Type4121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemovePluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetDeleteResponseError? Type4122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostResponse? Type4123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostResponseError? Type4124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekFeatureUnsupportedErrorDetails, global::Anthropic.BetaCmekKeyDisabledErrorDetails>? Type4125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaSettingsHistoryLimitExceededErrorDetails>? Type4126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdDeleteResponse? Type4127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdDeleteResponseError? Type4128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponse? Type4129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponseError? Type4130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponse2? Type4131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponseError2? Type4132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteV1OrganizationsInvitesInviteIdDeleteResponse? Type4133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteV1OrganizationsInvitesInviteIdDeleteResponseError? Type4134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserV1OrganizationsUsersUserIdPostResponse? Type4135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserV1OrganizationsUsersUserIdPostResponseError? Type4136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse? Type4137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError? Type4138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse2? Type4139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError2? Type4140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse3? Type4141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError3? Type4142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse? Type4143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError? Type4144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse2? Type4145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError2? Type4146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse3? Type4147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError3? Type4148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse? Type4149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError? Type4150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse2? Type4151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError2? Type4152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse3? Type4153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError3? Type4154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponse? Type4155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponseError? Type4156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse? Type4157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError? Type4158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse2? Type4159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError2? Type4160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponse? Type4161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponseError? Type4162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse? Type4163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError? Type4164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse2? Type4165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError2? Type4166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse? Type4167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError? Type4168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.OrgApiKeyLimitExceededErrorDetails, global::Anthropic.WorkspaceApiKeyLimitExceededErrorDetails>? Type4169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse2? Type4170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError2? Type4171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponse? Type4172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponseError? Type4173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponse2? Type4174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponseError2? Type4175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse? Type4176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError? Type4177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse2? Type4178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError2? Type4179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse? Type4180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError? Type4181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse2? Type4182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError2? Type4183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponse? Type4184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponseError? Type4185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponse? Type4186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponseError? Type4187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponse? Type4188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponseError? Type4189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponse? Type4190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponseError? Type4191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountV1OrganizationsServiceAccountsPostResponse? Type4192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountV1OrganizationsServiceAccountsPostResponseError? Type4193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponse? Type4194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponseError? Type4195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponse? Type4196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponseError? Type4197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponse? Type4198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponseError? Type4199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponse? Type4200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponseError? Type4201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationIssuerV1OrganizationsFederationIssuersPostResponse? Type4202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationIssuerV1OrganizationsFederationIssuersPostResponseError? Type4203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponse? Type4204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponseError? Type4205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponse? Type4206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponseError? Type4207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationRuleV1OrganizationsFederationRulesPostResponse? Type4208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationRuleV1OrganizationsFederationRulesPostResponseError? Type4209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponse? Type4210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponseError? Type4211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponse? Type4212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponseError? Type4213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponse? Type4214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponseError? Type4215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteResponse? Type4216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateRbacGroupV1OrganizationsRbacGroupsPostResponse? Type4217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateRbacGroupV1OrganizationsRbacGroupsPostResponseError? Type4218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse? Type4219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponseError? Type4220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse? Type4221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError? Type4222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails>? Type4223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse2? Type4224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError2? Type4225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse? Type4226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError? Type4227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse2? Type4228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError2? Type4229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse? Type4230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError? Type4231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse2? Type4232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError2? Type4233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolesV1OrganizationsRbacRolesGetResponse? Type4234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolesV1OrganizationsRbacRolesGetResponseError? Type4235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.OrganizationTypeNotSupportedErrorDetails, global::Anthropic.ParentOrganizationRequiredErrorDetails>? Type4236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponse? Type4237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponseError? Type4238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponse2? Type4239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponseError2? Type4240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponse? Type4241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponseError? Type4242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponse2? Type4243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponseError2? Type4244 { get; set; }

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
        public global::System.Collections.Generic.List<global::Anthropic.StateChangesVariant1Item2>? ListType89 { get; set; }
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
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item3>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestToolReferenceBlock>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaWebSearchToolRequestError>? ListType97 { get; set; }
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
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item4>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseToolReferenceBlock>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaWebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.BetaResponseWebSearchResultBlock>>? ListType108 { get; set; }
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
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem2>>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem2>? ListType112 { get; set; }
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
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlock>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestBashCodeExecutionOutputBlock>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.StateChangesVariant1Item>? ListType132 { get; set; }
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
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item>>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestToolReferenceBlock>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.WebSearchToolRequestError>? ListType139 { get; set; }
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
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item2>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseToolReferenceBlock>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.WebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem>>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem>? ListType148 { get; set; }
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
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSummary>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelBreakdown>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportItem>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaAllowedInferenceGeo>, string>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAllowedInferenceGeo>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaExternalKey>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationIssuer>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationRule>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationRuleWorkspace>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeCodeUsageReportItem>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportTimeBucket>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportTimeBucket>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendSummary>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaApiKey>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInviteSchema>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUser>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceMemberSchema>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspace>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimit>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportItem>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationWebhookEndpoint>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginComponent>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginInstallationSetting>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPlugin>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplace>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginError>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginShare>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginVersion>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRateLimitValue>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRateLimit>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacGroup>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacGroupMember>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacRole>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacRolePermission>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaServiceAccount>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaServiceAccountWorkspaceMember>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationTunnelCertificate>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationTunnel>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimitValue>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimit>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimitUpdateValue>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsSingleDayActivitySummary>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsArtifactActivity>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsConnectorActivity>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsPluginActivity>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsProjectActivity>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsSkillActivity>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsUserActivity>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.AllowedInferenceGeo>, string>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AllowedInferenceGeo>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ExternalKey>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationIssuer>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationRule>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationRuleWorkspace>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendSummary>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ApiKey>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InviteSchema>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.User>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceMemberSchema>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.Workspace>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RateLimitValue>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RateLimit>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacGroup>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacGroupMember>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacRole>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacRolePermission>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ServiceAccount>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ServiceAccountWorkspaceMember>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendLimitIncreaseRequestSchema>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimitValue>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimit>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimitUpdateValue>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ModelsListLifecycleItem>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnthropicBeta>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelsListLifecycleItem>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfileEnforcementStatus>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionStatus>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionEventType>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsEventDeltaType>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThreadStatus>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamStatus>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUsageReportServiceTier>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportContextWindow>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInferenceGeoFilter>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpeed>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportGroupBy>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportGroupBy>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitPeriod>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitIncreaseRequestStatus>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProductFilter>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsClaudeTagCategory>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSpeed>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsActorType>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageGroupBy>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostGroupBy>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUserGroupBy>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProjectGroupBy>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSkillGroupBy>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsConnectorGroupBy>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsPluginGroupBy>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsArtifactGroupBy>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendLimitPeriod>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendLimitIncreaseRequestStatus>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsUserGroupBy>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsProjectGroupBy>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsSkillGroupBy>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsConnectorGroupBy>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsPluginGroupBy>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsArtifactGroupBy>? ListType294 { get; set; }
    }
}