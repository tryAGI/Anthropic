#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Union type for document source variants.
    /// </summary>
    public readonly partial struct BetaManagedAgentsDocumentSource : global::System.IEquatable<BetaManagedAgentsDocumentSource>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Base64-encoded document data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsBase64DocumentSource? Base64 { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsBase64DocumentSource? Base64 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base64))]
#endif
        public bool IsBase64 => Base64 != null;

        /// <summary>
        /// Plain text document content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSource? Text { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsPlainTextDocumentSource? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// Document referenced by URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsURLDocumentSource? Url { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsURLDocumentSource? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;

        /// <summary>
        /// Document referenced by file ID.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsFileDocumentSource? File { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsFileDocumentSource? File { get; }
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
        public static implicit operator BetaManagedAgentsDocumentSource(global::Anthropic.BetaManagedAgentsBase64DocumentSource value) => new BetaManagedAgentsDocumentSource((global::Anthropic.BetaManagedAgentsBase64DocumentSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsBase64DocumentSource?(BetaManagedAgentsDocumentSource @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDocumentSource(global::Anthropic.BetaManagedAgentsBase64DocumentSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDocumentSource(global::Anthropic.BetaManagedAgentsPlainTextDocumentSource value) => new BetaManagedAgentsDocumentSource((global::Anthropic.BetaManagedAgentsPlainTextDocumentSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsPlainTextDocumentSource?(BetaManagedAgentsDocumentSource @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDocumentSource(global::Anthropic.BetaManagedAgentsPlainTextDocumentSource? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDocumentSource(global::Anthropic.BetaManagedAgentsURLDocumentSource value) => new BetaManagedAgentsDocumentSource((global::Anthropic.BetaManagedAgentsURLDocumentSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsURLDocumentSource?(BetaManagedAgentsDocumentSource @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDocumentSource(global::Anthropic.BetaManagedAgentsURLDocumentSource? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDocumentSource(global::Anthropic.BetaManagedAgentsFileDocumentSource value) => new BetaManagedAgentsDocumentSource((global::Anthropic.BetaManagedAgentsFileDocumentSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileDocumentSource?(BetaManagedAgentsDocumentSource @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDocumentSource(global::Anthropic.BetaManagedAgentsFileDocumentSource? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDocumentSource(
            global::Anthropic.BetaManagedAgentsDocumentSourceDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsBase64DocumentSource? base64,
            global::Anthropic.BetaManagedAgentsPlainTextDocumentSource? text,
            global::Anthropic.BetaManagedAgentsURLDocumentSource? url,
            global::Anthropic.BetaManagedAgentsFileDocumentSource? file
            )
        {
            Type = type;

            Base64 = base64;
            Text = text;
            Url = url;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            Url as object ??
            Text as object ??
            Base64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base64?.ToString() ??
            Text?.ToString() ??
            Url?.ToString() ??
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsText && !IsUrl && !IsFile || !IsBase64 && IsText && !IsUrl && !IsFile || !IsBase64 && !IsText && IsUrl && !IsFile || !IsBase64 && !IsText && !IsUrl && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsBase64DocumentSource?, TResult>? base64 = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsPlainTextDocumentSource?, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsURLDocumentSource?, TResult>? url = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsFileDocumentSource?, TResult>? file = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsBase64DocumentSource?>? base64 = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsPlainTextDocumentSource?>? text = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsURLDocumentSource?>? url = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsFileDocumentSource?>? file = null,
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
                typeof(global::Anthropic.BetaManagedAgentsBase64DocumentSource),
                Text,
                typeof(global::Anthropic.BetaManagedAgentsPlainTextDocumentSource),
                Url,
                typeof(global::Anthropic.BetaManagedAgentsURLDocumentSource),
                File,
                typeof(global::Anthropic.BetaManagedAgentsFileDocumentSource),
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
        public bool Equals(BetaManagedAgentsDocumentSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsBase64DocumentSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsPlainTextDocumentSource?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsURLDocumentSource?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileDocumentSource?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsDocumentSource obj1, BetaManagedAgentsDocumentSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsDocumentSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsDocumentSource obj1, BetaManagedAgentsDocumentSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsDocumentSource o && Equals(o);
        }
    }
}
