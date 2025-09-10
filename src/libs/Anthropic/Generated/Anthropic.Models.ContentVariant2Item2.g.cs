#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant2Item2 : global::System.IEquatable<ContentVariant2Item2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestTextBlock? Text { get; init; }
#else
        public global::Anthropic.BetaRequestTextBlock? Text { get; }
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
        public static implicit operator ContentVariant2Item2(global::Anthropic.BetaRequestTextBlock value) => new ContentVariant2Item2((global::Anthropic.BetaRequestTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestTextBlock?(ContentVariant2Item2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item2(global::Anthropic.BetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestImageBlock? Image { get; init; }
#else
        public global::Anthropic.BetaRequestImageBlock? Image { get; }
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
        public static implicit operator ContentVariant2Item2(global::Anthropic.BetaRequestImageBlock value) => new ContentVariant2Item2((global::Anthropic.BetaRequestImageBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestImageBlock?(ContentVariant2Item2 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item2(global::Anthropic.BetaRequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestSearchResultBlock? SearchResult { get; init; }
#else
        public global::Anthropic.BetaRequestSearchResultBlock? SearchResult { get; }
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
        public static implicit operator ContentVariant2Item2(global::Anthropic.BetaRequestSearchResultBlock value) => new ContentVariant2Item2((global::Anthropic.BetaRequestSearchResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestSearchResultBlock?(ContentVariant2Item2 @this) => @this.SearchResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item2(global::Anthropic.BetaRequestSearchResultBlock? value)
        {
            SearchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestDocumentBlock? Document { get; init; }
#else
        public global::Anthropic.BetaRequestDocumentBlock? Document { get; }
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
        public static implicit operator ContentVariant2Item2(global::Anthropic.BetaRequestDocumentBlock value) => new ContentVariant2Item2((global::Anthropic.BetaRequestDocumentBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestDocumentBlock?(ContentVariant2Item2 @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item2(global::Anthropic.BetaRequestDocumentBlock? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item2(
            global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? type,
            global::Anthropic.BetaRequestTextBlock? text,
            global::Anthropic.BetaRequestImageBlock? image,
            global::Anthropic.BetaRequestSearchResultBlock? searchResult,
            global::Anthropic.BetaRequestDocumentBlock? document
            )
        {
            Type = type;

            Text = text;
            Image = image;
            SearchResult = searchResult;
            Document = document;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Document as object ??
            SearchResult as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            SearchResult?.ToString() ??
            Document?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsSearchResult && !IsDocument || !IsText && IsImage && !IsSearchResult && !IsDocument || !IsText && !IsImage && IsSearchResult && !IsDocument || !IsText && !IsImage && !IsSearchResult && IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRequestTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaRequestImageBlock?, TResult>? image = null,
            global::System.Func<global::Anthropic.BetaRequestSearchResultBlock?, TResult>? searchResult = null,
            global::System.Func<global::Anthropic.BetaRequestDocumentBlock?, TResult>? document = null,
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
            else if (IsSearchResult && searchResult != null)
            {
                return searchResult(SearchResult!);
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
            global::System.Action<global::Anthropic.BetaRequestTextBlock?>? text = null,
            global::System.Action<global::Anthropic.BetaRequestImageBlock?>? image = null,
            global::System.Action<global::Anthropic.BetaRequestSearchResultBlock?>? searchResult = null,
            global::System.Action<global::Anthropic.BetaRequestDocumentBlock?>? document = null,
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
            else if (IsSearchResult)
            {
                searchResult?.Invoke(SearchResult!);
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
                typeof(global::Anthropic.BetaRequestTextBlock),
                Image,
                typeof(global::Anthropic.BetaRequestImageBlock),
                SearchResult,
                typeof(global::Anthropic.BetaRequestSearchResultBlock),
                Document,
                typeof(global::Anthropic.BetaRequestDocumentBlock),
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
        public bool Equals(ContentVariant2Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestSearchResultBlock?>.Default.Equals(SearchResult, other.SearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestDocumentBlock?>.Default.Equals(Document, other.Document) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant2Item2 obj1, ContentVariant2Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant2Item2 obj1, ContentVariant2Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item2 o && Equals(o);
        }
    }
}
