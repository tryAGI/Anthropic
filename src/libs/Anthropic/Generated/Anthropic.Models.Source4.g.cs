#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Source4 : global::System.IEquatable<Source4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestImageBlockSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.Base64ImageSource? Base64 { get; init; }
#else
        public global::Anthropic.Base64ImageSource? Base64 { get; }
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
        public static implicit operator Source4(global::Anthropic.Base64ImageSource value) => new Source4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.Base64ImageSource?(Source4 @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source4(global::Anthropic.Base64ImageSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.URLImageSource? Url { get; init; }
#else
        public global::Anthropic.URLImageSource? Url { get; }
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
        public static implicit operator Source4(global::Anthropic.URLImageSource value) => new Source4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.URLImageSource?(Source4 @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public Source4(global::Anthropic.URLImageSource? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source4(
            global::Anthropic.RequestImageBlockSourceDiscriminatorType? type,
            global::Anthropic.Base64ImageSource? base64,
            global::Anthropic.URLImageSource? url
            )
        {
            Type = type;

            Base64 = base64;
            Url = url;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Url as object ??
            Base64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsUrl || !IsBase64 && IsUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.Base64ImageSource?, TResult>? base64 = null,
            global::System.Func<global::Anthropic.URLImageSource?, TResult>? url = null,
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
            global::System.Action<global::Anthropic.Base64ImageSource?>? base64 = null,
            global::System.Action<global::Anthropic.URLImageSource?>? url = null,
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
                typeof(global::Anthropic.Base64ImageSource),
                Url,
                typeof(global::Anthropic.URLImageSource),
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
        public bool Equals(Source4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.Base64ImageSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.URLImageSource?>.Default.Equals(Url, other.Url) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source4 obj1, Source4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source4 obj1, Source4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source4 o && Equals(o);
        }
    }
}
