#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Structured information about why a session or thread stopped. Open union: clients must tolerate unknown variants.
    /// </summary>
    public readonly partial struct BetaManagedAgentsSessionStopDetails : global::System.IEquatable<BetaManagedAgentsSessionStopDetails>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminatorType? Type { get; }

        /// <summary>
        /// Structured information about a refusal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? Refusal { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? Refusal { get; }
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
            out global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? value)
        {
            value = Refusal;
            return IsRefusal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails PickRefusal() => Refusal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Refusal' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionStopDetails(global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails value) => new BetaManagedAgentsSessionStopDetails((global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails?(BetaManagedAgentsSessionStopDetails @this) => @this.Refusal;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionStopDetails(global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? value)
        {
            Refusal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionStopDetails FromRefusal(global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? value) => new BetaManagedAgentsSessionStopDetails(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionStopDetails(
            global::Anthropic.BetaManagedAgentsSessionStopDetailsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails? refusal
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
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails, TResult>? refusal = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails>? refusal = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails>? refusal = null,
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
                typeof(global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails),
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
        public bool Equals(BetaManagedAgentsSessionStopDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionRefusalStopDetails?>.Default.Equals(Refusal, other.Refusal)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSessionStopDetails obj1, BetaManagedAgentsSessionStopDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSessionStopDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSessionStopDetails obj1, BetaManagedAgentsSessionStopDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSessionStopDetails o && Equals(o);
        }
    }
}
