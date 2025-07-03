#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CitationsItem : global::System.IEquatable<CitationsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestTextBlockCitationDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestCharLocationCitation? CharLocation { get; init; }
#else
        public global::Anthropic.BetaRequestCharLocationCitation? CharLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CharLocation))]
#endif
        public bool IsCharLocation => CharLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsItem(global::Anthropic.BetaRequestCharLocationCitation value) => new CitationsItem((global::Anthropic.BetaRequestCharLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestCharLocationCitation?(CitationsItem @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem(global::Anthropic.BetaRequestCharLocationCitation? value)
        {
            CharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestPageLocationCitation? PageLocation { get; init; }
#else
        public global::Anthropic.BetaRequestPageLocationCitation? PageLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PageLocation))]
#endif
        public bool IsPageLocation => PageLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsItem(global::Anthropic.BetaRequestPageLocationCitation value) => new CitationsItem((global::Anthropic.BetaRequestPageLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestPageLocationCitation?(CitationsItem @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem(global::Anthropic.BetaRequestPageLocationCitation? value)
        {
            PageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestContentBlockLocationCitation? ContentBlockLocation { get; init; }
#else
        public global::Anthropic.BetaRequestContentBlockLocationCitation? ContentBlockLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockLocation))]
#endif
        public bool IsContentBlockLocation => ContentBlockLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsItem(global::Anthropic.BetaRequestContentBlockLocationCitation value) => new CitationsItem((global::Anthropic.BetaRequestContentBlockLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestContentBlockLocationCitation?(CitationsItem @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem(global::Anthropic.BetaRequestContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestWebSearchResultLocationCitation? WebSearchResultLocation { get; init; }
#else
        public global::Anthropic.BetaRequestWebSearchResultLocationCitation? WebSearchResultLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchResultLocation))]
#endif
        public bool IsWebSearchResultLocation => WebSearchResultLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsItem(global::Anthropic.BetaRequestWebSearchResultLocationCitation value) => new CitationsItem((global::Anthropic.BetaRequestWebSearchResultLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestWebSearchResultLocationCitation?(CitationsItem @this) => @this.WebSearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem(global::Anthropic.BetaRequestWebSearchResultLocationCitation? value)
        {
            WebSearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestSearchResultLocationCitation? SearchResultLocation { get; init; }
#else
        public global::Anthropic.BetaRequestSearchResultLocationCitation? SearchResultLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResultLocation))]
#endif
        public bool IsSearchResultLocation => SearchResultLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsItem(global::Anthropic.BetaRequestSearchResultLocationCitation value) => new CitationsItem((global::Anthropic.BetaRequestSearchResultLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestSearchResultLocationCitation?(CitationsItem @this) => @this.SearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem(global::Anthropic.BetaRequestSearchResultLocationCitation? value)
        {
            SearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem(
            global::Anthropic.BetaRequestTextBlockCitationDiscriminatorType? type,
            global::Anthropic.BetaRequestCharLocationCitation? charLocation,
            global::Anthropic.BetaRequestPageLocationCitation? pageLocation,
            global::Anthropic.BetaRequestContentBlockLocationCitation? contentBlockLocation,
            global::Anthropic.BetaRequestWebSearchResultLocationCitation? webSearchResultLocation,
            global::Anthropic.BetaRequestSearchResultLocationCitation? searchResultLocation
            )
        {
            Type = type;

            CharLocation = charLocation;
            PageLocation = pageLocation;
            ContentBlockLocation = contentBlockLocation;
            WebSearchResultLocation = webSearchResultLocation;
            SearchResultLocation = searchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchResultLocation as object ??
            WebSearchResultLocation as object ??
            ContentBlockLocation as object ??
            PageLocation as object ??
            CharLocation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CharLocation?.ToString() ??
            PageLocation?.ToString() ??
            ContentBlockLocation?.ToString() ??
            WebSearchResultLocation?.ToString() ??
            SearchResultLocation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCharLocation && !IsPageLocation && !IsContentBlockLocation && !IsWebSearchResultLocation && !IsSearchResultLocation || !IsCharLocation && IsPageLocation && !IsContentBlockLocation && !IsWebSearchResultLocation && !IsSearchResultLocation || !IsCharLocation && !IsPageLocation && IsContentBlockLocation && !IsWebSearchResultLocation && !IsSearchResultLocation || !IsCharLocation && !IsPageLocation && !IsContentBlockLocation && IsWebSearchResultLocation && !IsSearchResultLocation || !IsCharLocation && !IsPageLocation && !IsContentBlockLocation && !IsWebSearchResultLocation && IsSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRequestCharLocationCitation?, TResult>? charLocation = null,
            global::System.Func<global::Anthropic.BetaRequestPageLocationCitation?, TResult>? pageLocation = null,
            global::System.Func<global::Anthropic.BetaRequestContentBlockLocationCitation?, TResult>? contentBlockLocation = null,
            global::System.Func<global::Anthropic.BetaRequestWebSearchResultLocationCitation?, TResult>? webSearchResultLocation = null,
            global::System.Func<global::Anthropic.BetaRequestSearchResultLocationCitation?, TResult>? searchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCharLocation && charLocation != null)
            {
                return charLocation(CharLocation!);
            }
            else if (IsPageLocation && pageLocation != null)
            {
                return pageLocation(PageLocation!);
            }
            else if (IsContentBlockLocation && contentBlockLocation != null)
            {
                return contentBlockLocation(ContentBlockLocation!);
            }
            else if (IsWebSearchResultLocation && webSearchResultLocation != null)
            {
                return webSearchResultLocation(WebSearchResultLocation!);
            }
            else if (IsSearchResultLocation && searchResultLocation != null)
            {
                return searchResultLocation(SearchResultLocation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaRequestCharLocationCitation?>? charLocation = null,
            global::System.Action<global::Anthropic.BetaRequestPageLocationCitation?>? pageLocation = null,
            global::System.Action<global::Anthropic.BetaRequestContentBlockLocationCitation?>? contentBlockLocation = null,
            global::System.Action<global::Anthropic.BetaRequestWebSearchResultLocationCitation?>? webSearchResultLocation = null,
            global::System.Action<global::Anthropic.BetaRequestSearchResultLocationCitation?>? searchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCharLocation)
            {
                charLocation?.Invoke(CharLocation!);
            }
            else if (IsPageLocation)
            {
                pageLocation?.Invoke(PageLocation!);
            }
            else if (IsContentBlockLocation)
            {
                contentBlockLocation?.Invoke(ContentBlockLocation!);
            }
            else if (IsWebSearchResultLocation)
            {
                webSearchResultLocation?.Invoke(WebSearchResultLocation!);
            }
            else if (IsSearchResultLocation)
            {
                searchResultLocation?.Invoke(SearchResultLocation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CharLocation,
                typeof(global::Anthropic.BetaRequestCharLocationCitation),
                PageLocation,
                typeof(global::Anthropic.BetaRequestPageLocationCitation),
                ContentBlockLocation,
                typeof(global::Anthropic.BetaRequestContentBlockLocationCitation),
                WebSearchResultLocation,
                typeof(global::Anthropic.BetaRequestWebSearchResultLocationCitation),
                SearchResultLocation,
                typeof(global::Anthropic.BetaRequestSearchResultLocationCitation),
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
        public bool Equals(CitationsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestCharLocationCitation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestPageLocationCitation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestWebSearchResultLocationCitation?>.Default.Equals(WebSearchResultLocation, other.WebSearchResultLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestSearchResultLocationCitation?>.Default.Equals(SearchResultLocation, other.SearchResultLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationsItem obj1, CitationsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationsItem obj1, CitationsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationsItem o && Equals(o);
        }
    }
}
