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
        public bool TryPickBase64(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.Base64ImageSource? value)
        {
            value = Base64;
            return IsBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Base64ImageSource PickBase64() => Base64 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base64' but the value was {ToString()}.");

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
        public bool TryPickUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.URLImageSource? value)
        {
            value = Url;
            return IsUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.URLImageSource PickUrl() => Url is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Url' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.FileImageSource? File { get; init; }
#else
        public global::Anthropic.FileImageSource? File { get; }
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
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.FileImageSource? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FileImageSource PickFile() => File is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source3(global::Anthropic.Base64ImageSource value) => new Source3((global::Anthropic.Base64ImageSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.Base64ImageSource?(Source3 @this) => @this.Base64;

        /// <summary>
        ///
        /// </summary>
        public Source3(global::Anthropic.Base64ImageSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source3 FromBase64(global::Anthropic.Base64ImageSource? value) => new Source3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source3(global::Anthropic.URLImageSource value) => new Source3((global::Anthropic.URLImageSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.URLImageSource?(Source3 @this) => @this.Url;

        /// <summary>
        ///
        /// </summary>
        public Source3(global::Anthropic.URLImageSource? value)
        {
            Url = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source3 FromUrl(global::Anthropic.URLImageSource? value) => new Source3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source3(global::Anthropic.FileImageSource value) => new Source3((global::Anthropic.FileImageSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.FileImageSource?(Source3 @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public Source3(global::Anthropic.FileImageSource? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source3 FromFile(global::Anthropic.FileImageSource? value) => new Source3(value);

        /// <summary>
        ///
        /// </summary>
        public Source3(
            global::Anthropic.RequestImageBlockSourceDiscriminatorType? type,
            global::Anthropic.Base64ImageSource? base64,
            global::Anthropic.URLImageSource? url,
            global::Anthropic.FileImageSource? file
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
            global::System.Func<global::Anthropic.Base64ImageSource, TResult>? base64 = null,
            global::System.Func<global::Anthropic.URLImageSource, TResult>? url = null,
            global::System.Func<global::Anthropic.FileImageSource, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base64 is { } __value0 && base64 != null)
            {
                return base64(__value0);
            }
            else if (Url is { } __value1 && url != null)
            {
                return url(__value1);
            }
            else if (File is { } __value2 && file != null)
            {
                return file(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.Base64ImageSource>? base64 = null,

            global::System.Action<global::Anthropic.URLImageSource>? url = null,

            global::System.Action<global::Anthropic.FileImageSource>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base64 is { } __value0)
            {
                base64?.Invoke(__value0);
            }
            else if (Url is { } __value1)
            {
                url?.Invoke(__value1);
            }
            else if (File is { } __value2)
            {
                file?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.Base64ImageSource>? base64 = null,
            global::System.Action<global::Anthropic.URLImageSource>? url = null,
            global::System.Action<global::Anthropic.FileImageSource>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base64 is { } __value0)
            {
                base64?.Invoke(__value0);
            }
            else if (Url is { } __value1)
            {
                url?.Invoke(__value1);
            }
            else if (File is { } __value2)
            {
                file?.Invoke(__value2);
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
                File,
                typeof(global::Anthropic.FileImageSource),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.Base64ImageSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.URLImageSource?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.FileImageSource?>.Default.Equals(File, other.File)
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
