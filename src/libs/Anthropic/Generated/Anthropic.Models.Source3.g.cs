#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Source3 : global::System.IEquatable<Source3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaResponseDocumentBlockSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBase64PDFSource? Base64 { get; init; }
#else
        public global::Anthropic.BetaBase64PDFSource? Base64 { get; }
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
        public static implicit operator Source3(global::Anthropic.BetaBase64PDFSource value) => new Source3((global::Anthropic.BetaBase64PDFSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaBase64PDFSource?(Source3 @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source3(global::Anthropic.BetaBase64PDFSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaPlainTextSource? Text { get; init; }
#else
        public global::Anthropic.BetaPlainTextSource? Text { get; }
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
        public static implicit operator Source3(global::Anthropic.BetaPlainTextSource value) => new Source3((global::Anthropic.BetaPlainTextSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaPlainTextSource?(Source3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Source3(global::Anthropic.BetaPlainTextSource? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source3(
            global::Anthropic.BetaResponseDocumentBlockSourceDiscriminatorType? type,
            global::Anthropic.BetaBase64PDFSource? base64,
            global::Anthropic.BetaPlainTextSource? text
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
            global::System.Func<global::Anthropic.BetaBase64PDFSource?, TResult>? base64 = null,
            global::System.Func<global::Anthropic.BetaPlainTextSource?, TResult>? text = null,
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
            global::System.Action<global::Anthropic.BetaBase64PDFSource?>? base64 = null,
            global::System.Action<global::Anthropic.BetaPlainTextSource?>? text = null,
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
                typeof(global::Anthropic.BetaBase64PDFSource),
                Text,
                typeof(global::Anthropic.BetaPlainTextSource),
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
        public bool Equals(Source3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBase64PDFSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPlainTextSource?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source3 obj1, Source3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source3 obj1, Source3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source3 o && Equals(o);
        }
    }
}
