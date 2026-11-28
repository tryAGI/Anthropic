#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaStopDetails : global::System.IEquatable<BetaStopDetails>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStopDetailsDiscriminatorType? Type { get; }

        /// <summary>
        /// Structured information about a refusal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRefusalStopDetails? Refusal { get; init; }
#else
        public global::Anthropic.BetaRefusalStopDetails? Refusal { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefusal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRefusalStopDetails? value)
        {
            value = Refusal;
            return IsRefusal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRefusalStopDetails PickRefusal() => Refusal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Refusal' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaStopDetails(global::Anthropic.BetaRefusalStopDetails value) => new BetaStopDetails((global::Anthropic.BetaRefusalStopDetails?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRefusalStopDetails?(BetaStopDetails @this) => @this.Refusal;

        /// <summary>
        ///
        /// </summary>
        public BetaStopDetails(global::Anthropic.BetaRefusalStopDetails? value)
        {
            Refusal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaStopDetails FromRefusal(global::Anthropic.BetaRefusalStopDetails? value) => new BetaStopDetails(value);

        /// <summary>
        ///
        /// </summary>
        public BetaStopDetails(
            global::Anthropic.BetaStopDetailsDiscriminatorType? type,
            global::Anthropic.BetaRefusalStopDetails? refusal
            )
        {
            Type = type;

            Refusal = refusal;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Refusal as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Refusal?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRefusal;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRefusalStopDetails, TResult>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Refusal is { } __value0 && refusal != null)
            {
                return refusal(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaRefusalStopDetails>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Refusal is { } __value0)
            {
                refusal?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaRefusalStopDetails>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Refusal is { } __value0)
            {
                refusal?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Refusal,
                typeof(global::Anthropic.BetaRefusalStopDetails),
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
        public bool Equals(BetaStopDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRefusalStopDetails?>.Default.Equals(Refusal, other.Refusal)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaStopDetails obj1, BetaStopDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaStopDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaStopDetails obj1, BetaStopDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaStopDetails o && Equals(o);
        }
    }
}
