#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Content block in a tool result. Can be `text`, `image`, `document`, or `search_result`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsToolResultContentBlock : global::System.IEquatable<BetaManagedAgentsToolResultContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// Regular text content.<br/>
        /// Example: {"type":"text","text":"Where is my order #1234?"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTextBlock? Text { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTextBlock? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// Image content specified directly as base64 data or as a reference via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsImageBlock? Image { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsImageBlock? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// Document content, either specified directly as base64 data, as text, or as a reference via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsDocumentBlock? Document { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsDocumentBlock? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsToolResultContentBlock(global::Anthropic.BetaManagedAgentsTextBlock value) => new BetaManagedAgentsToolResultContentBlock((global::Anthropic.BetaManagedAgentsTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTextBlock?(BetaManagedAgentsToolResultContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsToolResultContentBlock(global::Anthropic.BetaManagedAgentsTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsToolResultContentBlock(global::Anthropic.BetaManagedAgentsImageBlock value) => new BetaManagedAgentsToolResultContentBlock((global::Anthropic.BetaManagedAgentsImageBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsImageBlock?(BetaManagedAgentsToolResultContentBlock @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsToolResultContentBlock(global::Anthropic.BetaManagedAgentsImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsToolResultContentBlock(global::Anthropic.BetaManagedAgentsDocumentBlock value) => new BetaManagedAgentsToolResultContentBlock((global::Anthropic.BetaManagedAgentsDocumentBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsDocumentBlock?(BetaManagedAgentsToolResultContentBlock @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsToolResultContentBlock(global::Anthropic.BetaManagedAgentsDocumentBlock? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsToolResultContentBlock(
            global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsTextBlock? text,
            global::Anthropic.BetaManagedAgentsImageBlock? image,
            global::Anthropic.BetaManagedAgentsDocumentBlock? document
            )
        {
            Type = type;

            Text = text;
            Image = image;
            Document = document;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Document as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            Document?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsDocument || !IsText && IsImage && !IsDocument || !IsText && !IsImage && IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsImageBlock?, TResult>? image = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsDocumentBlock?, TResult>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsTextBlock?>? text = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsImageBlock?>? image = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsDocumentBlock?>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Anthropic.BetaManagedAgentsTextBlock),
                Image,
                typeof(global::Anthropic.BetaManagedAgentsImageBlock),
                Document,
                typeof(global::Anthropic.BetaManagedAgentsDocumentBlock),
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
        public bool Equals(BetaManagedAgentsToolResultContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsDocumentBlock?>.Default.Equals(Document, other.Document) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsToolResultContentBlock obj1, BetaManagedAgentsToolResultContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsToolResultContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsToolResultContentBlock obj1, BetaManagedAgentsToolResultContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsToolResultContentBlock o && Equals(o);
        }
    }
}
