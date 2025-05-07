#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CitationsItem4 : global::System.IEquatable<CitationsItem4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ResponseTextBlockCitationDiscriminatorType? Type { get; }

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
        public static implicit operator CitationsItem4(global::Anthropic.ResponseCharLocationCitation value) => new CitationsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseCharLocationCitation?(CitationsItem4 @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem4(global::Anthropic.ResponseCharLocationCitation? value)
        {
            CharLocation = value;
        }

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
        public static implicit operator CitationsItem4(global::Anthropic.ResponsePageLocationCitation value) => new CitationsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponsePageLocationCitation?(CitationsItem4 @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem4(global::Anthropic.ResponsePageLocationCitation? value)
        {
            PageLocation = value;
        }

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
        public static implicit operator CitationsItem4(global::Anthropic.ResponseContentBlockLocationCitation value) => new CitationsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseContentBlockLocationCitation?(CitationsItem4 @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem4(global::Anthropic.ResponseContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

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
        public static implicit operator CitationsItem4(global::Anthropic.ResponseWebSearchResultLocationCitation value) => new CitationsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseWebSearchResultLocationCitation?(CitationsItem4 @this) => @this.WebSearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem4(global::Anthropic.ResponseWebSearchResultLocationCitation? value)
        {
            WebSearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem4(
            global::Anthropic.ResponseTextBlockCitationDiscriminatorType? type,
            global::Anthropic.ResponseCharLocationCitation? charLocation,
            global::Anthropic.ResponsePageLocationCitation? pageLocation,
            global::Anthropic.ResponseContentBlockLocationCitation? contentBlockLocation,
            global::Anthropic.ResponseWebSearchResultLocationCitation? webSearchResultLocation
            )
        {
            Type = type;

            CharLocation = charLocation;
            PageLocation = pageLocation;
            ContentBlockLocation = contentBlockLocation;
            WebSearchResultLocation = webSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            WebSearchResultLocation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCharLocation && !IsPageLocation && !IsContentBlockLocation && !IsWebSearchResultLocation || !IsCharLocation && IsPageLocation && !IsContentBlockLocation && !IsWebSearchResultLocation || !IsCharLocation && !IsPageLocation && IsContentBlockLocation && !IsWebSearchResultLocation || !IsCharLocation && !IsPageLocation && !IsContentBlockLocation && IsWebSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.ResponseCharLocationCitation?, TResult>? charLocation = null,
            global::System.Func<global::Anthropic.ResponsePageLocationCitation?, TResult>? pageLocation = null,
            global::System.Func<global::Anthropic.ResponseContentBlockLocationCitation?, TResult>? contentBlockLocation = null,
            global::System.Func<global::Anthropic.ResponseWebSearchResultLocationCitation?, TResult>? webSearchResultLocation = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ResponseCharLocationCitation?>? charLocation = null,
            global::System.Action<global::Anthropic.ResponsePageLocationCitation?>? pageLocation = null,
            global::System.Action<global::Anthropic.ResponseContentBlockLocationCitation?>? contentBlockLocation = null,
            global::System.Action<global::Anthropic.ResponseWebSearchResultLocationCitation?>? webSearchResultLocation = null,
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
        public bool Equals(CitationsItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseCharLocationCitation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponsePageLocationCitation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseWebSearchResultLocationCitation?>.Default.Equals(WebSearchResultLocation, other.WebSearchResultLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationsItem4 obj1, CitationsItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationsItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationsItem4 obj1, CitationsItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationsItem4 o && Equals(o);
        }
    }
}
