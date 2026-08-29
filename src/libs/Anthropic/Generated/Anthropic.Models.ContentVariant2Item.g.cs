#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentVariant2Item : global::System.IEquatable<ContentVariant2Item>
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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlock PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

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
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestImageBlock? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestImageBlock PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

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
        public bool TryPickSearchResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestSearchResultBlock? value)
        {
            value = SearchResult;
            return IsSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestSearchResultBlock PickSearchResult() => IsSearchResult
            ? SearchResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResult' but the value was {ToString()}.");

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
        public bool TryPickDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestDocumentBlock? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestDocumentBlock PickDocument() => IsDocument
            ? Document!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");

        /// <summary>
        /// Tool reference block that can be included in tool_result content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolReferenceBlock? ToolReference { get; init; }
#else
        public global::Anthropic.BetaRequestToolReferenceBlock? ToolReference { get; }
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
            out global::Anthropic.BetaRequestToolReferenceBlock? value)
        {
            value = ToolReference;
            return IsToolReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolReferenceBlock PickToolReference() => IsToolReference
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
        public global::Anthropic.BetaRequestBrowserStateBlock? BrowserState { get; init; }
#else
        public global::Anthropic.BetaRequestBrowserStateBlock? BrowserState { get; }
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
            out global::Anthropic.BetaRequestBrowserStateBlock? value)
        {
            value = BrowserState;
            return IsBrowserState;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlock PickBrowserState() => IsBrowserState
            ? BrowserState!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserState' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Anthropic.BetaRequestTextBlock value) => new ContentVariant2Item((global::Anthropic.BetaRequestTextBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestTextBlock?(ContentVariant2Item @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::Anthropic.BetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromText(global::Anthropic.BetaRequestTextBlock? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Anthropic.BetaRequestImageBlock value) => new ContentVariant2Item((global::Anthropic.BetaRequestImageBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestImageBlock?(ContentVariant2Item @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::Anthropic.BetaRequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromImage(global::Anthropic.BetaRequestImageBlock? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Anthropic.BetaRequestSearchResultBlock value) => new ContentVariant2Item((global::Anthropic.BetaRequestSearchResultBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestSearchResultBlock?(ContentVariant2Item @this) => @this.SearchResult;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::Anthropic.BetaRequestSearchResultBlock? value)
        {
            SearchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromSearchResult(global::Anthropic.BetaRequestSearchResultBlock? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Anthropic.BetaRequestDocumentBlock value) => new ContentVariant2Item((global::Anthropic.BetaRequestDocumentBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestDocumentBlock?(ContentVariant2Item @this) => @this.Document;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::Anthropic.BetaRequestDocumentBlock? value)
        {
            Document = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromDocument(global::Anthropic.BetaRequestDocumentBlock? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Anthropic.BetaRequestToolReferenceBlock value) => new ContentVariant2Item((global::Anthropic.BetaRequestToolReferenceBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolReferenceBlock?(ContentVariant2Item @this) => @this.ToolReference;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::Anthropic.BetaRequestToolReferenceBlock? value)
        {
            ToolReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromToolReference(global::Anthropic.BetaRequestToolReferenceBlock? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Anthropic.BetaRequestBrowserStateBlock value) => new ContentVariant2Item((global::Anthropic.BetaRequestBrowserStateBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestBrowserStateBlock?(ContentVariant2Item @this) => @this.BrowserState;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::Anthropic.BetaRequestBrowserStateBlock? value)
        {
            BrowserState = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromBrowserState(global::Anthropic.BetaRequestBrowserStateBlock? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(
            global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? type,
            global::Anthropic.BetaRequestTextBlock? text,
            global::Anthropic.BetaRequestImageBlock? image,
            global::Anthropic.BetaRequestSearchResultBlock? searchResult,
            global::Anthropic.BetaRequestDocumentBlock? document,
            global::Anthropic.BetaRequestToolReferenceBlock? toolReference,
            global::Anthropic.BetaRequestBrowserStateBlock? browserState
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
            global::System.Func<global::Anthropic.BetaRequestTextBlock, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaRequestImageBlock, TResult>? image = null,
            global::System.Func<global::Anthropic.BetaRequestSearchResultBlock, TResult>? searchResult = null,
            global::System.Func<global::Anthropic.BetaRequestDocumentBlock, TResult>? document = null,
            global::System.Func<global::Anthropic.BetaRequestToolReferenceBlock, TResult>? toolReference = null,
            global::System.Func<global::Anthropic.BetaRequestBrowserStateBlock, TResult>? browserState = null,
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
            global::System.Action<global::Anthropic.BetaRequestTextBlock>? text = null,

            global::System.Action<global::Anthropic.BetaRequestImageBlock>? image = null,

            global::System.Action<global::Anthropic.BetaRequestSearchResultBlock>? searchResult = null,

            global::System.Action<global::Anthropic.BetaRequestDocumentBlock>? document = null,

            global::System.Action<global::Anthropic.BetaRequestToolReferenceBlock>? toolReference = null,

            global::System.Action<global::Anthropic.BetaRequestBrowserStateBlock>? browserState = null,
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
            global::System.Action<global::Anthropic.BetaRequestTextBlock>? text = null,
            global::System.Action<global::Anthropic.BetaRequestImageBlock>? image = null,
            global::System.Action<global::Anthropic.BetaRequestSearchResultBlock>? searchResult = null,
            global::System.Action<global::Anthropic.BetaRequestDocumentBlock>? document = null,
            global::System.Action<global::Anthropic.BetaRequestToolReferenceBlock>? toolReference = null,
            global::System.Action<global::Anthropic.BetaRequestBrowserStateBlock>? browserState = null,
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
                typeof(global::Anthropic.BetaRequestTextBlock),
                Image,
                typeof(global::Anthropic.BetaRequestImageBlock),
                SearchResult,
                typeof(global::Anthropic.BetaRequestSearchResultBlock),
                Document,
                typeof(global::Anthropic.BetaRequestDocumentBlock),
                ToolReference,
                typeof(global::Anthropic.BetaRequestToolReferenceBlock),
                BrowserState,
                typeof(global::Anthropic.BetaRequestBrowserStateBlock),
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
        public bool Equals(ContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestSearchResultBlock?>.Default.Equals(SearchResult, other.SearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestDocumentBlock?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolReferenceBlock?>.Default.Equals(ToolReference, other.ToolReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestBrowserStateBlock?>.Default.Equals(BrowserState, other.BrowserState)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item o && Equals(o);
        }
    }
}
