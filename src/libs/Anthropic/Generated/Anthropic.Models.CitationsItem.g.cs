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
        public static implicit operator CitationsItem(global::Anthropic.BetaRequestCharLocationCitation value) => new CitationsItem(value);

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
        public static implicit operator CitationsItem(global::Anthropic.BetaRequestPageLocationCitation value) => new CitationsItem(value);

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
        public static implicit operator CitationsItem(global::Anthropic.BetaRequestContentBlockLocationCitation value) => new CitationsItem(value);

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
        public CitationsItem(
            global::Anthropic.BetaRequestTextBlockCitationDiscriminatorType? type,
            global::Anthropic.BetaRequestCharLocationCitation? charLocation,
            global::Anthropic.BetaRequestPageLocationCitation? pageLocation,
            global::Anthropic.BetaRequestContentBlockLocationCitation? contentBlockLocation
            )
        {
            Type = type;

            CharLocation = charLocation;
            PageLocation = pageLocation;
            ContentBlockLocation = contentBlockLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContentBlockLocation as object ??
            PageLocation as object ??
            CharLocation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCharLocation && !IsPageLocation && !IsContentBlockLocation || !IsCharLocation && IsPageLocation && !IsContentBlockLocation || !IsCharLocation && !IsPageLocation && IsContentBlockLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRequestCharLocationCitation?, TResult>? charLocation = null,
            global::System.Func<global::Anthropic.BetaRequestPageLocationCitation?, TResult>? pageLocation = null,
            global::System.Func<global::Anthropic.BetaRequestContentBlockLocationCitation?, TResult>? contentBlockLocation = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaRequestCharLocationCitation?>? charLocation = null,
            global::System.Action<global::Anthropic.BetaRequestPageLocationCitation?>? pageLocation = null,
            global::System.Action<global::Anthropic.BetaRequestContentBlockLocationCitation?>? contentBlockLocation = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) 
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
