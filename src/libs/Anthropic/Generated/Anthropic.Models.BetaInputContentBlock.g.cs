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
        public BetaInputContentBlock(
            global::Anthropic.BetaInputContentBlockDiscriminatorType? type,
            global::Anthropic.BetaRequestTextBlock? text,
            global::Anthropic.BetaRequestImageBlock? image,
            global::Anthropic.BetaRequestToolUseBlock? toolUse,
            global::Anthropic.BetaRequestServerToolUseBlock? serverToolUse,
            global::Anthropic.BetaRequestWebSearchToolResultBlock? webSearchToolResult,
            global::Anthropic.BetaRequestToolResultBlock? toolResult,
            global::Anthropic.BetaRequestDocumentBlock? document,
            global::Anthropic.BetaRequestThinkingBlock? thinking,
            global::Anthropic.BetaRequestRedactedThinkingBlock? redactedThinking
            )
        {
            Type = type;

            Text = text;
            Image = image;
            ToolUse = toolUse;
            ServerToolUse = serverToolUse;
            WebSearchToolResult = webSearchToolResult;
            ToolResult = toolResult;
            Document = document;
            Thinking = thinking;
            RedactedThinking = redactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RedactedThinking as object ??
            Thinking as object ??
            Document as object ??
            ToolResult as object ??
            WebSearchToolResult as object ??
            ServerToolUse as object ??
            ToolUse as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            ToolUse?.ToString() ??
            ServerToolUse?.ToString() ??
            WebSearchToolResult?.ToString() ??
            ToolResult?.ToString() ??
            Document?.ToString() ??
            Thinking?.ToString() ??
            RedactedThinking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsToolResult && !IsDocument && !IsThinking && !IsRedactedThinking || !IsText && IsImage && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsToolResult && !IsDocument && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsToolResult && !IsDocument && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsToolUse && IsServerToolUse && !IsWebSearchToolResult && !IsToolResult && !IsDocument && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsToolUse && !IsServerToolUse && IsWebSearchToolResult && !IsToolResult && !IsDocument && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && IsToolResult && !IsDocument && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsToolResult && IsDocument && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsToolResult && !IsDocument && IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsToolUse && !IsServerToolUse && !IsWebSearchToolResult && !IsToolResult && !IsDocument && !IsThinking && IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRequestTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaRequestImageBlock?, TResult>? image = null,
            global::System.Func<global::Anthropic.BetaRequestToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.BetaRequestServerToolUseBlock?, TResult>? serverToolUse = null,
            global::System.Func<global::Anthropic.BetaRequestWebSearchToolResultBlock?, TResult>? webSearchToolResult = null,
            global::System.Func<global::Anthropic.BetaRequestToolResultBlock?, TResult>? toolResult = null,
            global::System.Func<global::Anthropic.BetaRequestDocumentBlock?, TResult>? document = null,
            global::System.Func<global::Anthropic.BetaRequestThinkingBlock?, TResult>? thinking = null,
            global::System.Func<global::Anthropic.BetaRequestRedactedThinkingBlock?, TResult>? redactedThinking = null,
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
            else if (IsToolResult && toolResult != null)
            {
                return toolResult(ToolResult!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
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
            global::System.Action<global::Anthropic.BetaRequestTextBlock?>? text = null,
            global::System.Action<global::Anthropic.BetaRequestImageBlock?>? image = null,
            global::System.Action<global::Anthropic.BetaRequestToolUseBlock?>? toolUse = null,
            global::System.Action<global::Anthropic.BetaRequestServerToolUseBlock?>? serverToolUse = null,
            global::System.Action<global::Anthropic.BetaRequestWebSearchToolResultBlock?>? webSearchToolResult = null,
            global::System.Action<global::Anthropic.BetaRequestToolResultBlock?>? toolResult = null,
            global::System.Action<global::Anthropic.BetaRequestDocumentBlock?>? document = null,
            global::System.Action<global::Anthropic.BetaRequestThinkingBlock?>? thinking = null,
            global::System.Action<global::Anthropic.BetaRequestRedactedThinkingBlock?>? redactedThinking = null,
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
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
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
                typeof(global::Anthropic.BetaRequestTextBlock),
                Image,
                typeof(global::Anthropic.BetaRequestImageBlock),
                ToolUse,
                typeof(global::Anthropic.BetaRequestToolUseBlock),
                ServerToolUse,
                typeof(global::Anthropic.BetaRequestServerToolUseBlock),
                WebSearchToolResult,
                typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock),
                ToolResult,
                typeof(global::Anthropic.BetaRequestToolResultBlock),
                Document,
                typeof(global::Anthropic.BetaRequestDocumentBlock),
                Thinking,
                typeof(global::Anthropic.BetaRequestThinkingBlock),
                RedactedThinking,
                typeof(global::Anthropic.BetaRequestRedactedThinkingBlock),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestServerToolUseBlock?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestWebSearchToolResultBlock?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestDocumentBlock?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) 
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
