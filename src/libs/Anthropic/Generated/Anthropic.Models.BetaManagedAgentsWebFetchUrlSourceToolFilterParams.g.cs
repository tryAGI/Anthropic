#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which tools' results contribute URLs that may be fetched. Accepts the string "all" or "none", or an object whose type is "all", "none", "only" or "except". Responses use the object form.
    /// </summary>
    public readonly partial struct BetaManagedAgentsWebFetchUrlSourceToolFilterParams : global::System.IEquatable<BetaManagedAgentsWebFetchUrlSourceToolFilterParams>
    {
        /// <summary>
        /// String form of a url_sources value that has no field other than its type: "all" means {"type": "all"} and "none" means {"type": "none"}.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? Shorthand { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? Shorthand { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shorthand))]
#endif
        public bool IsShorthand => Shorthand != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShorthand(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? value)
        {
            value = Shorthand;
            return IsShorthand;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand PickShorthand() => Shorthand is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shorthand' but the value was {ToString()}.");

        /// <summary>
        /// Which tools' results contribute URLs that may be fetched.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? BetaManagedAgentsWebFetchUrlSourceToolFilter { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? BetaManagedAgentsWebFetchUrlSourceToolFilter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsWebFetchUrlSourceToolFilter))]
#endif
        public bool IsBetaManagedAgentsWebFetchUrlSourceToolFilter => BetaManagedAgentsWebFetchUrlSourceToolFilter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsWebFetchUrlSourceToolFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? value)
        {
            value = BetaManagedAgentsWebFetchUrlSourceToolFilter;
            return IsBetaManagedAgentsWebFetchUrlSourceToolFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter PickBetaManagedAgentsWebFetchUrlSourceToolFilter() => BetaManagedAgentsWebFetchUrlSourceToolFilter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsWebFetchUrlSourceToolFilter' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWebFetchUrlSourceToolFilterParams(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand value) => new BetaManagedAgentsWebFetchUrlSourceToolFilterParams((global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?(BetaManagedAgentsWebFetchUrlSourceToolFilterParams @this) => @this.Shorthand;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceToolFilterParams(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? value)
        {
            Shorthand = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceToolFilterParams FromShorthand(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? value) => new BetaManagedAgentsWebFetchUrlSourceToolFilterParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWebFetchUrlSourceToolFilterParams(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter value) => new BetaManagedAgentsWebFetchUrlSourceToolFilterParams((global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter?(BetaManagedAgentsWebFetchUrlSourceToolFilterParams @this) => @this.BetaManagedAgentsWebFetchUrlSourceToolFilter;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceToolFilterParams(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? value)
        {
            BetaManagedAgentsWebFetchUrlSourceToolFilter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceToolFilterParams FromBetaManagedAgentsWebFetchUrlSourceToolFilter(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? value) => new BetaManagedAgentsWebFetchUrlSourceToolFilterParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceToolFilterParams(
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? shorthand,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter? betaManagedAgentsWebFetchUrlSourceToolFilter
            )
        {
            Shorthand = shorthand;
            BetaManagedAgentsWebFetchUrlSourceToolFilter = betaManagedAgentsWebFetchUrlSourceToolFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaManagedAgentsWebFetchUrlSourceToolFilter as object ??
            Shorthand as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shorthand?.ToValueString() ??
            BetaManagedAgentsWebFetchUrlSourceToolFilter?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShorthand && !IsBetaManagedAgentsWebFetchUrlSourceToolFilter || !IsShorthand && IsBetaManagedAgentsWebFetchUrlSourceToolFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?, TResult>? shorthand = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter?, TResult>? betaManagedAgentsWebFetchUrlSourceToolFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shorthand is { } __value0 && shorthand != null)
            {
                return shorthand(__value0);
            }
            else if (BetaManagedAgentsWebFetchUrlSourceToolFilter is { } __value1 && betaManagedAgentsWebFetchUrlSourceToolFilter != null)
            {
                return betaManagedAgentsWebFetchUrlSourceToolFilter(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?>? shorthand = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter?>? betaManagedAgentsWebFetchUrlSourceToolFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shorthand is { } __value0)
            {
                shorthand?.Invoke(__value0);
            }
            else if (BetaManagedAgentsWebFetchUrlSourceToolFilter is { } __value1)
            {
                betaManagedAgentsWebFetchUrlSourceToolFilter?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?>? shorthand = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter?>? betaManagedAgentsWebFetchUrlSourceToolFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shorthand is { } __value0)
            {
                shorthand?.Invoke(__value0);
            }
            else if (BetaManagedAgentsWebFetchUrlSourceToolFilter is { } __value1)
            {
                betaManagedAgentsWebFetchUrlSourceToolFilter?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shorthand,
                typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand),
                BetaManagedAgentsWebFetchUrlSourceToolFilter,
                typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter),
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
        public bool Equals(BetaManagedAgentsWebFetchUrlSourceToolFilterParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?>.Default.Equals(Shorthand, other.Shorthand) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilter?>.Default.Equals(BetaManagedAgentsWebFetchUrlSourceToolFilter, other.BetaManagedAgentsWebFetchUrlSourceToolFilter)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsWebFetchUrlSourceToolFilterParams obj1, BetaManagedAgentsWebFetchUrlSourceToolFilterParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsWebFetchUrlSourceToolFilterParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsWebFetchUrlSourceToolFilterParams obj1, BetaManagedAgentsWebFetchUrlSourceToolFilterParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsWebFetchUrlSourceToolFilterParams o && Equals(o);
        }
    }
}
