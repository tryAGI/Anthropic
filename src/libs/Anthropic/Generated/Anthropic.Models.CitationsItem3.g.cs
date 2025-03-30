#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CitationsItem3 : global::System.IEquatable<CitationsItem3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestTextBlockCitationDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestCharLocationCitation? CharLocation { get; init; }
#else
        public global::Anthropic.RequestCharLocationCitation? CharLocation { get; }
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
        public static implicit operator CitationsItem3(global::Anthropic.RequestCharLocationCitation value) => new CitationsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestCharLocationCitation?(CitationsItem3 @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem3(global::Anthropic.RequestCharLocationCitation? value)
        {
            CharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestPageLocationCitation? PageLocation { get; init; }
#else
        public global::Anthropic.RequestPageLocationCitation? PageLocation { get; }
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
        public static implicit operator CitationsItem3(global::Anthropic.RequestPageLocationCitation value) => new CitationsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestPageLocationCitation?(CitationsItem3 @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem3(global::Anthropic.RequestPageLocationCitation? value)
        {
            PageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestContentBlockLocationCitation? ContentBlockLocation { get; init; }
#else
        public global::Anthropic.RequestContentBlockLocationCitation? ContentBlockLocation { get; }
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
        public static implicit operator CitationsItem3(global::Anthropic.RequestContentBlockLocationCitation value) => new CitationsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestContentBlockLocationCitation?(CitationsItem3 @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem3(global::Anthropic.RequestContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CitationsItem3(
            global::Anthropic.RequestTextBlockCitationDiscriminatorType? type,
            global::Anthropic.RequestCharLocationCitation? charLocation,
            global::Anthropic.RequestPageLocationCitation? pageLocation,
            global::Anthropic.RequestContentBlockLocationCitation? contentBlockLocation
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
        public override string? ToString() =>
            CharLocation?.ToString() ??
            PageLocation?.ToString() ??
            ContentBlockLocation?.ToString() 
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
            global::System.Func<global::Anthropic.RequestCharLocationCitation?, TResult>? charLocation = null,
            global::System.Func<global::Anthropic.RequestPageLocationCitation?, TResult>? pageLocation = null,
            global::System.Func<global::Anthropic.RequestContentBlockLocationCitation?, TResult>? contentBlockLocation = null,
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
            global::System.Action<global::Anthropic.RequestCharLocationCitation?>? charLocation = null,
            global::System.Action<global::Anthropic.RequestPageLocationCitation?>? pageLocation = null,
            global::System.Action<global::Anthropic.RequestContentBlockLocationCitation?>? contentBlockLocation = null,
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
                typeof(global::Anthropic.RequestCharLocationCitation),
                PageLocation,
                typeof(global::Anthropic.RequestPageLocationCitation),
                ContentBlockLocation,
                typeof(global::Anthropic.RequestContentBlockLocationCitation),
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
        public bool Equals(CitationsItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestCharLocationCitation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestPageLocationCitation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationsItem3 obj1, CitationsItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationsItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationsItem3 obj1, CitationsItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationsItem3 o && Equals(o);
        }
    }
}
