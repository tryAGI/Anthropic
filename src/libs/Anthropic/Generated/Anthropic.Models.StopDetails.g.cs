#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct StopDetails : global::System.IEquatable<StopDetails>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.StopDetailsDiscriminatorType? Type { get; }

        /// <summary>
        /// Structured information about a refusal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RefusalStopDetails? Refusal { get; init; }
#else
        public global::Anthropic.RefusalStopDetails? Refusal { get; }
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
            out global::Anthropic.RefusalStopDetails? value)
        {
            value = Refusal;
            return IsRefusal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RefusalStopDetails PickRefusal() => Refusal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Refusal' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopDetails(global::Anthropic.RefusalStopDetails value) => new StopDetails((global::Anthropic.RefusalStopDetails?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RefusalStopDetails?(StopDetails @this) => @this.Refusal;

        /// <summary>
        ///
        /// </summary>
        public StopDetails(global::Anthropic.RefusalStopDetails? value)
        {
            Refusal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopDetails FromRefusal(global::Anthropic.RefusalStopDetails? value) => new StopDetails(value);

        /// <summary>
        ///
        /// </summary>
        public StopDetails(
            global::Anthropic.StopDetailsDiscriminatorType? type,
            global::Anthropic.RefusalStopDetails? refusal
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
            global::System.Func<global::Anthropic.RefusalStopDetails, TResult>? refusal = null,
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
            global::System.Action<global::Anthropic.RefusalStopDetails>? refusal = null,
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
            global::System.Action<global::Anthropic.RefusalStopDetails>? refusal = null,
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
                typeof(global::Anthropic.RefusalStopDetails),
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
        public bool Equals(StopDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RefusalStopDetails?>.Default.Equals(Refusal, other.Refusal)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StopDetails obj1, StopDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StopDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StopDetails obj1, StopDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StopDetails o && Equals(o);
        }
    }
}
