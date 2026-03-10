#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Source6 : global::System.IEquatable<Source6>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ResponseDocumentBlockSourceDiscriminatorType? Type { get; }

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
        public static implicit operator Source6(global::Anthropic.Base64PDFSource value) => new Source6((global::Anthropic.Base64PDFSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.Base64PDFSource?(Source6 @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source6(global::Anthropic.Base64PDFSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source6(global::Anthropic.PlainTextSource value) => new Source6((global::Anthropic.PlainTextSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PlainTextSource?(Source6 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Source6(global::Anthropic.PlainTextSource? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source6(
            global::Anthropic.ResponseDocumentBlockSourceDiscriminatorType? type,
            global::Anthropic.Base64PDFSource? base64,
            global::Anthropic.PlainTextSource? text
            )
        {
            Type = type;

            Base64 = base64;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            Base64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base64?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsText || !IsBase64 && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.Base64PDFSource?, TResult>? base64 = null,
            global::System.Func<global::Anthropic.PlainTextSource?, TResult>? text = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.Base64PDFSource?>? base64 = null,
            global::System.Action<global::Anthropic.PlainTextSource?>? text = null,
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
        public bool Equals(Source6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.Base64PDFSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PlainTextSource?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source6 obj1, Source6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source6 obj1, Source6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source6 o && Equals(o);
        }
    }
}
