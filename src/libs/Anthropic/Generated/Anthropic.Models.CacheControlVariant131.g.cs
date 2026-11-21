#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CacheControlVariant131 : global::System.IEquatable<CacheControlVariant131>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801CacheControlVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.CacheControlEphemeral? Ephemeral { get; init; }
#else
        public global::Anthropic.CacheControlEphemeral? Ephemeral { get; }
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
            out global::Anthropic.CacheControlEphemeral? value)
        {
            value = Ephemeral;
            return IsEphemeral;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheControlEphemeral PickEphemeral() => Ephemeral is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ephemeral' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CacheControlVariant131(global::Anthropic.CacheControlEphemeral value) => new CacheControlVariant131((global::Anthropic.CacheControlEphemeral?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.CacheControlEphemeral?(CacheControlVariant131 @this) => @this.Ephemeral;

        /// <summary>
        ///
        /// </summary>
        public CacheControlVariant131(global::Anthropic.CacheControlEphemeral? value)
        {
            Ephemeral = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CacheControlVariant131 FromEphemeral(global::Anthropic.CacheControlEphemeral? value) => new CacheControlVariant131(value);

        /// <summary>
        ///
        /// </summary>
        public CacheControlVariant131(
            global::Anthropic.BrowserToolset20260801CacheControlVariant1DiscriminatorType? type,
            global::Anthropic.CacheControlEphemeral? ephemeral
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
            global::System.Func<global::Anthropic.CacheControlEphemeral, TResult>? ephemeral = null,
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
            global::System.Action<global::Anthropic.CacheControlEphemeral>? ephemeral = null,
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
            global::System.Action<global::Anthropic.CacheControlEphemeral>? ephemeral = null,
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
                typeof(global::Anthropic.CacheControlEphemeral),
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
        public bool Equals(CacheControlVariant131 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.CacheControlEphemeral?>.Default.Equals(Ephemeral, other.Ephemeral)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CacheControlVariant131 obj1, CacheControlVariant131 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CacheControlVariant131>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CacheControlVariant131 obj1, CacheControlVariant131 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CacheControlVariant131 o && Equals(o);
        }
    }
}
