#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaInputContentBlock : global::System.IEquatable<BetaInputContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// Regular text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestTextBlock? Text { get; init; }
#else
        public global::Anthropic.BetaRequestTextBlock? Text { get; }
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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestTextBlock PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Image content specified directly as base64 data or as a reference via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestImageBlock? Image { get; init; }
#else
        public global::Anthropic.BetaRequestImageBlock? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestImageBlock? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestImageBlock PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// Document content, either specified directly as base64 data, as text, or as a reference via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestDocumentBlock? Document { get; init; }
#else
        public global::Anthropic.BetaRequestDocumentBlock? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestDocumentBlock? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlock PickDocument() => IsDocument
            ? Document!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");

        /// <summary>
        /// A search result block containing source, title, and content from search operations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestSearchResultBlock? SearchResult { get; init; }
#else
        public global::Anthropic.BetaRequestSearchResultBlock? SearchResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResult))]
#endif
        public bool IsSearchResult => SearchResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestSearchResultBlock? value)
        {
            value = SearchResult;
            return IsSearchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlock PickSearchResult() => IsSearchResult
            ? SearchResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResult' but the value was {ToString()}.");

        /// <summary>
        /// A block specifying internal thinking by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestThinkingBlock? Thinking { get; init; }
#else
        public global::Anthropic.BetaRequestThinkingBlock? Thinking { get; }
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
        public bool TryPickThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestThinkingBlock? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestThinkingBlock PickThinking() => IsThinking
            ? Thinking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thinking' but the value was {ToString()}.");

        /// <summary>
        /// A block specifying internal, redacted thinking by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestRedactedThinkingBlock? RedactedThinking { get; init; }
#else
        public global::Anthropic.BetaRequestRedactedThinkingBlock? RedactedThinking { get; }
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
        public bool TryPickRedactedThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestRedactedThinkingBlock? value)
        {
            value = RedactedThinking;
            return IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestRedactedThinkingBlock PickRedactedThinking() => IsRedactedThinking
            ? RedactedThinking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RedactedThinking' but the value was {ToString()}.");

        /// <summary>
        /// A block indicating a tool use by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolUseBlock? ToolUse { get; init; }
#else
        public global::Anthropic.BetaRequestToolUseBlock? ToolUse { get; }
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
        public bool TryPickToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestToolUseBlock? value)
        {
            value = ToolUse;
            return IsToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestToolUseBlock PickToolUse() => IsToolUse
            ? ToolUse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolUse' but the value was {ToString()}.");

        /// <summary>
        /// A block specifying the results of a tool use by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolResultBlock? ToolResult { get; init; }
#else
        public global::Anthropic.BetaRequestToolResultBlock? ToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolResult))]
#endif
        public bool IsToolResult => ToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestToolResultBlock? value)
        {
            value = ToolResult;
            return IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlock PickToolResult() => IsToolResult
            ? ToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestServerToolUseBlock? ServerToolUse { get; init; }
#else
        public global::Anthropic.BetaRequestServerToolUseBlock? ServerToolUse { get; }
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
        public bool TryPickServerToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestServerToolUseBlock? value)
        {
            value = ServerToolUse;
            return IsServerToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestServerToolUseBlock PickServerToolUse() => IsServerToolUse
            ? ServerToolUse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServerToolUse' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestWebSearchToolResultBlock? WebSearchToolResult { get; init; }
#else
        public global::Anthropic.BetaRequestWebSearchToolResultBlock? WebSearchToolResult { get; }
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
        public bool TryPickWebSearchToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestWebSearchToolResultBlock? value)
        {
            value = WebSearchToolResult;
            return IsWebSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestWebSearchToolResultBlock PickWebSearchToolResult() => IsWebSearchToolResult
            ? WebSearchToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestWebFetchToolResultBlock? WebFetchToolResult { get; init; }
#else
        public global::Anthropic.BetaRequestWebFetchToolResultBlock? WebFetchToolResult { get; }
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
        public bool TryPickWebFetchToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestWebFetchToolResultBlock? value)
        {
            value = WebFetchToolResult;
            return IsWebFetchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestWebFetchToolResultBlock PickWebFetchToolResult() => IsWebFetchToolResult
            ? WebFetchToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestAdvisorToolResultBlock? AdvisorToolResult { get; init; }
#else
        public global::Anthropic.BetaRequestAdvisorToolResultBlock? AdvisorToolResult { get; }
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
        public bool TryPickAdvisorToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestAdvisorToolResultBlock? value)
        {
            value = AdvisorToolResult;
            return IsAdvisorToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestAdvisorToolResultBlock PickAdvisorToolResult() => IsAdvisorToolResult
            ? AdvisorToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdvisorToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlock? CodeExecutionToolResult { get; init; }
#else
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlock? CodeExecutionToolResult { get; }
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
        public bool TryPickCodeExecutionToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestCodeExecutionToolResultBlock? value)
        {
            value = CodeExecutionToolResult;
            return IsCodeExecutionToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlock PickCodeExecutionToolResult() => IsCodeExecutionToolResult
            ? CodeExecutionToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? BashCodeExecutionToolResult { get; init; }
#else
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? BashCodeExecutionToolResult { get; }
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
        public bool TryPickBashCodeExecutionToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? value)
        {
            value = BashCodeExecutionToolResult;
            return IsBashCodeExecutionToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock PickBashCodeExecutionToolResult() => IsBashCodeExecutionToolResult
            ? BashCodeExecutionToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashCodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? TextEditorCodeExecutionToolResult { get; init; }
#else
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? TextEditorCodeExecutionToolResult { get; }
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
        public bool TryPickTextEditorCodeExecutionToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? value)
        {
            value = TextEditorCodeExecutionToolResult;
            return IsTextEditorCodeExecutionToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock PickTextEditorCodeExecutionToolResult() => IsTextEditorCodeExecutionToolResult
            ? TextEditorCodeExecutionToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditorCodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolSearchToolResultBlock? ToolSearchToolResult { get; init; }
#else
        public global::Anthropic.BetaRequestToolSearchToolResultBlock? ToolSearchToolResult { get; }
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
        public bool TryPickToolSearchToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestToolSearchToolResultBlock? value)
        {
            value = ToolSearchToolResult;
            return IsToolSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestToolSearchToolResultBlock PickToolSearchToolResult() => IsToolSearchToolResult
            ? ToolSearchToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestMCPToolUseBlock? McpToolUse { get; init; }
#else
        public global::Anthropic.BetaRequestMCPToolUseBlock? McpToolUse { get; }
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
        public bool TryPickMcpToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestMCPToolUseBlock? value)
        {
            value = McpToolUse;
            return IsMcpToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolUseBlock PickMcpToolUse() => IsMcpToolUse
            ? McpToolUse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolUse' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestMCPToolResultBlock? McpToolResult { get; init; }
#else
        public global::Anthropic.BetaRequestMCPToolResultBlock? McpToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolResult))]
#endif
        public bool IsMcpToolResult => McpToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcpToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestMCPToolResultBlock? value)
        {
            value = McpToolResult;
            return IsMcpToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestMCPToolResultBlock PickMcpToolResult() => IsMcpToolResult
            ? McpToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolResult' but the value was {ToString()}.");

        /// <summary>
        /// A content block that represents a file to be uploaded to the container<br/>
        /// Files uploaded via this block will be available in the container's input directory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestContainerUploadBlock? ContainerUpload { get; init; }
#else
        public global::Anthropic.BetaRequestContainerUploadBlock? ContainerUpload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerUpload))]
#endif
        public bool IsContainerUpload => ContainerUpload != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContainerUpload(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestContainerUploadBlock? value)
        {
            value = ContainerUpload;
            return IsContainerUpload;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestContainerUploadBlock PickContainerUpload() => IsContainerUpload
            ? ContainerUpload!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerUpload' but the value was {ToString()}.");

        /// <summary>
        /// A compaction block containing summary of previous context.<br/>
        /// Users should round-trip these blocks from responses to subsequent requests<br/>
        /// to maintain context across compaction boundaries.<br/>
        /// When content is None, the block represents a failed compaction. The server<br/>
        /// treats these as no-ops. Empty string content is not allowed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestCompactionBlock? Compaction { get; init; }
#else
        public global::Anthropic.BetaRequestCompactionBlock? Compaction { get; }
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
        public bool TryPickCompaction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestCompactionBlock? value)
        {
            value = Compaction;
            return IsCompaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlock PickCompaction() => IsCompaction
            ? Compaction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Compaction' but the value was {ToString()}.");

        /// <summary>
        /// System instructions that appear mid-conversation.<br/>
        /// Use this block to provide or update system-level instructions at a specific<br/>
        /// point in the conversation, rather than only via the top-level `system` parameter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestMidConvSystemBlock? MidConvSystem { get; init; }
#else
        public global::Anthropic.BetaRequestMidConvSystemBlock? MidConvSystem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MidConvSystem))]
#endif
        public bool IsMidConvSystem => MidConvSystem != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMidConvSystem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestMidConvSystemBlock? value)
        {
            value = MidConvSystem;
            return IsMidConvSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestMidConvSystemBlock PickMidConvSystem() => IsMidConvSystem
            ? MidConvSystem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MidConvSystem' but the value was {ToString()}.");

        /// <summary>
        /// Mid-conversation directive to surface a declared tool.<br/>
        /// ``tool`` references a tool (or MCP toolset) by name from the request's<br/>
        /// ``tools``; it is offered to the model from this point in the<br/>
        /// conversation onward.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolAdditionBlock? ToolAddition { get; init; }
#else
        public global::Anthropic.BetaRequestToolAdditionBlock? ToolAddition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolAddition))]
#endif
        public bool IsToolAddition => ToolAddition != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolAddition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestToolAdditionBlock? value)
        {
            value = ToolAddition;
            return IsToolAddition;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlock PickToolAddition() => IsToolAddition
            ? ToolAddition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolAddition' but the value was {ToString()}.");

        /// <summary>
        /// Mid-conversation directive to withdraw a tool.<br/>
        /// ``tool`` references a tool (or MCP toolset) by name from the request's<br/>
        /// ``tools``; it is no longer offered to the model from this point in the<br/>
        /// conversation onward.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolRemovalBlock? ToolRemoval { get; init; }
#else
        public global::Anthropic.BetaRequestToolRemovalBlock? ToolRemoval { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolRemoval))]
#endif
        public bool IsToolRemoval => ToolRemoval != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolRemoval(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestToolRemovalBlock? value)
        {
            value = ToolRemoval;
            return IsToolRemoval;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlock PickToolRemoval() => IsToolRemoval
            ? ToolRemoval!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolRemoval' but the value was {ToString()}.");

        /// <summary>
        /// A `fallback` block echoed back from a prior response.<br/>
        /// Accepted in `messages[].content` and not rendered into the prompt; not<br/>
        /// validated against the request's `fallbacks` chain or top-level `model`.<br/>
        /// Echo the assistant turn back verbatim, including this block in its<br/>
        /// original position. The block marks the boundary between content produced<br/>
        /// before and after a fallback hop, and the server relies on that boundary<br/>
        /// to validate the turn: when thinking runs flank the boundary, omitting<br/>
        /// the block merges them into one span the server cannot validate (the<br/>
        /// request is rejected), and moving it into the middle of a single run is<br/>
        /// likewise rejected; between non-thinking blocks the block's placement has<br/>
        /// no validation effect.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestFallbackBlock? Fallback { get; init; }
#else
        public global::Anthropic.BetaRequestFallbackBlock? Fallback { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fallback))]
#endif
        public bool IsFallback => Fallback != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFallback(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestFallbackBlock? value)
        {
            value = Fallback;
            return IsFallback;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestFallbackBlock PickFallback() => IsFallback
            ? Fallback!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fallback' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestTextBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestTextBlock?(BetaInputContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromText(global::Anthropic.BetaRequestTextBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestImageBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestImageBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestImageBlock?(BetaInputContentBlock @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromImage(global::Anthropic.BetaRequestImageBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestDocumentBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestDocumentBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestDocumentBlock?(BetaInputContentBlock @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestDocumentBlock? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromDocument(global::Anthropic.BetaRequestDocumentBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestSearchResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestSearchResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestSearchResultBlock?(BetaInputContentBlock @this) => @this.SearchResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestSearchResultBlock? value)
        {
            SearchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromSearchResult(global::Anthropic.BetaRequestSearchResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestThinkingBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestThinkingBlock?(BetaInputContentBlock @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestThinkingBlock? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromThinking(global::Anthropic.BetaRequestThinkingBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestRedactedThinkingBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestRedactedThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestRedactedThinkingBlock?(BetaInputContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromRedactedThinking(global::Anthropic.BetaRequestRedactedThinkingBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestToolUseBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolUseBlock?(BetaInputContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromToolUse(global::Anthropic.BetaRequestToolUseBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolResultBlock?(BetaInputContentBlock @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestToolResultBlock? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromToolResult(global::Anthropic.BetaRequestToolResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestServerToolUseBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestServerToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestServerToolUseBlock?(BetaInputContentBlock @this) => @this.ServerToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestServerToolUseBlock? value)
        {
            ServerToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromServerToolUse(global::Anthropic.BetaRequestServerToolUseBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestWebSearchToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestWebSearchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestWebSearchToolResultBlock?(BetaInputContentBlock @this) => @this.WebSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestWebSearchToolResultBlock? value)
        {
            WebSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromWebSearchToolResult(global::Anthropic.BetaRequestWebSearchToolResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestWebFetchToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestWebFetchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestWebFetchToolResultBlock?(BetaInputContentBlock @this) => @this.WebFetchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestWebFetchToolResultBlock? value)
        {
            WebFetchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromWebFetchToolResult(global::Anthropic.BetaRequestWebFetchToolResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestAdvisorToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestAdvisorToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestAdvisorToolResultBlock?(BetaInputContentBlock @this) => @this.AdvisorToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestAdvisorToolResultBlock? value)
        {
            AdvisorToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromAdvisorToolResult(global::Anthropic.BetaRequestAdvisorToolResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestCodeExecutionToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestCodeExecutionToolResultBlock?(BetaInputContentBlock @this) => @this.CodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestCodeExecutionToolResultBlock? value)
        {
            CodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromCodeExecutionToolResult(global::Anthropic.BetaRequestCodeExecutionToolResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock?(BetaInputContentBlock @this) => @this.BashCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? value)
        {
            BashCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromBashCodeExecutionToolResult(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock?(BetaInputContentBlock @this) => @this.TextEditorCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? value)
        {
            TextEditorCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromTextEditorCodeExecutionToolResult(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestToolSearchToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestToolSearchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolSearchToolResultBlock?(BetaInputContentBlock @this) => @this.ToolSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestToolSearchToolResultBlock? value)
        {
            ToolSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromToolSearchToolResult(global::Anthropic.BetaRequestToolSearchToolResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestMCPToolUseBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestMCPToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestMCPToolUseBlock?(BetaInputContentBlock @this) => @this.McpToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestMCPToolUseBlock? value)
        {
            McpToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromMcpToolUse(global::Anthropic.BetaRequestMCPToolUseBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestMCPToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestMCPToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestMCPToolResultBlock?(BetaInputContentBlock @this) => @this.McpToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestMCPToolResultBlock? value)
        {
            McpToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromMcpToolResult(global::Anthropic.BetaRequestMCPToolResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestContainerUploadBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestContainerUploadBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestContainerUploadBlock?(BetaInputContentBlock @this) => @this.ContainerUpload;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestContainerUploadBlock? value)
        {
            ContainerUpload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromContainerUpload(global::Anthropic.BetaRequestContainerUploadBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestCompactionBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestCompactionBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestCompactionBlock?(BetaInputContentBlock @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestCompactionBlock? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromCompaction(global::Anthropic.BetaRequestCompactionBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestMidConvSystemBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestMidConvSystemBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestMidConvSystemBlock?(BetaInputContentBlock @this) => @this.MidConvSystem;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestMidConvSystemBlock? value)
        {
            MidConvSystem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromMidConvSystem(global::Anthropic.BetaRequestMidConvSystemBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestToolAdditionBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestToolAdditionBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolAdditionBlock?(BetaInputContentBlock @this) => @this.ToolAddition;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestToolAdditionBlock? value)
        {
            ToolAddition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromToolAddition(global::Anthropic.BetaRequestToolAdditionBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestToolRemovalBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestToolRemovalBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolRemovalBlock?(BetaInputContentBlock @this) => @this.ToolRemoval;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestToolRemovalBlock? value)
        {
            ToolRemoval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromToolRemoval(global::Anthropic.BetaRequestToolRemovalBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestFallbackBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestFallbackBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestFallbackBlock?(BetaInputContentBlock @this) => @this.Fallback;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestFallbackBlock? value)
        {
            Fallback = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromFallback(global::Anthropic.BetaRequestFallbackBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(
            global::Anthropic.BetaInputContentBlockDiscriminatorType? type,
            global::Anthropic.BetaRequestTextBlock? text,
            global::Anthropic.BetaRequestImageBlock? image,
            global::Anthropic.BetaRequestDocumentBlock? document,
            global::Anthropic.BetaRequestSearchResultBlock? searchResult,
            global::Anthropic.BetaRequestThinkingBlock? thinking,
            global::Anthropic.BetaRequestRedactedThinkingBlock? redactedThinking,
            global::Anthropic.BetaRequestToolUseBlock? toolUse,
            global::Anthropic.BetaRequestToolResultBlock? toolResult,
            global::Anthropic.BetaRequestServerToolUseBlock? serverToolUse,
            global::Anthropic.BetaRequestWebSearchToolResultBlock? webSearchToolResult,
            global::Anthropic.BetaRequestWebFetchToolResultBlock? webFetchToolResult,
            global::Anthropic.BetaRequestAdvisorToolResultBlock? advisorToolResult,
            global::Anthropic.BetaRequestCodeExecutionToolResultBlock? codeExecutionToolResult,
            global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? bashCodeExecutionToolResult,
            global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? textEditorCodeExecutionToolResult,
            global::Anthropic.BetaRequestToolSearchToolResultBlock? toolSearchToolResult,
            global::Anthropic.BetaRequestMCPToolUseBlock? mcpToolUse,
            global::Anthropic.BetaRequestMCPToolResultBlock? mcpToolResult,
            global::Anthropic.BetaRequestContainerUploadBlock? containerUpload,
            global::Anthropic.BetaRequestCompactionBlock? compaction,
            global::Anthropic.BetaRequestMidConvSystemBlock? midConvSystem,
            global::Anthropic.BetaRequestToolAdditionBlock? toolAddition,
            global::Anthropic.BetaRequestToolRemovalBlock? toolRemoval,
            global::Anthropic.BetaRequestFallbackBlock? fallback
            )
        {
            Type = type;

            Text = text;
            Image = image;
            Document = document;
            SearchResult = searchResult;
            Thinking = thinking;
            RedactedThinking = redactedThinking;
            ToolUse = toolUse;
            ToolResult = toolResult;
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
            MidConvSystem = midConvSystem;
            ToolAddition = toolAddition;
            ToolRemoval = toolRemoval;
            Fallback = fallback;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Fallback as object ??
            ToolRemoval as object ??
            ToolAddition as object ??
            MidConvSystem as object ??
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
            ToolResult as object ??
            ToolUse as object ??
            RedactedThinking as object ??
            Thinking as object ??
            SearchResult as object ??
            Document as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            Document?.ToString() ??
            SearchResult?.ToString() ??
            Thinking?.ToString() ??
            RedactedThinking?.ToString() ??
            ToolUse?.ToString() ??
            ToolResult?.ToString() ??
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
            Compaction?.ToString() ??
            MidConvSystem?.ToString() ??
            ToolAddition?.ToString() ??
            ToolRemoval?.ToString() ??
            Fallback?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && IsMidConvSystem && !IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && IsToolAddition && !IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && IsToolRemoval && !IsFallback || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsAdvisorToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsCompaction && !IsMidConvSystem && !IsToolAddition && !IsToolRemoval && IsFallback;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRequestTextBlock, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaRequestImageBlock, TResult>? image = null,
            global::System.Func<global::Anthropic.BetaRequestDocumentBlock, TResult>? document = null,
            global::System.Func<global::Anthropic.BetaRequestSearchResultBlock, TResult>? searchResult = null,
            global::System.Func<global::Anthropic.BetaRequestThinkingBlock, TResult>? thinking = null,
            global::System.Func<global::Anthropic.BetaRequestRedactedThinkingBlock, TResult>? redactedThinking = null,
            global::System.Func<global::Anthropic.BetaRequestToolUseBlock, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.BetaRequestToolResultBlock, TResult>? toolResult = null,
            global::System.Func<global::Anthropic.BetaRequestServerToolUseBlock, TResult>? serverToolUse = null,
            global::System.Func<global::Anthropic.BetaRequestWebSearchToolResultBlock, TResult>? webSearchToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestWebFetchToolResultBlock, TResult>? webFetchToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestAdvisorToolResultBlock, TResult>? advisorToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestCodeExecutionToolResultBlock, TResult>? codeExecutionToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock, TResult>? bashCodeExecutionToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock, TResult>? textEditorCodeExecutionToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestToolSearchToolResultBlock, TResult>? toolSearchToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestMCPToolUseBlock, TResult>? mcpToolUse = null,
            global::System.Func<global::Anthropic.BetaRequestMCPToolResultBlock, TResult>? mcpToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestContainerUploadBlock, TResult>? containerUpload = null,
            global::System.Func<global::Anthropic.BetaRequestCompactionBlock, TResult>? compaction = null,
            global::System.Func<global::Anthropic.BetaRequestMidConvSystemBlock, TResult>? midConvSystem = null,
            global::System.Func<global::Anthropic.BetaRequestToolAdditionBlock, TResult>? toolAddition = null,
            global::System.Func<global::Anthropic.BetaRequestToolRemovalBlock, TResult>? toolRemoval = null,
            global::System.Func<global::Anthropic.BetaRequestFallbackBlock, TResult>? fallback = null,
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
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }
            else if (IsSearchResult && searchResult != null)
            {
                return searchResult(SearchResult!);
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
            else if (IsToolResult && toolResult != null)
            {
                return toolResult(ToolResult!);
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
            else if (IsMidConvSystem && midConvSystem != null)
            {
                return midConvSystem(MidConvSystem!);
            }
            else if (IsToolAddition && toolAddition != null)
            {
                return toolAddition(ToolAddition!);
            }
            else if (IsToolRemoval && toolRemoval != null)
            {
                return toolRemoval(ToolRemoval!);
            }
            else if (IsFallback && fallback != null)
            {
                return fallback(Fallback!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaRequestTextBlock>? text = null,

            global::System.Action<global::Anthropic.BetaRequestImageBlock>? image = null,

            global::System.Action<global::Anthropic.BetaRequestDocumentBlock>? document = null,

            global::System.Action<global::Anthropic.BetaRequestSearchResultBlock>? searchResult = null,

            global::System.Action<global::Anthropic.BetaRequestThinkingBlock>? thinking = null,

            global::System.Action<global::Anthropic.BetaRequestRedactedThinkingBlock>? redactedThinking = null,

            global::System.Action<global::Anthropic.BetaRequestToolUseBlock>? toolUse = null,

            global::System.Action<global::Anthropic.BetaRequestToolResultBlock>? toolResult = null,

            global::System.Action<global::Anthropic.BetaRequestServerToolUseBlock>? serverToolUse = null,

            global::System.Action<global::Anthropic.BetaRequestWebSearchToolResultBlock>? webSearchToolResult = null,

            global::System.Action<global::Anthropic.BetaRequestWebFetchToolResultBlock>? webFetchToolResult = null,

            global::System.Action<global::Anthropic.BetaRequestAdvisorToolResultBlock>? advisorToolResult = null,

            global::System.Action<global::Anthropic.BetaRequestCodeExecutionToolResultBlock>? codeExecutionToolResult = null,

            global::System.Action<global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock>? bashCodeExecutionToolResult = null,

            global::System.Action<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock>? textEditorCodeExecutionToolResult = null,

            global::System.Action<global::Anthropic.BetaRequestToolSearchToolResultBlock>? toolSearchToolResult = null,

            global::System.Action<global::Anthropic.BetaRequestMCPToolUseBlock>? mcpToolUse = null,

            global::System.Action<global::Anthropic.BetaRequestMCPToolResultBlock>? mcpToolResult = null,

            global::System.Action<global::Anthropic.BetaRequestContainerUploadBlock>? containerUpload = null,

            global::System.Action<global::Anthropic.BetaRequestCompactionBlock>? compaction = null,

            global::System.Action<global::Anthropic.BetaRequestMidConvSystemBlock>? midConvSystem = null,

            global::System.Action<global::Anthropic.BetaRequestToolAdditionBlock>? toolAddition = null,

            global::System.Action<global::Anthropic.BetaRequestToolRemovalBlock>? toolRemoval = null,

            global::System.Action<global::Anthropic.BetaRequestFallbackBlock>? fallback = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
            else if (IsSearchResult)
            {
                searchResult?.Invoke(SearchResult!);
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
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
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
            else if (IsMidConvSystem)
            {
                midConvSystem?.Invoke(MidConvSystem!);
            }
            else if (IsToolAddition)
            {
                toolAddition?.Invoke(ToolAddition!);
            }
            else if (IsToolRemoval)
            {
                toolRemoval?.Invoke(ToolRemoval!);
            }
            else if (IsFallback)
            {
                fallback?.Invoke(Fallback!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaRequestTextBlock>? text = null,
            global::System.Action<global::Anthropic.BetaRequestImageBlock>? image = null,
            global::System.Action<global::Anthropic.BetaRequestDocumentBlock>? document = null,
            global::System.Action<global::Anthropic.BetaRequestSearchResultBlock>? searchResult = null,
            global::System.Action<global::Anthropic.BetaRequestThinkingBlock>? thinking = null,
            global::System.Action<global::Anthropic.BetaRequestRedactedThinkingBlock>? redactedThinking = null,
            global::System.Action<global::Anthropic.BetaRequestToolUseBlock>? toolUse = null,
            global::System.Action<global::Anthropic.BetaRequestToolResultBlock>? toolResult = null,
            global::System.Action<global::Anthropic.BetaRequestServerToolUseBlock>? serverToolUse = null,
            global::System.Action<global::Anthropic.BetaRequestWebSearchToolResultBlock>? webSearchToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestWebFetchToolResultBlock>? webFetchToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestAdvisorToolResultBlock>? advisorToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestCodeExecutionToolResultBlock>? codeExecutionToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock>? bashCodeExecutionToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock>? textEditorCodeExecutionToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestToolSearchToolResultBlock>? toolSearchToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestMCPToolUseBlock>? mcpToolUse = null,
            global::System.Action<global::Anthropic.BetaRequestMCPToolResultBlock>? mcpToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestContainerUploadBlock>? containerUpload = null,
            global::System.Action<global::Anthropic.BetaRequestCompactionBlock>? compaction = null,
            global::System.Action<global::Anthropic.BetaRequestMidConvSystemBlock>? midConvSystem = null,
            global::System.Action<global::Anthropic.BetaRequestToolAdditionBlock>? toolAddition = null,
            global::System.Action<global::Anthropic.BetaRequestToolRemovalBlock>? toolRemoval = null,
            global::System.Action<global::Anthropic.BetaRequestFallbackBlock>? fallback = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
            else if (IsSearchResult)
            {
                searchResult?.Invoke(SearchResult!);
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
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
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
            else if (IsMidConvSystem)
            {
                midConvSystem?.Invoke(MidConvSystem!);
            }
            else if (IsToolAddition)
            {
                toolAddition?.Invoke(ToolAddition!);
            }
            else if (IsToolRemoval)
            {
                toolRemoval?.Invoke(ToolRemoval!);
            }
            else if (IsFallback)
            {
                fallback?.Invoke(Fallback!);
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
                typeof(global::Anthropic.BetaRequestTextBlock),
                Image,
                typeof(global::Anthropic.BetaRequestImageBlock),
                Document,
                typeof(global::Anthropic.BetaRequestDocumentBlock),
                SearchResult,
                typeof(global::Anthropic.BetaRequestSearchResultBlock),
                Thinking,
                typeof(global::Anthropic.BetaRequestThinkingBlock),
                RedactedThinking,
                typeof(global::Anthropic.BetaRequestRedactedThinkingBlock),
                ToolUse,
                typeof(global::Anthropic.BetaRequestToolUseBlock),
                ToolResult,
                typeof(global::Anthropic.BetaRequestToolResultBlock),
                ServerToolUse,
                typeof(global::Anthropic.BetaRequestServerToolUseBlock),
                WebSearchToolResult,
                typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock),
                WebFetchToolResult,
                typeof(global::Anthropic.BetaRequestWebFetchToolResultBlock),
                AdvisorToolResult,
                typeof(global::Anthropic.BetaRequestAdvisorToolResultBlock),
                CodeExecutionToolResult,
                typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock),
                BashCodeExecutionToolResult,
                typeof(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock),
                TextEditorCodeExecutionToolResult,
                typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock),
                ToolSearchToolResult,
                typeof(global::Anthropic.BetaRequestToolSearchToolResultBlock),
                McpToolUse,
                typeof(global::Anthropic.BetaRequestMCPToolUseBlock),
                McpToolResult,
                typeof(global::Anthropic.BetaRequestMCPToolResultBlock),
                ContainerUpload,
                typeof(global::Anthropic.BetaRequestContainerUploadBlock),
                Compaction,
                typeof(global::Anthropic.BetaRequestCompactionBlock),
                MidConvSystem,
                typeof(global::Anthropic.BetaRequestMidConvSystemBlock),
                ToolAddition,
                typeof(global::Anthropic.BetaRequestToolAdditionBlock),
                ToolRemoval,
                typeof(global::Anthropic.BetaRequestToolRemovalBlock),
                Fallback,
                typeof(global::Anthropic.BetaRequestFallbackBlock),
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
        public bool Equals(BetaInputContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestDocumentBlock?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestSearchResultBlock?>.Default.Equals(SearchResult, other.SearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestServerToolUseBlock?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestWebSearchToolResultBlock?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestWebFetchToolResultBlock?>.Default.Equals(WebFetchToolResult, other.WebFetchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestAdvisorToolResultBlock?>.Default.Equals(AdvisorToolResult, other.AdvisorToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestCodeExecutionToolResultBlock?>.Default.Equals(CodeExecutionToolResult, other.CodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock?>.Default.Equals(BashCodeExecutionToolResult, other.BashCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock?>.Default.Equals(TextEditorCodeExecutionToolResult, other.TextEditorCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolSearchToolResultBlock?>.Default.Equals(ToolSearchToolResult, other.ToolSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestMCPToolUseBlock?>.Default.Equals(McpToolUse, other.McpToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestMCPToolResultBlock?>.Default.Equals(McpToolResult, other.McpToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestContainerUploadBlock?>.Default.Equals(ContainerUpload, other.ContainerUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestCompactionBlock?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestMidConvSystemBlock?>.Default.Equals(MidConvSystem, other.MidConvSystem) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolAdditionBlock?>.Default.Equals(ToolAddition, other.ToolAddition) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolRemovalBlock?>.Default.Equals(ToolRemoval, other.ToolRemoval) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestFallbackBlock?>.Default.Equals(Fallback, other.Fallback) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaInputContentBlock obj1, BetaInputContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaInputContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaInputContentBlock obj1, BetaInputContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaInputContentBlock o && Equals(o);
        }
    }
}
