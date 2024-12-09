#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant2Item3 : global::System.IEquatable<ContentVariant2Item3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.PromptCachingBetaRequestTextBlock? Text { get; init; }
#else
        public global::Anthropic.PromptCachingBetaRequestTextBlock? Text { get; }
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
        public static implicit operator ContentVariant2Item3(global::Anthropic.PromptCachingBetaRequestTextBlock value) => new ContentVariant2Item3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PromptCachingBetaRequestTextBlock?(ContentVariant2Item3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item3(global::Anthropic.PromptCachingBetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.PromptCachingBetaRequestImageBlock? Image { get; init; }
#else
        public global::Anthropic.PromptCachingBetaRequestImageBlock? Image { get; }
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
        public static implicit operator ContentVariant2Item3(global::Anthropic.PromptCachingBetaRequestImageBlock value) => new ContentVariant2Item3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PromptCachingBetaRequestImageBlock?(ContentVariant2Item3 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item3(global::Anthropic.PromptCachingBetaRequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.PromptCachingBetaRequestToolUseBlock? ToolUse { get; init; }
#else
        public global::Anthropic.PromptCachingBetaRequestToolUseBlock? ToolUse { get; }
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
        public static implicit operator ContentVariant2Item3(global::Anthropic.PromptCachingBetaRequestToolUseBlock value) => new ContentVariant2Item3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PromptCachingBetaRequestToolUseBlock?(ContentVariant2Item3 @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item3(global::Anthropic.PromptCachingBetaRequestToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.PromptCachingBetaRequestToolResultBlock? ToolResult { get; init; }
#else
        public global::Anthropic.PromptCachingBetaRequestToolResultBlock? ToolResult { get; }
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
        public static implicit operator ContentVariant2Item3(global::Anthropic.PromptCachingBetaRequestToolResultBlock value) => new ContentVariant2Item3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PromptCachingBetaRequestToolResultBlock?(ContentVariant2Item3 @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item3(global::Anthropic.PromptCachingBetaRequestToolResultBlock? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item3(
            global::Anthropic.PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType? type,
            global::Anthropic.PromptCachingBetaRequestTextBlock? text,
            global::Anthropic.PromptCachingBetaRequestImageBlock? image,
            global::Anthropic.PromptCachingBetaRequestToolUseBlock? toolUse,
            global::Anthropic.PromptCachingBetaRequestToolResultBlock? toolResult
            )
        {
            Type = type;

            Text = text;
            Image = image;
            ToolUse = toolUse;
            ToolResult = toolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolResult as object ??
            ToolUse as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsToolUse && !IsToolResult || !IsText && IsImage && !IsToolUse && !IsToolResult || !IsText && !IsImage && IsToolUse && !IsToolResult || !IsText && !IsImage && !IsToolUse && IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.PromptCachingBetaRequestTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.PromptCachingBetaRequestImageBlock?, TResult>? image = null,
            global::System.Func<global::Anthropic.PromptCachingBetaRequestToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.PromptCachingBetaRequestToolResultBlock?, TResult>? toolResult = null,
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
            else if (IsToolResult && toolResult != null)
            {
                return toolResult(ToolResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.PromptCachingBetaRequestTextBlock?>? text = null,
            global::System.Action<global::Anthropic.PromptCachingBetaRequestImageBlock?>? image = null,
            global::System.Action<global::Anthropic.PromptCachingBetaRequestToolUseBlock?>? toolUse = null,
            global::System.Action<global::Anthropic.PromptCachingBetaRequestToolResultBlock?>? toolResult = null,
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
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
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
                typeof(global::Anthropic.PromptCachingBetaRequestTextBlock),
                Image,
                typeof(global::Anthropic.PromptCachingBetaRequestImageBlock),
                ToolUse,
                typeof(global::Anthropic.PromptCachingBetaRequestToolUseBlock),
                ToolResult,
                typeof(global::Anthropic.PromptCachingBetaRequestToolResultBlock),
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
        public bool Equals(ContentVariant2Item3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PromptCachingBetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PromptCachingBetaRequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PromptCachingBetaRequestToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PromptCachingBetaRequestToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant2Item3 obj1, ContentVariant2Item3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant2Item3 obj1, ContentVariant2Item3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item3 o && Equals(o);
        }
    }
}
