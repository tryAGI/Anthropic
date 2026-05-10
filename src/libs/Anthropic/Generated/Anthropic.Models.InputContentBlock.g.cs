#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputContentBlock : global::System.IEquatable<InputContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// Regular text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestTextBlock? Text { get; init; }
#else
        public global::Anthropic.RequestTextBlock? Text { get; }
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
            out global::Anthropic.RequestTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestTextBlock PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Image content specified directly as base64 data or as a reference via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestImageBlock? Image { get; init; }
#else
        public global::Anthropic.RequestImageBlock? Image { get; }
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
            out global::Anthropic.RequestImageBlock? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestImageBlock PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// Document content, either specified directly as base64 data, as text, or as a reference via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestDocumentBlock? Document { get; init; }
#else
        public global::Anthropic.RequestDocumentBlock? Document { get; }
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
            out global::Anthropic.RequestDocumentBlock? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestDocumentBlock PickDocument() => IsDocument
            ? Document!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");

        /// <summary>
        /// A search result block containing source, title, and content from search operations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestSearchResultBlock? SearchResult { get; init; }
#else
        public global::Anthropic.RequestSearchResultBlock? SearchResult { get; }
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
            out global::Anthropic.RequestSearchResultBlock? value)
        {
            value = SearchResult;
            return IsSearchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestSearchResultBlock PickSearchResult() => IsSearchResult
            ? SearchResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResult' but the value was {ToString()}.");

        /// <summary>
        /// A block specifying internal thinking by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestThinkingBlock? Thinking { get; init; }
#else
        public global::Anthropic.RequestThinkingBlock? Thinking { get; }
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
            out global::Anthropic.RequestThinkingBlock? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestThinkingBlock PickThinking() => IsThinking
            ? Thinking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thinking' but the value was {ToString()}.");

        /// <summary>
        /// A block specifying internal, redacted thinking by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestRedactedThinkingBlock? RedactedThinking { get; init; }
#else
        public global::Anthropic.RequestRedactedThinkingBlock? RedactedThinking { get; }
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
            out global::Anthropic.RequestRedactedThinkingBlock? value)
        {
            value = RedactedThinking;
            return IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestRedactedThinkingBlock PickRedactedThinking() => IsRedactedThinking
            ? RedactedThinking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RedactedThinking' but the value was {ToString()}.");

        /// <summary>
        /// A block indicating a tool use by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestToolUseBlock? ToolUse { get; init; }
#else
        public global::Anthropic.RequestToolUseBlock? ToolUse { get; }
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
            out global::Anthropic.RequestToolUseBlock? value)
        {
            value = ToolUse;
            return IsToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestToolUseBlock PickToolUse() => IsToolUse
            ? ToolUse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolUse' but the value was {ToString()}.");

        /// <summary>
        /// A block specifying the results of a tool use by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestToolResultBlock? ToolResult { get; init; }
#else
        public global::Anthropic.RequestToolResultBlock? ToolResult { get; }
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
            out global::Anthropic.RequestToolResultBlock? value)
        {
            value = ToolResult;
            return IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestToolResultBlock PickToolResult() => IsToolResult
            ? ToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestServerToolUseBlock? ServerToolUse { get; init; }
#else
        public global::Anthropic.RequestServerToolUseBlock? ServerToolUse { get; }
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
            out global::Anthropic.RequestServerToolUseBlock? value)
        {
            value = ServerToolUse;
            return IsServerToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestServerToolUseBlock PickServerToolUse() => IsServerToolUse
            ? ServerToolUse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServerToolUse' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestWebSearchToolResultBlock? WebSearchToolResult { get; init; }
#else
        public global::Anthropic.RequestWebSearchToolResultBlock? WebSearchToolResult { get; }
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
            out global::Anthropic.RequestWebSearchToolResultBlock? value)
        {
            value = WebSearchToolResult;
            return IsWebSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestWebSearchToolResultBlock PickWebSearchToolResult() => IsWebSearchToolResult
            ? WebSearchToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestWebFetchToolResultBlock? WebFetchToolResult { get; init; }
#else
        public global::Anthropic.RequestWebFetchToolResultBlock? WebFetchToolResult { get; }
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
            out global::Anthropic.RequestWebFetchToolResultBlock? value)
        {
            value = WebFetchToolResult;
            return IsWebFetchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestWebFetchToolResultBlock PickWebFetchToolResult() => IsWebFetchToolResult
            ? WebFetchToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestCodeExecutionToolResultBlock? CodeExecutionToolResult { get; init; }
#else
        public global::Anthropic.RequestCodeExecutionToolResultBlock? CodeExecutionToolResult { get; }
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
            out global::Anthropic.RequestCodeExecutionToolResultBlock? value)
        {
            value = CodeExecutionToolResult;
            return IsCodeExecutionToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestCodeExecutionToolResultBlock PickCodeExecutionToolResult() => IsCodeExecutionToolResult
            ? CodeExecutionToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestBashCodeExecutionToolResultBlock? BashCodeExecutionToolResult { get; init; }
#else
        public global::Anthropic.RequestBashCodeExecutionToolResultBlock? BashCodeExecutionToolResult { get; }
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
            out global::Anthropic.RequestBashCodeExecutionToolResultBlock? value)
        {
            value = BashCodeExecutionToolResult;
            return IsBashCodeExecutionToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestBashCodeExecutionToolResultBlock PickBashCodeExecutionToolResult() => IsBashCodeExecutionToolResult
            ? BashCodeExecutionToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashCodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? TextEditorCodeExecutionToolResult { get; init; }
#else
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? TextEditorCodeExecutionToolResult { get; }
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
            out global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? value)
        {
            value = TextEditorCodeExecutionToolResult;
            return IsTextEditorCodeExecutionToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock PickTextEditorCodeExecutionToolResult() => IsTextEditorCodeExecutionToolResult
            ? TextEditorCodeExecutionToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditorCodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestToolSearchToolResultBlock? ToolSearchToolResult { get; init; }
#else
        public global::Anthropic.RequestToolSearchToolResultBlock? ToolSearchToolResult { get; }
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
            out global::Anthropic.RequestToolSearchToolResultBlock? value)
        {
            value = ToolSearchToolResult;
            return IsToolSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlock PickToolSearchToolResult() => IsToolSearchToolResult
            ? ToolSearchToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// A content block that represents a file to be uploaded to the container<br/>
        /// Files uploaded via this block will be available in the container's input directory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestContainerUploadBlock? ContainerUpload { get; init; }
#else
        public global::Anthropic.RequestContainerUploadBlock? ContainerUpload { get; }
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
            out global::Anthropic.RequestContainerUploadBlock? value)
        {
            value = ContainerUpload;
            return IsContainerUpload;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestContainerUploadBlock PickContainerUpload() => IsContainerUpload
            ? ContainerUpload!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerUpload' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestTextBlock value) => new InputContentBlock((global::Anthropic.RequestTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestTextBlock?(InputContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromText(global::Anthropic.RequestTextBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestImageBlock value) => new InputContentBlock((global::Anthropic.RequestImageBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestImageBlock?(InputContentBlock @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromImage(global::Anthropic.RequestImageBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestDocumentBlock value) => new InputContentBlock((global::Anthropic.RequestDocumentBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestDocumentBlock?(InputContentBlock @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestDocumentBlock? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromDocument(global::Anthropic.RequestDocumentBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestSearchResultBlock value) => new InputContentBlock((global::Anthropic.RequestSearchResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestSearchResultBlock?(InputContentBlock @this) => @this.SearchResult;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestSearchResultBlock? value)
        {
            SearchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromSearchResult(global::Anthropic.RequestSearchResultBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestThinkingBlock value) => new InputContentBlock((global::Anthropic.RequestThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestThinkingBlock?(InputContentBlock @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestThinkingBlock? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromThinking(global::Anthropic.RequestThinkingBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestRedactedThinkingBlock value) => new InputContentBlock((global::Anthropic.RequestRedactedThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestRedactedThinkingBlock?(InputContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromRedactedThinking(global::Anthropic.RequestRedactedThinkingBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestToolUseBlock value) => new InputContentBlock((global::Anthropic.RequestToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestToolUseBlock?(InputContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromToolUse(global::Anthropic.RequestToolUseBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestToolResultBlock value) => new InputContentBlock((global::Anthropic.RequestToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestToolResultBlock?(InputContentBlock @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestToolResultBlock? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromToolResult(global::Anthropic.RequestToolResultBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestServerToolUseBlock value) => new InputContentBlock((global::Anthropic.RequestServerToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestServerToolUseBlock?(InputContentBlock @this) => @this.ServerToolUse;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestServerToolUseBlock? value)
        {
            ServerToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromServerToolUse(global::Anthropic.RequestServerToolUseBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestWebSearchToolResultBlock value) => new InputContentBlock((global::Anthropic.RequestWebSearchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestWebSearchToolResultBlock?(InputContentBlock @this) => @this.WebSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestWebSearchToolResultBlock? value)
        {
            WebSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromWebSearchToolResult(global::Anthropic.RequestWebSearchToolResultBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestWebFetchToolResultBlock value) => new InputContentBlock((global::Anthropic.RequestWebFetchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestWebFetchToolResultBlock?(InputContentBlock @this) => @this.WebFetchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestWebFetchToolResultBlock? value)
        {
            WebFetchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromWebFetchToolResult(global::Anthropic.RequestWebFetchToolResultBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestCodeExecutionToolResultBlock value) => new InputContentBlock((global::Anthropic.RequestCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestCodeExecutionToolResultBlock?(InputContentBlock @this) => @this.CodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestCodeExecutionToolResultBlock? value)
        {
            CodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromCodeExecutionToolResult(global::Anthropic.RequestCodeExecutionToolResultBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestBashCodeExecutionToolResultBlock value) => new InputContentBlock((global::Anthropic.RequestBashCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestBashCodeExecutionToolResultBlock?(InputContentBlock @this) => @this.BashCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestBashCodeExecutionToolResultBlock? value)
        {
            BashCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromBashCodeExecutionToolResult(global::Anthropic.RequestBashCodeExecutionToolResultBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock value) => new InputContentBlock((global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock?(InputContentBlock @this) => @this.TextEditorCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? value)
        {
            TextEditorCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromTextEditorCodeExecutionToolResult(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestToolSearchToolResultBlock value) => new InputContentBlock((global::Anthropic.RequestToolSearchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestToolSearchToolResultBlock?(InputContentBlock @this) => @this.ToolSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestToolSearchToolResultBlock? value)
        {
            ToolSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromToolSearchToolResult(global::Anthropic.RequestToolSearchToolResultBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::Anthropic.RequestContainerUploadBlock value) => new InputContentBlock((global::Anthropic.RequestContainerUploadBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestContainerUploadBlock?(InputContentBlock @this) => @this.ContainerUpload;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestContainerUploadBlock? value)
        {
            ContainerUpload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContentBlock FromContainerUpload(global::Anthropic.RequestContainerUploadBlock? value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(
            global::Anthropic.InputContentBlockDiscriminatorType? type,
            global::Anthropic.RequestTextBlock? text,
            global::Anthropic.RequestImageBlock? image,
            global::Anthropic.RequestDocumentBlock? document,
            global::Anthropic.RequestSearchResultBlock? searchResult,
            global::Anthropic.RequestThinkingBlock? thinking,
            global::Anthropic.RequestRedactedThinkingBlock? redactedThinking,
            global::Anthropic.RequestToolUseBlock? toolUse,
            global::Anthropic.RequestToolResultBlock? toolResult,
            global::Anthropic.RequestServerToolUseBlock? serverToolUse,
            global::Anthropic.RequestWebSearchToolResultBlock? webSearchToolResult,
            global::Anthropic.RequestWebFetchToolResultBlock? webFetchToolResult,
            global::Anthropic.RequestCodeExecutionToolResultBlock? codeExecutionToolResult,
            global::Anthropic.RequestBashCodeExecutionToolResultBlock? bashCodeExecutionToolResult,
            global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? textEditorCodeExecutionToolResult,
            global::Anthropic.RequestToolSearchToolResultBlock? toolSearchToolResult,
            global::Anthropic.RequestContainerUploadBlock? containerUpload
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
            CodeExecutionToolResult = codeExecutionToolResult;
            BashCodeExecutionToolResult = bashCodeExecutionToolResult;
            TextEditorCodeExecutionToolResult = textEditorCodeExecutionToolResult;
            ToolSearchToolResult = toolSearchToolResult;
            ContainerUpload = containerUpload;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContainerUpload as object ??
            ToolSearchToolResult as object ??
            TextEditorCodeExecutionToolResult as object ??
            BashCodeExecutionToolResult as object ??
            CodeExecutionToolResult as object ??
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
            CodeExecutionToolResult?.ToString() ??
            BashCodeExecutionToolResult?.ToString() ??
            TextEditorCodeExecutionToolResult?.ToString() ??
            ToolSearchToolResult?.ToString() ??
            ContainerUpload?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && IsToolSearchToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && IsContainerUpload;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.RequestTextBlock, TResult>? text = null,
            global::System.Func<global::Anthropic.RequestImageBlock, TResult>? image = null,
            global::System.Func<global::Anthropic.RequestDocumentBlock, TResult>? document = null,
            global::System.Func<global::Anthropic.RequestSearchResultBlock, TResult>? searchResult = null,
            global::System.Func<global::Anthropic.RequestThinkingBlock, TResult>? thinking = null,
            global::System.Func<global::Anthropic.RequestRedactedThinkingBlock, TResult>? redactedThinking = null,
            global::System.Func<global::Anthropic.RequestToolUseBlock, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.RequestToolResultBlock, TResult>? toolResult = null,
            global::System.Func<global::Anthropic.RequestServerToolUseBlock, TResult>? serverToolUse = null,
            global::System.Func<global::Anthropic.RequestWebSearchToolResultBlock, TResult>? webSearchToolResult = null,
            global::System.Func<global::Anthropic.RequestWebFetchToolResultBlock, TResult>? webFetchToolResult = null,
            global::System.Func<global::Anthropic.RequestCodeExecutionToolResultBlock, TResult>? codeExecutionToolResult = null,
            global::System.Func<global::Anthropic.RequestBashCodeExecutionToolResultBlock, TResult>? bashCodeExecutionToolResult = null,
            global::System.Func<global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock, TResult>? textEditorCodeExecutionToolResult = null,
            global::System.Func<global::Anthropic.RequestToolSearchToolResultBlock, TResult>? toolSearchToolResult = null,
            global::System.Func<global::Anthropic.RequestContainerUploadBlock, TResult>? containerUpload = null,
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
            else if (IsContainerUpload && containerUpload != null)
            {
                return containerUpload(ContainerUpload!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.RequestTextBlock>? text = null,

            global::System.Action<global::Anthropic.RequestImageBlock>? image = null,

            global::System.Action<global::Anthropic.RequestDocumentBlock>? document = null,

            global::System.Action<global::Anthropic.RequestSearchResultBlock>? searchResult = null,

            global::System.Action<global::Anthropic.RequestThinkingBlock>? thinking = null,

            global::System.Action<global::Anthropic.RequestRedactedThinkingBlock>? redactedThinking = null,

            global::System.Action<global::Anthropic.RequestToolUseBlock>? toolUse = null,

            global::System.Action<global::Anthropic.RequestToolResultBlock>? toolResult = null,

            global::System.Action<global::Anthropic.RequestServerToolUseBlock>? serverToolUse = null,

            global::System.Action<global::Anthropic.RequestWebSearchToolResultBlock>? webSearchToolResult = null,

            global::System.Action<global::Anthropic.RequestWebFetchToolResultBlock>? webFetchToolResult = null,

            global::System.Action<global::Anthropic.RequestCodeExecutionToolResultBlock>? codeExecutionToolResult = null,

            global::System.Action<global::Anthropic.RequestBashCodeExecutionToolResultBlock>? bashCodeExecutionToolResult = null,

            global::System.Action<global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock>? textEditorCodeExecutionToolResult = null,

            global::System.Action<global::Anthropic.RequestToolSearchToolResultBlock>? toolSearchToolResult = null,

            global::System.Action<global::Anthropic.RequestContainerUploadBlock>? containerUpload = null,
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
            else if (IsContainerUpload)
            {
                containerUpload?.Invoke(ContainerUpload!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.RequestTextBlock>? text = null,
            global::System.Action<global::Anthropic.RequestImageBlock>? image = null,
            global::System.Action<global::Anthropic.RequestDocumentBlock>? document = null,
            global::System.Action<global::Anthropic.RequestSearchResultBlock>? searchResult = null,
            global::System.Action<global::Anthropic.RequestThinkingBlock>? thinking = null,
            global::System.Action<global::Anthropic.RequestRedactedThinkingBlock>? redactedThinking = null,
            global::System.Action<global::Anthropic.RequestToolUseBlock>? toolUse = null,
            global::System.Action<global::Anthropic.RequestToolResultBlock>? toolResult = null,
            global::System.Action<global::Anthropic.RequestServerToolUseBlock>? serverToolUse = null,
            global::System.Action<global::Anthropic.RequestWebSearchToolResultBlock>? webSearchToolResult = null,
            global::System.Action<global::Anthropic.RequestWebFetchToolResultBlock>? webFetchToolResult = null,
            global::System.Action<global::Anthropic.RequestCodeExecutionToolResultBlock>? codeExecutionToolResult = null,
            global::System.Action<global::Anthropic.RequestBashCodeExecutionToolResultBlock>? bashCodeExecutionToolResult = null,
            global::System.Action<global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock>? textEditorCodeExecutionToolResult = null,
            global::System.Action<global::Anthropic.RequestToolSearchToolResultBlock>? toolSearchToolResult = null,
            global::System.Action<global::Anthropic.RequestContainerUploadBlock>? containerUpload = null,
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
            else if (IsContainerUpload)
            {
                containerUpload?.Invoke(ContainerUpload!);
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
                typeof(global::Anthropic.RequestTextBlock),
                Image,
                typeof(global::Anthropic.RequestImageBlock),
                Document,
                typeof(global::Anthropic.RequestDocumentBlock),
                SearchResult,
                typeof(global::Anthropic.RequestSearchResultBlock),
                Thinking,
                typeof(global::Anthropic.RequestThinkingBlock),
                RedactedThinking,
                typeof(global::Anthropic.RequestRedactedThinkingBlock),
                ToolUse,
                typeof(global::Anthropic.RequestToolUseBlock),
                ToolResult,
                typeof(global::Anthropic.RequestToolResultBlock),
                ServerToolUse,
                typeof(global::Anthropic.RequestServerToolUseBlock),
                WebSearchToolResult,
                typeof(global::Anthropic.RequestWebSearchToolResultBlock),
                WebFetchToolResult,
                typeof(global::Anthropic.RequestWebFetchToolResultBlock),
                CodeExecutionToolResult,
                typeof(global::Anthropic.RequestCodeExecutionToolResultBlock),
                BashCodeExecutionToolResult,
                typeof(global::Anthropic.RequestBashCodeExecutionToolResultBlock),
                TextEditorCodeExecutionToolResult,
                typeof(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock),
                ToolSearchToolResult,
                typeof(global::Anthropic.RequestToolSearchToolResultBlock),
                ContainerUpload,
                typeof(global::Anthropic.RequestContainerUploadBlock),
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
        public bool Equals(InputContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestDocumentBlock?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestSearchResultBlock?>.Default.Equals(SearchResult, other.SearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestServerToolUseBlock?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestWebSearchToolResultBlock?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestWebFetchToolResultBlock?>.Default.Equals(WebFetchToolResult, other.WebFetchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestCodeExecutionToolResultBlock?>.Default.Equals(CodeExecutionToolResult, other.CodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestBashCodeExecutionToolResultBlock?>.Default.Equals(BashCodeExecutionToolResult, other.BashCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock?>.Default.Equals(TextEditorCodeExecutionToolResult, other.TextEditorCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestToolSearchToolResultBlock?>.Default.Equals(ToolSearchToolResult, other.ToolSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestContainerUploadBlock?>.Default.Equals(ContainerUpload, other.ContainerUpload) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputContentBlock obj1, InputContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputContentBlock obj1, InputContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputContentBlock o && Equals(o);
        }
    }
}
