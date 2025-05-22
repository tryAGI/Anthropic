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
        public global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBase64ImageSource? Base64 { get; init; }
#else
        public global::Anthropic.BetaBase64ImageSource? Base64 { get; }
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
        public static implicit operator Source2(global::Anthropic.BetaBase64ImageSource value) => new Source2((global::Anthropic.BetaBase64ImageSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaBase64ImageSource?(Source2 @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source2(global::Anthropic.BetaBase64ImageSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaURLImageSource? Url { get; init; }
#else
        public global::Anthropic.BetaURLImageSource? Url { get; }
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
        public static implicit operator Source2(global::Anthropic.BetaURLImageSource value) => new Source2((global::Anthropic.BetaURLImageSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaURLImageSource?(Source2 @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public Source2(global::Anthropic.BetaURLImageSource? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaFileImageSource? File { get; init; }
#else
        public global::Anthropic.BetaFileImageSource? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source2(global::Anthropic.BetaFileImageSource value) => new Source2((global::Anthropic.BetaFileImageSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaFileImageSource?(Source2 @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public Source2(global::Anthropic.BetaFileImageSource? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source2(
            global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType? type,
            global::Anthropic.BetaBase64ImageSource? base64,
            global::Anthropic.BetaURLImageSource? url,
            global::Anthropic.BetaFileImageSource? file
            )
        {
            Type = type;

            Base64 = base64;
            Url = url;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            Url as object ??
            Base64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base64?.ToString() ??
            Url?.ToString() ??
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsUrl && !IsFile || !IsBase64 && IsUrl && !IsFile || !IsBase64 && !IsUrl && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaBase64ImageSource?, TResult>? base64 = null,
            global::System.Func<global::Anthropic.BetaURLImageSource?, TResult>? url = null,
            global::System.Func<global::Anthropic.BetaFileImageSource?, TResult>? file = null,
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
            else if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaBase64ImageSource?>? base64 = null,
            global::System.Action<global::Anthropic.BetaURLImageSource?>? url = null,
            global::System.Action<global::Anthropic.BetaFileImageSource?>? file = null,
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
            else if (IsFile)
            {
                file?.Invoke(File!);
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
                typeof(global::Anthropic.BetaBase64ImageSource),
                Url,
                typeof(global::Anthropic.BetaURLImageSource),
                File,
                typeof(global::Anthropic.BetaFileImageSource),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBase64ImageSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaURLImageSource?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaFileImageSource?>.Default.Equals(File, other.File) 
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
