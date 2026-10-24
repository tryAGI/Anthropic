
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
        public global::Anthropic.AssistantInputMessage? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageContent? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AuthenticationError? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AvailableToolsLimitExceededErrorDetails? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Base64ImageSource? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Base64ImageSourceMediaType? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Base64PDFSource? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashCodeExecutionToolResultErrorCode? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashTool20250124? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AllowedCaller>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant1? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlEphemeral? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashTool20250124CacheControlVariant1Discriminator? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashTool20250124CacheControlVariant1DiscriminatorType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JsonValue? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAPIError? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorMessageIterationUsage? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheCreation? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Model? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorToolResultErrorCode? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedCaller>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllowedCaller? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant12? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheControlEphemeral? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1Discriminator? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CachingVariant1? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CachingVariant1Discriminator? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CachingVariant1DiscriminatorType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllThinkingTurns? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAssistantInputMessage? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageContent? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAuthenticationError? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAvailableToolsLimitExceededErrorDetails? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBase64ImageSource? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBase64ImageSourceMediaType? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBase64PDFSource? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashCodeExecutionToolResultErrorCode? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20241022? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant13? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20241022CacheControlVariant1Discriminator? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20241022CacheControlVariant1DiscriminatorType? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJsonValue? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20250124? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant14? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20250124CacheControlVariant1Discriminator? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20250124CacheControlVariant1DiscriminatorType? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBillingError? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBodyCreateSkillV1SkillsPost? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBodyCreateSkillVersionV1SkillsSkillIdVersionsPost? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTarget? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCoordinateTarget? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRefTarget? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTargetDiscriminator? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserClickTargetDiscriminatorType? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCloseTabConfig? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCloseTabInput? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserDoubleClickConfig? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserDoubleClickInput? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFileUploadConfig? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFileUploadInput? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFindConfig? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFindInput? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputConfig? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputInput? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputValue? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserGetPageTextConfig? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserGetPageTextInput? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoldKeyConfig? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoldKeyInput? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoverConfig? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoverInput? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserJavascriptExecConfig? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserJavascriptExecInput? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserKeyConfig? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserKeyInput? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickConfig? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickDragConfig? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickDragInput? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickInput? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseDownConfig? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseDownInput? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseUpConfig? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseUpInput? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserListTabsConfig? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserListTabsInput? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMemberInput? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNavigateInput? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNewTabInput? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserSwitchTabInput? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageInput? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadConsoleInput? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadNetworkInput? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollToInput? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScreenshotInput? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserZoomInput? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRightClickInput? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMiddleClickInput? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTripleClickInput? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMouseMoveInput? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollInput? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTypeInput? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserWaitInput? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMiddleClickConfig? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMouseMoveConfig? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNavigateConfig? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNewTabConfig? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadConsoleConfig? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadNetworkConfig? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageConfig? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageFilter? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRightClickConfig? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScreenshotConfig? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollConfig? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollDirection? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollToConfig? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadCompleted? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadFailed? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadStarted? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeTabOpened? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserStateTabEntry? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserSwitchTabConfig? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolsetConfigs? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTripleClickConfig? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTypeConfig? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserWaitConfig? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserZoomConfig? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant15? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801CacheControlVariant1Discriminator? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801CacheControlVariant1DiscriminatorType? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheControlEphemeralTtl? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissMessagesChanged? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissModelChanged? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissPreviousMessageNotFound? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReason? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissSystemChanged? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissToolsChanged? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissUnavailable? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReasonDiscriminator? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheMissReasonDiscriminatorType? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCanceledResult? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCapabilitySupport? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDelta? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Citation? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCharLocationCitation? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponsePageLocationCitation? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContentBlockLocationCitation? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchResultLocationCitation? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseSearchResultLocationCitation? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDeltaCitationDiscriminator? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCitationsDeltaCitationDiscriminatorType? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeVersionTooOldErrorDetails? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundle? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundleTarget? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTarget? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundleTargetDiscriminator? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundleTargetDiscriminatorType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCodedPermissionError? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCodedPermissionErrorDetails? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBody? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminator? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateSlackChannelRequest? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelIdentifiers? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingsCreate? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagDefaultSettingSource? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagDeletedBundleTarget? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagDeletedSlackChannel? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagEnvironmentNotFoundError? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagEnvironmentNotFoundErrorDetails? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagErrorResponse? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagErrorResponseError? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingsConflictError? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagErrorResponseErrorDiscriminator? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagErrorResponseErrorDiscriminatorType? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicy? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyAllow? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyRestrict? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyDiscriminator? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyDiscriminatorType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListBundleTargetsResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagBundleTarget>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListBundlesResponse? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagBundle>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListSlackChannelsResponse? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSlackChannel>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannel? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagListSlackWorkspacesResponse? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSlackWorkspace>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspace? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSetUpSettingsRefusedErrorDetails? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSource? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelSettingSource? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackDefaultSettingSource? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSourceDiscriminator? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSources? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSettingSource>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettings? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingsConflictErrorDetails? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingsUpdate? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceIdentifiers? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagUpdateSlackChannelRequestBody? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagUpdateSlackWorkspaceRequestBody? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearThinking20251015? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.OneOf<global::Anthropic.BetaThinkingTurns, global::Anthropic.BetaAllThinkingTurns>?, string>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaThinkingTurns, global::Anthropic.BetaAllThinkingTurns>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingTurns? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTokensClearAtLeast? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUsesKeep? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919KeepDiscriminator? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919KeepDiscriminatorType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Trigger? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTokensTrigger? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUsesTrigger? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919TriggerDiscriminator? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919TriggerDiscriminatorType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClientToolUnion? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTool? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfig? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Networking? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnrestrictedNetwork? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLimitedNetwork? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigNetworkingDiscriminator? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigNetworkingDiscriminatorType? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPackages? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParams? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NetworkingVariant1? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLimitedNetworkParams? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParamsNetworkingVariant1Discriminator? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCloudConfigParamsNetworkingVariant1DiscriminatorType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPackagesParams? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekContextUnavailableErrorDetails? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyDisabledErrorDetails? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekKeyUnreachableErrorDetails? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionToolResultErrorCode? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant16? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1Discriminator? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522CacheControlVariant1DiscriminatorType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant17? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1Discriminator? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825CacheControlVariant1DiscriminatorType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant18? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1Discriminator? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120CacheControlVariant1DiscriminatorType? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant19? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521CacheControlVariant1Discriminator? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521CacheControlVariant1DiscriminatorType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompact20260112? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionBlockMisplacedErrorDetails? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionCapability? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfig? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSummarizeCompaction? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfigDiscriminator? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfigDiscriminatorType? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionContentBlockDelta? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionContentMismatchErrorDetails? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionIncompleteTurnErrorDetails? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionIterationUsage? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionSignatureInvalidErrorDetails? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionTooManyToolReferencesErrorDetails? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionUnavailableErrorDetails? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionConfig? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionInput? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickConfig? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickInput? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyConfig? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyInput? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyConfig? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyInput? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickConfig? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragConfig? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragInput? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickInput? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownConfig? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownInput? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpConfig? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpInput? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMemberInput? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeInput? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveInput? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickInput? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickInput? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickInput? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollInput? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitInput? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotInput? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomInput? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickConfig? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveConfig? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickConfig? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotConfig? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollConfig? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollDirection? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolsetConfigs? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickConfig? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeConfig? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitConfig? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomConfig? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant110? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801CacheControlVariant1Discriminator? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801CacheControlVariant1DiscriminatorType? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant111? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1Discriminator? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022CacheControlVariant1DiscriminatorType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant112? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1Discriminator? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant113? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1Discriminator? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124CacheControlVariant1DiscriminatorType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainer? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaContainerSkill>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerSkill? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerParams? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillParams>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillParams? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContainerSkillType? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEvent? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Delta? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextContentBlockDelta? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputJsonContentBlockDelta? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingContentBlockDelta? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSignatureContentBlockDelta? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSource? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBetaContentBlockSourceContentItem>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBetaContentBlockSourceContentItem? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlock? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlock? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminator? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEvent? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlock? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseThinkingBlock? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseRedactedThinkingBlock? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlock? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlock? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlock? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlock? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorToolResultBlock? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionToolResultBlock? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolResultBlock? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolUseBlock? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolResultBlock? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContainerUploadBlock? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlock? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseFallbackBlock? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPToolListingBlock? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminator? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockStopEvent? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementCapability? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfig? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.EditsItem>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EditsItem? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminator? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminatorType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContextManagementResponse? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParams? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant114? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1Discriminator? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensParamsCacheControlVariant1DiscriminatorType? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestMCPServerURLDefinition>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPServerURLDefinition? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputMessageUnion>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnion? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputConfig? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJsonOutputFormat? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpeed? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParam? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoice? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolset? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCountMessageTokensResponse? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateDreamRequest? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInput? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelParams? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehavior? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageBatchParams? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatchIndividualRequestParams>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualRequestParams? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParams? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant115? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsCacheControlVariant1Discriminator? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsCacheControlVariant1DiscriminatorType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaContainerParams, string>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDiagnosticsParam? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::Anthropic.BetaFallbackCreditTokenParam>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackCreditTokenParam? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaFallbackConfigV2>, string>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFallbackConfigV2>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMetadata? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsServiceTier? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThreadVariant1? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadCreateParams? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadContinueParams? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsThreadVariant1Discriminator? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsThreadVariant1DiscriminatorType? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaToolUnion>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUnion? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTelemetryDestinationRequest? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTracesParams? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParams? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelCertificateRequestBody? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelRequest? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateUserProfileActionUrlRequestBody? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileAction? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateUserProfileRequest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileAccessType? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserDetailsParams? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCurrency? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteMessageBatchResponse? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedSkill? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedSkillVersion? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedTelemetryDestination? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedTelemetryDestinationWorkspace? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedUserProfile? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDiagnostics? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDirectCaller? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDream? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamOutput>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutput? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamStatus? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamError? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelConfig? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamUsage? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreInput? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamSessionsInput? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminator? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminatorType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreOutput? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamModelConfigParams? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminator? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminatorType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorResponse? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingError? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffortCapability? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEffortLevel? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnrollmentUrl? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironment? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Config? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfig? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminator? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminatorType? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentScope? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentArchivedErrorDetails? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentCreateDisabledErrorDetails? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentDeleteResponse? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentListResponse? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaEnvironment>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEnvironmentUpdateDisabledErrorDetails? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaErrorResponse? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Error? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidRequestError? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPermissionError? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNotFoundError? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitError? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGatewayTimeoutError? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOverloadedError? Type522 { get; set; }
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
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlock? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserInputMessage? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessage? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnionDiscriminator? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnionDiscriminatorRole? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputSchema? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformation? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformation? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminator? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminatorType? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidConfigTypeChangeErrorDetails? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidMetadataErrorDetails? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListDreamsResponse? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDream>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseMessageBatch? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatch>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatch? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseModelInfo? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelInfo>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelInfo? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsResponse? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillVersion>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillVersion? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsResponse? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkill>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkill? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTelemetryDestinationWorkspacesResponse? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTelemetryDestinationWorkspace>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspace? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTelemetryDestinationsResponse? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTelemetryDestination>? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestination? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTunnelCertificatesResponse? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTunnelCertificate>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelCertificate? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListTunnelsResponse? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaTunnel>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnel? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListUserProfilesResponse? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUserProfile>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfile? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPTool? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolConfig? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolDefaultConfig? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant116? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolsetCacheControlVariant1Discriminator? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolsetCacheControlVariant1DiscriminatorType? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaMCPToolConfig>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMCPTool>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActor? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionActor? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsApiActor? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserActor? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountActor? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminator? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminatorType? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResource? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResource? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminator? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminatorType? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParams? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceParams? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminator? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminatorType? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisor? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisorParams? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgent? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelConfig? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentTool? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServer? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkill? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentity? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedRunError? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminator? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStruct? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentEvaluatedPermission? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlock? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluation? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlock? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextBlock? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRedactedBlock? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminator? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminatorType? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageEvent? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentMessageContentBlock>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentParams? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentReference? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThinkingEvent? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock>? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlock? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolset? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomTool? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminator? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminatorType? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnion? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfig? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfig? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfig? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfig? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfig? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfig? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfig? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfig? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminator? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminatorType? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfigParams? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfigParams? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfigParams? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfigParams? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfigParams? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfigParams? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminator? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminator? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminatorType? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolName? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParams? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401Params? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetParams? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolParams? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminator? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminatorType? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolResultEvent? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolUseEvent? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfig? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigUnion>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfigParams? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicy? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParams? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2Discriminator? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelParams? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParams? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParams? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkill? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAnthropicSkillParams? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponse? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStore? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminator? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAutoPolicy? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64DocumentSource? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBase64ImageSource? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBillingError? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatus? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBranchCheckout? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudget? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetLimit? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminator? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminatorType? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMonetaryAmount? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCacheCreationUsage? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCommitCheckout? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsContentSha256Precondition? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateAgentParams? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParams? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParams? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateCredentialRequestBody? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuth? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateDeploymentParams? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceParams>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParams? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParams? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryParams? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreRequest? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponse? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminator? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParams? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionParams? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParams? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateVaultRequest? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredential? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuth? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableAuthResponse? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminator? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminatorType? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminator? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminatorType? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParams? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminator? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminator? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialRefreshStatus? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuth? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminator? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminatorType? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidation? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialValidationStatus? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpProbe? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRefreshObject? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronSchedule? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.DateTime>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronScheduleParams? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkill? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomSkillParams? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCustomToolInputSchema? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponse? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemoryStore? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminator? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteSessionResource? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedCredential? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedMemory? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedSession? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeletedVault? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeployment? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent>? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEvent? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResourceConfig>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfig? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSchedule? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentStatus? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReason? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminator? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminatorType? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEventParams? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEventParams? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminator? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminator? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminatorType? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminator? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentRun? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContext? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunError? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSystemContentBlock>? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlock? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubric? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentBlock? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSource? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSource? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLDocumentSource? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileDocumentSource? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminator? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminatorType? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffort? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLow? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMedium? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortHigh? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortXhigh? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMax? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminator? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminatorType? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLevel? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortParams? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationResponse? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationParams? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInjectionLocationUpdateParams? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorResponse? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsError? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEvent? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDelta? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminator? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaType? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParams? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEventParams? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEventParams? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminator? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminatorType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEvent? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEvent? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminator? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminatorType? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminator? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminatorType? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminator? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminatorType? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileImageSource? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundRunError? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceConfig? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubric? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileRubricParams? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponse? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminator? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetMemoryStoreResponseDiscriminatorType? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResource? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResource? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResource? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminator? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminatorType? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckout? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageBlock? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSource? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLImageSource? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminator? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminatorType? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInlineAgent? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEvent? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEvent? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminator? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminatorType? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListAgentVersions? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgent>? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListAgents? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListCredentialsResponse? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsCredential>? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListDeploymentRunsData? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentRun>? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListDeploymentsData? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeployment>? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoriesResult? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryListItem>? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItem? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoryStoresResponse? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryStore>? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListMemoryVersionsResult? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryVersion>? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersion? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListOrder? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionEvents? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEvent>? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEvent? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionResources? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResource>? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResource? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionThreadEvents? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessionThreads? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThread>? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThread? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListSessions? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSession>? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSession? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsListVaultsResponse? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsVault>? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVault? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerURLDefinition? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminator? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminatorType? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsURLMCPServerParams? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminator? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminatorType? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolConfig? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolConfigParams? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfig? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfig>? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPToolsetDefaultConfigParams? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualTriggerContext? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponse? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParams? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminator? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminator? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParams? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminator? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorType? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRefreshHttpResponse? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemory? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPrefix? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminator? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminatorType? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPathConflictError? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMountMode? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryVersionOperation? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryView? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModel? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpeed? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelConfigParams? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelOverloadedError? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRateLimitedError? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRequestFailedError? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinator? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminator? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminatorType? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflows? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagents? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisor? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001Params? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParams? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParams? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabled? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabled? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDiscriminator? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDiscriminatorType? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminator? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntry>? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntry? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams>? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgents? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminator? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParams? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminator? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminator? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminatorType? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSelfParams? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryDiscriminator? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryDiscriminatorType? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabled? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDiscriminator? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDiscriminatorType? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentReference>? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminator? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminator? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminatorType? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminator? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminator? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminatorType? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPrecondition? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminator? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminatorType? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminator? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminatorType? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCloneError? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusRetrying? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusExhausted? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusTerminal? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminator? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminatorType? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubric? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminator? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminatorType? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParams? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextRubricParams? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminator? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminatorType? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedRunError? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownRunError? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminator? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminator? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminatorType? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminator? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminatorType? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleTriggerContext? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultBlock? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSearchResultContent>? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultContent? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultCitations? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSendSessionEvents? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsInputEvent>? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSendSessionEventsParams? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventParams>? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServerToolUsage? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatus? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgent? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource>? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsage? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStats? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagent? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionAgentUpdate? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionBudgetReached? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionDeletedEvent? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEndTurn? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEvent? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventError? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownError? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminator? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageEvent? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventDiscriminator? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventDiscriminatorType? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminator? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminatorType? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagent20261001? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminator? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminatorType? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflows? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagents? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionRosterEntry>? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntry? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminator? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgent? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsEnabled? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsDiscriminator? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflowsDiscriminatorType? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusal? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetailsCategory? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRequiresAction? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceDiscriminator? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceDiscriminatorType? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminator? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminatorType? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminator? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminatorType? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminator? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminatorType? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetails? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReason? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminator? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminator? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminatorType? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatus? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntry? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadUsage? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStats? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntryDiscriminator? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgentEntryDiscriminatorType? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReason? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminator? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageSnapshot? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminator? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminatorType? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminator? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminatorType? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelUsage? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEvents? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminator? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminator? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminator? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminatorType? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminator? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminatorType? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminator? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminatorType? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerType? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateAgentParams? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateCredentialRequestBody? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateDeploymentParams? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryParams? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreRequestBody? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponse? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminator? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionParams? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResource? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminator? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceDiscriminatorType? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateSessionResourceParams? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUpdateVaultRequestBody? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminator? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserContentBlockDiscriminatorType? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserLocation? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationResult? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSources? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourcesParams? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference>? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminator? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterParams? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminator? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputParams? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWorkflowRunPhase>? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhase? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunError? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminator? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResult? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultError? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminator? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminatorType? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant117? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CacheControlVariant1Discriminator? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CacheControlVariant1DiscriminatorType? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818Command? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818ViewCommand? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CreateCommand? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818InsertCommand? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818DeleteCommand? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818RenameCommand? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminator? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CreateCommandCommand? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818InsertCommandCommand? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818RenameCommandCommand? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818ViewCommandCommand? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessage? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaContentBlock>? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlock? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopReason? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRefusalStopDetails? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsage? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputTransformation>? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagement? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchProcessingStatus? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCounts? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponse? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Result? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSucceededResult? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminator? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDelta? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDeltaEvent? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageDeltaUsage? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaIterationsUsageVariant1Item>? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputTokensDetails? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolUsage? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageIterationUsage? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStartEvent? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStopEvent? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEvent? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminator? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminatorType? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelCapabilities? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolsCapability? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingCapability? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelInfoLifecycle? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelLine? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationOnHoldErrorDetails? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorCreateNew? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorUpdateExisting? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminator? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminatorType? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTokenTaskBudget? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPlainTextSource? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequest? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConfigVariant1? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfigParams? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1Discriminator? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestScope? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequest? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConfigVariant12? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1Discriminator? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentUpdateRequestScope? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorRedactedResultBlock? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorResultBlock? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlock? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant118? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1Discriminator? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestAdvisorToolResultError, global::Anthropic.BetaRequestAdvisorResultBlock, global::Anthropic.BetaRequestAdvisorRedactedResultBlock>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultError? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionOutputBlock? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionResultBlock? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestBashCodeExecutionOutputBlock>? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant119? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestBashCodeExecutionToolResultError, global::Anthropic.BetaRequestBashCodeExecutionResultBlock>? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultError? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBodyTooLargeAfterDecodingErrorDetails? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlock? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant120? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockCacheControlVariant1Discriminator? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockCacheControlVariant1DiscriminatorType? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item>? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StateChangesVariant1Item? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminator? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaBrowserStateTabEntry>? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCharLocationCitation? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCitationsConfig? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionOutputBlock? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionResultBlock? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestCodeExecutionOutputBlock>? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlock? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant121? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultError? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestEncryptedCodeExecutionResultBlock? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlock? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant122? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1Discriminator? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockCacheControlVariant1DiscriminatorType? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item>? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChangesVariant1Item? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlock? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlock? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminator? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlock? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant123? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1Discriminator? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlockCacheControlVariant1DiscriminatorType? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestContentBlockLocationCitation? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlock? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant124? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1Discriminator? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockCacheControlVariant1DiscriminatorType? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaURLPDFSource? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminator? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestFallbackBlock? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestFallbackHopInfo? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant125? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockCacheControlVariant1Discriminator? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockCacheControlVariant1DiscriminatorType? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source2? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaURLImageSource? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminator? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageTransformations? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageTransformationsOversizedImage? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPServerToolConfiguration? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolListingBlock? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlock? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant126? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1Discriminator? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlockCacheControlVariant1DiscriminatorType? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlock? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant127? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1Discriminator? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlockCacheControlVariant1DiscriminatorType? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestPageLocationCitation? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestRedactedThinkingBlock? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlock? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant128? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1Discriminator? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlockCacheControlVariant1DiscriminatorType? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultLocationCitation? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlock? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant129? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1Discriminator? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCacheControlVariant1DiscriminatorType? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolCaller? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolCaller20260120? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminator? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockCallerDiscriminatorType? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlockName? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant130? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCacheControlVariant1Discriminator? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCacheControlVariant1DiscriminatorType? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item>? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchResultLocationCitation? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminator? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant131? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditorCodeExecutionToolResultErrorCode? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockFileType? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestThinkingBlock? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant132? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockCacheControlVariant1Discriminator? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockCacheControlVariant1DiscriminatorType? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolReference? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolReference? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolsetReference? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolDefinition? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminator? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminatorType? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlock? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant133? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1Discriminator? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlockCacheControlVariant1DiscriminatorType? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant134? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1Discriminator? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool2? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminator? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminatorType? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlock? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant135? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1Discriminator? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockCacheControlVariant1DiscriminatorType? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>>? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentVariant2Item? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminator? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlock? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant136? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1Discriminator? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestToolSearchToolResultError, global::Anthropic.BetaRequestToolSearchToolSearchResultBlock>? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultError? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolSearchResultBlock? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolResultErrorCode? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestToolReferenceBlock>? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlock? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant137? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1Discriminator? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCacheControlVariant1DiscriminatorType? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller2? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCallerDiscriminator? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlockCallerDiscriminatorType? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchResultBlock? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlock? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant138? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1Discriminator? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller3? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminator? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlockCallerDiscriminatorType? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRequestWebFetchToolResultError, global::Anthropic.BetaRequestWebFetchResultBlock>? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultError? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchToolResultErrorCode? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchResultBlock? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlock? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant139? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1Discriminator? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller4? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminator? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlockCallerDiscriminatorType? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>, global::Anthropic.BetaRequestWebSearchToolResultError>? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRequestWebSearchResultBlock>? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultError? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchToolResultErrorCode? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorRedactedResultBlock? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorResultBlock? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseAdvisorToolResultError, global::Anthropic.BetaResponseAdvisorResultBlock, global::Anthropic.BetaResponseAdvisorRedactedResultBlock>? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseAdvisorToolResultError? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionOutputBlock? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionResultBlock? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock>? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseBashCodeExecutionToolResultError, global::Anthropic.BetaResponseBashCodeExecutionResultBlock>? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultError? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCaller? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFindToolUseBlock? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserHoverToolUseBlock? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserKeyToolUseBlock? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScrollToolUseBlock? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlock? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnion? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserZoomToolUseBlock? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserTypeToolUseBlock? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserWaitToolUseBlock? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminator? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCitationsConfig? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseClearThinking20251015Edit? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseClearToolUses20250919Edit? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionOutputBlock? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionResultBlock? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseCodeExecutionOutputBlock>? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCodeExecutionToolResultError? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseEncryptedCodeExecutionResultBlock? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item2>? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChangesVariant1Item2? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlock? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlock? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminator? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerKeyToolUseBlock? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerRightClickToolUseBlock? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerScrollToolUseBlock? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlock? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnion? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerTypeToolUseBlock? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerWaitToolUseBlock? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerZoomToolUseBlock? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminator? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AppliedEditsItem>? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AppliedEditsItem? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminator? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlock? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source3? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlockSourceDiscriminator? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlockSourceDiscriminatorType? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseFallbackHopInfo? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseMCPTool? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseMCPTool>? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>>? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller5? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminator? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockCallerDiscriminatorType? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseServerToolUseBlockName? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item2>? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item2? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminator? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockFileType? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseTool? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolInputSchema? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool3? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeToolReference? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeMCPToolReference? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeMCPToolsetReference? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeToolDefinition? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlockToolDiscriminator? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlockToolDiscriminatorType? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUnion? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolReferenceBlock? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool4? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminator? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminatorType? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseToolSearchToolResultError, global::Anthropic.BetaResponseToolSearchToolSearchResultBlock>? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolResultError? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolSearchToolSearchResultBlock? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseToolReferenceBlock>? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller6? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockCallerDiscriminator? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockCallerDiscriminatorType? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlockUnion? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchResultBlock? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller7? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminator? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultBlockCallerDiscriminatorType? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebFetchToolResultError, global::Anthropic.BetaResponseWebFetchResultBlock>? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebFetchToolResultError? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchResultBlock? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller8? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminator? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultBlockCallerDiscriminatorType? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>>? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseWebSearchToolResultError? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenRequestBody? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWork? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSessionWorkData? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkState? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkHeartbeatResponse? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkHeartbeatResponseState? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkListResponse? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSelfHostedWork>? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkQueueStats? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkStopRequest? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSelfHostedWorkUpdateRequest? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillSource? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillParamsType? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillReadBlockedUndecryptableErrorDetails? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillSourceType? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageQuotaExceededErrorDetails? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageClearAt? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem>>? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem>? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlocksItem? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageContentBlockDiscriminator? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageContentBlockDiscriminatorType? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemMessageOutputConfig? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTargetStoreHeldError? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTraces? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationState? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDeliveryHealth? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspaces? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationContentMode? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReason? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminator? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabled? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabled? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminator? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminatorType? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabledParams? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabledParams? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParams? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminator? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminatorType? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTest? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResult? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestFailure? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestSuccess? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminator? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminatorType? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAll? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminator? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminatorType? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminator? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminatorType? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant140? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022CacheControlVariant1Discriminator? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022CacheControlVariant1DiscriminatorType? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant141? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124CacheControlVariant1Discriminator? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124CacheControlVariant1DiscriminatorType? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant142? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429CacheControlVariant1Discriminator? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429CacheControlVariant1DiscriminatorType? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant143? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728CacheControlVariant1Discriminator? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728CacheControlVariant1DiscriminatorType? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingBlockBinding? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingPrefixMismatchBehavior? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingTypes? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDisplayMode? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformationReason? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformationReason? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant144? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolCacheControlVariant1Discriminator? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolCacheControlVariant1DiscriminatorType? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceAny? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceAuto? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceNone? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceTool? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolNameConflictErrorDetails? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolReferenceUnresolvedErrorDetails? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant145? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1Discriminator? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119Type? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant146? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1Discriminator? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119Type? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCallerDiscriminator? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolUseCallerDiscriminatorType? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelToken? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateTelemetryDestinationRequestBody? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserProfileRequestBody? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageServiceTier? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserLocation? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserDetails? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaUserProfileTrustGrant>? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileTrustGrant? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileEnrollEndUserAction? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminator? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminatorType? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionUrl? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserAccountStatus? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileExternalUserEntityType? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileListOrder? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileListOrderBy? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileTrustGrantStatus? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant147? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1Discriminator? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910CacheControlVariant1DiscriminatorType? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSources? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant148? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1Discriminator? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209CacheControlVariant1DiscriminatorType? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant149? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1Discriminator? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309CacheControlVariant1DiscriminatorType? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant150? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318CacheControlVariant1Discriminator? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318CacheControlVariant1DiscriminatorType? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318ResponseInclusion? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceAll? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceExcept? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWebFetchUrlSourceToolReference>? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceToolReference? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceNone? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceOnly? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolResults? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesClientToolResultsDiscriminator? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolResults? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminator? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInput? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminator? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminatorType? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant151? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1Discriminator? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305CacheControlVariant1DiscriminatorType? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant152? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1Discriminator? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209CacheControlVariant1DiscriminatorType? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant153? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318CacheControlVariant1Discriminator? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318CacheControlVariant1DiscriminatorType? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318ResponseInclusion? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentArchivedEventData? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentCreatedEventData? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentDeletedEventData? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookAgentUpdatedEventData? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentArchivedEventData? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentCreatedEventData? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentDeletedEventData? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentPausedEventData? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunFailedEventData? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunStartedEventData? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUnpausedEventData? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUpdatedEventData? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentArchivedEventData? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentCreatedEventData? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentDeletedEventData? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnwrapWebhookEvent? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventData? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionCreatedEventData? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionPendingEventData? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRunningEventData? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionIdledEventData? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRequiresActionEventData? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionArchivedEventData? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionDeletedEventData? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusIdledEventData? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadCreatedEventData? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadIdledEventData? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCreatedEventData? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultArchivedEventData? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultDeletedEventData? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionUpdatedEventData? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookSessionBudgetReachedEventData? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileEnforcementActionOpenedEventData? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookUserProfileEnforcementActionResolvedEventData? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminator? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminatorType? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkLeaseStateState? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BillingError? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BodyCreateSkillV1SkillsPost? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BodyCreateSkillVersionV1SkillsSkillIdVersionsPost? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTarget? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCoordinateTarget? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRefTarget? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminator? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminatorType? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabConfig? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabInput? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickConfig? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickInput? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadConfig? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadInput? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindConfig? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindInput? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputConfig? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputInput? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputValue? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextConfig? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextInput? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyConfig? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyInput? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverConfig? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverInput? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecConfig? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecInput? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyConfig? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyInput? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickConfig? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragConfig? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragInput? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickInput? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownConfig? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownInput? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpConfig? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpInput? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsConfig? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsInput? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMemberInput? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateInput? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabInput? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabInput? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageInput? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleInput? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkInput? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToInput? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotInput? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomInput? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickInput? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickInput? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickInput? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveInput? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollInput? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeInput? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitInput? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickConfig? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveConfig? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateConfig? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabConfig? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleConfig? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkConfig? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageConfig? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageFilter? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickConfig? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotConfig? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollConfig? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollDirection? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToConfig? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadCompleted? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadFailed? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadStarted? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeTabOpened? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateTabEntry? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabConfig? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolsetConfigs? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickConfig? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeConfig? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitConfig? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomConfig? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant154? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1Discriminator? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1DiscriminatorType? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlEphemeralTtl? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheCreation? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissMessagesChanged? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissModelChanged? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissPreviousMessageNotFound? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReason? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissSystemChanged? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissToolsChanged? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissUnavailable? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminator? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminatorType? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CanceledResult? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CapabilitySupport? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDelta? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Citation2? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCharLocationCitation? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponsePageLocationCitation? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseContentBlockLocationCitation? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultLocationCitation? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseSearchResultLocationCitation? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminator? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminatorType? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClaudeCodeVersionTooOldErrorDetails? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolUnion? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool5? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekContextUnavailableErrorDetails? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyDisabledErrorDetails? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyNetworkBlockedErrorDetails? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CmekKeyUnreachableErrorDetails? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionToolResultErrorCode? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant155? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522CacheControlVariant1Discriminator? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250522CacheControlVariant1DiscriminatorType? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant156? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825CacheControlVariant1Discriminator? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20250825CacheControlVariant1DiscriminatorType? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant157? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120CacheControlVariant1Discriminator? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260120CacheControlVariant1DiscriminatorType? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant158? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521CacheControlVariant1Discriminator? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CodeExecutionTool20260521CacheControlVariant1DiscriminatorType? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionBlockAmbiguousErrorDetails? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionBlockMisplacedErrorDetails? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionContentMismatchErrorDetails? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionIncompleteTurnErrorDetails? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionNothingToSummarizeErrorDetails? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionSignatureInvalidErrorDetails? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionTooManyToolReferencesErrorDetails? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionToolChangesMismatchErrorDetails? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompactionUnavailableErrorDetails? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompletionRequest? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Metadata? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompletionResponse? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionConfig? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionInput? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickConfig? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickInput? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyConfig? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyInput? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyConfig? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyInput? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickConfig? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragConfig? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragInput? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickInput? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownConfig? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownInput? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpConfig? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpInput? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMemberInput? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeInput? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveInput? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickInput? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickInput? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickInput? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollInput? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitInput? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotInput? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomInput? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickConfig? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveConfig? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickConfig? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotConfig? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollConfig? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollDirection? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolsetConfigs? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickConfig? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeConfig? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitConfig? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomConfig? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant159? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801CacheControlVariant1Discriminator? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801CacheControlVariant1DiscriminatorType? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Container2? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContainerSkill>? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerSkill? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerParams? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SkillParams>? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillParams? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContainerSkillType? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEvent? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Delta2? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextContentBlockDelta? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputJsonContentBlockDelta? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingContentBlockDelta? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SignatureContentBlockDelta? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSource? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>>? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentContentBlockSourceContentItem>? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentContentBlockSourceContentItem? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlock? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlock? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminator? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEvent? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock2? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlock? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseThinkingBlock? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseRedactedThinkingBlock? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlock? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlock? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlock? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlock? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionToolResultBlock? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionToolResultBlock? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionToolResultBlock? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolResultBlock? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseContainerUploadBlock? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEventContentBlockDiscriminator? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStartEventContentBlockDiscriminatorType? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockStopEvent? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContextManagementCapability? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParams? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant160? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParamsCacheControlVariant1Discriminator? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensParamsCacheControlVariant1DiscriminatorType? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputMessageUnion>? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnion? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OutputConfig? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Speed? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParam? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoice? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CountMessageTokensResponse? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageBatchParams? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.MessageBatchIndividualRequestParams>? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualRequestParams? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParams? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant161? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsCacheControlVariant1Discriminator? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsCacheControlVariant1DiscriminatorType? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ContainerParams, string>? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DiagnosticsParam? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsServiceTier? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateUserProfileActionUrlRequestBody? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileAction? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateUserProfileRequest? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileAccessType? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserDetailsParams? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteMessageBatchResponse? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedSkill? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedSkillVersion? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeletedUserProfile? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Diagnostics? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DirectCaller? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EffortCapability? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EffortLevel? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EnforcedSpendLimitReachedErrorDetails? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponse? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Error2? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InvalidRequestError? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PermissionError? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NotFoundError? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitError? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GatewayTimeoutError? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OverloadedError? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminator? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminatorType? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErrorType? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ErroredResult? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExpiredResult? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileDeleteResponse? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileDocumentSource? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileExpiredErrorDetails? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileImageSource? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileListResponse? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FileMetadataSchema>? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileMetadataSchema? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileNotDownloadableErrorDetails? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlock? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInputMessage? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessage? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnionDiscriminator? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnionDiscriminatorRole? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputSchema? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JsonOutputFormat? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseMessageBatch? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.MessageBatch>? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatch? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseModelInfo? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ModelInfo>? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelInfo? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsResponse? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.SkillVersion>? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillVersion? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsResponse? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Skill>? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Skill? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListUserProfilesResponse? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfile>? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfile? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant162? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818CacheControlVariant1Discriminator? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818CacheControlVariant1DiscriminatorType? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Message? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlock3>? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlock3? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopReason? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalStopDetails? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Usage? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchProcessingStatus? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCounts? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponse? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Result2? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SucceededResult? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminator? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDelta? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDeltaEvent? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageDeltaUsage? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OutputTokensDetails? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolUsage? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStartEvent? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStopEvent? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEvent? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Ping? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminator? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminatorType? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelCapabilities? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolsCapability? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingCapability? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelInfoLifecycle? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelLine? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationOnHoldErrorDetails? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PlainTextSource? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalCategory? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionOutputBlock? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionResultBlock? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestBashCodeExecutionOutputBlock>? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlock? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant163? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestBashCodeExecutionToolResultError, global::Anthropic.RequestBashCodeExecutionResultBlock>? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultError? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyEncodingInvalidErrorDetails? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyEncodingUnsupportedErrorDetails? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBodyTooLargeAfterDecodingErrorDetails? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlock? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant164? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockCacheControlVariant1Discriminator? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockCacheControlVariant1DiscriminatorType? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item2>? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StateChangesVariant1Item2? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminator? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BrowserStateTabEntry>? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCharLocationCitation? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCitationsConfig? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionOutputBlock? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionResultBlock? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestCodeExecutionOutputBlock>? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlock? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant165? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestCodeExecutionToolResultError, global::Anthropic.RequestCodeExecutionResultBlock, global::Anthropic.RequestEncryptedCodeExecutionResultBlock>? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultError? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestEncryptedCodeExecutionResultBlock? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlock? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant166? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlockCacheControlVariant1Discriminator? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlockCacheControlVariant1DiscriminatorType? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestContentBlockLocationCitation? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlock? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant167? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockCacheControlVariant1Discriminator? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockCacheControlVariant1DiscriminatorType? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source4? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLPDFSource? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminator? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminatorType? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant168? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockCacheControlVariant1Discriminator? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockCacheControlVariant1DiscriminatorType? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source5? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLImageSource? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminator? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminatorType? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageTransformations? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageTransformationsOversizedImage? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestPageLocationCitation? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestRedactedThinkingBlock? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlock? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant169? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlockCacheControlVariant1Discriminator? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlockCacheControlVariant1DiscriminatorType? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultLocationCitation? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlock? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant170? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCacheControlVariant1Discriminator? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCacheControlVariant1DiscriminatorType? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller9? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolCaller? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolCaller20260120? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCallerDiscriminator? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockCallerDiscriminatorType? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlockName? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant171? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCacheControlVariant1Discriminator? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCacheControlVariant1DiscriminatorType? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item3>? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item3? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchResultLocationCitation? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminator? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationsVariant1ItemDiscriminatorType? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant172? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1Discriminator? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultError? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditorCodeExecutionToolResultErrorCode? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionViewResultBlockFileType? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestThinkingBlock? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlock? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant173? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlockCacheControlVariant1Discriminator? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlockCacheControlVariant1DiscriminatorType? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlock? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant174? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockCacheControlVariant1Discriminator? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockCacheControlVariant1DiscriminatorType? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>>? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item2>? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentVariant2Item2? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminator? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlock? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant175? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1Discriminator? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestToolSearchToolResultError, global::Anthropic.RequestToolSearchToolSearchResultBlock>? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultError? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolSearchToolSearchResultBlock? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolResultErrorCode? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestToolReferenceBlock>? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlock? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant176? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCacheControlVariant1Discriminator? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCacheControlVariant1DiscriminatorType? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller10? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCallerDiscriminator? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolUseBlockCallerDiscriminatorType? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchResultBlock? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlock? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant177? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1Discriminator? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller11? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminator? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlockCallerDiscriminatorType? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.RequestWebFetchToolResultError, global::Anthropic.RequestWebFetchResultBlock>? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultError? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchToolResultErrorCode? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchResultBlock? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlock? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant178? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1Discriminator? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller12? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminator? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlockCallerDiscriminatorType? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.RequestWebSearchToolResultError>? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultError? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchToolResultErrorCode? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionOutputBlock? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionResultBlock? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseBashCodeExecutionOutputBlock>? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseBashCodeExecutionToolResultError, global::Anthropic.ResponseBashCodeExecutionResultBlock>? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBashCodeExecutionToolResultError? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserCloseTabToolUseBlock? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCaller? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFileUploadToolUseBlock? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFindToolUseBlock? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFormInputToolUseBlock? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoverToolUseBlock? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserKeyToolUseBlock? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickToolUseBlock? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserListTabsToolUseBlock? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNavigateToolUseBlock? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNewTabToolUseBlock? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadPageToolUseBlock? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserRightClickToolUseBlock? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScreenshotToolUseBlock? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToToolUseBlock? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToolUseBlock? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlock? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnion? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserZoomToolUseBlock? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTripleClickToolUseBlock? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTypeToolUseBlock? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserWaitToolUseBlock? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminator? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCitationsConfig? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionOutputBlock? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionResultBlock? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseCodeExecutionOutputBlock>? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseCodeExecutionToolResultError? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseEncryptedCodeExecutionResultBlock? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerCursorPositionToolUseBlock? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerDoubleClickToolUseBlock? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerHoldKeyToolUseBlock? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerKeyToolUseBlock? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickToolUseBlock? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMiddleClickToolUseBlock? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMouseMoveToolUseBlock? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerRightClickToolUseBlock? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScreenshotToolUseBlock? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScrollToolUseBlock? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlock? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnion? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTypeToolUseBlock? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTripleClickToolUseBlock? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerWaitToolUseBlock? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerZoomToolUseBlock? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminator? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlock? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source6? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminator? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminatorType? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller13? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockCallerDiscriminator? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockCallerDiscriminatorType? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseServerToolUseBlockName? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsVariant1Item4>? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CitationsVariant1Item4? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminator? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionToolResultError? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlockFileType? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolReferenceBlock? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolResultError? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolSearchToolSearchResultBlock? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseToolReferenceBlock>? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller14? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockCallerDiscriminator? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockCallerDiscriminatorType? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlockUnion? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchResultBlock? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller15? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminator? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultBlockCallerDiscriminatorType? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebFetchToolResultError, global::Anthropic.ResponseWebFetchResultBlock>? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebFetchToolResultError? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultBlock? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Caller16? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminator? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultBlockCallerDiscriminatorType? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>>? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseWebSearchToolResultError? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ResponseWebSearchResultBlock>? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillSource? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillParamsType? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillReadBlockedUndecryptableErrorDetails? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SkillSourceType? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StorageQuotaExceededErrorDetails? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem2>>? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ContentBlocksItem2>? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlocksItem2? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessageContentBlockDiscriminator? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessageContentBlockDiscriminatorType? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant179? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124CacheControlVariant1Discriminator? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124CacheControlVariant1DiscriminatorType? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant180? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429CacheControlVariant1Discriminator? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429CacheControlVariant1DiscriminatorType? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant181? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728CacheControlVariant1Discriminator? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728CacheControlVariant1DiscriminatorType? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingTypes? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigAdaptive? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingDisplayMode? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigBetweenTools? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigDisabled? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigEnabled? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant182? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolCacheControlVariant1Discriminator? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolCacheControlVariant1DiscriminatorType? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceAny? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceAuto? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceNone? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceTool? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolNameConflictErrorDetails? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolReferenceUnresolvedErrorDetails? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant183? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1Discriminator? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolBM2520251119Type? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant184? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1Discriminator? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119CacheControlVariant1DiscriminatorType? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolSearchToolRegex20251119Type? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCallerDiscriminator? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolUseCallerDiscriminatorType? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserProfileRequestBody? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UsageServiceTier? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserLocation? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserDetails? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementStatus? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementAction>? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementAction? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfilePrograms? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnrollEndUserAction? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionDiscriminator? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionDiscriminatorType? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileActionUrl? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberProgram? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileProgramStatus? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileCyberTier>? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberTier? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberRequirements? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileCyberTierStatus? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsFeature? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsFeatureStatus? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEfsProgram? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileEfsFeature>? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionRestriction? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionBan? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionDiscriminator? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionDiscriminatorType? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionReason? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionNextStep? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserAccountStatus? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileExternalUserEntityType? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileListOrder? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileListOrderBy? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant185? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910CacheControlVariant1Discriminator? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20250910CacheControlVariant1DiscriminatorType? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSources? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant186? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209CacheControlVariant1Discriminator? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260209CacheControlVariant1DiscriminatorType? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant187? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309CacheControlVariant1Discriminator? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260309CacheControlVariant1DiscriminatorType? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant188? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318CacheControlVariant1Discriminator? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318CacheControlVariant1DiscriminatorType? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchTool20260318ResponseInclusion? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceAll? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceExcept? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WebFetchUrlSourceToolReference>? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceToolReference? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceNone? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceOnly? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ClientToolResults2? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesClientToolResultsDiscriminator? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesClientToolResultsDiscriminatorType? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServerToolResults2? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminator? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminatorType? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInput2? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminator? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminatorType? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant189? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305CacheControlVariant1Discriminator? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20250305CacheControlVariant1DiscriminatorType? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant190? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209CacheControlVariant1Discriminator? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260209CacheControlVariant1DiscriminatorType? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant191? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318CacheControlVariant1Discriminator? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318CacheControlVariant1DiscriminatorType? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebSearchTool20260318ResponseInclusion? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddFederationRuleWorkspaceParams? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberParams? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllConnectorsPermissionResource? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllowedInferenceGeo? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAlreadyMemberErrorDetails? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsActivitySummaryResponse? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSingleDayActivitySummary>? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSingleDayActivitySummary? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsActorType? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsApiActor? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactActivity? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsArtifactsResponse? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsArtifactActivity>? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedChatMetrics? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedMetrics? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatCoworkUnifiedSessionsMetrics? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsChatMetrics? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeCodeMetrics? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCoreCodeMetrics? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsToolActions? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsClaudeTagCategory? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorActivity? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedMetrics? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatMetrics? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorClaudeCodeMetrics? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorCoworkMetrics? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorOfficeMetrics? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorOfficeProductMetrics? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsConnectorsResponse? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsConnectorActivity>? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsLinesOfCode? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResponse? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostReportTimeBucket>? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostReportTimeBucket? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResult? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportContextWindow? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostType? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceGeo? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostBucketedResultSpeed? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTokenType? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostGroupBy? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostBucketedResult>? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItem? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserActor? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemActorDiscriminator? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemActorDiscriminatorType? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersItemSpeed? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersOrderBy? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCostUsersResponse? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostUsersItem>? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsCoworkMetrics? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsDesignMetrics? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActor? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProvider? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminator? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminatorType? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostGroup? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActor? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostCostType? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostInferenceGeo? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageReportServiceTier? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSpeed? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostItem? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostMetrics? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostOrderBy? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatCostResponse? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsFlatCostItem>? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatGroup? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageItem? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageMetrics? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServerToolUse? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageOrderBy? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFlatUsageResponse? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsFlatUsageItem>? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOfficeMetrics? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsOfficeProductMetrics? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginActivity? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginChatCoworkUnifiedMetrics? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginClaudeCodeMetrics? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginCoworkMetrics? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsPluginsResponse? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsPluginActivity>? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProductFilter? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectActivity? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUser? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsProjectsResponse? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProjectActivity>? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportUserActor? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsServiceAccountActor? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActorDiscriminator? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActorDiscriminatorType? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsScienceMetrics? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillActivity? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedMetrics? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatMetrics? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillClaudeCodeMetrics? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillCoworkMetrics? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillOfficeMetrics? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillActivityShareStatus? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedChatMetrics? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillOfficeProductMetrics? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSkillsResponse? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSkillActivity>? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsSortOrder? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsTimeBucketWidth? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsToolActionCounts? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResponse? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageReportTimeBucket>? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageReportTimeBucket? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResult? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageBucketedResultSpeed? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostProductFilter? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageCostSortOrder? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageGroupBy? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageBucketedResult>? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItem? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemActorDiscriminator? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemActorDiscriminatorType? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersItemSpeed? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersOrderBy? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsageUsersResponse? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageUsersItem>? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUserActivity? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsUsersResponse? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUserActivity>? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKey? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatedBy? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PrincipalVariant1? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUserActor? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyServiceAccountActor? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1Discriminator? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1DiscriminatorType? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyOrganizationScope? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyWorkspaceScope? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminator? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminatorType? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyStatus? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUpdateParams? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUpdateParamsStatus? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApprovalMetrics? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestParams? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitPeriod? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponse? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserActorSchema? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScopedApiKeyActorSchema? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminator? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResolvedByVariant1? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1Discriminator? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1DiscriminatorType? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimit? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummary? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestStatus? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAttachedAttachment? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAwsExternalKeyConfig? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfig? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfigParams? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBillingFrozenErrorDetails? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotInviteEmailsWithUnverifiedDomainsErrorDetails? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCannotRemoveLastMemberErrorDetails? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeApiActor? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItem? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor2? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUserActor? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminator? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminatorType? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCoreMetrics? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCustomerType? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelBreakdown>? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelBreakdown? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSubscriptionType? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaApprovalMetrics>? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeEnterpriseOrganizationRole? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettings? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsState? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabled? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabled? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDiscriminator? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDiscriminatorType? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabledParams? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabledParams? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParams? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParamsDiscriminator? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateParamsDiscriminatorType? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsUpdateParams? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConcurrentMembershipChangeErrorDetails? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorPermissionResource? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorScopePermissionResource? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorToolPermissionResource? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaLinesOfCode? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportGroupBy? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportItem? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostType? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportServiceTier? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInferenceGeoFilter? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTimeBucket? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportItem>? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCostReportTimeBucketWidth? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteParams? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteParamsRole? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateRbacGroupParams? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateTunnelCertificateParams? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberParams? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNoBillingWorkspaceRoleSchema? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatedByType? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidency? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>, string>? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceGeo? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidencyCreateParams? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDataResidencyUpdateParams? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteExternalKeyResponse? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteInviteResponse? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupMemberResponse? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupResponse? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitResponse? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteUserResponse? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteWorkspaceMemberResponse? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletedOrganizationWebhookEndpoint? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDenySpendLimitIncreaseRequestParams? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEmailDomainNotAllowedErrorDetails? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaEstimatedCost? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKey? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Attachment? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnattachedAttachment? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminator? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminatorType? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpExternalKeyConfig? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderConfigDiscriminator? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyProviderConfigDiscriminatorType? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyChangedErrorDetails? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParams? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig2? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminator? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminatorType? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyListResponse? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaExternalKey>? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParams? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfigVariant1? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParamsProviderConfigVariant1Discriminator? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuer? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksDiscovery? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksExplicitUrl? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksInline? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerJwksDiscriminator? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerJwksDiscriminatorType? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIssuerPollStatus? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParams? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks2? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminator? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminatorType? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerListResponse? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationIssuer>? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParams? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksVariant1? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1Discriminator? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRule? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRuleMatch? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountTarget? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleCreateParams? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleListResponse? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationRule>? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleUpdateParams? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleWorkspace? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleWorkspaceListResponse? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaFederationRuleWorkspace>? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetClaudeCodeUsageReportResponse? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeUsageReportItem>? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportResponse? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportTimeBucket>? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetMessagesUsageReportResponse? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportTimeBucket>? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportTimeBucket? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteAlreadyExistsErrorDetails? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteSchema? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationRoleSchema? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInviteStatusSchema? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsResponse? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendSummary>? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseApiKey? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaApiKey>? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseInviteSchema? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInviteSchema>? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseUser? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUser>? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUser? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseWorkspaceMemberSchema? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceMemberSchema>? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceMemberSchema? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListResponseWorkspace? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspace>? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspace? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsResponse? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimit>? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportGroupBy? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportItem? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportItem>? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTokenUsage? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNewOrganizationWebhookEndpoint? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent>? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointState? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgApiKeyLimitExceededErrorDetails? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgMemberLimitExceededErrorDetails? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgServiceScope? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationPermissionResource? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationSchema? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationScope? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTypeNotSupportedErrorDetails? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpoint? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent>? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointList? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationWebhookEndpoint>? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationWebhookEndpointSigningSecret? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPlugin? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginComponent>? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginComponent? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScan? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByVariant1? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginUserActor? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginApiActor? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1Discriminator? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1DiscriminatorType? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOrganizationInstallationPreference? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Owner? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerOrganization? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerUser? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminator? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminatorType? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginReach? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginComponentType? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScanAssessment? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginContentScanStatus? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginDeleted? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSetting? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingInstallationPreference? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganization? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetRbacGroup? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganizationMember? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingTargetDiscriminator? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingTargetDiscriminatorType? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeleted? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target2? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminator? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminatorType? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginInstallationSettingList? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginInstallationSetting>? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginList? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPlugin>? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplace? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Owner2? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceOwnerDiscriminator? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceOwnerDiscriminatorType? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceSource? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceSyncStatus? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceList? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplace>? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginError? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginWarning? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning>? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginMarketplaceValidationReport? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginError>? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings>? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginNameTakenErrorDetails? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShare? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Target3? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminator? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminatorType? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareList? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginShare>? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersion? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByVariant12? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionCreatedByVariant1Discriminator? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionCreatedByVariant1DiscriminatorType? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionReach? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginVersionList? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaPluginVersion>? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimit? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitModelGroup? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitBatchGroup? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitTokenCountGroup? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitFilesGroup? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitSkillsGroup? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitWebSearchGroup? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupDiscriminator? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitGroupDiscriminatorType? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimitValue>? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitValue? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitListResponse? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimit>? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroup? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupSourceType? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupList? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacGroup>? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupMember? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupMemberList? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacGroupMember>? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupScope? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRole? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleList? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacRole>? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermission? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Resource? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminator? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionList? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaRbacRolePermission>? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRegistrationPendingErrorDetails? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveFederationRuleWorkspaceResponse? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRoleSchema? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRotateTunnelTokenParams? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScanFailedErrorDetails? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScanPendingErrorDetails? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSeatTierScope? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccount? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountOrganizationRole? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountCreateParams? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountCreateParamsOrganizationRole? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountListResponse? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaServiceAccount>? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountUpdateParams? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountUpdateParamsOrganizationRole? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMember? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRoleSchema? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberCreateFromSAParams? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberCreateParams? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberDeleteResponse? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberListResponse? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaServiceAccountWorkspaceMember>? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountWorkspaceMemberUpdateParams? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParams? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope2? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserScope? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceScope? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminator? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminatorType? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSkillNameTakenErrorDetails? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope3? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUsageTierScope? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminator? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminatorType? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestListResponse? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchema? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor3? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchemaActorDiscriminator? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchemaActorDiscriminatorType? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResolvedByVariant12? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1Discriminator? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Actor4? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryActorDiscriminator? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryActorDiscriminatorType? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope4? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryScopeDiscriminator? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummaryScopeDiscriminatorType? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source7? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummarySourceDiscriminator? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendSummarySourceDiscriminatorType? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnel? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnelCertificate? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelCertificateListResponse? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationTunnelCertificate>? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTunnelListResponse? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationTunnel>? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationTunnelToken? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnsupportedCharsetErrorDetails? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateRbacGroupParams? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserParams? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateUserParamsRole? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberParams? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyResponse? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidateExternalKeyResponseStatus? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceApiKeyLimitExceededErrorDetails? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceCreateParams? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceMemberLimitExceededErrorDetails? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimit? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group2? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminator? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminatorType? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitValue>? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValue? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitListResponse? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimit>? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateParams? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitUpdateValue>? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateValue? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitUpdateValueType? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source8? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminator? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminatorType? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceUpdateParams? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AddFederationRuleWorkspaceParams? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AllowedInferenceGeo? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AlreadyMemberErrorDetails? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKey? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedBy? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PrincipalVariant12? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUserActor? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyServiceAccountActor? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1Discriminator? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1DiscriminatorType? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Scope5? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyOrganizationScope? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyWorkspaceScope? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminator? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminatorType? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyStatus? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUpdateParams? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUpdateParamsStatus? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AttachedAttachment? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AwsExternalKeyConfig? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfig? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfigParams? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CannotInviteEmailsWithUnverifiedDomainsErrorDetails? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CannotRemoveLastMemberErrorDetails? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettings? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsState? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabled? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabled? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminator? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminatorType? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabledParams? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabledParams? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParams? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminator? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminatorType? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsUpdateParams? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConcurrentMembershipChangeErrorDetails? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteParams? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteParamsRole? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberParams? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.NoBillingWorkspaceRoleSchema? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreatedByType? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidency? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>, string>? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InferenceGeo? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceGeo? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidencyCreateParams? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DataResidencyUpdateParams? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteExternalKeyResponse? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteInviteResponse? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteUserResponse? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteWorkspaceMemberResponse? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.EmailDomainNotAllowedErrorDetails? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKey? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Attachment2? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnattachedAttachment? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminator? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminatorType? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig3? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GcpExternalKeyConfig? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyProviderConfigDiscriminator? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyProviderConfigDiscriminatorType? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyChangedErrorDetails? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParams? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfig4? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminator? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminatorType? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyListResponse? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ExternalKey>? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParams? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ProviderConfigVariant12? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1Discriminator? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuer? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks3? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksDiscovery? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksExplicitUrl? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksInline? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerJwksDiscriminator? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerJwksDiscriminatorType? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.IssuerPollStatus? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParams? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Jwks4? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminator? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminatorType? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerListResponse? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationIssuer>? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParams? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksVariant12? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParamsJwksVariant1Discriminator? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerUpdateParamsJwksVariant1DiscriminatorType? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRule? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RuleMatch? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountTarget? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleCreateParams? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleListResponse? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationRule>? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleUpdateParams? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleWorkspace? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationRuleWorkspaceListResponse? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.FederationRuleWorkspace>? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteAlreadyExistsErrorDetails? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteSchema? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationRoleSchema? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InviteStatusSchema? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseApiKey? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ApiKey>? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseInviteSchema? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InviteSchema>? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseUser? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.User>? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.User? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseWorkspaceMemberSchema? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceMemberSchema>? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceMemberSchema? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListResponseWorkspace? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Workspace>? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Workspace? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgApiKeyLimitExceededErrorDetails? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgMemberLimitExceededErrorDetails? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationSchema? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimit? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group3? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitModelGroup? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitBatchGroup? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitTokenCountGroup? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitFilesGroup? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitSkillsGroup? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitWebSearchGroup? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupDiscriminator? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitGroupDiscriminatorType? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RateLimitValue>? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitValue? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitListResponse? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.RateLimit>? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveFederationRuleWorkspaceResponse? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccount? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountOrganizationRole? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountCreateParams? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountCreateParamsOrganizationRole? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountListResponse? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ServiceAccount>? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountUpdateParams? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountUpdateParamsOrganizationRole? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMember? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRoleSchema? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberCreateFromSAParams? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberCreateParams? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberDeleteResponse? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberListResponse? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ServiceAccountWorkspaceMember>? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ServiceAccountWorkspaceMemberUpdateParams? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserParams? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateUserParamsRole? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberParams? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyResponse? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ValidateExternalKeyResponseStatus? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceApiKeyLimitExceededErrorDetails? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceCreateParams? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceMemberLimitExceededErrorDetails? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimit? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Group4? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminator? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminatorType? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimitValue>? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValue? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitListResponse? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimit>? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitOrganizationSource? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateParams? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.WorkspaceRateLimitUpdateValue>? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateValue? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitUpdateValueType? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Source9? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitWorkspaceSource? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValueSourceDiscriminator? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitValueSourceDiscriminatorType? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceUpdateParams? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsConflictError? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminator? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminatorType? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminator? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminatorType? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsWithoutStream? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlVariant192? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsWithoutStreamCacheControlVariant1Discriminator? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsWithoutStreamCacheControlVariant1DiscriminatorType? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateMessageParamsWithoutStreamServiceTier? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnthropicBeta? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnthropicBetaEnum? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminator? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminatorType? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminator? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminatorType? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminator? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminatorType? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminator? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminatorType? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminator? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminatorType? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminator? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminatorType? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminator? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminatorType? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminator? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminatorType? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEventType? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401BashInput? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401ReadInput? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401WriteInput? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401EditInput? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401GlobInput? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401GrepInput? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageVariant1Item? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminator? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminatorType? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.PingType? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostRequest? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostRequest? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostRequest? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostRequest? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceRepositoryV1OrganizationsPluginMarketplacesValidateRepositoryPostRequest? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetPluginInstallationSettingV1OrganizationsPluginsPluginIdInstallationSettingsTargetPostRequest? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequest? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequest? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent>? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequest? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent>? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ModelsListLifecycleItem>? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListLifecycleItem? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaModelsListLifecycleItem>? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListLifecycleItem? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementStatus>? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionStatus>? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEventType>? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadStatus>? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaDreamStatus>? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse>? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListApiKeysV1OrganizationsApiKeysGetStatus? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportGroupBy>? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item>? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSpendLimitIncreaseRequestStatus>? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginsV1OrganizationsPluginsGetOwnerType? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetOwnerType? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsProductFilter>? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsClaudeTagCategory>? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetBucketWidth? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item>? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetBucketWidth? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item>? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetBucketWidth? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item>? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item>? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item>? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item>? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSpeed>? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsActorType>? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageGroupBy>? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsCostGroupBy>? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item>? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item>? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item>? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillsV1OrganizationsAnalyticsSkillsGetOrder? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item>? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item>? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item>? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse>? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatus? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse2? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError2? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse3? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError3? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse4? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError4? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse5? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError5? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponse6? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesPostResponseError6? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompletePostResponse? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CompletePostResponseError? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails>? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListResponse? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsListResponseError? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsGetResponse? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ModelsGetResponseError? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponse? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponseError? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.CmekKeyDisabledErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails>? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponse2? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesPostResponseError2? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesListResponse? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesListResponseError? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesRetrieveResponse? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesRetrieveResponseError? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesDeleteResponse? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesDeleteResponseError? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesCancelResponse? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesCancelResponseError? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesResultsResponse? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessageBatchesResultsResponseError? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse2? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError2? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse3? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError3? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponse4? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MessagesCountTokensPostResponseError4? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostResponse? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UploadFileV1FilesPostResponseError? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListFilesV1FilesGetResponse? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListFilesV1FilesGetResponseError? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetFileMetadataV1FilesFileIdGetResponse? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetFileMetadataV1FilesFileIdGetResponseError? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteFileV1FilesFileIdDeleteResponse? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteFileV1FilesFileIdDeleteResponseError? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponse? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponseError? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponse2? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DownloadFileV1FilesFileIdContentGetResponseError2? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponse? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponseError? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponse2? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillV1SkillsPostResponseError2? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsV1SkillsGetResponse? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillsV1SkillsGetResponseError? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillV1SkillsSkillIdGetResponse? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillV1SkillsSkillIdGetResponseError? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillV1SkillsSkillIdDeleteResponse? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillV1SkillsSkillIdDeleteResponseError? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponse? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponseError? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponse2? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateSkillVersionV1SkillsSkillIdVersionsPostResponseError2? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsV1SkillsSkillIdVersionsGetResponse? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ListSkillVersionsV1SkillsSkillIdVersionsGetResponseError? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillVersionV1SkillsSkillIdVersionsVersionGetResponse? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GetSkillVersionV1SkillsSkillIdVersionsVersionGetResponseError? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponse? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.DeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponseError? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse2? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError2? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse3? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError3? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse4? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError4? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse5? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError5? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponse6? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesPostResponseError6? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListResponse? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsListResponseError? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails>? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsGetResponse? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaModelsGetResponseError? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponse? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponseError? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponse2? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesPostResponseError2? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesListResponse? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesListResponseError? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesRetrieveResponse? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesRetrieveResponseError? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesDeleteResponse? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesDeleteResponseError? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesCancelResponse? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesCancelResponseError? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesResultsResponse? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessageBatchesResultsResponseError? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse2? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError2? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse3? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError3? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponse4? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMessagesCountTokensPostResponseError4? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostResponse? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUploadFileV1FilesPostResponseError? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListFilesV1FilesGetResponse? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListFilesV1FilesGetResponseError? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetFileMetadataV1FilesFileIdGetResponse? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetFileMetadataV1FilesFileIdGetResponseError? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteFileV1FilesFileIdDeleteResponse? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteFileV1FilesFileIdDeleteResponseError? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponse? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponseError? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponse2? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDownloadFileV1FilesFileIdContentGetResponseError2? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponse? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponseError? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponse2? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillV1SkillsPostResponseError2? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsV1SkillsGetResponse? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillsV1SkillsGetResponseError? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponse? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponseError? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillV1SkillsSkillIdDeleteResponse? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillV1SkillsSkillIdDeleteResponseError? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseError? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponse2? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateSkillVersionV1SkillsSkillIdVersionsPostResponseError2? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsV1SkillsSkillIdVersionsGetResponse? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSkillVersionsV1SkillsSkillIdVersionsGetResponseError? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillVersionV1SkillsSkillIdVersionsVersionGetResponse? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSkillVersionV1SkillsSkillIdVersionsVersionGetResponseError? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponse? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSkillVersionV1SkillsSkillIdVersionsVersionDeleteResponseError? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponse? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponseError? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponse2? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateEnvironmentV1EnvironmentsPostResponseError2? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEnvironmentsV1EnvironmentsGetResponse? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEnvironmentsV1EnvironmentsGetResponseError? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponseError? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponse? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponseError? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponse2? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostResponseError2? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteResponse? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteResponseError? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveEnvironmentV1EnvironmentsEnvironmentIdArchivePostResponse? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaArchiveEnvironmentV1EnvironmentsEnvironmentIdArchivePostResponseError? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentStatsV1EnvironmentsEnvironmentIdWorkStatsGetResponse? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetEnvironmentStatsV1EnvironmentsEnvironmentIdWorkStatsGetResponseError? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRecordHeartbeatV1EnvironmentsEnvironmentIdWorkWorkIdHeartbeatPostResponse? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRecordHeartbeatV1EnvironmentsEnvironmentIdWorkWorkIdHeartbeatPostResponseError? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopWorkV1EnvironmentsEnvironmentIdWorkWorkIdStopPostResponse? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopWorkV1EnvironmentsEnvironmentIdWorkWorkIdStopPostResponseError? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkV1EnvironmentsEnvironmentIdWorkWorkIdGetResponse? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetWorkV1EnvironmentsEnvironmentIdWorkWorkIdGetResponseError? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkV1EnvironmentsEnvironmentIdWorkWorkIdPostResponse? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkV1EnvironmentsEnvironmentIdWorkWorkIdPostResponseError? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponse? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateInviteV1OrganizationsInvitesPostResponseError? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponse2? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveUserV1OrganizationsUsersUserIdDeleteResponseError2? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponse? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceV1OrganizationsWorkspacesPostResponseError? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaOrgApiKeyLimitExceededErrorDetails, global::Anthropic.BetaWorkspaceApiKeyLimitExceededErrorDetails>? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponse? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetResponseError? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetResponse? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetResponseError? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitV1OrganizationsSpendLimitsPostResponse? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitV1OrganizationsSpendLimitsPostResponseError? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaBillingFrozenErrorDetails, global::Anthropic.BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails>? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSpendLimitV1OrganizationsSpendLimitsSpendLimitIdGetResponse? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetSpendLimitV1OrganizationsSpendLimitsSpendLimitIdGetResponseError? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteResponse? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteSpendLimitV1OrganizationsSpendLimitsSpendLimitIdDeleteResponseError? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponse? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeleteRbacGroupV1OrganizationsRbacGroupsGroupIdDeleteResponseError? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails>? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponse? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRemoveRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersUserIdDeleteResponseError? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponse? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAddRbacGroupMemberV1OrganizationsRbacGroupsGroupIdMembersPostResponseError? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails, global::Anthropic.BetaUnsupportedCharsetErrorDetails>? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse2? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError2? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaPluginNameTakenErrorDetails, global::Anthropic.BetaSkillNameTakenErrorDetails>? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponse3? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginV1OrganizationsPluginsPostResponseError3? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails, global::Anthropic.BetaScanFailedErrorDetails>? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponse2? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUpdatePluginV1OrganizationsPluginsPluginIdPostResponseError2? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaScanPendingErrorDetails, global::Anthropic.BetaSkillNameTakenErrorDetails>? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponse? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDeletePluginV1OrganizationsPluginsPluginIdDeleteResponseError? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse2? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError2? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponse3? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreatePluginVersionV1OrganizationsPluginsPluginIdVersionsPostResponseError3? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponse? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGetPluginVersionContentV1OrganizationsPluginsPluginIdVersionsVersionContentGetResponseError? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.BetaCmekKeyDisabledErrorDetails, global::Anthropic.BetaCmekKeyNetworkBlockedErrorDetails>? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponseError? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponse? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateInviteV1OrganizationsInvitesPostResponseError? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponse2? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RemoveUserV1OrganizationsUsersUserIdDeleteResponseError2? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponse? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponse? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceV1OrganizationsWorkspacesPostResponseError? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponse? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersUserIdPostResponseError? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponse? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CreateWorkspaceMemberV1OrganizationsWorkspacesWorkspaceIdMembersPostResponseError? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponse? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UpdateApiKeyV1OrganizationsApiKeysApiKeyIdPostResponseError? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.OrgApiKeyLimitExceededErrorDetails, global::Anthropic.WorkspaceApiKeyLimitExceededErrorDetails>? Type3704 { get; set; }

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
        public global::System.Collections.Generic.List<global::Anthropic.BetaDream>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessageBatch>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelInfo>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkillVersion>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSkill>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTelemetryDestinationWorkspace>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTelemetryDestination>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTunnelCertificate>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaTunnel>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUserProfile>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMCPTool>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentTool>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPServer>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSkill>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentMessageContentBlock>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsUserContentBlock>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolConfigUnion>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParams>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentToolParams>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPServerParams>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSkillParams>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParams>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResourceParams>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionInitialEventParams>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.DateTime>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResourceConfig>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSystemContentBlock>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgent>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsCredential>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeploymentRun>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsDeployment>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryListItem>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryStore>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMemoryVersion>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionEvent>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionResource>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThread>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSession>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsVault>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPToolConfig>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMCPToolConfigParams>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentRosterEntry>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsAgentReference>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSearchResultContent>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsInputEvent>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsEventParams>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsOutcomeEvaluationResource>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionRosterEntry>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsWorkflowRunPhase>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaContentBlock>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInputTransformation>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaIterationsUsageVariant1Item>? ListType87 { get; set; }
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
        public global::System.Collections.Generic.List<global::Anthropic.BetaWebFetchUrlSourceToolReference>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContainerSkill>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SkillParams>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentContentBlockSourceContentItem>>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentContentBlockSourceContentItem>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InputMessageUnion>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.RequestTextBlock>>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestTextBlock>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.MessageBatchIndividualRequestParams>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FileMetadataSchema>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InputContentBlock>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.MessageBatch>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ModelInfo>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.SkillVersion>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.Skill>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfile>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlock3>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestBashCodeExecutionOutputBlock>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.StateChangesVariant1Item2>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BrowserStateTabEntry>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestCodeExecutionOutputBlock>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item3>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentVariant2Item2>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestToolReferenceBlock>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.RequestWebSearchToolResultError>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseBashCodeExecutionOutputBlock>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseCodeExecutionOutputBlock>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.CitationsVariant1Item4>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseToolReferenceBlock>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::Anthropic.ResponseWebSearchToolResultError, global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ResponseWebSearchResultBlock>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem2>>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ContentBlocksItem2>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfileEnforcementAction>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WebFetchUrlSourceToolReference>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSingleDayActivitySummary>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsArtifactActivity>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsConnectorActivity>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostReportTimeBucket>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostBucketedResult>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostUsersItem>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsFlatCostItem>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsFlatUsageItem>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsPluginActivity>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProjectActivity>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSkillActivity>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageReportTimeBucket>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageBucketedResult>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageUsersItem>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUserActivity>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelBreakdown>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportItem>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.BetaAllowedInferenceGeo>, string>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAllowedInferenceGeo>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaExternalKey>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationIssuer>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationRule>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaFederationRuleWorkspace>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaClaudeCodeUsageReportItem>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportTimeBucket>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportTimeBucket>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendSummary>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaApiKey>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInviteSchema>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUser>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceMemberSchema>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspace>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimit>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportItem>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaNewOrganizationWebhookEndpointEnabledEvent>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationWebhookEndpointEnabledEvent>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationWebhookEndpoint>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginComponent>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginInstallationSetting>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPlugin>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplace>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginError>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginShare>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaPluginVersion>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRateLimitValue>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRateLimit>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacGroup>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacGroupMember>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacRole>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaRbacRolePermission>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaServiceAccount>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaServiceAccountWorkspaceMember>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitIncreaseRequestSchema>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationTunnelCertificate>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaOrganizationTunnel>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimitValue>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimit>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaWorkspaceRateLimitUpdateValue>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.AllowedInferenceGeo>, string>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AllowedInferenceGeo>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ExternalKey>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationIssuer>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationRule>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.FederationRuleWorkspace>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ApiKey>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.InviteSchema>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.User>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceMemberSchema>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.Workspace>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RateLimitValue>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.RateLimit>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ServiceAccount>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ServiceAccountWorkspaceMember>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimitValue>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimit>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.WorkspaceRateLimitUpdateValue>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestEnabledEvent>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.AnthropicBeta>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ModelsListLifecycleItem>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaModelsListLifecycleItem>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.UserProfileEnforcementStatus>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionStatus>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionEventType>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsEventDeltaType>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaManagedAgentsSessionThreadStatus>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaDreamStatus>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListInvitesV1OrganizationsInvitesGetStatuse>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaUsageReportServiceTier>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportContextWindow>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaInferenceGeoFilter>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpeed>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaMessagesUsageReportGroupBy>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaCostReportGroupBy>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaSpendLimitIncreaseRequestStatus>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsProductFilter>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetSpeedsVariant1Item>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsClaudeTagCategory>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserUsageReportV1OrganizationsAnalyticsUserUsageReportGetGroupByVariant1Item>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetSpeedsVariant1Item>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUserCostReportV1OrganizationsAnalyticsUserCostReportGetGroupByVariant1Item>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetSpeedsVariant1Item>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsageReportV1OrganizationsAnalyticsUsageReportGetGroupByVariant1Item>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetSpeedsVariant1Item>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetGroupByVariant1Item>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageCostProductFilter>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsSpeed>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsActorType>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsUsageGroupBy>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaAnalyticsCostGroupBy>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetGroupByVariant1Item>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetGroupByVariant1Item>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetSkillsV1OrganizationsAnalyticsSkillsGetGroupByVariant1Item>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse>? ListType270 { get; set; }
    }
}