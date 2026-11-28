
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
        public global::Anthropic.BetaComplianceReviewActor? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewUserActor? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewApiActor? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewServiceAccountActor? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewActorDiscriminator? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewActorDiscriminatorType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCase? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseStatus? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewPolicyCategory>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewPolicyCategory? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewEnforcementAction? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewTranscript>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewTranscript? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseCloseReason? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseCloseReasonType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseClosed? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseOpen? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseOrderBy? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseStatusDiscriminator? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseStatusDiscriminatorType? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseStatusFilter? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewContentNotCaptured? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewContentUnavailableReason? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewStoredCopyUnavailable? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewContentUnavailableReasonDiscriminator? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewContentUnavailableReasonDiscriminatorType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCreateMessageContent? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStruct? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessage? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewDetermination? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewItem? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewReadReason? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewItemDetails? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewMessageDetails? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewItemDetailsDiscriminator? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewItemDetailsDiscriminatorType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewMessageContent? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewMessageContentDiscriminator? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewMessageContentDiscriminatorType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewNotice? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewNoticeKind? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewNoticeKindType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewOrder? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewSafeguardsReason? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewReadReasonDiscriminator? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewReadReasonDiscriminatorType? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewVerdict? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewViolatedPolicyCategory? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionConfig? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionInput? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickConfig? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickInput? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyConfig? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyInput? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyConfig? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyInput? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickConfig? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragConfig? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragInput? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickInput? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownConfig? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownInput? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpConfig? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpInput? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMemberInput? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeInput? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveInput? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickInput? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickInput? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickInput? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollInput? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitInput? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotInput? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomInput? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickConfig? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveConfig? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickConfig? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotConfig? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollConfig? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollDirection? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolsetConfigs? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickConfig? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeConfig? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitConfig? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomConfig? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant158? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801CacheControlVariant1Discriminator? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801CacheControlVariant1DiscriminatorType? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant159? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1Discriminator? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1DiscriminatorType? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant160? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1Discriminator? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant161? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1Discriminator? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1DiscriminatorType? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainer? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaContainerSkill>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerSkill? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerParams? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillParams>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillParams? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerSkillType? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlock? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlock? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseThinkingBlock? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseRedactedThinkingBlock? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlock? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlock? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlock? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlock? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorToolResultBlock? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionToolResultBlock? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolResultBlock? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolUseBlock? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolResultBlock? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContainerUploadBlock? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlock? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseFallbackBlock? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolListingBlock? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminator? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminatorType? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEvent? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Delta2? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextContentBlockDelta? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputJsonContentBlockDelta? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingContentBlockDelta? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignatureContentBlockDelta? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSource? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBetaContentBlockSourceContentItem? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlock? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlock? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminator? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEvent? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock2? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminator? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStopEvent? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementCapability? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfig? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.EditsItem>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EditsItem? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminator? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminatorType? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementResponse? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContractSpendLimitReachedErrorDetails? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParams? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant162? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1Discriminator? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1DiscriminatorType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestMCPServerURLDefinition>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPServerURLDefinition? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputMessageUnion>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnion? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputConfig? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJsonOutputFormat? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpeed? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParam? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoice? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolset? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensResponse? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateDreamRequest? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInput? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelParams? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehavior? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageBatchParams? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatchIndividualRequestParams>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualRequestParams? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParams? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant124? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsCacheControlVariant1Discriminator? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsCacheControlVariant1DiscriminatorType? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaContainerParams, string>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDiagnosticsParam? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::Anthropic.BetaFallbackCreditTokenParam>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditTokenParam? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaFallbackConfigV2>, string>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFallbackConfigV2>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMetadata? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsServiceTier? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadVariant1? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadCreateParams? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadContinueParams? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsThreadVariant1Discriminator? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsThreadVariant1DiscriminatorType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaToolUnion>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUnion? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTelemetryDestinationRequest? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTracesParams? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParams? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelCertificateRequestBody? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelRequest? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateUserProfileActionUrlRequestBody? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileAction? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateUserProfileRequest? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileAccessType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserDetailsParams? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCurrency? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteMessageBatchResponse? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedSkill? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedSkillVersion? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedTelemetryDestination? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedTelemetryDestinationWorkspace? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedUserProfile? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDiagnostics? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDirectCaller? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDream? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamOutput>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutput? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamStatus? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamError? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelConfig? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamUsage? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreInput? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamSessionsInput? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminator? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminatorType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreOutput? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelConfigParams? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminator? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminatorType? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingError? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidRequestError? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPermissionError? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNotFoundError? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitError? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGatewayTimeoutError? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOverloadedError? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTargetStoreHeldError? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminator? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminatorType? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorResponse? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffortCapability? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffortLevel? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnrollmentUrl? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironment? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Config? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfig? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminator? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminatorType? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentScope? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentArchivedErrorDetails? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentCreateDisabledErrorDetails? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentDeleteResponse? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentListResponse? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaEnvironment>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentNotFoundErrorDetails? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentUpdateDisabledErrorDetails? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorResponse? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Error2? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorDiscriminator? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorDiscriminatorType? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorType? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErroredResult? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExpiredResult? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingVariant1? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigEnabled? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigDisabled? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigBetweenTools? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigAdaptive? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2ThinkingVariant1Discriminator? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2ThinkingVariant1DiscriminatorType? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditNotApplied? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditNotAppliedReason? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditRedeemed? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditTokenParamMode? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsage? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Status3? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsageStatusDiscriminator? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsageStatusDiscriminatorType? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackMessageIterationUsage? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackRefusalTrigger? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRefusalCategory? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileDeleteResponse? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileDocumentSource? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileExpiredErrorDetails? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileImageSource? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileListResponse? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFileMetadataSchema>? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileMetadataSchema? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileScope? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFileNotDownloadableErrorDetails? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedBucketReference? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekControl? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekDisabled? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekEnabled? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekControlDiscriminator? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekControlDiscriminatorType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekControlParams? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekDisabledParams? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekEnabledParams? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekControlParamsDiscriminator? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekControlParamsDiscriminatorType? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedRetiredKey>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedRetiredKey? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaGoogleManagedCmekRegionStatus>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionActive? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionFailed? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionPending? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionStatus? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionSuspended? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionStatusDiscriminator? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionStatusDiscriminatorType? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedDataControls? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageControl? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedRetiredBucket? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageBucket? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageDisabled? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageEnabled? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageControlDiscriminator? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageControlDiscriminatorType? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageControlParams? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageDisabledParams? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageEnabledParams? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageControlParamsDiscriminator? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageControlParamsDiscriminatorType? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedRetiredBucket>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaGoogleManagedStorageBucket>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaGoogleManagedStorageRegionStatus>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageFailedCheck? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageFailedCheckCheck? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageFailedCheckRole? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionActive? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedStorageFailedCheck>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionFailed? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionPending? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionStatus? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionSuspended? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminator? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminatorType? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaHeartbeatPreconditionFailedErrorDetails? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkLeaseState? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaImageDimensionsTooLargeErrorDetails? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlock? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlock? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlock? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestThinkingBlock? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestRedactedThinkingBlock? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlock? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlock? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlock? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlock? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlock? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlock? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlock? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlock? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlock? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlock? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlock? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlock? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlock? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlock? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolListingBlock? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestFallbackBlock? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminator? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminatorType? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserInputMessage? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessage? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnionDiscriminator? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnionDiscriminatorRole? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputSchema? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformation? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformation? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminator? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminatorType? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidConfigTypeChangeErrorDetails? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidMetadataErrorDetails? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaIterationsUsageVariant1Item>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageVariant1Item? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageIterationUsage? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminator? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminatorType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLinkedOrganizationBillingUnavailableErrorDetails? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLinkedOrganizationSpendLimitReachedErrorDetails? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListDreamsResponse? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDream>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseMessageBatch? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatch>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatch? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseModelInfo? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelInfo>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelInfo? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListReviewCasesResponse? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewCase>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListReviewNoticesResponse? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewNotice>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsResponse? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillVersion>? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillVersion? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsResponse? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkill>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkill? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTelemetryDestinationWorkspacesResponse? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTelemetryDestinationWorkspace>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspace? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTelemetryDestinationsResponse? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTelemetryDestination>? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestination? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTunnelCertificatesResponse? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTunnelCertificate>? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelCertificate? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTunnelsResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTunnel>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnel? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListUserProfilesResponse? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUserProfile>? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfile? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPTool? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolConfig? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolDefaultConfig? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant1? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolsetCacheControlVariant1Discriminator? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolsetCacheControlVariant1DiscriminatorType? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaMCPToolConfig>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMCPTool>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActor? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionActor? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsApiActor? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserActor? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountActor? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminator? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminatorType? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResource? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResource? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminator? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminatorType? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParams? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceParams? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminator? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminatorType? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisor? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisorParams? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgent? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelConfig? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool>? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentTool? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServer? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkill? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentity? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedRunError? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminator? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStruct? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentEvaluatedPermission? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlock? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluation? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlock? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextBlock? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRedactedBlock? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminator? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminatorType? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageEvent? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentMessageContentBlock>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentParams? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentReference? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThinkingEvent? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlock? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolset? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomTool? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminator? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminatorType? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnion? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfig? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfig? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfig? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfig? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfig? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfig? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfig? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfig? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminator? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminatorType? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfigParams? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfigParams? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfigParams? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfigParams? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfigParams? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfigParams? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminator? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminator? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminatorType? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolName? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParams? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401Params? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetParams? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolParams? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminator? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminatorType? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolResultEvent? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolUseEvent? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfig? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigUnion>? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfigParams? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams>? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401BashInput? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401EditInput? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401GlobInput? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401GrepInput? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401ReadInput? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401WriteInput? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicy? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParams? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2Discriminator? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelParams? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParams? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParams? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkill? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkillParams? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponse? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStore? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminator? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAutoPolicy? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64DocumentSource? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64ImageSource? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBillingError? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatus? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBranchCheckout? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudget? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetLimit? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminator? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminatorType? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMonetaryAmount? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCacheCreationUsage? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCommitCheckout? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCompactionLimitReachedError? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsConflictError? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsContentSha256Precondition? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateAgentParams? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParams? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParams? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateCredentialRequestBody? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuth? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateDeploymentParams? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParams? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParams? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryParams? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreRequest? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponse? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminator? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParams? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParamsVariant2? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParamsVariant2Discriminator? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionParams? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParams? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateVaultRequest? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredential? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuth? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableAuthResponse? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminator? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminatorType? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminator? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminatorType? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParams? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminator? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminator? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialRefreshStatus? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuth? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminator? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminatorType? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidation? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidationStatus? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpProbe? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRefreshObject? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronSchedule? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.DateTime>? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronScheduleParams? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkill? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkillParams? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolInputSchema? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponse? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemoryStore? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminator? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteSessionResource? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedCredential? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemory? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedSession? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedVault? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeployment? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent>? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEvent? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceConfig>? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfig? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSchedule? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentStatus? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReason? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminator? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminatorType? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEventParams? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEventParams? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminator? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminator? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminatorType? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminator? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentRun? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContext? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunError? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSystemContentBlock>? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlock? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubric? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentBlock? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSource? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSource? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLDocumentSource? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileDocumentSource? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminator? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminatorType? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffort? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLow? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMedium? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortHigh? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortXhigh? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMax? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminator? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminatorType? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLevel? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortParams? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationResponse? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationParams? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationUpdateParams? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsError? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPathConflictError? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminator? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminatorType? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorResponse? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEvent? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDelta? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminator? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaType? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParams? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEventParams? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEventParams? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminator? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminatorType? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEvent? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEvent? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminator? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminatorType? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminator? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminatorType? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminator? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminatorType? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileImageSource? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundRunError? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceConfig? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubric? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubricParams? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponse? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminator? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminatorType? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResource? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResource? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResource? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminator? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminatorType? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckout? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageBlock? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSource? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLImageSource? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminator? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminatorType? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInlineAgent? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEvent? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEvent? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminator? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminatorType? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListAgentVersions? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgent>? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListAgents? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListCredentialsResponse? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsCredential>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListDeploymentRunsData? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentRun>? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListDeploymentsData? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeployment>? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoriesResult? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryListItem>? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItem? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoryStoresResponse? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryStore>? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoryVersionsResult? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryVersion>? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersion? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListOrder? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionEvents? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEvent>? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEvent? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionResources? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResource>? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResource? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionThreadEvents? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionThreads? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThread>? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThread? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessions? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSession>? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSession? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListVaultsResponse? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsVault>? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVault? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerURLDefinition? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminator? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminatorType? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLMCPServerParams? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminator? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminatorType? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolConfig? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolConfigParams? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfig? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfig>? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfigParams? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualTriggerContext? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponse? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParams? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminator? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminator? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParams? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminator? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorType? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRefreshHttpResponse? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemory? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPrefix? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminator? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminatorType? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMountMode? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersionOperation? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryView? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModel? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpeed? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelConfigParams? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelOverloadedError? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRateLimitedError? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRequestFailedError? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinator? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminator? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminatorType? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflows? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagents? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisor? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001Params? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParams? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParams? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabled? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabled? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDiscriminator? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDiscriminatorType? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminator? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntry>? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntry? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams>? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgents? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminator? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParams? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminator? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminator? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminatorType? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSelfParams? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2Discriminator? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2DiscriminatorType? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryDiscriminator? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryDiscriminatorType? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParamsVariant2? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParamsVariant2Discriminator? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabled? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDiscriminator? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDiscriminatorType? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentReference>? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminator? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminator? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminatorType? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminator? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminator? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminatorType? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPrecondition? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminator? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminatorType? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminator? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminatorType? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCloneError? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusRetrying? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusExhausted? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusTerminal? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminator? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminatorType? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubric? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminator? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminatorType? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParams? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubricParams? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminator? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminatorType? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedRunError? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownRunError? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminator? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminator? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminatorType? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminator? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminatorType? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleTriggerContext? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultBlock? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSearchResultContent>? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultContent? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultCitations? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSendSessionEvents? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsInputEvent>? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSendSessionEventsParams? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventParams>? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServerToolUsage? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatus? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgent? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource>? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsage? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStats? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagent? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgentUpdate? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionBudgetReached? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionDeletedEvent? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEndTurn? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEvent? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventError? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownError? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolUseLimitReachedError? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminator? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageEvent? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventDiscriminator? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventDiscriminatorType? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminator? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminatorType? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagent20261001? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminator? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminatorType? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflows? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagents? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionRosterEntry>? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntry? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminator? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgent? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsEnabled? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsDiscriminator? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusal? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetailsCategory? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRequiresAction? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceDiscriminator? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceDiscriminatorType? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminator? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminatorType? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminator? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminatorType? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminator? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminatorType? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetails? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReason? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminator? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminator? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminatorType? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatus? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntry? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadUsage? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStats? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntryDiscriminator? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReason? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminator? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageSnapshot? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminator? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminatorType? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminator? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminatorType? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelUsage? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEvents? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminator? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminator? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminator? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminatorType? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminator? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminatorType? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminator? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminatorType? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerType? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateAgentParams? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateCredentialRequestBody? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateDeploymentParams? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryParams? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreRequestBody? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminator? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionParams? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResource? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminator? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminatorType? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceParams? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateVaultRequestBody? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminator? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminatorType? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserLocation? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationResult? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSources? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourcesParams? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference>? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminator? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterParams? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminator? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputParams? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWorkflowRunPhase>? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhase? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunError? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminator? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResult? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultError? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminator? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminatorType? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant125? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CacheControlVariant1Discriminator? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CacheControlVariant1DiscriminatorType? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818Command? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818ViewCommand? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CreateCommand? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818InsertCommand? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818DeleteCommand? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818RenameCommand? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminator? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CreateCommandCommand? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818InsertCommandCommand? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818RenameCommandCommand? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818ViewCommandCommand? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaContentBlock>? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopReason? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopDetails? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsage? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputTransformation>? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagement? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchProcessingStatus? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCounts? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponse? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Result2? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSucceededResult? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminator? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDelta? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDeltaEvent? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDeltaUsage? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputTokensDetails? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolUsage? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStartEvent? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStopEvent? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEvent? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Ping? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminator? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminatorType? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelCapabilities? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolsCapability? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingCapability? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelInfoLifecycle? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelLine? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationLevelScopedApiKeyRequiredErrorDetails? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationOnHoldErrorDetails? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorCreateNew? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorUpdateExisting? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminator? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminatorType? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTokenTaskBudget? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPlainTextSource? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequest? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConfigVariant1? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfigParams? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1Discriminator? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestScope? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequest? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConfigVariant12? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1Discriminator? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestScope? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRampLimitExceededErrorDetails? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRefusalStopDetails? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorRedactedResultBlock? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorResultBlock? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant180? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1Discriminator? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestAdvisorToolResultError, global::Anthropic.BetaRequestAdvisorResultBlock, global::Anthropic.BetaRequestAdvisorRedactedResultBlock>? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultError? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionOutputBlock? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionResultBlock? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant187? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestBashCodeExecutionToolResultError, global::Anthropic.BetaRequestBashCodeExecutionResultBlock>? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultError? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyTooLargeAfterDecodingErrorDetails? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlock? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant163? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockCacheControlVariant1Discriminator? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockCacheControlVariant1DiscriminatorType? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item2>? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StateChangesVariant1Item2? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminator? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaBrowserStateTabEntry>? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCharLocationCitation? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCitationsConfig? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionOutputBlock? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionResultBlock? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestCodeExecutionOutputBlock>? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant185? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultError? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant144? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1Discriminator? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1DiscriminatorType? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item>? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChangesVariant1Item? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminator? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant175? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1Discriminator? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1DiscriminatorType? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContentBlockLocationCitation? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant133? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1Discriminator? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1DiscriminatorType? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source8? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaURLPDFSource? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminator? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestFallbackHopInfo? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant115? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockCacheControlVariant1Discriminator? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockCacheControlVariant1DiscriminatorType? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source5? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaURLImageSource? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminator? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageTransformations? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageTransformationsOversizedImage? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPServerToolConfiguration? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant167? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1Discriminator? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1DiscriminatorType? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant145? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1Discriminator? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1DiscriminatorType? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestPageLocationCitation? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant164? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1Discriminator? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1DiscriminatorType? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultLocationCitation? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant168? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1Discriminator? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1DiscriminatorType? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller7? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolCaller? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolCaller20260120? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminator? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminatorType? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockName? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant111? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCacheControlVariant1Discriminator? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCacheControlVariant1DiscriminatorType? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item3>? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item3? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchResultLocationCitation? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminator? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant189? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditorCodeExecutionToolResultErrorCode? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockFileType? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant165? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockCacheControlVariant1Discriminator? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockCacheControlVariant1DiscriminatorType? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool3? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolReference? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolReference? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolsetReference? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolDefinition? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminator? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminatorType? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlock? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant169? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1Discriminator? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1DiscriminatorType? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant155? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1Discriminator? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool2? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminator? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminatorType? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant146? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1Discriminator? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1DiscriminatorType? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>>? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentVariant2Item2? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminator? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant184? Type1664 { get; set; }
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
        public global::Anthropic.CacheControlVariant126? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1Discriminator? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1DiscriminatorType? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller3? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCallerDiscriminator? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCallerDiscriminatorType? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchResultBlock? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant181? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1Discriminator? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller13? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminator? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminatorType? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestWebFetchToolResultError, global::Anthropic.BetaRequestWebFetchResultBlock>? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultError? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchToolResultErrorCode? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchResultBlock? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant182? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1Discriminator? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller14? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminator? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminatorType? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaWebSearchToolRequestError>? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchToolRequestError? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchToolResultErrorCode? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRespondToReviewCaseRequestBody? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewViolatedPolicyCategory>? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewVerdict>? Type1701 { get; set; }
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
        public global::Anthropic.AnyOf<global::Anthropic.BetaAdvisorToolResultError, global::Anthropic.BetaResponseAdvisorResultBlock, global::Anthropic.BetaResponseAdvisorRedactedResultBlock>? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorToolResultError? Type1705 { get; set; }
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
        public global::Anthropic.AnyOf<global::Anthropic.BetaBashCodeExecutionToolResultError, global::Anthropic.BetaResponseBashCodeExecutionResultBlock>? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashCodeExecutionToolResultError? Type1710 { get; set; }
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
        public global::Anthropic.BetaCodeExecutionToolResultError? Type1753 { get; set; }
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
        public global::Anthropic.Source9? Type1787 { get; set; }
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
        public global::Anthropic.Caller8? Type1795 { get; set; }
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
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item4>? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item4? Type1800 { get; set; }
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
        public global::Anthropic.BetaTextEditorCodeExecutionToolResultError? Type1805 { get; set; }
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
        public global::Anthropic.Tool5? Type1810 { get; set; }
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
        public global::Anthropic.AnyOf<global::Anthropic.BetaToolSearchToolResultError, global::Anthropic.BetaResponseToolSearchToolSearchResultBlock>? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolResultError? Type1823 { get; set; }
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
        public global::Anthropic.Caller4? Type1826 { get; set; }
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
        public global::Anthropic.Caller15? Type1831 { get; set; }
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
        public global::Anthropic.Caller16? Type1837 { get; set; }
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
        public global::Anthropic.AnyOf<global::Anthropic.BetaWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>>? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchToolResultError? Type1841 { get; set; }
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
        public global::Anthropic.BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSlackChannelSetUpSettingsConflictErrorDetails? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSlackChannelSetUpSettingsRefusedErrorDetails? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopDetailsDiscriminator? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopDetailsDiscriminatorType? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageQuotaExceededErrorDetails? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageClearAt? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem2>>? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem2>? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlocksItem2? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageContentBlockDiscriminator? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageContentBlockDiscriminatorType? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemMessageOutputConfig? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTraces? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationState? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDeliveryHealth? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspaces? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationContentMode? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReason? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminator? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabled? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabled? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminator? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminatorType? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabledParams? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabledParams? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParams? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminator? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminatorType? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTest? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResult? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestFailure? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestSuccess? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminator? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminatorType? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAll? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminator? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminatorType? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminator? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminatorType? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant127? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022CacheControlVariant1Discriminator? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022CacheControlVariant1DiscriminatorType? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant128? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124CacheControlVariant1Discriminator? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124CacheControlVariant1DiscriminatorType? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant129? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429CacheControlVariant1Discriminator? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429CacheControlVariant1DiscriminatorType? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant130? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728CacheControlVariant1Discriminator? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728CacheControlVariant1DiscriminatorType? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingBlockBinding? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingPrefixMismatchBehavior? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingTypes? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDisplayMode? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminator? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminatorType? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformationReason? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformationReason? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadAlreadyContinuedErrorDetails? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadContinueInFlightErrorDetails? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadFingerprintMismatchErrorDetails? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadNotFoundErrorDetails? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadUnsupportedRequestErrorDetails? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant191? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolCacheControlVariant1Discriminator? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolCacheControlVariant1DiscriminatorType? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceAuto? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceAny? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceTool? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceNone? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminator? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminatorType? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolNameConflictErrorDetails? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolReferenceUnresolvedErrorDetails? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant176? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1Discriminator? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119Type? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant178? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1Discriminator? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119Type? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCallerDiscriminator? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCallerDiscriminatorType? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelToken? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateGoogleManagedDataControlsRequestBody? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateTelemetryDestinationRequestBody? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserProfileRequestBody? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageServiceTier? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserLocation? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserDetails? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaUserProfileTrustGrant>? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileTrustGrant? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileEnrollEndUserAction? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminator? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminatorType? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionUrl? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileBillingNotAuthorizedErrorDetails? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserAccountStatus? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserEntityType? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileListOrder? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileListOrderBy? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileNotBillableErrorDetails? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileRequiredErrorDetails? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileTrustGrantStatus? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant138? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1Discriminator? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1DiscriminatorType? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSources? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant139? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1Discriminator? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1DiscriminatorType? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant140? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1Discriminator? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1DiscriminatorType? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant141? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318CacheControlVariant1Discriminator? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318CacheControlVariant1DiscriminatorType? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318ResponseInclusion? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceAll? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceExcept? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWebFetchUrlSourceToolReference>? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceToolReference? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceNone? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceOnly? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolResults2? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesClientToolResultsDiscriminator? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolResults2? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminator? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInput2? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminator? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminatorType? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant147? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1Discriminator? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1DiscriminatorType? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant148? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1Discriminator? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1DiscriminatorType? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant149? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318CacheControlVariant1Discriminator? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318CacheControlVariant1DiscriminatorType? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318ResponseInclusion? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentArchivedEventData? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentCreatedEventData? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentDeletedEventData? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentUpdatedEventData? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentArchivedEventData? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentCreatedEventData? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentDeletedEventData? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentPausedEventData? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunFailedEventData? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunStartedEventData? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUnpausedEventData? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUpdatedEventData? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentArchivedEventData? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentCreatedEventData? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentDeletedEventData? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnwrapWebhookEvent? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventData? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionCreatedEventData? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionPendingEventData? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRunningEventData? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionIdledEventData? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRequiresActionEventData? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionArchivedEventData? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionDeletedEventData? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusIdledEventData? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadCreatedEventData? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadIdledEventData? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCreatedEventData? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultArchivedEventData? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultDeletedEventData? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionUpdatedEventData? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionBudgetReachedEventData? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileEnforcementActionOpenedEventData? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileEnforcementActionResolvedEventData? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileProgramStatusUpdatedEventData? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookExternalKeyFailedEventData? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookExternalKeyRecoveredEventData? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookExternalStorageFailedEventData? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookExternalStorageRecoveredEventData? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminator? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminatorType? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkLeaseStateState? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceHumanReviewDisabledErrorDetails? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BillingError? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BodyCreateSkillV1SkillsPost? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BodyCreateSkillVersionV1SkillsSkillIdVersionsPost? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTarget? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCoordinateTarget? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRefTarget? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminator? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminatorType? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabConfig? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabInput? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickConfig? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickInput? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadConfig? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadInput? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindConfig? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindInput? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputConfig? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputInput? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputValue? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextConfig? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextInput? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyConfig? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyInput? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverConfig? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverInput? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecConfig? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecInput? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyConfig? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyInput? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickConfig? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragConfig? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragInput? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickInput? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownConfig? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownInput? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpConfig? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpInput? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsConfig? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsInput? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMemberInput? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateInput? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabInput? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabInput? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageInput? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleInput? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkInput? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToInput? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotInput? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomInput? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickInput? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickInput? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickInput? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveInput? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollInput? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeInput? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitInput? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickConfig? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveConfig? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateConfig? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabConfig? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleConfig? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkConfig? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageConfig? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageFilter? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickConfig? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotConfig? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollConfig? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollDirection? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToConfig? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadCompleted? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadFailed? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadStarted? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeTabOpened? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateTabEntry? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabConfig? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolsetConfigs? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickConfig? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeConfig? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitConfig? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomConfig? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant131? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1Discriminator? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1DiscriminatorType? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlEphemeralTtl? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheCreation? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissMessagesChanged? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissModelChanged? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissPreviousMessageNotFound? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReason? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissSystemChanged? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissToolsChanged? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissUnavailable? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminator? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminatorType? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CanceledResult? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CapabilitySupport? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDelta? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Citation? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCharLocationCitation? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponsePageLocationCitation? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseContentBlockLocationCitation? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultLocationCitation? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseSearchResultLocationCitation? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminator? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminatorType? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClaudeCodeVersionTooOldErrorDetails? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolUnion? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekContextUnavailableErrorDetails? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyDisabledErrorDetails? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyNetworkBlockedErrorDetails? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyUnreachableErrorDetails? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionToolResultErrorCode? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant150? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522CacheControlVariant1Discriminator? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522CacheControlVariant1DiscriminatorType? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant151? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825CacheControlVariant1Discriminator? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825CacheControlVariant1DiscriminatorType? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant152? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120CacheControlVariant1Discriminator? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120CacheControlVariant1DiscriminatorType? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant153? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521CacheControlVariant1Discriminator? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521CacheControlVariant1DiscriminatorType? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionBlockAmbiguousErrorDetails? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionBlockMisplacedErrorDetails? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionContentMismatchErrorDetails? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionIncompleteTurnErrorDetails? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionNothingToSummarizeErrorDetails? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionSignatureInvalidErrorDetails? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionTooManyToolReferencesErrorDetails? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionToolChangesMismatchErrorDetails? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionUnavailableErrorDetails? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionConfig? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionInput? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickConfig? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickInput? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyConfig? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyInput? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyConfig? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyInput? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickConfig? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragConfig? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragInput? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickInput? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownConfig? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownInput? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpConfig? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpInput? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMemberInput? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeInput? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveInput? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickInput? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickInput? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickInput? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollInput? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitInput? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotInput? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomInput? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickConfig? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveConfig? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickConfig? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotConfig? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollConfig? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollDirection? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolsetConfigs? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickConfig? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeConfig? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitConfig? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomConfig? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant134? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801CacheControlVariant1Discriminator? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801CacheControlVariant1DiscriminatorType? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Container? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContainerSkill>? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerSkill? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerParams? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SkillParams>? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillParams? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerSkillType? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlock? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseThinkingBlock? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseRedactedThinkingBlock? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlock? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlock? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlock? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlock? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionToolResultBlock? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionToolResultBlock? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionToolResultBlock? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolResultBlock? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseContainerUploadBlock? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminator? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminatorType? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEvent? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Delta? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextContentBlockDelta? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputJsonContentBlockDelta? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingContentBlockDelta? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SignatureContentBlockDelta? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSource? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>>? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentContentBlockSourceContentItem? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlock? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlock? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminator? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEvent? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEventContentBlockDiscriminator? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEventContentBlockDiscriminatorType? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStopEvent? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContextManagementCapability? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContractSpendLimitReachedErrorDetails? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParams? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant135? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParamsCacheControlVariant1Discriminator? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParamsCacheControlVariant1DiscriminatorType? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputMessageUnion>? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnion? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OutputConfig? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Speed? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParam? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoice? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensResponse? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageBatchParams? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.MessageBatchIndividualRequestParams>? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualRequestParams? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParams? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant15? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsCacheControlVariant1Discriminator? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsCacheControlVariant1DiscriminatorType? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ContainerParams, string>? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DiagnosticsParam? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Metadata? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsServiceTier? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateUserProfileActionUrlRequestBody? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileAction? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateUserProfileRequest? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileAccessType? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserDetailsParams? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteMessageBatchResponse? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedSkill? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedSkillVersion? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedUserProfile? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Diagnostics? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DirectCaller? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EffortCapability? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EffortLevel? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EnforcedSpendLimitReachedErrorDetails? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponse? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Error? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InvalidRequestError? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PermissionError? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NotFoundError? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitError? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GatewayTimeoutError? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OverloadedError? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminator? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminatorType? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorType? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErroredResult? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExpiredResult? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileDeleteResponse? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileDocumentSource? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileExpiredErrorDetails? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileImageSource? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileListResponse? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FileMetadataSchema>? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileMetadataSchema? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileNotDownloadableErrorDetails? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ImageDimensionsTooLargeErrorDetails? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlock? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlock? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlock? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestThinkingBlock? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestRedactedThinkingBlock? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlock? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlock? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlock? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlock? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlock? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlock? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlock? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlock? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlock? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminator? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminatorType? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInputMessage? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessage? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnionDiscriminator? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnionDiscriminatorRole? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputSchema? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JsonOutputFormat? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.LinkedOrganizationBillingUnavailableErrorDetails? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.LinkedOrganizationSpendLimitReachedErrorDetails? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseMessageBatch? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.MessageBatch>? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatch? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseModelInfo? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ModelInfo>? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelInfo? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsResponse? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SkillVersion>? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillVersion? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsResponse? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Skill>? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Skill? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListUserProfilesResponse? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfile>? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfile? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant16? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818CacheControlVariant1Discriminator? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818CacheControlVariant1DiscriminatorType? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Message? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlock>? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopReason? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopDetails? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Usage? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchProcessingStatus? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCounts? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponse? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Result? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SucceededResult? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminator? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDelta? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDeltaEvent? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDeltaUsage? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OutputTokensDetails? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolUsage? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStartEvent? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStopEvent? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEvent? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminator? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminatorType? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelCapabilities? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolsCapability? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingCapability? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelInfoLifecycle? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelLine? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationOnHoldErrorDetails? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PlainTextSource? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RampLimitExceededErrorDetails? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalCategory? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalStopDetails? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionOutputBlock? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionResultBlock? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestBashCodeExecutionOutputBlock>? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant186? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestBashCodeExecutionToolResultError, global::Anthropic.RequestBashCodeExecutionResultBlock>? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultError? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyEncodingInvalidErrorDetails? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyEncodingUnsupportedErrorDetails? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyTooLargeAfterDecodingErrorDetails? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlock? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant136? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockCacheControlVariant1Discriminator? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockCacheControlVariant1DiscriminatorType? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item>? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StateChangesVariant1Item? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminator? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BrowserStateTabEntry>? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCharLocationCitation? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCitationsConfig? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionOutputBlock? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionResultBlock? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestCodeExecutionOutputBlock>? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant183? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestCodeExecutionToolResultError, global::Anthropic.RequestCodeExecutionResultBlock, global::Anthropic.RequestEncryptedCodeExecutionResultBlock>? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultError? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestEncryptedCodeExecutionResultBlock? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant156? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlockCacheControlVariant1Discriminator? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlockCacheControlVariant1DiscriminatorType? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContentBlockLocationCitation? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant112? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockCacheControlVariant1Discriminator? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockCacheControlVariant1DiscriminatorType? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source4? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLPDFSource? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminator? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminatorType? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant14? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockCacheControlVariant1Discriminator? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockCacheControlVariant1DiscriminatorType? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source3? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLImageSource? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminator? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminatorType? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageTransformations? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageTransformationsOversizedImage? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestPageLocationCitation? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant137? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlockCacheControlVariant1Discriminator? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlockCacheControlVariant1DiscriminatorType? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultLocationCitation? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant142? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCacheControlVariant1Discriminator? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCacheControlVariant1DiscriminatorType? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller5? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolCaller? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolCaller20260120? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCallerDiscriminator? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCallerDiscriminatorType? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockName? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant12? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCacheControlVariant1Discriminator? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCacheControlVariant1DiscriminatorType? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item>? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchResultLocationCitation? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminator? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant188? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultError? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditorCodeExecutionToolResultErrorCode? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionViewResultBlockFileType? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlock? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant143? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlockCacheControlVariant1Discriminator? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlockCacheControlVariant1DiscriminatorType? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant120? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockCacheControlVariant1Discriminator? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockCacheControlVariant1DiscriminatorType? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>>? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentVariant2Item? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminator? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant179? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1Discriminator? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestToolSearchToolResultError, global::Anthropic.RequestToolSearchToolSearchResultBlock>? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultError? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolSearchResultBlock? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolResultErrorCode? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestToolReferenceBlock>? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant17? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCacheControlVariant1Discriminator? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCacheControlVariant1DiscriminatorType? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCallerDiscriminator? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCallerDiscriminatorType? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchResultBlock? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant174? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1Discriminator? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller9? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminator? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminatorType? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestWebFetchToolResultError, global::Anthropic.RequestWebFetchResultBlock>? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultError? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchToolResultErrorCode? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchResultBlock? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant177? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1Discriminator? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller10? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminator? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminatorType? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.WebSearchToolRequestError>? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchToolRequestError? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchToolResultErrorCode? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionOutputBlock? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionResultBlock? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseBashCodeExecutionOutputBlock>? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BashCodeExecutionToolResultError, global::Anthropic.ResponseBashCodeExecutionResultBlock>? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashCodeExecutionToolResultError? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserCloseTabToolUseBlock? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCaller? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFileUploadToolUseBlock? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFindToolUseBlock? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFormInputToolUseBlock? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoverToolUseBlock? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserKeyToolUseBlock? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickToolUseBlock? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserListTabsToolUseBlock? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNavigateToolUseBlock? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNewTabToolUseBlock? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadPageToolUseBlock? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserRightClickToolUseBlock? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScreenshotToolUseBlock? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToToolUseBlock? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToolUseBlock? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlock? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnion? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserZoomToolUseBlock? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTripleClickToolUseBlock? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTypeToolUseBlock? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserWaitToolUseBlock? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminator? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCitationsConfig? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionOutputBlock? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionResultBlock? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseCodeExecutionOutputBlock>? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.CodeExecutionToolResultError, global::Anthropic.ResponseCodeExecutionResultBlock, global::Anthropic.ResponseEncryptedCodeExecutionResultBlock>? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionToolResultError? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseEncryptedCodeExecutionResultBlock? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerCursorPositionToolUseBlock? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerDoubleClickToolUseBlock? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerHoldKeyToolUseBlock? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerKeyToolUseBlock? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickToolUseBlock? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMiddleClickToolUseBlock? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMouseMoveToolUseBlock? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerRightClickToolUseBlock? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScreenshotToolUseBlock? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScrollToolUseBlock? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlock? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnion? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTypeToolUseBlock? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTripleClickToolUseBlock? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerWaitToolUseBlock? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerZoomToolUseBlock? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminator? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlock? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source6? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminator? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminatorType? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller6? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockName? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item2>? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item2? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminator? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditorCodeExecutionToolResultError? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlockFileType? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolReferenceBlock? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolResultError? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolSearchResultBlock? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseToolReferenceBlock>? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller2? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockCallerDiscriminator? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockCallerDiscriminatorType? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockUnion? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchResultBlock? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller11? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminator? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminatorType? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebFetchToolResultError, global::Anthropic.ResponseWebFetchResultBlock>? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultError? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultBlock? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller12? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminator? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminatorType? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.WebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>>? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchToolResultError? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillSource? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillParamsType? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillReadBlockedUndecryptableErrorDetails? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillSourceType? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopDetailsDiscriminator? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopDetailsDiscriminatorType? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StorageQuotaExceededErrorDetails? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem>>? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem>? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlocksItem? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessageContentBlockDiscriminator? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessageContentBlockDiscriminatorType? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant18? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124CacheControlVariant1Discriminator? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124CacheControlVariant1DiscriminatorType? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant19? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429CacheControlVariant1Discriminator? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429CacheControlVariant1DiscriminatorType? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant110? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728CacheControlVariant1Discriminator? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728CacheControlVariant1DiscriminatorType? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingTypes? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigAdaptive? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingDisplayMode? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigBetweenTools? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigDisabled? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigEnabled? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminator? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminatorType? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadAlreadyContinuedErrorDetails? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadContinueInFlightErrorDetails? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadFingerprintMismatchErrorDetails? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadNotFoundErrorDetails? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadUnsupportedRequestErrorDetails? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant190? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolCacheControlVariant1Discriminator? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolCacheControlVariant1DiscriminatorType? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceAuto? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceAny? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceTool? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceNone? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminator? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminatorType? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolNameConflictErrorDetails? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolReferenceUnresolvedErrorDetails? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant157? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1Discriminator? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119Type? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant166? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1Discriminator? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119Type? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCallerDiscriminator? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCallerDiscriminatorType? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserProfileRequestBody? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UsageServiceTier? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserLocation? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserDetails? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementStatus? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementAction>? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementAction? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfilePrograms? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnrollEndUserAction? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionDiscriminator? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionDiscriminatorType? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionUrl? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileBillingNotAuthorizedErrorDetails? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberProgram? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileProgramStatus? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileCyberTier>? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberTier? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberRequirements? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberTierStatus? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsFeature? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsFeatureStatus? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsProgram? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileEfsFeature>? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionRestriction? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionBan? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionDiscriminator? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionDiscriminatorType? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionReason? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionNextStep? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserAccountStatus? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserEntityType? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileListOrder? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileListOrderBy? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileNotBillableErrorDetails? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileRequiredErrorDetails? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant116? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910CacheControlVariant1Discriminator? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910CacheControlVariant1DiscriminatorType? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSources? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant117? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209CacheControlVariant1Discriminator? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209CacheControlVariant1DiscriminatorType? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant118? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309CacheControlVariant1Discriminator? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309CacheControlVariant1DiscriminatorType? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant119? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318CacheControlVariant1Discriminator? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318CacheControlVariant1DiscriminatorType? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318ResponseInclusion? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceAll? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceExcept? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WebFetchUrlSourceToolReference>? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceToolReference? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceNone? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceOnly? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolResults? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesClientToolResultsDiscriminator? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesClientToolResultsDiscriminatorType? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolResults? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminator? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminatorType? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInput? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminator? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminatorType? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant121? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305CacheControlVariant1Discriminator? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305CacheControlVariant1DiscriminatorType? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant122? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209CacheControlVariant1Discriminator? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209CacheControlVariant1DiscriminatorType? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant123? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318CacheControlVariant1Discriminator? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318CacheControlVariant1DiscriminatorType? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318ResponseInclusion? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceHumanReviewDisabledErrorDetails? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventType? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAccessTransparency? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAccessTransparencyType? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaActiveExternalStorageStatus? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceParams? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberParams? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllConnectorsPermissionResource? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllowedInferenceGeo? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAlreadyMemberErrorDetails? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsActivitySummaryResponse? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSingleDayActivitySummary>? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSingleDayActivitySummary? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsActorType? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsApiActor? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactActivity? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactGroupBy? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactsResponse? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsArtifactActivity>? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedChatMetrics? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedMetrics? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedSessionsMetrics? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatMetrics? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeCodeMetrics? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCoreCodeMetrics? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsToolActions? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeTagCategory? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeTagMetrics? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorActivity? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedMetrics? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatMetrics? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorClaudeCodeMetrics? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorCoworkMetrics? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorOfficeMetrics? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorGroupBy? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorOfficeProductMetrics? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorsResponse? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsConnectorActivity>? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsLinesOfCode? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResponse? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostReportTimeBucket>? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostReportTimeBucket? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResult? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportContextWindow? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostType? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceGeo? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResultSpeed? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTokenType? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostGroupBy? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostBucketedResult>? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItem? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserActor? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemActorDiscriminator? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemActorDiscriminatorType? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemSpeed? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersOrderBy? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersResponse? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostUsersItem>? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCoworkMetrics? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsDesignMetrics? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActor? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProvider? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminator? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminatorType? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostGroup? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActor? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostCostType? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostInferenceGeo? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageReportServiceTier? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSpeed? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostItem? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostMetrics? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostOrderBy? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostResponse? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsFlatCostItem>? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatGroup? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageItem? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageMetrics? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolUse? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageOrderBy? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageResponse? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsFlatUsageItem>? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOfficeMetrics? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOfficeProductMetrics? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOrder? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginActivity? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginChatCoworkUnifiedMetrics? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginClaudeCodeMetrics? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginCoworkMetrics? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginGroupBy? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginsResponse? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsPluginActivity>? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProductFilter? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectActivity? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUser? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectGroupBy? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectsResponse? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProjectActivity>? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportUserActor? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsServiceAccountActor? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActorDiscriminator? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActorDiscriminatorType? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsScienceMetrics? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillActivity? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedMetrics? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatMetrics? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillClaudeCodeMetrics? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillCoworkMetrics? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillOfficeMetrics? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillActivityShareStatus? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedChatMetrics? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillGroupBy? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillOfficeProductMetrics? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillsResponse? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSkillActivity>? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSortOrder? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsTimeBucketWidth? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsToolActionCounts? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResponse? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageReportTimeBucket>? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageReportTimeBucket? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResult? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResultSpeed? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostProductFilter? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostSortOrder? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageGroupBy? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageBucketedResult>? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItem? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemActorDiscriminator? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemActorDiscriminatorType? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemSpeed? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersOrderBy? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersResponse? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageUsersItem>? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserActivity? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserGroupBy? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsersResponse? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUserActivity>? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKey? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatedBy? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PrincipalVariant1? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUserActor? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyServiceAccountActor? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1Discriminator? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1DiscriminatorType? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyOrganizationScope? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyWorkspaceScope? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminator? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminatorType? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyStatus? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUpdateParams? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUpdateParamsStatus? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApprovalMetrics? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApprovalRequiredErrorDetails? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestParams? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitPeriod? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponse? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestActor? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestResolvedBy? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimit? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummary? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestStatus? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAttachedAttachment? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAuthorizationCheckUnavailableErrorDetails? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAvailableExternalStorageStatus? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAwsExternalKeyConfig? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAwsExternalStorageConfig? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAwsExternalStorageConfigParams? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfig? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfigParams? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBucketReference? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotInviteEmailsWithUnverifiedDomainsErrorDetails? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotRemoveLastMemberErrorDetails? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutManagedMemberErrorDetails? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutMembershipAdminErrorDetails? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutOwnerErrorDetails? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutPrimaryOwnerErrorDetails? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutPrivilegedMemberErrorDetails? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotSignOutSelfErrorDetails? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaChangeOutcomeUnknownErrorDetails? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeApiActor? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsConfiguration? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsMode? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsConfigurationUpdateParams? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeParams? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminator? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminatorType? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminator? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupDefaultManagedSettings? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupDefaultManagedSettingsUpdateParams? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupManagedSettings? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatus? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsDeleted? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsList? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSummary>? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSummary? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSetParams? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusActive? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminator? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminatorType? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItem? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor3? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUserActor? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminator? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminatorType? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCoreMetrics? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCustomerType? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelBreakdown>? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelBreakdown? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSubscriptionType? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaApprovalMetrics>? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeEnterpriseOrganizationRole? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlDisabled? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRetiredKey>? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRetiredKey? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlDisabledParams? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlEnabled? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Status2? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekRegionNotConfigured? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekRegionPending? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekRegionActive? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekRegionFailed? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekRegionSuspended? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlEnabledStatusDiscriminator? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlEnabledStatusDiscriminatorType? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlEnabledParams? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekFeatureUnsupportedErrorDetails? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekNotApprovedErrorDetails? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettings? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsState? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabled? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabled? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDiscriminator? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDiscriminatorType? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabledParams? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabledParams? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParams? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParamsDiscriminator? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParamsDiscriminatorType? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsUpdateParams? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConcurrentMembershipChangeErrorDetails? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorPermissionResource? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorScopePermissionResource? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorToolPermissionResource? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLinesOfCode? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportGroupBy? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportItem? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostType? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportServiceTier? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceGeoFilter? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTimeBucket? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportItem>? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTimeBucketWidth? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteParams? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteParamsRole? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupParams? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelCertificateParams? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberParams? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNoBillingWorkspaceRoleSchema? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatedByType? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidency? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>, string>? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceGeo? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidencyCreateParams? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidencyUpdateParams? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyResponse? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteResponse? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupMemberResponse? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupResponse? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitResponse? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteUserResponse? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberResponse? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedOrganizationWebhookEndpoint? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDenySpendLimitIncreaseRequestParams? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDrainingExternalStorageStatus? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffectiveBucket? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEmailDomainNotAllowedErrorDetails? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEstimatedCost? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKey? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Attachment2? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnattachedAttachment? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminator? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminatorType? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig2? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpExternalKeyConfig? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderConfigDiscriminator? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderConfigDiscriminatorType? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyChangedErrorDetails? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParams? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig5? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminator? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminatorType? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyInWorkspacePolicyErrorDetails? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyListResponse? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaExternalKey>? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyNotFoundErrorDetails? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderMismatchErrorDetails? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParams? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfigVariant12? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParamsProviderConfigVariant1Discriminator? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyValidationFailedErrorDetails? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorage? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig3? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpExternalStorageConfig? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageProviderConfigDiscriminator? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageProviderConfigDiscriminatorType? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Status? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPendingConfigurationExternalStorageStatus? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageStatusDiscriminator? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageStatusDiscriminatorType? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageCreateParams? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig6? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpExternalStorageConfigParams? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageCreateParamsProviderConfigDiscriminator? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageCreateParamsProviderConfigDiscriminatorType? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageDeletedResponse? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageFailedCheck? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageFailedCheckCheck? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageFailedCheckRole? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageInUseErrorDetails? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageInWorkspacePolicyErrorDetails? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageListResponse? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaExternalStorage>? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageMember? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageMemberParams? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageNotAvailableErrorDetails? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageUpdateParams? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuer? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks2? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksDiscovery? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksExplicitUrl? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksInline? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerJwksDiscriminator? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerJwksDiscriminatorType? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIssuerPollStatus? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParams? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks4? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminator? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminatorType? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerListResponse? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationIssuer>? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParams? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksVariant12? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1Discriminator? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRule? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRuleMatch? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleCreateParams? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleListResponse? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationRule>? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleTarget? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountTarget? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleTargetDiscriminator? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleTargetDiscriminatorType? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleUpdateParams? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleWorkspace? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleWorkspaceListResponse? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationRuleWorkspace>? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpProjectControlledByAnotherOrganizationErrorDetails? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpProjectNotVerifiedErrorDetails? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetClaudeCodeUsageReportResponse? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeUsageReportItem>? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportResponse? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportTimeBucket>? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetMessagesUsageReportResponse? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportTimeBucket>? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportTimeBucket? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControls? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Cmek? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsCmekDiscriminator? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsCmekDiscriminatorType? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Storage? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlDisabled? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlEnabled? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsStorageDiscriminator? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsStorageDiscriminatorType? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsUpdateParams? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Cmek2? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminator? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorType? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Storage2? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlDisabledParams? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlEnabledParams? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsUpdateParamsStorageDiscriminator? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsUpdateParamsStorageDiscriminatorType? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGrantRequiredErrorDetails? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaHumanReview? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaHumanReviewType? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaHumanReviewNotAvailableErrorDetails? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaHumanReviewOnWithExternalStorageErrorDetails? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaHumanReviewParams? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaHumanReviewParamsType? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceDataPrivacy? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageMember? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceDataPrivacyCreateParams? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageMemberParams? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceDataPrivacyUpdateParams? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInternalStorage? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInternalStorageParams? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidStorageArnErrorDetails? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteAlreadyExistsErrorDetails? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteSchema? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationRoleSchema? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteStatusSchema? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaKeyProfileMismatchErrorDetails? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsResponse? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendSummary>? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseApiKey? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaApiKey>? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseInviteSchema? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInviteSchema>? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseUser? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUser>? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUser? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseWorkspaceMemberSchema? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceMemberSchema>? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceMemberSchema? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseWorkspace? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspace>? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspace? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsResponse? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimit>? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportGroupBy? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportItem? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportItem>? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTokenUsage? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNewOrganizationWebhookEndpoint? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent>? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointState? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgApiKeyLimitExceededErrorDetails? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgMemberLimitExceededErrorDetails? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgServiceScope? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationNotEligibleErrorDetails? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationNotEnrolledInBetaErrorDetails? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationPermissionResource? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationSchema? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationScope? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTypeNotSupportedErrorDetails? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpoint? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent>? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointList? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationWebhookEndpoint>? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointSigningSecret? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaParentOrganizationRequiredErrorDetails? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPlugin? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginComponent>? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginComponent? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScan? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByVariant1? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginUserActor? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginApiActor? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1Discriminator? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1DiscriminatorType? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOrganizationInstallationPreference? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Owner? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerOrganization? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerUser? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminator? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminatorType? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginReach? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginComponentType? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScanAssessment? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScanStatus? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginDeleted? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSetting? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingInstallationPreference? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target2? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganization? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetRbacGroup? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganizationMember? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingTargetDiscriminator? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingTargetDiscriminatorType? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeleted? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target3? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminator? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminatorType? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingList? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginInstallationSetting>? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginList? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPlugin>? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplace? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Owner2? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceOwnerDiscriminator? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceOwnerDiscriminatorType? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceSource? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceSyncStatus? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceList? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplace>? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginError? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginWarning? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning>? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationReport? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginError>? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings>? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginNameTakenErrorDetails? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShare? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminator? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminatorType? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareList? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginShare>? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersion? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByVariant12? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionCreatedByVariant1Discriminator? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionCreatedByVariant1DiscriminatorType? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionReach? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionList? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginVersion>? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaProviderNotAllowedErrorDetails? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimit? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitModelGroup? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitBatchGroup? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitTokenCountGroup? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitFilesGroup? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitSkillsGroup? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitWebSearchGroup? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupDiscriminator? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupDiscriminatorType? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimitValue>? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitValue? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitListResponse? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimit>? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroup? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupSourceType? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupList? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacGroup>? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupManagedSettingsNotFoundErrorDetails? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupMember? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupMemberList? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacGroupMember>? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupNotFoundErrorDetails? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupOrderLimitExceededErrorDetails? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupScope? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRole? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSource? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleList? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacRole>? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleNotFoundErrorDetails? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermission? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Resource2? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminator? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionList? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacRolePermission>? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceBuiltIn? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceCustom? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceDiscriminator? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceDiscriminatorType? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRegionNotSupportedErrorDetails? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRegistrationPendingErrorDetails? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyTimeoutErrorDetails? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRetiredBucket? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRoleSchema? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenParams? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSandboxEgressRestrictedErrorDetails? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScanFailedErrorDetails? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScanPendingErrorDetails? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScopedApiKeyActorSchema? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSeatTierScope? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccount? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountOrganizationRole? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountCreateParams? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountCreateParamsOrganizationRole? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountListResponse? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaServiceAccount>? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountUpdateParams? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountUpdateParamsOrganizationRole? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMember? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRoleSchema? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberCreateFromSAParams? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberCreateParams? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberDeleteResponse? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberListResponse? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaServiceAccountWorkspaceMember>? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberUpdateParams? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParams? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope6? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserScope? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceScope? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminator? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminatorType? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSettingsDocumentLimitExceededErrorDetails? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSettingsHistoryLimitExceededErrorDetails? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillNameTakenErrorDetails? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope4? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageTierScope? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminator? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminatorType? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserActorSchema? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestActorDiscriminator? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestActorDiscriminatorType? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestListResponse? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchema? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestResolvedByDiscriminator? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestResolvedByDiscriminatorType? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor2? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryActorDiscriminator? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryActorDiscriminatorType? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope5? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryScopeDiscriminator? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryScopeDiscriminatorType? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source2? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummarySourceDiscriminator? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummarySourceDiscriminatorType? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageAlreadyRegisteredErrorDetails? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageAttachLimitReachedErrorDetails? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageAttachedDuringArchiveErrorDetails? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageBucket? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageChangedConcurrentlyErrorDetails? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRetiredBucket>? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaStorageBucket>? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Status4? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageRegionNotConfigured? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageRegionPending? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageRegionActive? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageRegionFailed? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageRegionSuspended? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlEnabledStatusDiscriminator? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlEnabledStatusDiscriminatorType? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageFailedCheck? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageFailedCheckCheck? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageFailedCheckRole? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageInUseErrorDetails? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageMemberDiscriminator? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageMemberDiscriminatorType? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageMemberParamsDiscriminator? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageMemberParamsDiscriminatorType? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageNotApprovedErrorDetails? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageNotAttachableErrorDetails? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageProfileMismatchErrorDetails? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageProfileStillRequiredErrorDetails? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaStorageFailedCheck>? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageVerificationFailedErrorDetails? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaExternalStorageFailedCheck>? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTranscriptsStorageRequiredErrorDetails? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnel? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnelCertificate? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelCertificateListResponse? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationTunnelCertificate>? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelListResponse? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationTunnel>? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnelToken? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnsupportedCharsetErrorDetails? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnsupportedRegionErrorDetails? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupParams? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserParams? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserParamsRole? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberParams? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileNotFoundErrorDetails? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyResponse? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyResponseStatus? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceApiKeyLimitExceededErrorDetails? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceChangedConcurrentlyErrorDetails? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceChangedConcurrentlyField? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceCreateParams? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceCreatedIncompleteErrorDetails? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceMemberLimitExceededErrorDetails? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspacePolicyField? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspacePolicyViolationErrorDetails? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimit? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group3? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminator? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminatorType? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitValue>? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValue? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitListResponse? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimit>? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateParams? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitUpdateValue>? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateValue? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateValueType? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source10? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminator? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminatorType? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceUpdateParams? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceParams? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberParams? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AllConnectorsPermissionResource? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AllowedInferenceGeo? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AlreadyMemberErrorDetails? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsActivitySummaryResponse? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsSingleDayActivitySummary>? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSingleDayActivitySummary? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsArtifactActivity? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsArtifactGroupBy? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsArtifactsResponse? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsArtifactActivity>? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatCoworkUnifiedChatMetrics? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatCoworkUnifiedMetrics? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatCoworkUnifiedSessionsMetrics? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsChatMetrics? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsClaudeCodeMetrics? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsCoreCodeMetrics? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsToolActions? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsClaudeTagMetrics? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorActivity? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatCoworkUnifiedMetrics? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatMetrics? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorClaudeCodeMetrics? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorCoworkMetrics? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorOfficeMetrics? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatCoworkUnifiedChatMetrics? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorChatCoworkUnifiedSessionsMetrics? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorGroupBy? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorOfficeProductMetrics? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsConnectorsResponse? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsConnectorActivity>? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsLinesOfCode? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsCoworkMetrics? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsDesignMetrics? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsOfficeMetrics? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsOfficeProductMetrics? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsOrder? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginActivity? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginChatCoworkUnifiedMetrics? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginClaudeCodeMetrics? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginCoworkMetrics? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginGroupBy? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsPluginsResponse? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsPluginActivity>? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsProjectActivity? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUser? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsProjectGroupBy? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsProjectsResponse? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsProjectActivity>? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsScienceMetrics? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillActivity? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatCoworkUnifiedMetrics? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatMetrics? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillClaudeCodeMetrics? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillCoworkMetrics? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillOfficeMetrics? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillActivityShareStatus? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatCoworkUnifiedChatMetrics? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillChatCoworkUnifiedSessionsMetrics? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillGroupBy? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillOfficeProductMetrics? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsSkillsResponse? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsSkillActivity>? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsToolActionCounts? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUserActivity? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUserGroupBy? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnalyticsUsersResponse? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsUserActivity>? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKey? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedBy? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PrincipalVariant12? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUserActor? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyServiceAccountActor? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1Discriminator? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1DiscriminatorType? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope7? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyOrganizationScope? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyWorkspaceScope? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminator? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminatorType? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyStatus? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUpdateParams? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUpdateParamsStatus? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApproveSpendLimitIncreaseRequestParams? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitPeriod? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApproveSpendLimitIncreaseRequestResponse? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestActor? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestResolvedBy? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimit? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummary? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestStatus? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AttachedAttachment? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AwsExternalKeyConfig? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfig? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfigParams? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CannotInviteEmailsWithUnverifiedDomainsErrorDetails? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CannotRemoveLastMemberErrorDetails? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ChangeOutcomeUnknownErrorDetails? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettings? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsState? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabled? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabled? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminator? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminatorType? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabledParams? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabledParams? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParams? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminator? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminatorType? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsUpdateParams? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConcurrentMembershipChangeErrorDetails? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorPermissionResource? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorScopePermissionResource? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorToolPermissionResource? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteParams? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteParamsRole? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateRbacGroupParams? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberParams? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NoBillingWorkspaceRoleSchema? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByType? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidency? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>, string>? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InferenceGeo? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceGeo? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidencyCreateParams? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidencyUpdateParams? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyResponse? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteResponse? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupMemberResponse? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupResponse? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteUserResponse? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberResponse? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DenySpendLimitIncreaseRequestParams? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EmailDomainNotAllowedErrorDetails? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKey? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Attachment? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnattachedAttachment? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminator? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminatorType? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GcpExternalKeyConfig? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyProviderConfigDiscriminator? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyProviderConfigDiscriminatorType? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyChangedErrorDetails? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParams? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig4? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminator? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminatorType? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyInWorkspacePolicyErrorDetails? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyListResponse? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ExternalKey>? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParams? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfigVariant1? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1Discriminator? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyValidationFailedErrorDetails? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyValidationTimedOutErrorDetails? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuer? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksDiscovery? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksExplicitUrl? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksInline? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerJwksDiscriminator? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerJwksDiscriminatorType? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.IssuerPollStatus? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParams? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks3? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminator? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminatorType? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerListResponse? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationIssuer>? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParams? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksVariant1? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParamsJwksVariant1Discriminator? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParamsJwksVariant1DiscriminatorType? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRule? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RuleMatch? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleCreateParams? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleListResponse? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationRule>? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleTarget? Type3704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountTarget? Type3705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleTargetDiscriminator? Type3706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleTargetDiscriminatorType? Type3707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleUpdateParams? Type3708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleWorkspace? Type3709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleWorkspaceListResponse? Type3710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationRuleWorkspace>? Type3711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteAlreadyExistsErrorDetails? Type3712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteSchema? Type3713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationRoleSchema? Type3714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteStatusSchema? Type3715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.KeyProfileMismatchErrorDetails? Type3716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListEffectiveSpendLimitsResponse? Type3717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendSummary>? Type3718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseApiKey? Type3719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ApiKey>? Type3720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseInviteSchema? Type3721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InviteSchema>? Type3722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseUser? Type3723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.User>? Type3724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.User? Type3725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseWorkspaceMemberSchema? Type3726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceMemberSchema>? Type3727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceMemberSchema? Type3728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseWorkspace? Type3729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Workspace>? Type3730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Workspace? Type3731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgApiKeyLimitExceededErrorDetails? Type3732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgMemberLimitExceededErrorDetails? Type3733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgServiceScope? Type3734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationPermissionResource? Type3735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationSchema? Type3736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationScope? Type3737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationTypeNotSupportedErrorDetails? Type3738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ParentOrganizationRequiredErrorDetails? Type3739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimit? Type3740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group4? Type3741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitModelGroup? Type3742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitBatchGroup? Type3743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitTokenCountGroup? Type3744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitFilesGroup? Type3745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitSkillsGroup? Type3746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitWebSearchGroup? Type3747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupDiscriminator? Type3748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupDiscriminatorType? Type3749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RateLimitValue>? Type3750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitValue? Type3751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitListResponse? Type3752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RateLimit>? Type3753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroup? Type3754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupSourceType? Type3755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails? Type3756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupList? Type3757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacGroup>? Type3758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupMember? Type3759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupMemberList? Type3760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacGroupMember>? Type3761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails? Type3762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupScope? Type3763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRole? Type3764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSource? Type3765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleList? Type3766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacRole>? Type3767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleNotFoundErrorDetails? Type3768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermission? Type3769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Resource? Type3770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermissionResourceDiscriminator? Type3771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermissionResourceDiscriminatorType? Type3772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermissionList? Type3773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RbacRolePermission>? Type3774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceBuiltIn? Type3775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceCustom? Type3776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceDiscriminator? Type3777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceDiscriminatorType? Type3778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveFederationRuleWorkspaceResponse? Type3779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SandboxEgressRestrictedErrorDetails? Type3780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ScopedApiKeyActorSchema? Type3781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SeatTierScope? Type3782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccount? Type3783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountOrganizationRole? Type3784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountCreateParams? Type3785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountCreateParamsOrganizationRole? Type3786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountListResponse? Type3787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ServiceAccount>? Type3788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountUpdateParams? Type3789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountUpdateParamsOrganizationRole? Type3790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMember? Type3791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRoleSchema? Type3792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberCreateFromSAParams? Type3793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberCreateParams? Type3794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberDeleteResponse? Type3795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberListResponse? Type3796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ServiceAccountWorkspaceMember>? Type3797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberUpdateParams? Type3798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope2? Type3799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserScope? Type3800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceScope? Type3801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UsageTierScope? Type3802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitScopeDiscriminator? Type3803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitScopeDiscriminatorType? Type3804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserActorSchema? Type3805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestActorDiscriminator? Type3806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestActorDiscriminatorType? Type3807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestListResponse? Type3808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendLimitIncreaseRequestSchema>? Type3809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestSchema? Type3810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestResolvedByDiscriminator? Type3811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendLimitIncreaseRequestResolvedByDiscriminatorType? Type3812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor? Type3813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryActorDiscriminator? Type3814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryActorDiscriminatorType? Type3815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope3? Type3816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryScopeDiscriminator? Type3817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummaryScopeDiscriminatorType? Type3818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source? Type3819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummarySourceDiscriminator? Type3820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummarySourceDiscriminatorType? Type3821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StorageAttachedDuringArchiveErrorDetails? Type3822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StorageProfileMismatchErrorDetails? Type3823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateRbacGroupParams? Type3824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserParams? Type3825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserParamsRole? Type3826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberParams? Type3827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileNotFoundErrorDetails? Type3828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyResponse? Type3829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyResponseStatus? Type3830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceApiKeyLimitExceededErrorDetails? Type3831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceCreateParams? Type3832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceCreatedIncompleteErrorDetails? Type3833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceMemberLimitExceededErrorDetails? Type3834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspacePolicyField? Type3835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspacePolicyViolationErrorDetails? Type3836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimit? Type3837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group2? Type3838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminator? Type3839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminatorType? Type3840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimitValue>? Type3841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValue? Type3842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitListResponse? Type3843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimit>? Type3844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitOrganizationSource? Type3845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateParams? Type3846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimitUpdateValue>? Type3847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateValue? Type3848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateValueType? Type3849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source7? Type3850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitWorkspaceSource? Type3851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValueSourceDiscriminator? Type3852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValueSourceDiscriminatorType? Type3853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceUpdateParams? Type3854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PingType? Type3855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostRequest? Type3856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostRequest? Type3857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostRequest? Type3858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest? Type3859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest? Type3860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest? Type3861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest? Type3862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest? Type3863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequest? Type3864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest? Type3865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent>? Type3866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent? Type3867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequest? Type3868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent>? Type3869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent? Type3870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState? Type3871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ModelsListLifecycleItem>? Type3872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListLifecycleItem? Type3873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? Type3874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelsListLifecycleItem>? Type3875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListLifecycleItem? Type3876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementStatus>? Type3877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionStatus>? Type3878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEventType>? Type3879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? Type3880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadStatus>? Type3881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamStatus>? Type3882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse>? Type3883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse? Type3884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListApiKeysV1OrganizationsApiKeysGetStatus? Type3885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? Type3886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? Type3887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? Type3888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? Type3889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? Type3890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportGroupBy>? Type3891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? Type3892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType? Type3893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitPeriod>? Type3894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? Type3895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item? Type3896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitIncreaseRequestStatus>? Type3897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginsV1OrganizationsPluginsGetOwnerType? Type3898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? Type3899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType? Type3900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType? Type3901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource? Type3902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder? Type3903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProductFilter>? Type3904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? Type3905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item? Type3906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? Type3907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? Type3908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? Type3909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item? Type3910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item>? Type3911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item? Type3912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth? Type3913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item>? Type3914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item? Type3915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth? Type3916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item>? Type3917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item? Type3918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item>? Type3919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item? Type3920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth? Type3921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item>? Type3922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item? Type3923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item>? Type3924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item? Type3925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? Type3926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSpeed>? Type3927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsActorType>? Type3928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageGroupBy>? Type3929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostGroupBy>? Type3930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUserGroupBy>? Type3931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProjectGroupBy>? Type3932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSkillGroupBy>? Type3933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsConnectorGroupBy>? Type3934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsPluginGroupBy>? Type3935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsArtifactGroupBy>? Type3936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse>? Type3937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse? Type3938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatus? Type3939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? Type3940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType? Type3941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendLimitPeriod>? Type3942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SpendLimitIncreaseRequestStatus>? Type3943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsUserGroupBy>? Type3944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsProjectGroupBy>? Type3945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsSkillGroupBy>? Type3946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsConnectorGroupBy>? Type3947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsPluginGroupBy>? Type3948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnalyticsArtifactGroupBy>? Type3949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse? Type3950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError? Type3951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse2? Type3952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError2? Type3953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.LinkedOrganizationBillingUnavailableErrorDetails, global::Anthropic.LinkedOrganizationSpendLimitReachedErrorDetails>? Type3954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse3? Type3955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError3? Type3956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.UserProfileBillingNotAuthorizedErrorDetails, global::Anthropic.UserProfileNotBillableErrorDetails>? Type3957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse4? Type3958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError4? Type3959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse5? Type3960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError5? Type3961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse6? Type3962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError6? Type3963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse7? Type3964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError7? Type3965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ContractSpendLimitReachedErrorDetails, global::Anthropic.EnforcedSpendLimitReachedErrorDetails, global::Anthropic.RampLimitExceededErrorDetails>? Type3966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse8? Type3967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError8? Type3968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse9? Type3969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError9? Type3970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListResponse? Type3971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListResponseError? Type3972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails>? Type3973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsGetResponse? Type3974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsGetResponseError? Type3975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponse? Type3976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponseError? Type3977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponse2? Type3978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponseError2? Type3979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesListResponse? Type3980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesListResponseError? Type3981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesRetrieveResponse? Type3982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesRetrieveResponseError? Type3983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesDeleteResponse? Type3984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesDeleteResponseError? Type3985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesCancelResponse? Type3986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesCancelResponseError? Type3987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesResultsResponse? Type3988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesResultsResponseError? Type3989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.CmekKeyDisabledErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails>? Type3990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse? Type3991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError? Type3992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse2? Type3993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError2? Type3994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse3? Type3995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError3? Type3996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse4? Type3997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError4? Type3998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostResponse? Type3999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostResponseError? Type4000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListFilesV1FilesGetResponse? Type4001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListFilesV1FilesGetResponseError? Type4002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetFileMetadataV1FilesFileIdGetResponse? Type4003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetFileMetadataV1FilesFileIdGetResponseError? Type4004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteFileV1FilesFileIdDeleteResponse? Type4005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteFileV1FilesFileIdDeleteResponseError? Type4006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponse? Type4007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponseError? Type4008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponse2? Type4009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponseError2? Type4010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponse? Type4011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponseError? Type4012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponse2? Type4013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponseError2? Type4014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsV1SkillsGetResponse? Type4015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsV1SkillsGetResponseError? Type4016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillV1SkillsSkillIdGetResponse? Type4017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillV1SkillsSkillIdGetResponseError? Type4018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillV1SkillsSkillIdDeleteResponse? Type4019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillV1SkillsSkillIdDeleteResponseError? Type4020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponse? Type4021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponseError? Type4022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponse2? Type4023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponseError2? Type4024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsV1SkillsSkillIdVersionsGetResponse? Type4025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsV1SkillsSkillIdVersionsGetResponseError? Type4026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillVersionV1SkillsSkillIdVersionsVersionGetResponse? Type4027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillVersionV1SkillsSkillIdVersionsVersionGetResponseError? Type4028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponse? Type4029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponseError? Type4030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse? Type4031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError? Type4032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse2? Type4033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError2? Type4034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaLinkedOrganizationBillingUnavailableErrorDetails, global::Anthropic.BetaLinkedOrganizationSpendLimitReachedErrorDetails>? Type4035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse3? Type4036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError3? Type4037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaUserProfileBillingNotAuthorizedErrorDetails, global::Anthropic.BetaUserProfileNotBillableErrorDetails>? Type4038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse4? Type4039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError4? Type4040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse5? Type4041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError5? Type4042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse6? Type4043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError6? Type4044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse7? Type4045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError7? Type4046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse8? Type4047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError8? Type4048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse9? Type4049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError9? Type4050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListResponse? Type4051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListResponseError? Type4052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails>? Type4053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsGetResponse? Type4054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsGetResponseError? Type4055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponse? Type4056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponseError? Type4057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponse2? Type4058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponseError2? Type4059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesListResponse? Type4060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesListResponseError? Type4061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesRetrieveResponse? Type4062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesRetrieveResponseError? Type4063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesDeleteResponse? Type4064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesDeleteResponseError? Type4065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesCancelResponse? Type4066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesCancelResponseError? Type4067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesResultsResponse? Type4068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesResultsResponseError? Type4069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse? Type4070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError? Type4071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse2? Type4072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError2? Type4073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse3? Type4074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError3? Type4075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse4? Type4076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError4? Type4077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostResponse? Type4078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostResponseError? Type4079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListFilesV1FilesGetResponse? Type4080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListFilesV1FilesGetResponseError? Type4081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetFileMetadataV1FilesFileIdGetResponse? Type4082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetFileMetadataV1FilesFileIdGetResponseError? Type4083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteFileV1FilesFileIdDeleteResponse? Type4084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteFileV1FilesFileIdDeleteResponseError? Type4085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponse? Type4086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponseError? Type4087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponse2? Type4088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponseError2? Type4089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponse? Type4090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponseError? Type4091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponse2? Type4092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponseError2? Type4093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsV1SkillsGetResponse? Type4094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsV1SkillsGetResponseError? Type4095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponse? Type4096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponseError? Type4097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillV1SkillsSkillIdDeleteResponse? Type4098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillV1SkillsSkillIdDeleteResponseError? Type4099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse? Type4100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseError? Type4101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse2? Type4102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseError2? Type4103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsV1SkillsSkillIdVersionsGetResponse? Type4104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsV1SkillsSkillIdVersionsGetResponseError? Type4105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillVersionV1SkillsSkillIdVersionsVersionGetResponse? Type4106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillVersionV1SkillsSkillIdVersionsVersionGetResponseError? Type4107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponse? Type4108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponseError? Type4109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponse? Type4110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponseError? Type4111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponse2? Type4112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponseError2? Type4113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEnvironmentsV1EnvironmentsGetResponse? Type4114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEnvironmentsV1EnvironmentsGetResponseError? Type4115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse? Type4116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponseError? Type4117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponse? Type4118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponseError? Type4119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponse2? Type4120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponseError2? Type4121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteResponse? Type4122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteResponseError? Type4123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveEnvironmentV1EnvironmentsEnvironmentIdArchivePostResponse? Type4124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveEnvironmentV1EnvironmentsEnvironmentIdArchivePostResponseError? Type4125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentStatsV1EnvironmentsEnvironmentIdWorkStatsGetResponse? Type4126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentStatsV1EnvironmentsEnvironmentIdWorkStatsGetResponseError? Type4127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRecordHeartbeatV1EnvironmentsEnvironmentIdWorkWorkIdHeartbeatPostResponse? Type4128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRecordHeartbeatV1EnvironmentsEnvironmentIdWorkWorkIdHeartbeatPostResponseError? Type4129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopWorkV1EnvironmentsEnvironmentIdWorkWorkIdStopPostResponse? Type4130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopWorkV1EnvironmentsEnvironmentIdWorkWorkIdStopPostResponseError? Type4131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkV1EnvironmentsEnvironmentIdWorkWorkIdGetResponse? Type4132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkV1EnvironmentsEnvironmentIdWorkWorkIdGetResponseError? Type4133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkV1EnvironmentsEnvironmentIdWorkWorkIdPostResponse? Type4134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkV1EnvironmentsEnvironmentIdWorkWorkIdPostResponseError? Type4135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse? Type4136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError? Type4137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse2? Type4138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError2? Type4139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse3? Type4140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError3? Type4141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaEnvironmentNotFoundErrorDetails, global::Anthropic.BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails>? Type4142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponse4? Type4143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSlackChannelResponseError4? Type4144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackChannelsResponse? Type4145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackChannelsResponseError? Type4146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackChannelResponse? Type4147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackChannelResponseError? Type4148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponse? Type4149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponseError? Type4150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponse2? Type4151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponseError2? Type4152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponse3? Type4153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackChannelResponseError3? Type4154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponse? Type4155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponseError? Type4156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponse2? Type4157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSlackChannelResponseError2? Type4158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackWorkspacesResponse? Type4159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSlackWorkspacesResponseError? Type4160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackWorkspaceResponse? Type4161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSlackWorkspaceResponseError? Type4162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponse? Type4163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponseError? Type4164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponse2? Type4165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponseError2? Type4166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponse3? Type4167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateSlackWorkspaceResponseError3? Type4168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundlesResponse? Type4169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundlesResponseError? Type4170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleResponse? Type4171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleResponseError? Type4172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponse? Type4173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponseError? Type4174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaBundleAttachmentNotSupportedErrorDetails, global::Anthropic.BetaBundleOnCallErrorDetails>? Type4175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponse2? Type4176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponseError2? Type4177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponse3? Type4178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateBundleResponseError3? Type4179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundleTargetsResponse? Type4180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListBundleTargetsResponseError? Type4181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateBundleTargetResponse? Type4182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateBundleTargetResponseError? Type4183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleTargetResponse? Type4184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetBundleTargetResponseError? Type4185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteBundleTargetResponse? Type4186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteBundleTargetResponseError? Type4187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponse? Type4188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponseError? Type4189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponse2? Type4190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponseError2? Type4191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteV1OrganizationsInvitesInviteIdDeleteResponse? Type4192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteV1OrganizationsInvitesInviteIdDeleteResponseError? Type4193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserV1OrganizationsUsersUserIdPostResponse? Type4194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserV1OrganizationsUsersUserIdPostResponseError? Type4195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse? Type4196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError? Type4197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse2? Type4198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError2? Type4199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse3? Type4200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError3? Type4201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponse? Type4202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponseError? Type4203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponse2? Type4204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignOutUserV1OrganizationsUsersUserIdSignOutPostResponseError2? Type4205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse? Type4206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError? Type4207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse2? Type4208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError2? Type4209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse3? Type4210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError3? Type4211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse4? Type4212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError4? Type4213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaAuthorizationCheckUnavailableErrorDetails, global::Anthropic.BetaChangeOutcomeUnknownErrorDetails>? Type4214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse? Type4215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError? Type4216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse2? Type4217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError2? Type4218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse3? Type4219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError3? Type4220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse4? Type4221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError4? Type4222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaAuthorizationCheckUnavailableErrorDetails, global::Anthropic.BetaWorkspaceCreatedIncompleteErrorDetails>? Type4223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponse? Type4224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponseError? Type4225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponse2? Type4226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponseError2? Type4227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse? Type4228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError? Type4229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse2? Type4230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError2? Type4231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponse? Type4232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponseError? Type4233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse? Type4234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError? Type4235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse2? Type4236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError2? Type4237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse? Type4238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError? Type4239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaOrgApiKeyLimitExceededErrorDetails, global::Anthropic.BetaWorkspaceApiKeyLimitExceededErrorDetails>? Type4240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse2? Type4241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError2? Type4242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponse? Type4243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponseError? Type4244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponse2? Type4245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalKeyV1OrganizationsExternalKeysPostResponseError2? Type4246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse? Type4247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError? Type4248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse2? Type4249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError2? Type4250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse? Type4251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError? Type4252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse2? Type4253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError2? Type4254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponse? Type4255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponseError? Type4256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaGcpProjectControlledByAnotherOrganizationErrorDetails, global::Anthropic.BetaStorageInUseErrorDetails>? Type4257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponse? Type4258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponseError? Type4259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalStorageV1OrganizationsExternalStoragePostResponse? Type4260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalStorageV1OrganizationsExternalStoragePostResponseError? Type4261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalStorageV1OrganizationsExternalStoragePostResponse2? Type4262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalStorageV1OrganizationsExternalStoragePostResponseError2? Type4263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalStorageV1OrganizationsExternalStoragePostResponse3? Type4264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalStorageV1OrganizationsExternalStoragePostResponseError3? Type4265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalStorageV1OrganizationsExternalStoragePostResponse4? Type4266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateExternalStorageV1OrganizationsExternalStoragePostResponseError4? Type4267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetExternalStorageV1OrganizationsExternalStorageExternalStorageIdGetResponse? Type4268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetExternalStorageV1OrganizationsExternalStorageExternalStorageIdGetResponseError? Type4269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalStorageV1OrganizationsExternalStorageExternalStorageIdPostResponse? Type4270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalStorageV1OrganizationsExternalStorageExternalStorageIdPostResponseError? Type4271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalStorageV1OrganizationsExternalStorageExternalStorageIdPostResponse2? Type4272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateExternalStorageV1OrganizationsExternalStorageExternalStorageIdPostResponseError2? Type4273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalStorageV1OrganizationsExternalStorageExternalStorageIdDeleteResponse? Type4274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalStorageV1OrganizationsExternalStorageExternalStorageIdDeleteResponseError? Type4275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalStorageV1OrganizationsExternalStorageExternalStorageIdDeleteResponse2? Type4276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalStorageV1OrganizationsExternalStorageExternalStorageIdDeleteResponseError2? Type4277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaActivateExternalStorageV1OrganizationsExternalStorageExternalStorageIdActivatePostResponse? Type4278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaActivateExternalStorageV1OrganizationsExternalStorageExternalStorageIdActivatePostResponseError? Type4279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaActivateExternalStorageV1OrganizationsExternalStorageExternalStorageIdActivatePostResponse2? Type4280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaActivateExternalStorageV1OrganizationsExternalStorageExternalStorageIdActivatePostResponseError2? Type4281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaActivateExternalStorageV1OrganizationsExternalStorageExternalStorageIdActivatePostResponse3? Type4282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaActivateExternalStorageV1OrganizationsExternalStorageExternalStorageIdActivatePostResponseError3? Type4283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponse? Type4284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponseError? Type4285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponse? Type4286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponseError? Type4287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetResponse? Type4288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetResponseError? Type4289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitV1OrganizationsSpendLimitsPostResponse? Type4290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitV1OrganizationsSpendLimitsPostResponseError? Type4291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaSandboxEgressRestrictedErrorDetails, global::Anthropic.BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails>? Type4292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSpendLimitV1OrganizationsSpendLimitsSpendLimitIdGetResponse? Type4293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSpendLimitV1OrganizationsSpendLimitsSpendLimitIdGetResponseError? Type4294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteResponse? Type4295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteResponseError? Type4296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountV1OrganizationsServiceAccountsPostResponse? Type4297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountV1OrganizationsServiceAccountsPostResponseError? Type4298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponse? Type4299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponseError? Type4300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponse? Type4301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponseError? Type4302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponse? Type4303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponseError? Type4304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponse? Type4305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponseError? Type4306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationIssuerV1OrganizationsFederationIssuersPostResponse? Type4307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationIssuerV1OrganizationsFederationIssuersPostResponseError? Type4308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponse? Type4309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponseError? Type4310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponse? Type4311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponseError? Type4312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse? Type4313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponseError? Type4314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponse? Type4315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponseError? Type4316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponse? Type4317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponseError? Type4318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponse? Type4319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponseError? Type4320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveTunnelV1OrganizationsTunnelsTunnelIdArchivePostResponse? Type4321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveTunnelV1OrganizationsTunnelsTunnelIdArchivePostResponseError? Type4322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRevealTunnelTokenV1OrganizationsTunnelsTunnelIdRevealTokenPostResponse? Type4323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRevealTunnelTokenV1OrganizationsTunnelsTunnelIdRevealTokenPostResponseError? Type4324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenV1OrganizationsTunnelsTunnelIdRotateTokenPostResponse? Type4325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenV1OrganizationsTunnelsTunnelIdRotateTokenPostResponseError? Type4326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateCertificateV1OrganizationsTunnelsTunnelIdCertificatesPostResponse? Type4327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateCertificateV1OrganizationsTunnelsTunnelIdCertificatesPostResponseError? Type4328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveCertificateV1OrganizationsTunnelsTunnelIdCertificatesCertificateIdArchivePostResponse? Type4329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveCertificateV1OrganizationsTunnelsTunnelIdCertificatesCertificateIdArchivePostResponseError? Type4330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupV1OrganizationsRbacGroupsPostResponse? Type4331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupV1OrganizationsRbacGroupsPostResponseError? Type4332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse? Type4333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponseError? Type4334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse? Type4335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError? Type4336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails>? Type4337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse2? Type4338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError2? Type4339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse? Type4340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError? Type4341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse2? Type4342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError2? Type4343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse? Type4344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError? Type4345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse2? Type4346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError2? Type4347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolesV1OrganizationsRbacRolesGetResponse? Type4348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolesV1OrganizationsRbacRolesGetResponseError? Type4349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaOrganizationTypeNotSupportedErrorDetails, global::Anthropic.BetaParentOrganizationRequiredErrorDetails>? Type4350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponse? Type4351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponseError? Type4352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponse2? Type4353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponseError2? Type4354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponse? Type4355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponseError? Type4356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponse2? Type4357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponseError2? Type4358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse? Type4359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError? Type4360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails, global::Anthropic.BetaUnsupportedCharsetErrorDetails>? Type4361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse2? Type4362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError2? Type4363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse3? Type4364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError3? Type4365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaPluginNameTakenErrorDetails, global::Anthropic.BetaSkillNameTakenErrorDetails>? Type4366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse4? Type4367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError4? Type4368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse? Type4369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError? Type4370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails, global::Anthropic.BetaScanFailedErrorDetails>? Type4371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse2? Type4372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError2? Type4373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse3? Type4374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError3? Type4375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaScanPendingErrorDetails, global::Anthropic.BetaSkillNameTakenErrorDetails>? Type4376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponse? Type4377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponseError? Type4378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponse2? Type4379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponseError2? Type4380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse? Type4381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError? Type4382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse2? Type4383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError2? Type4384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse3? Type4385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError3? Type4386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse4? Type4387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError4? Type4388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponse? Type4389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponseError? Type4390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails>? Type4391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponse2? Type4392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponseError2? Type4393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostResponse? Type4394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostResponseError? Type4395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse? Type4396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponseError? Type4397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2? Type4398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponseError2? Type4399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostResponse? Type4400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostResponseError? Type4401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemovePluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetDeleteResponse? Type4402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemovePluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetDeleteResponseError? Type4403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostResponse? Type4404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostResponseError? Type4405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekFeatureUnsupportedErrorDetails, global::Anthropic.BetaCmekKeyDisabledErrorDetails>? Type4406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaSettingsHistoryLimitExceededErrorDetails>? Type4407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdDeleteResponse? Type4408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdDeleteResponseError? Type4409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponse? Type4410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponseError? Type4411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponse2? Type4412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponseError2? Type4413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteV1OrganizationsInvitesInviteIdDeleteResponse? Type4414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteV1OrganizationsInvitesInviteIdDeleteResponseError? Type4415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserV1OrganizationsUsersUserIdPostResponse? Type4416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserV1OrganizationsUsersUserIdPostResponseError? Type4417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse? Type4418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError? Type4419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse2? Type4420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError2? Type4421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse3? Type4422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError3? Type4423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse? Type4424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError? Type4425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse2? Type4426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError2? Type4427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse3? Type4428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError3? Type4429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse4? Type4430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError4? Type4431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse? Type4432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError? Type4433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse2? Type4434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError2? Type4435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse3? Type4436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError3? Type4437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse4? Type4438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError4? Type4439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponse? Type4440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponseError? Type4441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponse2? Type4442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveWorkspaceV1OrganizationsWorkspacesWorkspaceIdArchivePostResponseError2? Type4443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse? Type4444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError? Type4445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse2? Type4446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError2? Type4447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponse? Type4448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdDeleteResponseError? Type4449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse? Type4450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError? Type4451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse2? Type4452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError2? Type4453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse? Type4454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError? Type4455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.OrgApiKeyLimitExceededErrorDetails, global::Anthropic.WorkspaceApiKeyLimitExceededErrorDetails>? Type4456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse2? Type4457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError2? Type4458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponse? Type4459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponseError? Type4460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponse2? Type4461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateExternalKeyV1OrganizationsExternalKeysPostResponseError2? Type4462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse? Type4463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError? Type4464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponse2? Type4465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateExternalKeyV1OrganizationsExternalKeysExternalKeyIdPostResponseError2? Type4466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse? Type4467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError? Type4468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponse2? Type4469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyV1OrganizationsExternalKeysExternalKeyIdDeleteResponseError2? Type4470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponse? Type4471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostResponseError? Type4472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponse? Type4473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateComplianceSettingsV1OrganizationsComplianceSettingsPostResponseError? Type4474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponse? Type4475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsRateLimitIdPostResponseError? Type4476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponse? Type4477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponseError? Type4478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountV1OrganizationsServiceAccountsPostResponse? Type4479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountV1OrganizationsServiceAccountsPostResponseError? Type4480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponse? Type4481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateServiceAccountV1OrganizationsServiceAccountsServiceAccountIdPostResponseError? Type4482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponse? Type4483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveServiceAccountV1OrganizationsServiceAccountsServiceAccountIdArchivePostResponseError? Type4484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponse? Type4485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateServiceAccountWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdServiceAccountsPostResponseError? Type4486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponse? Type4487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddWorkspaceToServiceAccountV1OrganizationsServiceAccountsServiceAccountIdWorkspacesPostResponseError? Type4488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationIssuerV1OrganizationsFederationIssuersPostResponse? Type4489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationIssuerV1OrganizationsFederationIssuersPostResponseError? Type4490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponse? Type4491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdPostResponseError? Type4492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponse? Type4493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationIssuerV1OrganizationsFederationIssuersFederationIssuerIdArchivePostResponseError? Type4494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationRuleV1OrganizationsFederationRulesPostResponse? Type4495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateFederationRuleV1OrganizationsFederationRulesPostResponseError? Type4496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponse? Type4497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateFederationRuleV1OrganizationsFederationRulesFederationRuleIdPostResponseError? Type4498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponse? Type4499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ArchiveFederationRuleV1OrganizationsFederationRulesFederationRuleIdArchivePostResponseError? Type4500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponse? Type4501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesPostResponseError? Type4502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveFederationRuleWorkspaceV1OrganizationsFederationRulesFederationRuleIdWorkspacesWorkspaceIdDeleteResponse? Type4503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateRbacGroupV1OrganizationsRbacGroupsPostResponse? Type4504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateRbacGroupV1OrganizationsRbacGroupsPostResponseError? Type4505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse? Type4506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponseError? Type4507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse? Type4508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError? Type4509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails>? Type4510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse2? Type4511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError2? Type4512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse? Type4513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError? Type4514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse2? Type4515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError2? Type4516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse? Type4517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError? Type4518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse2? Type4519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError2? Type4520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolesV1OrganizationsRbacRolesGetResponse? Type4521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolesV1OrganizationsRbacRolesGetResponseError? Type4522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.OrganizationTypeNotSupportedErrorDetails, global::Anthropic.ParentOrganizationRequiredErrorDetails>? Type4523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponse? Type4524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponseError? Type4525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponse2? Type4526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetRbacRoleV1OrganizationsRbacRolesRoleIdGetResponseError2? Type4527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponse? Type4528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponseError? Type4529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponse2? Type4530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListRbacRolePermissionsV1OrganizationsRbacRolesRoleIdPermissionsGetResponseError2? Type4531 { get; set; }

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
        public global::System.Collections.Generic.List<global::Anthropic.BetaComplianceReviewPolicyCategory>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaComplianceReviewTranscript>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaContainerSkill>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkillParams>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBetaContentBlockSourceContentItem>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBetaContentBlockSourceContentItem>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.EditsItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestMCPServerURLDefinition>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInputMessageUnion>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaRequestTextBlock>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestTextBlock>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamInput>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatchIndividualRequestParams>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaFallbackConfigV2>, string>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFallbackConfigV2>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaToolUnion>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamOutput>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaEnvironment>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFileMetadataSchema>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGoogleManagedRetiredKey>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGoogleManagedRetiredBucket>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGoogleManagedStorageFailedCheck>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInputContentBlock>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaIterationsUsageVariant1Item>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDream>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatch>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelInfo>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaComplianceReviewCase>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaComplianceReviewNotice>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkillVersion>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkill>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTelemetryDestinationWorkspace>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTelemetryDestination>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTunnelCertificate>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTunnel>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUserProfile>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMCPTool>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentTool>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPServer>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSkill>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentMessageContentBlock>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsUserContentBlock>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolConfigUnion>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolParams>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPServerParams>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSkillParams>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResourceParams>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.DateTime>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResourceConfig>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSystemContentBlock>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgent>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsCredential>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentRun>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeployment>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryListItem>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryStore>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryVersion>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionEvent>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResource>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThread>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSession>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsVault>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPToolConfig>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentRosterEntry>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentReference>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSearchResultContent>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsInputEvent>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsEventParams>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionRosterEntry>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsWorkflowRunPhase>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaContentBlock>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInputTransformation>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.StateChangesVariant1Item2>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaBrowserStateTabEntry>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestCodeExecutionOutputBlock>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ToolChangesVariant1Item>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item3>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestToolReferenceBlock>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaWebSearchToolRequestError>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRequestWebSearchResultBlock>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaComplianceReviewViolatedPolicyCategory>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaComplianceReviewVerdict>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseCodeExecutionOutputBlock>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ToolChangesVariant1Item2>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AppliedEditsItem>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseMCPTool>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaResponseTextBlock>>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseTextBlock>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item4>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseToolReferenceBlock>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaWebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.BetaResponseWebSearchResultBlock>>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaResponseWebSearchResultBlock>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSelfHostedWork>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem2>>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem2>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWebFetchUrlSourceToolReference>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContainerSkill>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SkillParams>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentContentBlockSourceContentItem>>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentContentBlockSourceContentItem>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InputMessageUnion>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.RequestTextBlock>>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestTextBlock>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.MessageBatchIndividualRequestParams>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FileMetadataSchema>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InputContentBlock>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.MessageBatch>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ModelInfo>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SkillVersion>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.Skill>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfile>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlock>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestBashCodeExecutionOutputBlock>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.StateChangesVariant1Item>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BrowserStateTabEntry>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestCodeExecutionOutputBlock>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item>>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestToolReferenceBlock>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.WebSearchToolRequestError>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseBashCodeExecutionOutputBlock>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseCodeExecutionOutputBlock>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item2>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseToolReferenceBlock>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.WebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem>>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfileEnforcementAction>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WebFetchUrlSourceToolReference>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSingleDayActivitySummary>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsArtifactActivity>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsConnectorActivity>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostReportTimeBucket>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostBucketedResult>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostUsersItem>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsFlatCostItem>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsFlatUsageItem>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsPluginActivity>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProjectActivity>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSkillActivity>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageReportTimeBucket>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageBucketedResult>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageUsersItem>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUserActivity>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSummary>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelBreakdown>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRetiredKey>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportItem>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaAllowedInferenceGeo>, string>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAllowedInferenceGeo>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaExternalKey>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaExternalStorage>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationIssuer>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationRule>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationRuleWorkspace>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeCodeUsageReportItem>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportTimeBucket>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportTimeBucket>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendSummary>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaApiKey>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInviteSchema>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUser>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceMemberSchema>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspace>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimit>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportItem>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationWebhookEndpoint>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginComponent>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginInstallationSetting>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPlugin>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplace>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginError>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginShare>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginVersion>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRateLimitValue>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRateLimit>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacGroup>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacGroupMember>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacRole>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacRolePermission>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaServiceAccount>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaServiceAccountWorkspaceMember>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRetiredBucket>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaStorageFailedCheck>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaExternalStorageFailedCheck>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationTunnelCertificate>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationTunnel>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimitValue>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimit>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimitUpdateValue>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsSingleDayActivitySummary>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsArtifactActivity>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsConnectorActivity>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsPluginActivity>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsProjectActivity>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsSkillActivity>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsUserActivity>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.AllowedInferenceGeo>, string>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AllowedInferenceGeo>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ExternalKey>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationIssuer>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationRule>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationRuleWorkspace>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendSummary>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ApiKey>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InviteSchema>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.User>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceMemberSchema>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.Workspace>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RateLimitValue>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RateLimit>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacGroup>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacGroupMember>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacRole>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RbacRolePermission>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ServiceAccount>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ServiceAccountWorkspaceMember>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendLimitIncreaseRequestSchema>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimitValue>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimit>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimitUpdateValue>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ModelsListLifecycleItem>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnthropicBeta>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelsListLifecycleItem>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfileEnforcementStatus>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionStatus>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionEventType>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsEventDeltaType>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThreadStatus>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamStatus>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUsageReportServiceTier>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportContextWindow>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInferenceGeoFilter>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpeed>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportGroupBy>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportGroupBy>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitPeriod>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitIncreaseRequestStatus>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProductFilter>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsClaudeTagCategory>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSpeed>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsActorType>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageGroupBy>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostGroupBy>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUserGroupBy>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProjectGroupBy>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSkillGroupBy>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsConnectorGroupBy>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsPluginGroupBy>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsArtifactGroupBy>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendLimitPeriod>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SpendLimitIncreaseRequestStatus>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsUserGroupBy>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsProjectGroupBy>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsSkillGroupBy>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsConnectorGroupBy>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsPluginGroupBy>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnalyticsArtifactGroupBy>? ListType308 { get; set; }
    }
}