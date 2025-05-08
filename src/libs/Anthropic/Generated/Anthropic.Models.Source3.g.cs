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
        public static implicit operator Source3(global::Anthropic.Base64PDFSource value) => new Source3((global::Anthropic.Base64PDFSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.Base64PDFSource?(Source3 @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source3(global::Anthropic.Base64PDFSource? value)
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
        public static implicit operator Source3(global::Anthropic.PlainTextSource value) => new Source3((global::Anthropic.PlainTextSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PlainTextSource?(Source3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Source3(global::Anthropic.PlainTextSource? value)
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
        public static implicit operator Source3(global::Anthropic.ContentBlockSource value) => new Source3((global::Anthropic.ContentBlockSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ContentBlockSource?(Source3 @this) => @this.Content;

        /// <summary>
        /// 
        /// </summary>
        public Source3(global::Anthropic.ContentBlockSource? value)
        {
            Content = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.URLPDFSource? Url { get; init; }
#else
        public global::Anthropic.URLPDFSource? Url { get; }
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
        public static implicit operator Source3(global::Anthropic.URLPDFSource value) => new Source3((global::Anthropic.URLPDFSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.URLPDFSource?(Source3 @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public Source3(global::Anthropic.URLPDFSource? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source3(
            global::Anthropic.RequestDocumentBlockSourceDiscriminatorType? type,
            global::Anthropic.Base64PDFSource? base64,
            global::Anthropic.PlainTextSource? text,
            global::Anthropic.ContentBlockSource? content,
            global::Anthropic.URLPDFSource? url
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
            global::System.Func<global::Anthropic.Base64PDFSource?, TResult>? base64 = null,
            global::System.Func<global::Anthropic.PlainTextSource?, TResult>? text = null,
            global::System.Func<global::Anthropic.ContentBlockSource?, TResult>? content = null,
            global::System.Func<global::Anthropic.URLPDFSource?, TResult>? url = null,
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
            global::System.Action<global::Anthropic.Base64PDFSource?>? base64 = null,
            global::System.Action<global::Anthropic.PlainTextSource?>? text = null,
            global::System.Action<global::Anthropic.ContentBlockSource?>? content = null,
            global::System.Action<global::Anthropic.URLPDFSource?>? url = null,
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
                typeof(global::Anthropic.Base64PDFSource),
                Text,
                typeof(global::Anthropic.PlainTextSource),
                Content,
                typeof(global::Anthropic.ContentBlockSource),
                Url,
                typeof(global::Anthropic.URLPDFSource),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.Base64PDFSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PlainTextSource?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ContentBlockSource?>.Default.Equals(Content, other.Content) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.URLPDFSource?>.Default.Equals(Url, other.Url) 
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
