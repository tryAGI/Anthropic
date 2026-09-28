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
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextBlock PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsImageBlock? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsImageBlock PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

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
        public bool TryPickDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsDocumentBlock? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDocumentBlock PickDocument() => Document is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");

        /// <summary>
        /// A block containing a web search result.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSearchResultBlock? SearchResult { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSearchResultBlock? SearchResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResult))]
#endif
        public bool IsSearchResult => SearchResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSearchResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSearchResultBlock? value)
        {
            value = SearchResult;
            return IsSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSearchResultBlock PickSearchResult() => SearchResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResult' but the value was {ToString()}.");
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
        public static BetaManagedAgentsToolResultContentBlock FromText(global::Anthropic.BetaManagedAgentsTextBlock? value) => new BetaManagedAgentsToolResultContentBlock(value);

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
        public static BetaManagedAgentsToolResultContentBlock FromImage(global::Anthropic.BetaManagedAgentsImageBlock? value) => new BetaManagedAgentsToolResultContentBlock(value);

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
        public static BetaManagedAgentsToolResultContentBlock FromDocument(global::Anthropic.BetaManagedAgentsDocumentBlock? value) => new BetaManagedAgentsToolResultContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsToolResultContentBlock(global::Anthropic.BetaManagedAgentsSearchResultBlock value) => new BetaManagedAgentsToolResultContentBlock((global::Anthropic.BetaManagedAgentsSearchResultBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSearchResultBlock?(BetaManagedAgentsToolResultContentBlock @this) => @this.SearchResult;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsToolResultContentBlock(global::Anthropic.BetaManagedAgentsSearchResultBlock? value)
        {
            SearchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsToolResultContentBlock FromSearchResult(global::Anthropic.BetaManagedAgentsSearchResultBlock? value) => new BetaManagedAgentsToolResultContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsToolResultContentBlock(
            global::Anthropic.BetaManagedAgentsToolResultContentBlockDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsTextBlock? text,
            global::Anthropic.BetaManagedAgentsImageBlock? image,
            global::Anthropic.BetaManagedAgentsDocumentBlock? document,
            global::Anthropic.BetaManagedAgentsSearchResultBlock? searchResult
            )
        {
            Type = type;

            Text = text;
            Image = image;
            Document = document;
            SearchResult = searchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SearchResult as object ??
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
            Document?.ToString() ??
            SearchResult?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsDocument && !IsSearchResult || !IsText && IsImage && !IsDocument && !IsSearchResult || !IsText && !IsImage && IsDocument && !IsSearchResult || !IsText && !IsImage && !IsDocument && IsSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsTextBlock, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsImageBlock, TResult>? image = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsDocumentBlock, TResult>? document = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSearchResultBlock, TResult>? searchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (Image is { } __value1 && image != null)
            {
                return image(__value1);
            }
            else if (Document is { } __value2 && document != null)
            {
                return document(__value2);
            }
            else if (SearchResult is { } __value3 && searchResult != null)
            {
                return searchResult(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsTextBlock>? text = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsImageBlock>? image = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsDocumentBlock>? document = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSearchResultBlock>? searchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (Document is { } __value2)
            {
                document?.Invoke(__value2);
            }
            else if (SearchResult is { } __value3)
            {
                searchResult?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsTextBlock>? text = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsImageBlock>? image = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsDocumentBlock>? document = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSearchResultBlock>? searchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (Document is { } __value2)
            {
                document?.Invoke(__value2);
            }
            else if (SearchResult is { } __value3)
            {
                searchResult?.Invoke(__value3);
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
                SearchResult,
                typeof(global::Anthropic.BetaManagedAgentsSearchResultBlock),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsDocumentBlock?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSearchResultBlock?>.Default.Equals(SearchResult, other.SearchResult)
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
