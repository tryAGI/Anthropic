#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Citation2 : global::System.IEquatable<Citation2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.CitationsDeltaCitationDiscriminatorType? Type { get; }

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
        public static implicit operator Citation2(global::Anthropic.ResponseCharLocationCitation value) => new Citation2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseCharLocationCitation?(Citation2 @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation2(global::Anthropic.ResponseCharLocationCitation? value)
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
        public static implicit operator Citation2(global::Anthropic.ResponsePageLocationCitation value) => new Citation2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponsePageLocationCitation?(Citation2 @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation2(global::Anthropic.ResponsePageLocationCitation? value)
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
        public static implicit operator Citation2(global::Anthropic.ResponseContentBlockLocationCitation value) => new Citation2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ResponseContentBlockLocationCitation?(Citation2 @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public Citation2(global::Anthropic.ResponseContentBlockLocationCitation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Citation2(
            global::Anthropic.CitationsDeltaCitationDiscriminatorType? type,
            global::Anthropic.ResponseCharLocationCitation? charLocation,
            global::Anthropic.ResponsePageLocationCitation? pageLocation,
            global::Anthropic.ResponseContentBlockLocationCitation? contentBlockLocation
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
            global::System.Func<global::Anthropic.ResponseCharLocationCitation?, TResult>? charLocation = null,
            global::System.Func<global::Anthropic.ResponsePageLocationCitation?, TResult>? pageLocation = null,
            global::System.Func<global::Anthropic.ResponseContentBlockLocationCitation?, TResult>? contentBlockLocation = null,
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
            global::System.Action<global::Anthropic.ResponseCharLocationCitation?>? charLocation = null,
            global::System.Action<global::Anthropic.ResponsePageLocationCitation?>? pageLocation = null,
            global::System.Action<global::Anthropic.ResponseContentBlockLocationCitation?>? contentBlockLocation = null,
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
                typeof(global::Anthropic.ResponseCharLocationCitation),
                PageLocation,
                typeof(global::Anthropic.ResponsePageLocationCitation),
                ContentBlockLocation,
                typeof(global::Anthropic.ResponseContentBlockLocationCitation),
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
        public bool Equals(Citation2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseCharLocationCitation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponsePageLocationCitation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseContentBlockLocationCitation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Citation2 obj1, Citation2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Citation2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Citation2 obj1, Citation2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Citation2 o && Equals(o);
        }
    }
}
