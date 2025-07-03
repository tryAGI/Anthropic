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
        /// 
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
            global::Anthropic.BetaRequestCodeExecutionToolResultBlock? codeExecutionToolResult,
            global::Anthropic.BetaRequestMCPToolUseBlock? mcpToolUse,
            global::Anthropic.BetaRequestMCPToolResultBlock? mcpToolResult,
            global::Anthropic.BetaRequestContainerUploadBlock? containerUpload
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
            CodeExecutionToolResult = codeExecutionToolResult;
            McpToolUse = mcpToolUse;
            McpToolResult = mcpToolResult;
            ContainerUpload = containerUpload;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContainerUpload as object ??
            McpToolResult as object ??
            McpToolUse as object ??
            CodeExecutionToolResult as object ??
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
            CodeExecutionToolResult?.ToString() ??
            McpToolUse?.ToString() ??
            McpToolResult?.ToString() ??
            ContainerUpload?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && IsMcpToolResult && !IsContainerUpload || !IsText && !IsImage && !IsDocument && !IsSearchResult && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsToolResult && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && IsContainerUpload;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRequestTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaRequestImageBlock?, TResult>? image = null,
            global::System.Func<global::Anthropic.BetaRequestDocumentBlock?, TResult>? document = null,
            global::System.Func<global::Anthropic.BetaRequestSearchResultBlock?, TResult>? searchResult = null,
            global::System.Func<global::Anthropic.BetaRequestThinkingBlock?, TResult>? thinking = null,
            global::System.Func<global::Anthropic.BetaRequestRedactedThinkingBlock?, TResult>? redactedThinking = null,
            global::System.Func<global::Anthropic.BetaRequestToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.BetaRequestToolResultBlock?, TResult>? toolResult = null,
            global::System.Func<global::Anthropic.BetaRequestServerToolUseBlock?, TResult>? serverToolUse = null,
            global::System.Func<global::Anthropic.BetaRequestWebSearchToolResultBlock?, TResult>? webSearchToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestCodeExecutionToolResultBlock?, TResult>? codeExecutionToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestMCPToolUseBlock?, TResult>? mcpToolUse = null,
            global::System.Func<global::Anthropic.BetaRequestMCPToolResultBlock?, TResult>? mcpToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestContainerUploadBlock?, TResult>? containerUpload = null,
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
            else if (IsCodeExecutionToolResult && codeExecutionToolResult != null)
            {
                return codeExecutionToolResult(CodeExecutionToolResult!);
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaRequestTextBlock?>? text = null,
            global::System.Action<global::Anthropic.BetaRequestImageBlock?>? image = null,
            global::System.Action<global::Anthropic.BetaRequestDocumentBlock?>? document = null,
            global::System.Action<global::Anthropic.BetaRequestSearchResultBlock?>? searchResult = null,
            global::System.Action<global::Anthropic.BetaRequestThinkingBlock?>? thinking = null,
            global::System.Action<global::Anthropic.BetaRequestRedactedThinkingBlock?>? redactedThinking = null,
            global::System.Action<global::Anthropic.BetaRequestToolUseBlock?>? toolUse = null,
            global::System.Action<global::Anthropic.BetaRequestToolResultBlock?>? toolResult = null,
            global::System.Action<global::Anthropic.BetaRequestServerToolUseBlock?>? serverToolUse = null,
            global::System.Action<global::Anthropic.BetaRequestWebSearchToolResultBlock?>? webSearchToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestCodeExecutionToolResultBlock?>? codeExecutionToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestMCPToolUseBlock?>? mcpToolUse = null,
            global::System.Action<global::Anthropic.BetaRequestMCPToolResultBlock?>? mcpToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestContainerUploadBlock?>? containerUpload = null,
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
            else if (IsCodeExecutionToolResult)
            {
                codeExecutionToolResult?.Invoke(CodeExecutionToolResult!);
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
                CodeExecutionToolResult,
                typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock),
                McpToolUse,
                typeof(global::Anthropic.BetaRequestMCPToolUseBlock),
                McpToolResult,
                typeof(global::Anthropic.BetaRequestMCPToolResultBlock),
                ContainerUpload,
                typeof(global::Anthropic.BetaRequestContainerUploadBlock),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestCodeExecutionToolResultBlock?>.Default.Equals(CodeExecutionToolResult, other.CodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestMCPToolUseBlock?>.Default.Equals(McpToolUse, other.McpToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestMCPToolResultBlock?>.Default.Equals(McpToolResult, other.McpToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestContainerUploadBlock?>.Default.Equals(ContainerUpload, other.ContainerUpload) 
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
