#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CitationsVariant1Item4 : global::System.IEquatable<CitationsVariant1Item4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseCharLocationCitation? CharLocation { get; init; }
#else
        public global::Anthropic.ResponseCharLocationCitation? CharLocation { get; }
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
        public bool TryPickCharLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseCharLocationCitation? value)
        {
            value = CharLocation;
            return IsCharLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ResponseCharLocationCitation PickCharLocation() => IsCharLocation
            ? CharLocation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CharLocation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponsePageLocationCitation? PageLocation { get; init; }
#else
        public global::Anthropic.ResponsePageLocationCitation? PageLocation { get; }
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
        public bool TryPickPageLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponsePageLocationCitation? value)
        {
            value = PageLocation;
            return IsPageLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ResponsePageLocationCitation PickPageLocation() => IsPageLocation
            ? PageLocation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PageLocation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseContentBlockLocationCitation? ContentBlockLocation { get; init; }
#else
        public global::Anthropic.ResponseContentBlockLocationCitation? ContentBlockLocation { get; }
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
        public bool TryPickContentBlockLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseContentBlockLocationCitation? value)
        {
            value = ContentBlockLocation;
            return IsContentBlockLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ResponseContentBlockLocationCitation PickContentBlockLocation() => IsContentBlockLocation
            ? ContentBlockLocation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockLocation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseWebSearchResultLocationCitation? WebSearchResultLocation { get; init; }
#else
        public global::Anthropic.ResponseWebSearchResultLocationCitation? WebSearchResultLocation { get; }
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
        public bool TryPickWebSearchResultLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseWebSearchResultLocationCitation? value)
        {
            value = WebSearchResultLocation;
            return IsWebSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ResponseWebSearchResultLocationCitation PickWebSearchResultLocation() => IsWebSearchResultLocation
            ? WebSearchResultLocation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchResultLocation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseSearchResultLocationCitation? SearchResultLocation { get; init; }
#else
        public global::Anthropic.ResponseSearchResultLocationCitation? SearchResultLocation { get; }
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
        public bool TryPickSearchResultLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseSearchResultLocationCitation? value)
        {
            value = SearchResultLocation;
            return IsSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ResponseSearchResultLocationCitation PickSearchResultLocation() => IsSearchResultLocation
            ? SearchResultLocation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResultLocation' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item4(global::Anthropic.ResponseCharLocationCitation value) => new CitationsVariant1Item4((global::Anthropic.ResponseCharLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseCharLocationCitation?(CitationsVariant1Item4 @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item4(global::Anthropic.ResponseCharLocationCitation? value)
        {
            CharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CitationsVariant1Item4 FromCharLocation(global::Anthropic.ResponseCharLocationCitation? value) => new CitationsVariant1Item4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item4(global::Anthropic.ResponsePageLocationCitation value) => new CitationsVariant1Item4((global::Anthropic.ResponsePageLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponsePageLocationCitation?(CitationsVariant1Item4 @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item4(global::Anthropic.ResponsePageLocationCitation? value)
        {
            PageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CitationsVariant1Item4 FromPageLocation(global::Anthropic.ResponsePageLocationCitation? value) => new CitationsVariant1Item4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item4(global::Anthropic.ResponseContentBlockLocationCitation value) => new CitationsVariant1Item4((global::Anthropic.ResponseContentBlockLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseContentBlockLocationCitation?(CitationsVariant1Item4 @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item4(global::Anthropic.ResponseContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CitationsVariant1Item4 FromContentBlockLocation(global::Anthropic.ResponseContentBlockLocationCitation? value) => new CitationsVariant1Item4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item4(global::Anthropic.ResponseWebSearchResultLocationCitation value) => new CitationsVariant1Item4((global::Anthropic.ResponseWebSearchResultLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseWebSearchResultLocationCitation?(CitationsVariant1Item4 @this) => @this.WebSearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item4(global::Anthropic.ResponseWebSearchResultLocationCitation? value)
        {
            WebSearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CitationsVariant1Item4 FromWebSearchResultLocation(global::Anthropic.ResponseWebSearchResultLocationCitation? value) => new CitationsVariant1Item4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationsVariant1Item4(global::Anthropic.ResponseSearchResultLocationCitation value) => new CitationsVariant1Item4((global::Anthropic.ResponseSearchResultLocationCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseSearchResultLocationCitation?(CitationsVariant1Item4 @this) => @this.SearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item4(global::Anthropic.ResponseSearchResultLocationCitation? value)
        {
            SearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CitationsVariant1Item4 FromSearchResultLocation(global::Anthropic.ResponseSearchResultLocationCitation? value) => new CitationsVariant1Item4(value);

        /// <summary>
        /// 
        /// </summary>
        public CitationsVariant1Item4(
            global::Anthropic.ResponseTextBlockCitationsVariant1ItemDiscriminatorType? type,
            global::Anthropic.ResponseCharLocationCitation? charLocation,
            global::Anthropic.ResponsePageLocationCitation? pageLocation,
            global::Anthropic.ResponseContentBlockLocationCitation? contentBlockLocation,
            global::Anthropic.ResponseWebSearchResultLocationCitation? webSearchResultLocation,
            global::Anthropic.ResponseSearchResultLocationCitation? searchResultLocation
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
            global::System.Func<global::Anthropic.ResponseCharLocationCitation, TResult>? charLocation = null,
            global::System.Func<global::Anthropic.ResponsePageLocationCitation, TResult>? pageLocation = null,
            global::System.Func<global::Anthropic.ResponseContentBlockLocationCitation, TResult>? contentBlockLocation = null,
            global::System.Func<global::Anthropic.ResponseWebSearchResultLocationCitation, TResult>? webSearchResultLocation = null,
            global::System.Func<global::Anthropic.ResponseSearchResultLocationCitation, TResult>? searchResultLocation = null,
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
            global::System.Action<global::Anthropic.ResponseCharLocationCitation>? charLocation = null,

            global::System.Action<global::Anthropic.ResponsePageLocationCitation>? pageLocation = null,

            global::System.Action<global::Anthropic.ResponseContentBlockLocationCitation>? contentBlockLocation = null,

            global::System.Action<global::Anthropic.ResponseWebSearchResultLocationCitation>? webSearchResultLocation = null,

            global::System.Action<global::Anthropic.ResponseSearchResultLocationCitation>? searchResultLocation = null,
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
        public void Switch(
            global::System.Action<global::Anthropic.ResponseCharLocationCitation>? charLocation = null,
            global::System.Action<global::Anthropic.ResponsePageLocationCitation>? pageLocation = null,
            global::System.Action<global::Anthropic.ResponseContentBlockLocationCitation>? contentBlockLocation = null,
            global::System.Action<global::Anthropic.ResponseWebSearchResultLocationCitation>? webSearchResultLocation = null,
            global::System.Action<global::Anthropic.ResponseSearchResultLocationCitation>? searchResultLocation = null,
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
                typeof(global::Anthropic.ResponseCharLocationCitation),
                PageLocation,
                typeof(global::Anthropic.ResponsePageLocationCitation),
                ContentBlockLocation,
                typeof(global::Anthropic.ResponseContentBlockLocationCitation),
                WebSearchResultLocation,
                typeof(global::Anthropic.ResponseWebSearchResultLocationCitation),
                SearchResultLocation,
                typeof(global::Anthropic.ResponseSearchResultLocationCitation),
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
        public bool Equals(CitationsVariant1Item4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseCharLocationCitation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponsePageLocationCitation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseWebSearchResultLocationCitation?>.Default.Equals(WebSearchResultLocation, other.WebSearchResultLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseSearchResultLocationCitation?>.Default.Equals(SearchResultLocation, other.SearchResultLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationsVariant1Item4 obj1, CitationsVariant1Item4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationsVariant1Item4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationsVariant1Item4 obj1, CitationsVariant1Item4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationsVariant1Item4 o && Equals(o);
        }
    }
}
