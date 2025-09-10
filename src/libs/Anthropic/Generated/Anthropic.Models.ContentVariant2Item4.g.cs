#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant2Item4 : global::System.IEquatable<ContentVariant2Item4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestTextBlock? Text { get; init; }
#else
        public global::Anthropic.RequestTextBlock? Text { get; }
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
        public static implicit operator ContentVariant2Item4(global::Anthropic.RequestTextBlock value) => new ContentVariant2Item4((global::Anthropic.RequestTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestTextBlock?(ContentVariant2Item4 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item4(global::Anthropic.RequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestImageBlock? Image { get; init; }
#else
        public global::Anthropic.RequestImageBlock? Image { get; }
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
        public static implicit operator ContentVariant2Item4(global::Anthropic.RequestImageBlock value) => new ContentVariant2Item4((global::Anthropic.RequestImageBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestImageBlock?(ContentVariant2Item4 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item4(global::Anthropic.RequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestSearchResultBlock? SearchResult { get; init; }
#else
        public global::Anthropic.RequestSearchResultBlock? SearchResult { get; }
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
        public static implicit operator ContentVariant2Item4(global::Anthropic.RequestSearchResultBlock value) => new ContentVariant2Item4((global::Anthropic.RequestSearchResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestSearchResultBlock?(ContentVariant2Item4 @this) => @this.SearchResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item4(global::Anthropic.RequestSearchResultBlock? value)
        {
            SearchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestDocumentBlock? Document { get; init; }
#else
        public global::Anthropic.RequestDocumentBlock? Document { get; }
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
        public static implicit operator ContentVariant2Item4(global::Anthropic.RequestDocumentBlock value) => new ContentVariant2Item4((global::Anthropic.RequestDocumentBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestDocumentBlock?(ContentVariant2Item4 @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item4(global::Anthropic.RequestDocumentBlock? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item4(
            global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType? type,
            global::Anthropic.RequestTextBlock? text,
            global::Anthropic.RequestImageBlock? image,
            global::Anthropic.RequestSearchResultBlock? searchResult,
            global::Anthropic.RequestDocumentBlock? document
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
            global::System.Func<global::Anthropic.RequestTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.RequestImageBlock?, TResult>? image = null,
            global::System.Func<global::Anthropic.RequestSearchResultBlock?, TResult>? searchResult = null,
            global::System.Func<global::Anthropic.RequestDocumentBlock?, TResult>? document = null,
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
            global::System.Action<global::Anthropic.RequestTextBlock?>? text = null,
            global::System.Action<global::Anthropic.RequestImageBlock?>? image = null,
            global::System.Action<global::Anthropic.RequestSearchResultBlock?>? searchResult = null,
            global::System.Action<global::Anthropic.RequestDocumentBlock?>? document = null,
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
                typeof(global::Anthropic.RequestTextBlock),
                Image,
                typeof(global::Anthropic.RequestImageBlock),
                SearchResult,
                typeof(global::Anthropic.RequestSearchResultBlock),
                Document,
                typeof(global::Anthropic.RequestDocumentBlock),
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
        public bool Equals(ContentVariant2Item4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestSearchResultBlock?>.Default.Equals(SearchResult, other.SearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestDocumentBlock?>.Default.Equals(Document, other.Document) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant2Item4 obj1, ContentVariant2Item4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant2Item4 obj1, ContentVariant2Item4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item4 o && Equals(o);
        }
    }
}
