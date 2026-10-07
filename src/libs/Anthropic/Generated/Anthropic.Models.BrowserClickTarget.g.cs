#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where to act: either a viewport coordinate or an element reference.
    /// </summary>
    public readonly partial struct BrowserClickTarget : global::System.IEquatable<BrowserClickTarget>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserClickTargetDiscriminatorType? Type { get; }

        /// <summary>
        /// A point in the browser viewport, in viewport pixels (the same frame as a<br/>
        /// full-viewport screenshot).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserCoordinateTarget? Coordinate { get; init; }
#else
        public global::Anthropic.BrowserCoordinateTarget? Coordinate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Coordinate))]
#endif
        public bool IsCoordinate => Coordinate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCoordinate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BrowserCoordinateTarget? value)
        {
            value = Coordinate;
            return IsCoordinate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCoordinateTarget PickCoordinate() => Coordinate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Coordinate' but the value was {ToString()}.");

        /// <summary>
        /// An element on the page, identified by a reference from a prior `read_page` or<br/>
        /// `find` result. References are scoped to the tab that produced them and become<br/>
        /// stale after navigation or a major re-render.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserRefTarget? Ref { get; init; }
#else
        public global::Anthropic.BrowserRefTarget? Ref { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ref))]
#endif
        public bool IsRef => Ref != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRef(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BrowserRefTarget? value)
        {
            value = Ref;
            return IsRef;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRefTarget PickRef() => Ref is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ref' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserClickTarget(global::Anthropic.BrowserCoordinateTarget value) => new BrowserClickTarget((global::Anthropic.BrowserCoordinateTarget?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserCoordinateTarget?(BrowserClickTarget @this) => @this.Coordinate;

        /// <summary>
        ///
        /// </summary>
        public BrowserClickTarget(global::Anthropic.BrowserCoordinateTarget? value)
        {
            Coordinate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserClickTarget FromCoordinate(global::Anthropic.BrowserCoordinateTarget? value) => new BrowserClickTarget(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserClickTarget(global::Anthropic.BrowserRefTarget value) => new BrowserClickTarget((global::Anthropic.BrowserRefTarget?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserRefTarget?(BrowserClickTarget @this) => @this.Ref;

        /// <summary>
        ///
        /// </summary>
        public BrowserClickTarget(global::Anthropic.BrowserRefTarget? value)
        {
            Ref = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserClickTarget FromRef(global::Anthropic.BrowserRefTarget? value) => new BrowserClickTarget(value);

        /// <summary>
        ///
        /// </summary>
        public BrowserClickTarget(
            global::Anthropic.BrowserClickTargetDiscriminatorType? type,
            global::Anthropic.BrowserCoordinateTarget? coordinate,
            global::Anthropic.BrowserRefTarget? @ref
            )
        {
            Type = type;

            Coordinate = coordinate;
            Ref = @ref;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Ref as object ??
            Coordinate as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Coordinate?.ToString() ??
            Ref?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCoordinate && !IsRef || !IsCoordinate && IsRef;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BrowserCoordinateTarget, TResult>? coordinate = null,
            global::System.Func<global::Anthropic.BrowserRefTarget, TResult>? @ref = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Coordinate is { } __value0 && coordinate != null)
            {
                return coordinate(__value0);
            }
            else if (Ref is { } __value1 && @ref != null)
            {
                return @ref(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BrowserCoordinateTarget>? coordinate = null,

            global::System.Action<global::Anthropic.BrowserRefTarget>? @ref = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Coordinate is { } __value0)
            {
                coordinate?.Invoke(__value0);
            }
            else if (Ref is { } __value1)
            {
                @ref?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BrowserCoordinateTarget>? coordinate = null,
            global::System.Action<global::Anthropic.BrowserRefTarget>? @ref = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Coordinate is { } __value0)
            {
                coordinate?.Invoke(__value0);
            }
            else if (Ref is { } __value1)
            {
                @ref?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Coordinate,
                typeof(global::Anthropic.BrowserCoordinateTarget),
                Ref,
                typeof(global::Anthropic.BrowserRefTarget),
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
        public bool Equals(BrowserClickTarget other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserCoordinateTarget?>.Default.Equals(Coordinate, other.Coordinate) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserRefTarget?>.Default.Equals(Ref, other.Ref)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BrowserClickTarget obj1, BrowserClickTarget obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BrowserClickTarget>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BrowserClickTarget obj1, BrowserClickTarget obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BrowserClickTarget o && Equals(o);
        }
    }
}
