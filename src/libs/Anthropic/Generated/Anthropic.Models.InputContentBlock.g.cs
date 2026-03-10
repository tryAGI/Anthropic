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
            global::System.Func<global::Anthropic.RequestTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.RequestImageBlock?, TResult>? image = null,
            global::System.Func<global::Anthropic.RequestDocumentBlock?, TResult>? document = null,
            global::System.Func<global::Anthropic.RequestSearchResultBlock?, TResult>? searchResult = null,
            global::System.Func<global::Anthropic.RequestThinkingBlock?, TResult>? thinking = null,
            global::System.Func<global::Anthropic.RequestRedactedThinkingBlock?, TResult>? redactedThinking = null,
            global::System.Func<global::Anthropic.RequestToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.RequestToolResultBlock?, TResult>? toolResult = null,
            global::System.Func<global::Anthropic.RequestServerToolUseBlock?, TResult>? serverToolUse = null,
            global::System.Func<global::Anthropic.RequestWebSearchToolResultBlock?, TResult>? webSearchToolResult = null,
            global::System.Func<global::Anthropic.RequestWebFetchToolResultBlock?, TResult>? webFetchToolResult = null,
            global::System.Func<global::Anthropic.RequestCodeExecutionToolResultBlock?, TResult>? codeExecutionToolResult = null,
            global::System.Func<global::Anthropic.RequestBashCodeExecutionToolResultBlock?, TResult>? bashCodeExecutionToolResult = null,
            global::System.Func<global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock?, TResult>? textEditorCodeExecutionToolResult = null,
            global::System.Func<global::Anthropic.RequestToolSearchToolResultBlock?, TResult>? toolSearchToolResult = null,
            global::System.Func<global::Anthropic.RequestContainerUploadBlock?, TResult>? containerUpload = null,
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
            global::System.Action<global::Anthropic.RequestTextBlock?>? text = null,
            global::System.Action<global::Anthropic.RequestImageBlock?>? image = null,
            global::System.Action<global::Anthropic.RequestDocumentBlock?>? document = null,
            global::System.Action<global::Anthropic.RequestSearchResultBlock?>? searchResult = null,
            global::System.Action<global::Anthropic.RequestThinkingBlock?>? thinking = null,
            global::System.Action<global::Anthropic.RequestRedactedThinkingBlock?>? redactedThinking = null,
            global::System.Action<global::Anthropic.RequestToolUseBlock?>? toolUse = null,
            global::System.Action<global::Anthropic.RequestToolResultBlock?>? toolResult = null,
            global::System.Action<global::Anthropic.RequestServerToolUseBlock?>? serverToolUse = null,
            global::System.Action<global::Anthropic.RequestWebSearchToolResultBlock?>? webSearchToolResult = null,
            global::System.Action<global::Anthropic.RequestWebFetchToolResultBlock?>? webFetchToolResult = null,
            global::System.Action<global::Anthropic.RequestCodeExecutionToolResultBlock?>? codeExecutionToolResult = null,
            global::System.Action<global::Anthropic.RequestBashCodeExecutionToolResultBlock?>? bashCodeExecutionToolResult = null,
            global::System.Action<global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock?>? textEditorCodeExecutionToolResult = null,
            global::System.Action<global::Anthropic.RequestToolSearchToolResultBlock?>? toolSearchToolResult = null,
            global::System.Action<global::Anthropic.RequestContainerUploadBlock?>? containerUpload = null,
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
