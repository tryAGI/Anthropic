#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaContentBlock : global::System.IEquatable<BetaContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaContentBlockDiscriminatorType? Type { get; }

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
        public static implicit operator BetaContentBlock(global::Anthropic.BetaResponseTextBlock value) => new BetaContentBlock((global::Anthropic.BetaResponseTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseTextBlock?(BetaContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::Anthropic.BetaResponseTextBlock? value)
        {
            Text = value;
        }

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
        public static implicit operator BetaContentBlock(global::Anthropic.BetaResponseToolUseBlock value) => new BetaContentBlock((global::Anthropic.BetaResponseToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolUseBlock?(BetaContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::Anthropic.BetaResponseToolUseBlock? value)
        {
            ToolUse = value;
        }

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
        public static implicit operator BetaContentBlock(global::Anthropic.BetaResponseServerToolUseBlock value) => new BetaContentBlock((global::Anthropic.BetaResponseServerToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseServerToolUseBlock?(BetaContentBlock @this) => @this.ServerToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::Anthropic.BetaResponseServerToolUseBlock? value)
        {
            ServerToolUse = value;
        }

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
        public static implicit operator BetaContentBlock(global::Anthropic.BetaResponseWebSearchToolResultBlock value) => new BetaContentBlock((global::Anthropic.BetaResponseWebSearchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseWebSearchToolResultBlock?(BetaContentBlock @this) => @this.WebSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::Anthropic.BetaResponseWebSearchToolResultBlock? value)
        {
            WebSearchToolResult = value;
        }

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
        public static implicit operator BetaContentBlock(global::Anthropic.BetaResponseCodeExecutionToolResultBlock value) => new BetaContentBlock((global::Anthropic.BetaResponseCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseCodeExecutionToolResultBlock?(BetaContentBlock @this) => @this.CodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::Anthropic.BetaResponseCodeExecutionToolResultBlock? value)
        {
            CodeExecutionToolResult = value;
        }

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
        public static implicit operator BetaContentBlock(global::Anthropic.BetaResponseMCPToolUseBlock value) => new BetaContentBlock((global::Anthropic.BetaResponseMCPToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseMCPToolUseBlock?(BetaContentBlock @this) => @this.McpToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::Anthropic.BetaResponseMCPToolUseBlock? value)
        {
            McpToolUse = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator BetaContentBlock(global::Anthropic.BetaResponseMCPToolResultBlock value) => new BetaContentBlock((global::Anthropic.BetaResponseMCPToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseMCPToolResultBlock?(BetaContentBlock @this) => @this.McpToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::Anthropic.BetaResponseMCPToolResultBlock? value)
        {
            McpToolResult = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator BetaContentBlock(global::Anthropic.BetaResponseContainerUploadBlock value) => new BetaContentBlock((global::Anthropic.BetaResponseContainerUploadBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseContainerUploadBlock?(BetaContentBlock @this) => @this.ContainerUpload;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::Anthropic.BetaResponseContainerUploadBlock? value)
        {
            ContainerUpload = value;
        }

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
        public static implicit operator BetaContentBlock(global::Anthropic.BetaResponseThinkingBlock value) => new BetaContentBlock((global::Anthropic.BetaResponseThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseThinkingBlock?(BetaContentBlock @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::Anthropic.BetaResponseThinkingBlock? value)
        {
            Thinking = value;
        }

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
        public static implicit operator BetaContentBlock(global::Anthropic.BetaResponseRedactedThinkingBlock value) => new BetaContentBlock((global::Anthropic.BetaResponseRedactedThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseRedactedThinkingBlock?(BetaContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::Anthropic.BetaResponseRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(
            global::Anthropic.BetaContentBlockDiscriminatorType? type,
            global::Anthropic.BetaResponseTextBlock? text,
            global::Anthropic.BetaResponseToolUseBlock? toolUse,
            global::Anthropic.BetaResponseServerToolUseBlock? serverToolUse,
            global::Anthropic.BetaResponseWebSearchToolResultBlock? webSearchToolResult,
            global::Anthropic.BetaResponseCodeExecutionToolResultBlock? codeExecutionToolResult,
            global::Anthropic.BetaResponseMCPToolUseBlock? mcpToolUse,
            global::Anthropic.BetaResponseMCPToolResultBlock? mcpToolResult,
            global::Anthropic.BetaResponseContainerUploadBlock? containerUpload,
            global::Anthropic.BetaResponseThinkingBlock? thinking,
            global::Anthropic.BetaResponseRedactedThinkingBlock? redactedThinking
            )
        {
            Type = type;

            Text = text;
            ToolUse = toolUse;
            ServerToolUse = serverToolUse;
            WebSearchToolResult = webSearchToolResult;
            CodeExecutionToolResult = codeExecutionToolResult;
            McpToolUse = mcpToolUse;
            McpToolResult = mcpToolResult;
            ContainerUpload = containerUpload;
            Thinking = thinking;
            RedactedThinking = redactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RedactedThinking as object ??
            Thinking as object ??
            ContainerUpload as object ??
            McpToolResult as object ??
            McpToolUse as object ??
            CodeExecutionToolResult as object ??
            WebSearchToolResult as object ??
            ServerToolUse as object ??
            ToolUse as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ToolUse?.ToString() ??
            ServerToolUse?.ToString() ??
            WebSearchToolResult?.ToString() ??
            CodeExecutionToolResult?.ToString() ??
            McpToolUse?.ToString() ??
            McpToolResult?.ToString() ??
            ContainerUpload?.ToString() ??
            Thinking?.ToString() ??
            RedactedThinking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsThinking && !IsRedactedThinking || !IsText && IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && !IsServerToolUse && IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && IsMcpToolResult && !IsContainerUpload && !IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && IsContainerUpload && !IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionToolResult && !IsMcpToolUse && !IsMcpToolResult && !IsContainerUpload && !IsThinking && IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaResponseTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaResponseToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.BetaResponseServerToolUseBlock?, TResult>? serverToolUse = null,
            global::System.Func<global::Anthropic.BetaResponseWebSearchToolResultBlock?, TResult>? webSearchToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseCodeExecutionToolResultBlock?, TResult>? codeExecutionToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseMCPToolUseBlock?, TResult>? mcpToolUse = null,
            global::System.Func<global::Anthropic.BetaResponseMCPToolResultBlock?, TResult>? mcpToolResult = null,
            global::System.Func<global::Anthropic.BetaResponseContainerUploadBlock?, TResult>? containerUpload = null,
            global::System.Func<global::Anthropic.BetaResponseThinkingBlock?, TResult>? thinking = null,
            global::System.Func<global::Anthropic.BetaResponseRedactedThinkingBlock?, TResult>? redactedThinking = null,
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
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsRedactedThinking && redactedThinking != null)
            {
                return redactedThinking(RedactedThinking!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaResponseTextBlock?>? text = null,
            global::System.Action<global::Anthropic.BetaResponseToolUseBlock?>? toolUse = null,
            global::System.Action<global::Anthropic.BetaResponseServerToolUseBlock?>? serverToolUse = null,
            global::System.Action<global::Anthropic.BetaResponseWebSearchToolResultBlock?>? webSearchToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseCodeExecutionToolResultBlock?>? codeExecutionToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseMCPToolUseBlock?>? mcpToolUse = null,
            global::System.Action<global::Anthropic.BetaResponseMCPToolResultBlock?>? mcpToolResult = null,
            global::System.Action<global::Anthropic.BetaResponseContainerUploadBlock?>? containerUpload = null,
            global::System.Action<global::Anthropic.BetaResponseThinkingBlock?>? thinking = null,
            global::System.Action<global::Anthropic.BetaResponseRedactedThinkingBlock?>? redactedThinking = null,
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
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsRedactedThinking)
            {
                redactedThinking?.Invoke(RedactedThinking!);
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
                ToolUse,
                typeof(global::Anthropic.BetaResponseToolUseBlock),
                ServerToolUse,
                typeof(global::Anthropic.BetaResponseServerToolUseBlock),
                WebSearchToolResult,
                typeof(global::Anthropic.BetaResponseWebSearchToolResultBlock),
                CodeExecutionToolResult,
                typeof(global::Anthropic.BetaResponseCodeExecutionToolResultBlock),
                McpToolUse,
                typeof(global::Anthropic.BetaResponseMCPToolUseBlock),
                McpToolResult,
                typeof(global::Anthropic.BetaResponseMCPToolResultBlock),
                ContainerUpload,
                typeof(global::Anthropic.BetaResponseContainerUploadBlock),
                Thinking,
                typeof(global::Anthropic.BetaResponseThinkingBlock),
                RedactedThinking,
                typeof(global::Anthropic.BetaResponseRedactedThinkingBlock),
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
        public bool Equals(BetaContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseServerToolUseBlock?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseWebSearchToolResultBlock?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseCodeExecutionToolResultBlock?>.Default.Equals(CodeExecutionToolResult, other.CodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseMCPToolUseBlock?>.Default.Equals(McpToolUse, other.McpToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseMCPToolResultBlock?>.Default.Equals(McpToolResult, other.McpToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseContainerUploadBlock?>.Default.Equals(ContainerUpload, other.ContainerUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaContentBlock obj1, BetaContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaContentBlock obj1, BetaContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaContentBlock o && Equals(o);
        }
    }
}
