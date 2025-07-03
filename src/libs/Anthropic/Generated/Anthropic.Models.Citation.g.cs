#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Citation : global::System.IEquatable<Citation>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCitationsDeltaCitationDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseCharLocationCitation? CharLocation { get; init; }
#else
        public global::Anthropic.BetaResponseCharLocationCitation? CharLocation { get; }
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
        public static implicit operator Citation(global::Anthropic.BetaResponseCharLocationCitation value) => new Citation((global::Anthropic.BetaResponseCharLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseCharLocationCitation?(Citation @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::Anthropic.BetaResponseCharLocationCitation? value)
        {
            CharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponsePageLocationCitation? PageLocation { get; init; }
#else
        public global::Anthropic.BetaResponsePageLocationCitation? PageLocation { get; }
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
        public static implicit operator Citation(global::Anthropic.BetaResponsePageLocationCitation value) => new Citation((global::Anthropic.BetaResponsePageLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponsePageLocationCitation?(Citation @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::Anthropic.BetaResponsePageLocationCitation? value)
        {
            PageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseContentBlockLocationCitation? ContentBlockLocation { get; init; }
#else
        public global::Anthropic.BetaResponseContentBlockLocationCitation? ContentBlockLocation { get; }
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
        public static implicit operator Citation(global::Anthropic.BetaResponseContentBlockLocationCitation value) => new Citation((global::Anthropic.BetaResponseContentBlockLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseContentBlockLocationCitation?(Citation @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::Anthropic.BetaResponseContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseWebSearchResultLocationCitation? WebSearchResultLocation { get; init; }
#else
        public global::Anthropic.BetaResponseWebSearchResultLocationCitation? WebSearchResultLocation { get; }
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
        public static implicit operator Citation(global::Anthropic.BetaResponseWebSearchResultLocationCitation value) => new Citation((global::Anthropic.BetaResponseWebSearchResultLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseWebSearchResultLocationCitation?(Citation @this) => @this.WebSearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::Anthropic.BetaResponseWebSearchResultLocationCitation? value)
        {
            WebSearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseSearchResultLocationCitation? SearchResultLocation { get; init; }
#else
        public global::Anthropic.BetaResponseSearchResultLocationCitation? SearchResultLocation { get; }
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
        public static implicit operator Citation(global::Anthropic.BetaResponseSearchResultLocationCitation value) => new Citation((global::Anthropic.BetaResponseSearchResultLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseSearchResultLocationCitation?(Citation @this) => @this.SearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation(global::Anthropic.BetaResponseSearchResultLocationCitation? value)
        {
            SearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Citation(
            global::Anthropic.BetaCitationsDeltaCitationDiscriminatorType? type,
            global::Anthropic.BetaResponseCharLocationCitation? charLocation,
            global::Anthropic.BetaResponsePageLocationCitation? pageLocation,
            global::Anthropic.BetaResponseContentBlockLocationCitation? contentBlockLocation,
            global::Anthropic.BetaResponseWebSearchResultLocationCitation? webSearchResultLocation,
            global::Anthropic.BetaResponseSearchResultLocationCitation? searchResultLocation
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
            global::System.Func<global::Anthropic.BetaResponseCharLocationCitation?, TResult>? charLocation = null,
            global::System.Func<global::Anthropic.BetaResponsePageLocationCitation?, TResult>? pageLocation = null,
            global::System.Func<global::Anthropic.BetaResponseContentBlockLocationCitation?, TResult>? contentBlockLocation = null,
            global::System.Func<global::Anthropic.BetaResponseWebSearchResultLocationCitation?, TResult>? webSearchResultLocation = null,
            global::System.Func<global::Anthropic.BetaResponseSearchResultLocationCitation?, TResult>? searchResultLocation = null,
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
            global::System.Action<global::Anthropic.BetaResponseCharLocationCitation?>? charLocation = null,
            global::System.Action<global::Anthropic.BetaResponsePageLocationCitation?>? pageLocation = null,
            global::System.Action<global::Anthropic.BetaResponseContentBlockLocationCitation?>? contentBlockLocation = null,
            global::System.Action<global::Anthropic.BetaResponseWebSearchResultLocationCitation?>? webSearchResultLocation = null,
            global::System.Action<global::Anthropic.BetaResponseSearchResultLocationCitation?>? searchResultLocation = null,
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
                typeof(global::Anthropic.BetaResponseCharLocationCitation),
                PageLocation,
                typeof(global::Anthropic.BetaResponsePageLocationCitation),
                ContentBlockLocation,
                typeof(global::Anthropic.BetaResponseContentBlockLocationCitation),
                WebSearchResultLocation,
                typeof(global::Anthropic.BetaResponseWebSearchResultLocationCitation),
                SearchResultLocation,
                typeof(global::Anthropic.BetaResponseSearchResultLocationCitation),
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
        public bool Equals(Citation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseCharLocationCitation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponsePageLocationCitation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseWebSearchResultLocationCitation?>.Default.Equals(WebSearchResultLocation, other.WebSearchResultLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseSearchResultLocationCitation?>.Default.Equals(SearchResultLocation, other.SearchResultLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Citation obj1, Citation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Citation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Citation obj1, Citation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Citation o && Equals(o);
        }
    }
}
