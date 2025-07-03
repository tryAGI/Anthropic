#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentBlock3 : global::System.IEquatable<ContentBlock3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseTextBlock? Text { get; init; }
#else
        public global::Anthropic.ResponseTextBlock? Text { get; }
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
        public static implicit operator ContentBlock3(global::Anthropic.ResponseTextBlock value) => new ContentBlock3((global::Anthropic.ResponseTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseTextBlock?(ContentBlock3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock3(global::Anthropic.ResponseTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseThinkingBlock? Thinking { get; init; }
#else
        public global::Anthropic.ResponseThinkingBlock? Thinking { get; }
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
        public static implicit operator ContentBlock3(global::Anthropic.ResponseThinkingBlock value) => new ContentBlock3((global::Anthropic.ResponseThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseThinkingBlock?(ContentBlock3 @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock3(global::Anthropic.ResponseThinkingBlock? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseRedactedThinkingBlock? RedactedThinking { get; init; }
#else
        public global::Anthropic.ResponseRedactedThinkingBlock? RedactedThinking { get; }
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
        public static implicit operator ContentBlock3(global::Anthropic.ResponseRedactedThinkingBlock value) => new ContentBlock3((global::Anthropic.ResponseRedactedThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseRedactedThinkingBlock?(ContentBlock3 @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock3(global::Anthropic.ResponseRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseToolUseBlock? ToolUse { get; init; }
#else
        public global::Anthropic.ResponseToolUseBlock? ToolUse { get; }
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
        public static implicit operator ContentBlock3(global::Anthropic.ResponseToolUseBlock value) => new ContentBlock3((global::Anthropic.ResponseToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseToolUseBlock?(ContentBlock3 @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock3(global::Anthropic.ResponseToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseServerToolUseBlock? ServerToolUse { get; init; }
#else
        public global::Anthropic.ResponseServerToolUseBlock? ServerToolUse { get; }
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
        public static implicit operator ContentBlock3(global::Anthropic.ResponseServerToolUseBlock value) => new ContentBlock3((global::Anthropic.ResponseServerToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseServerToolUseBlock?(ContentBlock3 @this) => @this.ServerToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock3(global::Anthropic.ResponseServerToolUseBlock? value)
        {
            ServerToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseWebSearchToolResultBlock? WebSearchToolResult { get; init; }
#else
        public global::Anthropic.ResponseWebSearchToolResultBlock? WebSearchToolResult { get; }
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
        public static implicit operator ContentBlock3(global::Anthropic.ResponseWebSearchToolResultBlock value) => new ContentBlock3((global::Anthropic.ResponseWebSearchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseWebSearchToolResultBlock?(ContentBlock3 @this) => @this.WebSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock3(global::Anthropic.ResponseWebSearchToolResultBlock? value)
        {
            WebSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock3(
            global::Anthropic.ContentBlockDiscriminatorType? type,
            global::Anthropic.ResponseTextBlock? text,
            global::Anthropic.ResponseThinkingBlock? thinking,
            global::Anthropic.ResponseRedactedThinkingBlock? redactedThinking,
            global::Anthropic.ResponseToolUseBlock? toolUse,
            global::Anthropic.ResponseServerToolUseBlock? serverToolUse,
            global::Anthropic.ResponseWebSearchToolResultBlock? webSearchToolResult
            )
        {
            Type = type;

            Text = text;
            Thinking = thinking;
            RedactedThinking = redactedThinking;
            ToolUse = toolUse;
            ServerToolUse = serverToolUse;
            WebSearchToolResult = webSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            WebSearchToolResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult || !IsText && IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult || !IsText && !IsThinking && IsRedactedThinking && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult || !IsText && !IsThinking && !IsRedactedThinking && IsToolUse && !IsServerToolUse && !IsWebSearchToolResult || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && IsServerToolUse && !IsWebSearchToolResult || !IsText && !IsThinking && !IsRedactedThinking && !IsToolUse && !IsServerToolUse && IsWebSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.ResponseTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.ResponseThinkingBlock?, TResult>? thinking = null,
            global::System.Func<global::Anthropic.ResponseRedactedThinkingBlock?, TResult>? redactedThinking = null,
            global::System.Func<global::Anthropic.ResponseToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.ResponseServerToolUseBlock?, TResult>? serverToolUse = null,
            global::System.Func<global::Anthropic.ResponseWebSearchToolResultBlock?, TResult>? webSearchToolResult = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ResponseTextBlock?>? text = null,
            global::System.Action<global::Anthropic.ResponseThinkingBlock?>? thinking = null,
            global::System.Action<global::Anthropic.ResponseRedactedThinkingBlock?>? redactedThinking = null,
            global::System.Action<global::Anthropic.ResponseToolUseBlock?>? toolUse = null,
            global::System.Action<global::Anthropic.ResponseServerToolUseBlock?>? serverToolUse = null,
            global::System.Action<global::Anthropic.ResponseWebSearchToolResultBlock?>? webSearchToolResult = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Anthropic.ResponseTextBlock),
                Thinking,
                typeof(global::Anthropic.ResponseThinkingBlock),
                RedactedThinking,
                typeof(global::Anthropic.ResponseRedactedThinkingBlock),
                ToolUse,
                typeof(global::Anthropic.ResponseToolUseBlock),
                ServerToolUse,
                typeof(global::Anthropic.ResponseServerToolUseBlock),
                WebSearchToolResult,
                typeof(global::Anthropic.ResponseWebSearchToolResultBlock),
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
        public bool Equals(ContentBlock3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseServerToolUseBlock?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseWebSearchToolResultBlock?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentBlock3 obj1, ContentBlock3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentBlock3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentBlock3 obj1, ContentBlock3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentBlock3 o && Equals(o);
        }
    }
}
