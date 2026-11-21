#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CacheControlVariant176 : global::System.IEquatable<CacheControlVariant176>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCacheControlEphemeral? Ephemeral { get; init; }
#else
        public global::Anthropic.BetaCacheControlEphemeral? Ephemeral { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ephemeral))]
#endif
        public bool IsEphemeral => Ephemeral != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEphemeral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaCacheControlEphemeral? value)
        {
            value = Ephemeral;
            return IsEphemeral;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCacheControlEphemeral PickEphemeral() => Ephemeral is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ephemeral' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CacheControlVariant176(global::Anthropic.BetaCacheControlEphemeral value) => new CacheControlVariant176((global::Anthropic.BetaCacheControlEphemeral?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCacheControlEphemeral?(CacheControlVariant176 @this) => @this.Ephemeral;

        /// <summary>
        ///
        /// </summary>
        public CacheControlVariant176(global::Anthropic.BetaCacheControlEphemeral? value)
        {
            Ephemeral = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CacheControlVariant176 FromEphemeral(global::Anthropic.BetaCacheControlEphemeral? value) => new CacheControlVariant176(value);

        /// <summary>
        ///
        /// </summary>
        public CacheControlVariant176(
            global::Anthropic.BetaToolSearchToolBM2520251119CacheControlVariant1DiscriminatorType? type,
            global::Anthropic.BetaCacheControlEphemeral? ephemeral
            )
        {
            Type = type;

            Ephemeral = ephemeral;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Ephemeral as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Ephemeral?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEphemeral;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaCacheControlEphemeral, TResult>? ephemeral = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Ephemeral is { } __value0 && ephemeral != null)
            {
                return ephemeral(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaCacheControlEphemeral>? ephemeral = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Ephemeral is { } __value0)
            {
                ephemeral?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaCacheControlEphemeral>? ephemeral = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Ephemeral is { } __value0)
            {
                ephemeral?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Ephemeral,
                typeof(global::Anthropic.BetaCacheControlEphemeral),
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
        public bool Equals(CacheControlVariant176 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCacheControlEphemeral?>.Default.Equals(Ephemeral, other.Ephemeral)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CacheControlVariant176 obj1, CacheControlVariant176 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CacheControlVariant176>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CacheControlVariant176 obj1, CacheControlVariant176 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CacheControlVariant176 o && Equals(o);
        }
    }
}
