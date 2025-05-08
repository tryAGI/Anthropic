#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Source : global::System.IEquatable<Source>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType? Type { get; }

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
        public static implicit operator Source(global::Anthropic.BetaBase64PDFSource value) => new Source((global::Anthropic.BetaBase64PDFSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaBase64PDFSource?(Source @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Anthropic.BetaBase64PDFSource? value)
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
        public static implicit operator Source(global::Anthropic.BetaPlainTextSource value) => new Source((global::Anthropic.BetaPlainTextSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaPlainTextSource?(Source @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Anthropic.BetaPlainTextSource? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaContentBlockSource? Content { get; init; }
#else
        public global::Anthropic.BetaContentBlockSource? Content { get; }
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
        public static implicit operator Source(global::Anthropic.BetaContentBlockSource value) => new Source((global::Anthropic.BetaContentBlockSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaContentBlockSource?(Source @this) => @this.Content;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Anthropic.BetaContentBlockSource? value)
        {
            Content = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaURLPDFSource? Url { get; init; }
#else
        public global::Anthropic.BetaURLPDFSource? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::Anthropic.BetaURLPDFSource value) => new Source((global::Anthropic.BetaURLPDFSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaURLPDFSource?(Source @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Anthropic.BetaURLPDFSource? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source(
            global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType? type,
            global::Anthropic.BetaBase64PDFSource? base64,
            global::Anthropic.BetaPlainTextSource? text,
            global::Anthropic.BetaContentBlockSource? content,
            global::Anthropic.BetaURLPDFSource? url
            )
        {
            Type = type;

            Base64 = base64;
            Text = text;
            Content = content;
            Url = url;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Url as object ??
            Content as object ??
            Text as object ??
            Base64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base64?.ToString() ??
            Text?.ToString() ??
            Content?.ToString() ??
            Url?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsText && !IsContent && !IsUrl || !IsBase64 && IsText && !IsContent && !IsUrl || !IsBase64 && !IsText && IsContent && !IsUrl || !IsBase64 && !IsText && !IsContent && IsUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaBase64PDFSource?, TResult>? base64 = null,
            global::System.Func<global::Anthropic.BetaPlainTextSource?, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaContentBlockSource?, TResult>? content = null,
            global::System.Func<global::Anthropic.BetaURLPDFSource?, TResult>? url = null,
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
            else if (IsUrl && url != null)
            {
                return url(Url!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaBase64PDFSource?>? base64 = null,
            global::System.Action<global::Anthropic.BetaPlainTextSource?>? text = null,
            global::System.Action<global::Anthropic.BetaContentBlockSource?>? content = null,
            global::System.Action<global::Anthropic.BetaURLPDFSource?>? url = null,
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
            else if (IsUrl)
            {
                url?.Invoke(Url!);
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
                Content,
                typeof(global::Anthropic.BetaContentBlockSource),
                Url,
                typeof(global::Anthropic.BetaURLPDFSource),
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
        public bool Equals(Source other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBase64PDFSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPlainTextSource?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaContentBlockSource?>.Default.Equals(Content, other.Content) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaURLPDFSource?>.Default.Equals(Url, other.Url) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source obj1, Source obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source obj1, Source obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source o && Equals(o);
        }
    }
}
