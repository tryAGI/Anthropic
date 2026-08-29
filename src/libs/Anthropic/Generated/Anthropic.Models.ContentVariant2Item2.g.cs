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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.RequestTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestTextBlock PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

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
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.RequestImageBlock? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestImageBlock PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

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
        public bool TryPickSearchResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.RequestSearchResultBlock? value)
        {
            value = SearchResult;
            return IsSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestSearchResultBlock PickSearchResult() => IsSearchResult
            ? SearchResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResult' but the value was {ToString()}.");

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
        public bool TryPickDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.RequestDocumentBlock? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestDocumentBlock PickDocument() => IsDocument
            ? Document!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");

        /// <summary>
        /// Tool reference block that can be included in tool_result content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestToolReferenceBlock? ToolReference { get; init; }
#else
        public global::Anthropic.RequestToolReferenceBlock? ToolReference { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolReference))]
#endif
        public bool IsToolReference => ToolReference != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.RequestToolReferenceBlock? value)
        {
            value = ToolReference;
            return IsToolReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestToolReferenceBlock PickToolReference() => IsToolReference
            ? ToolReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolReference' but the value was {ToString()}.");

        /// <summary>
        /// The caller's browser state after a browser toolset member call —<br/>
        /// the full inventory of open tabs, which tab is active, and any side<br/>
        /// effects (tabs opened, download state changes) the call produced.<br/>
        /// At most one per `tool_result`, only on a non-error result answering a<br/>
        /// browser toolset member `tool_use`. The server renders the<br/>
        /// model-visible text from it; the model never sees the raw fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestBrowserStateBlock? BrowserState { get; init; }
#else
        public global::Anthropic.RequestBrowserStateBlock? BrowserState { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserState))]
#endif
        public bool IsBrowserState => BrowserState != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserState(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.RequestBrowserStateBlock? value)
        {
            value = BrowserState;
            return IsBrowserState;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlock PickBrowserState() => IsBrowserState
            ? BrowserState!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserState' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item2(global::Anthropic.RequestTextBlock value) => new ContentVariant2Item2((global::Anthropic.RequestTextBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RequestTextBlock?(ContentVariant2Item2 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item2(global::Anthropic.RequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item2 FromText(global::Anthropic.RequestTextBlock? value) => new ContentVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item2(global::Anthropic.RequestImageBlock value) => new ContentVariant2Item2((global::Anthropic.RequestImageBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RequestImageBlock?(ContentVariant2Item2 @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item2(global::Anthropic.RequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item2 FromImage(global::Anthropic.RequestImageBlock? value) => new ContentVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item2(global::Anthropic.RequestSearchResultBlock value) => new ContentVariant2Item2((global::Anthropic.RequestSearchResultBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RequestSearchResultBlock?(ContentVariant2Item2 @this) => @this.SearchResult;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item2(global::Anthropic.RequestSearchResultBlock? value)
        {
            SearchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item2 FromSearchResult(global::Anthropic.RequestSearchResultBlock? value) => new ContentVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item2(global::Anthropic.RequestDocumentBlock value) => new ContentVariant2Item2((global::Anthropic.RequestDocumentBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RequestDocumentBlock?(ContentVariant2Item2 @this) => @this.Document;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item2(global::Anthropic.RequestDocumentBlock? value)
        {
            Document = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item2 FromDocument(global::Anthropic.RequestDocumentBlock? value) => new ContentVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item2(global::Anthropic.RequestToolReferenceBlock value) => new ContentVariant2Item2((global::Anthropic.RequestToolReferenceBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RequestToolReferenceBlock?(ContentVariant2Item2 @this) => @this.ToolReference;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item2(global::Anthropic.RequestToolReferenceBlock? value)
        {
            ToolReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item2 FromToolReference(global::Anthropic.RequestToolReferenceBlock? value) => new ContentVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item2(global::Anthropic.RequestBrowserStateBlock value) => new ContentVariant2Item2((global::Anthropic.RequestBrowserStateBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RequestBrowserStateBlock?(ContentVariant2Item2 @this) => @this.BrowserState;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item2(global::Anthropic.RequestBrowserStateBlock? value)
        {
            BrowserState = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item2 FromBrowserState(global::Anthropic.RequestBrowserStateBlock? value) => new ContentVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item2(
            global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType? type,
            global::Anthropic.RequestTextBlock? text,
            global::Anthropic.RequestImageBlock? image,
            global::Anthropic.RequestSearchResultBlock? searchResult,
            global::Anthropic.RequestDocumentBlock? document,
            global::Anthropic.RequestToolReferenceBlock? toolReference,
            global::Anthropic.RequestBrowserStateBlock? browserState
            )
        {
            Type = type;

            Text = text;
            Image = image;
            SearchResult = searchResult;
            Document = document;
            ToolReference = toolReference;
            BrowserState = browserState;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BrowserState as object ??
            ToolReference as object ??
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
            Document?.ToString() ??
            ToolReference?.ToString() ??
            BrowserState?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsSearchResult && !IsDocument && !IsToolReference && !IsBrowserState || !IsText && IsImage && !IsSearchResult && !IsDocument && !IsToolReference && !IsBrowserState || !IsText && !IsImage && IsSearchResult && !IsDocument && !IsToolReference && !IsBrowserState || !IsText && !IsImage && !IsSearchResult && IsDocument && !IsToolReference && !IsBrowserState || !IsText && !IsImage && !IsSearchResult && !IsDocument && IsToolReference && !IsBrowserState || !IsText && !IsImage && !IsSearchResult && !IsDocument && !IsToolReference && IsBrowserState;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.RequestTextBlock, TResult>? text = null,
            global::System.Func<global::Anthropic.RequestImageBlock, TResult>? image = null,
            global::System.Func<global::Anthropic.RequestSearchResultBlock, TResult>? searchResult = null,
            global::System.Func<global::Anthropic.RequestDocumentBlock, TResult>? document = null,
            global::System.Func<global::Anthropic.RequestToolReferenceBlock, TResult>? toolReference = null,
            global::System.Func<global::Anthropic.RequestBrowserStateBlock, TResult>? browserState = null,
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
            else if (IsToolReference && toolReference != null)
            {
                return toolReference(ToolReference!);
            }
            else if (IsBrowserState && browserState != null)
            {
                return browserState(BrowserState!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.RequestTextBlock>? text = null,

            global::System.Action<global::Anthropic.RequestImageBlock>? image = null,

            global::System.Action<global::Anthropic.RequestSearchResultBlock>? searchResult = null,

            global::System.Action<global::Anthropic.RequestDocumentBlock>? document = null,

            global::System.Action<global::Anthropic.RequestToolReferenceBlock>? toolReference = null,

            global::System.Action<global::Anthropic.RequestBrowserStateBlock>? browserState = null,
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
            else if (IsToolReference)
            {
                toolReference?.Invoke(ToolReference!);
            }
            else if (IsBrowserState)
            {
                browserState?.Invoke(BrowserState!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.RequestTextBlock>? text = null,
            global::System.Action<global::Anthropic.RequestImageBlock>? image = null,
            global::System.Action<global::Anthropic.RequestSearchResultBlock>? searchResult = null,
            global::System.Action<global::Anthropic.RequestDocumentBlock>? document = null,
            global::System.Action<global::Anthropic.RequestToolReferenceBlock>? toolReference = null,
            global::System.Action<global::Anthropic.RequestBrowserStateBlock>? browserState = null,
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
            else if (IsToolReference)
            {
                toolReference?.Invoke(ToolReference!);
            }
            else if (IsBrowserState)
            {
                browserState?.Invoke(BrowserState!);
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
                ToolReference,
                typeof(global::Anthropic.RequestToolReferenceBlock),
                BrowserState,
                typeof(global::Anthropic.RequestBrowserStateBlock),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestSearchResultBlock?>.Default.Equals(SearchResult, other.SearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestDocumentBlock?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestToolReferenceBlock?>.Default.Equals(ToolReference, other.ToolReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestBrowserStateBlock?>.Default.Equals(BrowserState, other.BrowserState)
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
