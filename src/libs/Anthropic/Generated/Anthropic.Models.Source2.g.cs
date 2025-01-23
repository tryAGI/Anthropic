#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Source2 : global::System.IEquatable<Source2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestDocumentBlockSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.Base64PDFSource? Base64 { get; init; }
#else
        public global::Anthropic.Base64PDFSource? Base64 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base64))]
#endif
        public bool IsBase64 => Base64 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source2(global::Anthropic.Base64PDFSource value) => new Source2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.Base64PDFSource?(Source2 @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source2(global::Anthropic.Base64PDFSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.PlainTextSource? Text { get; init; }
#else
        public global::Anthropic.PlainTextSource? Text { get; }
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
        public static implicit operator Source2(global::Anthropic.PlainTextSource value) => new Source2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PlainTextSource?(Source2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Source2(global::Anthropic.PlainTextSource? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ContentBlockSource? Content { get; init; }
#else
        public global::Anthropic.ContentBlockSource? Content { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Content))]
#endif
        public bool IsContent => Content != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source2(global::Anthropic.ContentBlockSource value) => new Source2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ContentBlockSource?(Source2 @this) => @this.Content;

        /// <summary>
        /// 
        /// </summary>
        public Source2(global::Anthropic.ContentBlockSource? value)
        {
            Content = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source2(
            global::Anthropic.RequestDocumentBlockSourceDiscriminatorType? type,
            global::Anthropic.Base64PDFSource? base64,
            global::Anthropic.PlainTextSource? text,
            global::Anthropic.ContentBlockSource? content
            )
        {
            Type = type;

            Base64 = base64;
            Text = text;
            Content = content;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Content as object ??
            Text as object ??
            Base64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsText && !IsContent || !IsBase64 && IsText && !IsContent || !IsBase64 && !IsText && IsContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.Base64PDFSource?, TResult>? base64 = null,
            global::System.Func<global::Anthropic.PlainTextSource?, TResult>? text = null,
            global::System.Func<global::Anthropic.ContentBlockSource?, TResult>? content = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64 && base64 != null)
            {
                return base64(Base64!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsContent && content != null)
            {
                return content(Content!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.Base64PDFSource?>? base64 = null,
            global::System.Action<global::Anthropic.PlainTextSource?>? text = null,
            global::System.Action<global::Anthropic.ContentBlockSource?>? content = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64)
            {
                base64?.Invoke(Base64!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsContent)
            {
                content?.Invoke(Content!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base64,
                typeof(global::Anthropic.Base64PDFSource),
                Text,
                typeof(global::Anthropic.PlainTextSource),
                Content,
                typeof(global::Anthropic.ContentBlockSource),
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
        public bool Equals(Source2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.Base64PDFSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PlainTextSource?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ContentBlockSource?>.Default.Equals(Content, other.Content) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source2 obj1, Source2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source2 obj1, Source2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source2 o && Equals(o);
        }
    }
}
