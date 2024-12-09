#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant2Item4 : global::System.IEquatable<ContentVariant2Item4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? Type { get; }

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
        public static implicit operator ContentVariant2Item4(global::Anthropic.PromptCachingBetaRequestTextBlock value) => new ContentVariant2Item4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PromptCachingBetaRequestTextBlock?(ContentVariant2Item4 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item4(global::Anthropic.PromptCachingBetaRequestTextBlock? value)
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
        public static implicit operator ContentVariant2Item4(global::Anthropic.PromptCachingBetaRequestImageBlock value) => new ContentVariant2Item4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PromptCachingBetaRequestImageBlock?(ContentVariant2Item4 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item4(global::Anthropic.PromptCachingBetaRequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item4(
            global::Anthropic.PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? type,
            global::Anthropic.PromptCachingBetaRequestTextBlock? text,
            global::Anthropic.PromptCachingBetaRequestImageBlock? image
            )
        {
            Type = type;

            Text = text;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage || !IsText && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.PromptCachingBetaRequestTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.PromptCachingBetaRequestImageBlock?, TResult>? image = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.PromptCachingBetaRequestTextBlock?>? text = null,
            global::System.Action<global::Anthropic.PromptCachingBetaRequestImageBlock?>? image = null,
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
        public bool Equals(ContentVariant2Item4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PromptCachingBetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PromptCachingBetaRequestImageBlock?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant2Item4 obj1, ContentVariant2Item4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant2Item4 obj1, ContentVariant2Item4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item4 o && Equals(o);
        }
    }
}
