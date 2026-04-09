#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentBlock : global::System.IEquatable<ContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseTextBlock? Text { get; init; }
#else
        public global::Anthropic.BetaResponseTextBlock? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseThinkingBlock? Thinking { get; init; }
#else
        public global::Anthropic.BetaResponseThinkingBlock? Thinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseRedactedThinkingBlock? RedactedThinking { get; init; }
#else
        public global::Anthropic.BetaResponseRedactedThinkingBlock? RedactedThinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RedactedThinking))]
#endif
        public bool IsRedactedThinking => RedactedThinking != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseToolUseBlock? ToolUse { get; init; }
#else
        public global::Anthropic.BetaResponseToolUseBlock? ToolUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolUse))]
#endif
        public bool IsToolUse => ToolUse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseServerToolUseBlock? ServerToolUse { get; init; }
#else
        public global::Anthropic.BetaResponseServerToolUseBlock? ServerToolUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServerToolUse))]
#endif
        public bool IsServerToolUse => ServerToolUse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseWebSearchToolResultBlock? WebSearchToolResult { get; init; }
#else
        public global::Anthropic.BetaResponseWebSearchToolResultBlock? WebSearchToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchToolResult))]
#endif
        public bool IsWebSearchToolResult => WebSearchToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseWebFetchToolResultBlock? WebFetchToolResult { get; init; }
#else
        public global::Anthropic.BetaResponseWebFetchToolResultBlock? WebFetchToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchToolResult))]
#endif
        public bool IsWebFetchToolResult => WebFetchToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseAdvisorToolResultBlock? AdvisorToolResult { get; init; }
#else
        public global::Anthropic.BetaResponseAdvisorToolResultBlock? AdvisorToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdvisorToolResult))]
#endif
        public bool IsAdvisorToolResult => AdvisorToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseCodeExecutionToolResultBlock? CodeExecutionToolResult { get; init; }
#else
        public global::Anthropic.BetaResponseCodeExecutionToolResultBlock? CodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionToolResult))]
#endif
        public bool IsCodeExecutionToolResult => CodeExecutionToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock? BashCodeExecutionToolResult { get; init; }
#else
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock? BashCodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashCodeExecutionToolResult))]
#endif
        public bool IsBashCodeExecutionToolResult => BashCodeExecutionToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock? TextEditorCodeExecutionToolResult { get; init; }
#else
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock? TextEditorCodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionToolResult))]
#endif
        public bool IsTextEditorCodeExecutionToolResult => TextEditorCodeExecutionToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseToolSearchToolResultBlock? ToolSearchToolResult { get; init; }
#else
        public global::Anthropic.BetaResponseToolSearchToolResultBlock? ToolSearchToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchToolResult))]
#endif
        public bool IsToolSearchToolResult => ToolSearchToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseMCPToolUseBlock? McpToolUse { get; init; }
#else
        public global::Anthropic.BetaResponseMCPToolUseBlock? McpToolUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolUse))]
#endif
        public bool IsMcpToolUse => McpToolUse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseMCPToolResultBlock? McpToolResult { get; init; }
#else
        public global::Anthropic.BetaResponseMCPToolResultBlock? McpToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolResult))]
#endif
        public bool IsMcpToolResult => McpToolResult != null;

        /// <summary>
        /// Response model for a file uploaded to the container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseContainerUploadBlock? ContainerUpload { get; init; }
#else
        public global::Anthropic.BetaResponseContainerUploadBlock? ContainerUpload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerUpload))]
#endif
        public bool IsContainerUpload => ContainerUpload != null;

        /// <summary>
        /// A compaction block returned when autocompact is triggered.<br/>
        /// When content is None, it indicates the compaction failed to produce a valid<br/>
        /// summary (e.g., malformed output from the model). Clients may round-trip<br/>
        /// compaction blocks with null content; the server treats them as no-ops.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseCompactionBlock? Compaction { get; init; }
#else
        public global::Anthropic.BetaResponseCompactionBlock? Compaction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compaction))]
#endif
        public bool IsCompaction => Compaction != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseTextBlock value) => new ContentBlock((global::Anthropic.BetaResponseTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseTextBlock?(ContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseThinkingBlock value) => new ContentBlock((global::Anthropic.BetaResponseThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseThinkingBlock?(ContentBlock @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseThinkingBlock? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseRedactedThinkingBlock value) => new ContentBlock((global::Anthropic.BetaResponseRedactedThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseRedactedThinkingBlock?(ContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseToolUseBlock value) => new ContentBlock((global::Anthropic.BetaResponseToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolUseBlock?(ContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseServerToolUseBlock value) => new ContentBlock((global::Anthropic.BetaResponseServerToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseServerToolUseBlock?(ContentBlock @this) => @this.ServerToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseServerToolUseBlock? value)
        {
            ServerToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseWebSearchToolResultBlock value) => new ContentBlock((global::Anthropic.BetaResponseWebSearchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseWebSearchToolResultBlock?(ContentBlock @this) => @this.WebSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseWebSearchToolResultBlock? value)
        {
            WebSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseWebFetchToolResultBlock value) => new ContentBlock((global::Anthropic.BetaResponseWebFetchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseWebFetchToolResultBlock?(ContentBlock @this) => @this.WebFetchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseWebFetchToolResultBlock? value)
        {
            WebFetchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseAdvisorToolResultBlock value) => new ContentBlock((global::Anthropic.BetaResponseAdvisorToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseAdvisorToolResultBlock?(ContentBlock @this) => @this.AdvisorToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseAdvisorToolResultBlock? value)
        {
            AdvisorToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseCodeExecutionToolResultBlock value) => new ContentBlock((global::Anthropic.BetaResponseCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseCodeExecutionToolResultBlock?(ContentBlock @this) => @this.CodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseCodeExecutionToolResultBlock? value)
        {
            CodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock value) => new ContentBlock((global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock?(ContentBlock @this) => @this.BashCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock? value)
        {
            BashCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock value) => new ContentBlock((global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock?(ContentBlock @this) => @this.TextEditorCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock? value)
        {
            TextEditorCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseToolSearchToolResultBlock value) => new ContentBlock((global::Anthropic.BetaResponseToolSearchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolSearchToolResultBlock?(ContentBlock @this) => @this.ToolSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseToolSearchToolResultBlock? value)
        {
            ToolSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseMCPToolUseBlock value) => new ContentBlock((global::Anthropic.BetaResponseMCPToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseMCPToolUseBlock?(ContentBlock @this) => @this.McpToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseMCPToolUseBlock? value)
        {
            McpToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseMCPToolResultBlock value) => new ContentBlock((global::Anthropic.BetaResponseMCPToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseMCPToolResultBlock?(ContentBlock @this) => @this.McpToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseMCPToolResultBlock? value)
        {
            McpToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseContainerUploadBlock value) => new ContentBlock((global::Anthropic.BetaResponseContainerUploadBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseContainerUploadBlock?(ContentBlock @this) => @this.ContainerUpload;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseContainerUploadBlock? value)
        {
            ContainerUpload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseCompactionBlock value) => new ContentBlock((global::Anthropic.BetaResponseCompactionBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseCompactionBlock?(ContentBlock @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseCompactionBlock? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(
            global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? type,
            global::Anthropic.BetaResponseTextBlock? text,
            global::Anthropic.BetaResponseThinkingBlock? thinking,
            global::Anthropic.BetaResponseRedactedThinkingBlock? redactedThinking,
            global::Anthropic.BetaResponseToolUseBlock? toolUse,
            global::Anthropic.BetaResponseServerToolUseBlock? serverToolUse,
            global::Anthropic.BetaResponseWebSearchToolResultBlock? webSearchToolResult,
            global::Anthropic.BetaResponseWebFetchToolResultBlock? webFetchToolResult,
            global::Anthropic.BetaResponseAdvisorToolResultBlock? advisorToolResult,
            global::Anthropic.BetaResponseCodeExecutionToolResultBlock? codeExecutionToolResult,
            global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock? bashCodeExecutionToolResult,
            global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock? textEditorCodeExecutionToolResult,
            global::Anthropic.BetaResponseToolSearchToolResultBlock? toolSearchToolResult,
            global::Anthropic.BetaResponseMCPToolUseBlock? mcpToolUse,
            global::Anthropic.BetaResponseMCPToolResultBlock? mcpToolResult,
            global::Anthropic.BetaResponseContainerUploadBlock? containerUpload,
            global::Anthropic.BetaResponseCompactionBlock? compaction
            )
        {
            Type = type;

            Text = text;
            Thinking = thinking;
            RedactedThinking = redactedThinking;
            ToolUse = toolUse;
            ServerToolUse = serverToolUse;
            WebSearchToolResult = webSearchToolResult;
            WebFetchToolResult = webFetchToolResult;
            AdvisorToolResult = advisorToolResult;
            CodeExecutionToolResult = codeExecutionToolResult;
            BashCodeExecutionToolResult = bashCodeExecutionToolResult;
            TextEditorCodeExecutionToolResult = textEditorCodeExecutionToolResult;
            ToolSearchToolResult = toolSearchToolResult;
            McpToolUse = mcpToolUse;
            McpToolResult = mcpToolResult;
            ContainerUpload = containerUpload;
            Compaction = compaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Compaction as object ??
            ContainerUpload as object ??
            McpToolResult as object ??
            McpToolUse as object ??
            ToolSearchToolResult as object ??
            TextEditorCodeExecutionToolResult as object ??
            BashCodeExecutionToolResult as object ??
            CodeExecutionToolResult as object ??
            AdvisorToolResult as object ??
            WebFetchToolResult as object ??
            WebSearchToolResult as object ??
            ServerToolUse as object ??
            ToolUse as object ??
            RedactedThinking as object ??
            Thinking as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Thinking?.ToString() ??
            RedactedThinking?.ToString() ??
            ToolUse?.ToString() ??
            ServerToolUse?.ToString() ??
            WebSearchToolResult?.ToString() ??
            WebFetchToolResult?.ToString() ??
            AdvisorToolResult?.ToString() ??
            CodeExecutionToolResult?.ToString() ??
            BashCodeExecutionToolResult?.ToString() ??
            TextEditorCodeExecutionToolResult?.ToString() ??
            ToolSearchToolResult?.ToString() ??
            McpToolUse?.ToString() ??
            McpToolResult?.ToString() ??
            ContainerUpload?.ToString() ??
            Compaction?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && IsMcpToolResult && !IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && IsContainerUpload && !IsCompaction || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && IsCompaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaResponseTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaResponseThinkingBlock?, TResult>? thinking = null,
            global::System.Func<global::Anthropic.BetaResponseRedactedThinkingBlock?, TResult>? redactedThinking = null,
            global::System.Func<global::Anthropic.BetaResponseToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.BetaResponseServerToolUseBlock?, TResult>? serverToolUse = null,
            global::System.Func<global::Anthropic.BetaResponseWebSearchToolResultBlock?, TResult>? webSearchToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseWebFetchToolResultBlock?, TResult>? webFetchToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseAdvisorToolResultBlock?, TResult>? advisorToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseCodeExecutionToolResultBlock?, TResult>? codeExecutionToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock?, TResult>? bashCodeExecutionToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock?, TResult>? textEditorCodeExecutionToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseToolSearchToolResultBlock?, TResult>? toolSearchToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseMCPToolUseBlock?, TResult>? mcpToolUse = null,
            global::System.Func<global::Anthropic.BetaResponseMCPToolResultBlock?, TResult>? mcpToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseContainerUploadBlock?, TResult>? containerUpload = null,
            global::System.Func<global::Anthropic.BetaResponseCompactionBlock?, TResult>? compaction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsRedactedThinking && redactedThinking != null)
            {
                return redactedThinking(RedactedThinking!);
            }
            else if (IsToolUse && toolUse != null)
            {
                return toolUse(ToolUse!);
            }
            else if (IsServerToolUse && serverToolUse != null)
            {
                return serverToolUse(ServerToolUse!);
            }
            else if (IsWebSearchToolResult && webSearchToolResult != null)
            {
                return webSearchToolResult(WebSearchToolResult!);
            }
            else if (IsWebFetchToolResult && webFetchToolResult != null)
            {
                return webFetchToolResult(WebFetchToolResult!);
            }
            else if (IsAdvisorToolResult && advisorToolResult != null)
            {
                return advisorToolResult(AdvisorToolResult!);
            }
            else if (IsCodeExecutionToolResult && codeExecutionToolResult != null)
            {
                return codeExecutionToolResult(CodeExecutionToolResult!);
            }
            else if (IsBashCodeExecutionToolResult && bashCodeExecutionToolResult != null)
            {
                return bashCodeExecutionToolResult(BashCodeExecutionToolResult!);
            }
            else if (IsTextEditorCodeExecutionToolResult && textEditorCodeExecutionToolResult != null)
            {
                return textEditorCodeExecutionToolResult(TextEditorCodeExecutionToolResult!);
            }
            else if (IsToolSearchToolResult && toolSearchToolResult != null)
            {
                return toolSearchToolResult(ToolSearchToolResult!);
            }
            else if (IsMcpToolUse && mcpToolUse != null)
            {
                return mcpToolUse(McpToolUse!);
            }
            else if (IsMcpToolResult && mcpToolResult != null)
            {
                return mcpToolResult(McpToolResult!);
            }
            else if (IsContainerUpload && containerUpload != null)
            {
                return containerUpload(ContainerUpload!);
            }
            else if (IsCompaction && compaction != null)
            {
                return compaction(Compaction!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaResponseTextBlock?>? text = null,
            global::System.Action<global::Anthropic.BetaResponseThinkingBlock?>? thinking = null,
            global::System.Action<global::Anthropic.BetaResponseRedactedThinkingBlock?>? redactedThinking = null,
            global::System.Action<global::Anthropic.BetaResponseToolUseBlock?>? toolUse = null,
            global::System.Action<global::Anthropic.BetaResponseServerToolUseBlock?>? serverToolUse = null,
            global::System.Action<global::Anthropic.BetaResponseWebSearchToolResultBlock?>? webSearchToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseWebFetchToolResultBlock?>? webFetchToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseAdvisorToolResultBlock?>? advisorToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseCodeExecutionToolResultBlock?>? codeExecutionToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock?>? bashCodeExecutionToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock?>? textEditorCodeExecutionToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseToolSearchToolResultBlock?>? toolSearchToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseMCPToolUseBlock?>? mcpToolUse = null,
            global::System.Action<global::Anthropic.BetaResponseMCPToolResultBlock?>? mcpToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseContainerUploadBlock?>? containerUpload = null,
            global::System.Action<global::Anthropic.BetaResponseCompactionBlock?>? compaction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsRedactedThinking)
            {
                redactedThinking?.Invoke(RedactedThinking!);
            }
            else if (IsToolUse)
            {
                toolUse?.Invoke(ToolUse!);
            }
            else if (IsServerToolUse)
            {
                serverToolUse?.Invoke(ServerToolUse!);
            }
            else if (IsWebSearchToolResult)
            {
                webSearchToolResult?.Invoke(WebSearchToolResult!);
            }
            else if (IsWebFetchToolResult)
            {
                webFetchToolResult?.Invoke(WebFetchToolResult!);
            }
            else if (IsAdvisorToolResult)
            {
                advisorToolResult?.Invoke(AdvisorToolResult!);
            }
            else if (IsCodeExecutionToolResult)
            {
                codeExecutionToolResult?.Invoke(CodeExecutionToolResult!);
            }
            else if (IsBashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult?.Invoke(BashCodeExecutionToolResult!);
            }
            else if (IsTextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult?.Invoke(TextEditorCodeExecutionToolResult!);
            }
            else if (IsToolSearchToolResult)
            {
                toolSearchToolResult?.Invoke(ToolSearchToolResult!);
            }
            else if (IsMcpToolUse)
            {
                mcpToolUse?.Invoke(McpToolUse!);
            }
            else if (IsMcpToolResult)
            {
                mcpToolResult?.Invoke(McpToolResult!);
            }
            else if (IsContainerUpload)
            {
                containerUpload?.Invoke(ContainerUpload!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Anthropic.BetaResponseTextBlock),
                Thinking,
                typeof(global::Anthropic.BetaResponseThinkingBlock),
                RedactedThinking,
                typeof(global::Anthropic.BetaResponseRedactedThinkingBlock),
                ToolUse,
                typeof(global::Anthropic.BetaResponseToolUseBlock),
                ServerToolUse,
                typeof(global::Anthropic.BetaResponseServerToolUseBlock),
                WebSearchToolResult,
                typeof(global::Anthropic.BetaResponseWebSearchToolResultBlock),
                WebFetchToolResult,
                typeof(global::Anthropic.BetaResponseWebFetchToolResultBlock),
                AdvisorToolResult,
                typeof(global::Anthropic.BetaResponseAdvisorToolResultBlock),
                CodeExecutionToolResult,
                typeof(global::Anthropic.BetaResponseCodeExecutionToolResultBlock),
                BashCodeExecutionToolResult,
                typeof(global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock),
                TextEditorCodeExecutionToolResult,
                typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock),
                ToolSearchToolResult,
                typeof(global::Anthropic.BetaResponseToolSearchToolResultBlock),
                McpToolUse,
                typeof(global::Anthropic.BetaResponseMCPToolUseBlock),
                McpToolResult,
                typeof(global::Anthropic.BetaResponseMCPToolResultBlock),
                ContainerUpload,
                typeof(global::Anthropic.BetaResponseContainerUploadBlock),
                Compaction,
                typeof(global::Anthropic.BetaResponseCompactionBlock),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseServerToolUseBlock?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseWebSearchToolResultBlock?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseWebFetchToolResultBlock?>.Default.Equals(WebFetchToolResult, other.WebFetchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseAdvisorToolResultBlock?>.Default.Equals(AdvisorToolResult, other.AdvisorToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseCodeExecutionToolResultBlock?>.Default.Equals(CodeExecutionToolResult, other.CodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock?>.Default.Equals(BashCodeExecutionToolResult, other.BashCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock?>.Default.Equals(TextEditorCodeExecutionToolResult, other.TextEditorCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolSearchToolResultBlock?>.Default.Equals(ToolSearchToolResult, other.ToolSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseMCPToolUseBlock?>.Default.Equals(McpToolUse, other.McpToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseMCPToolResultBlock?>.Default.Equals(McpToolResult, other.McpToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseContainerUploadBlock?>.Default.Equals(ContainerUpload, other.ContainerUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseCompactionBlock?>.Default.Equals(Compaction, other.Compaction) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentBlock obj1, ContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentBlock obj1, ContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentBlock o && Equals(o);
        }
    }
}
