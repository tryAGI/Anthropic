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
        public static implicit operator ContentBlock3(global::Anthropic.ResponseTextBlock value) => new ContentBlock3(value);

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
        public static implicit operator ContentBlock3(global::Anthropic.ResponseToolUseBlock value) => new ContentBlock3(value);

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
        public ContentBlock3(
            global::Anthropic.ContentBlockDiscriminatorType? type,
            global::Anthropic.ResponseTextBlock? text,
            global::Anthropic.ResponseToolUseBlock? toolUse
            )
        {
            Type = type;

            Text = text;
            ToolUse = toolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolUse as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsToolUse || !IsText && IsToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.ResponseTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.ResponseToolUseBlock?, TResult>? toolUse = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ResponseTextBlock?>? text = null,
            global::System.Action<global::Anthropic.ResponseToolUseBlock?>? toolUse = null,
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
                ToolUse,
                typeof(global::Anthropic.ResponseToolUseBlock),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) 
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
