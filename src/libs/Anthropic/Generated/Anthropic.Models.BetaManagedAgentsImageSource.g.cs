#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Union type for image source variants.
    /// </summary>
    public readonly partial struct BetaManagedAgentsImageSource : global::System.IEquatable<BetaManagedAgentsImageSource>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Base64-encoded image data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsBase64ImageSource? Base64 { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsBase64ImageSource? Base64 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base64))]
#endif
        public bool IsBase64 => Base64 != null;

        /// <summary>
        /// Image referenced by URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsURLImageSource? Url { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsURLImageSource? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;

        /// <summary>
        /// Image referenced by file ID.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsFileImageSource? File { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsFileImageSource? File { get; }
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
        public static implicit operator BetaManagedAgentsImageSource(global::Anthropic.BetaManagedAgentsBase64ImageSource value) => new BetaManagedAgentsImageSource((global::Anthropic.BetaManagedAgentsBase64ImageSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsBase64ImageSource?(BetaManagedAgentsImageSource @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsImageSource(global::Anthropic.BetaManagedAgentsBase64ImageSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsImageSource(global::Anthropic.BetaManagedAgentsURLImageSource value) => new BetaManagedAgentsImageSource((global::Anthropic.BetaManagedAgentsURLImageSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsURLImageSource?(BetaManagedAgentsImageSource @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsImageSource(global::Anthropic.BetaManagedAgentsURLImageSource? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsImageSource(global::Anthropic.BetaManagedAgentsFileImageSource value) => new BetaManagedAgentsImageSource((global::Anthropic.BetaManagedAgentsFileImageSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileImageSource?(BetaManagedAgentsImageSource @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsImageSource(global::Anthropic.BetaManagedAgentsFileImageSource? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsImageSource(
            global::Anthropic.BetaManagedAgentsImageSourceDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsBase64ImageSource? base64,
            global::Anthropic.BetaManagedAgentsURLImageSource? url,
            global::Anthropic.BetaManagedAgentsFileImageSource? file
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
            global::System.Func<global::Anthropic.BetaManagedAgentsBase64ImageSource?, TResult>? base64 = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsURLImageSource?, TResult>? url = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsFileImageSource?, TResult>? file = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsBase64ImageSource?>? base64 = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsURLImageSource?>? url = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsFileImageSource?>? file = null,
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
                typeof(global::Anthropic.BetaManagedAgentsBase64ImageSource),
                Url,
                typeof(global::Anthropic.BetaManagedAgentsURLImageSource),
                File,
                typeof(global::Anthropic.BetaManagedAgentsFileImageSource),
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
        public bool Equals(BetaManagedAgentsImageSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsBase64ImageSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsURLImageSource?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileImageSource?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsImageSource obj1, BetaManagedAgentsImageSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsImageSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsImageSource obj1, BetaManagedAgentsImageSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsImageSource o && Equals(o);
        }
    }
}
