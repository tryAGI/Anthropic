#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CachingVariant1 : global::System.IEquatable<CachingVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301CachingVariant1DiscriminatorType? Type { get; }

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
        public static implicit operator CachingVariant1(global::Anthropic.BetaCacheControlEphemeral value) => new CachingVariant1((global::Anthropic.BetaCacheControlEphemeral?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCacheControlEphemeral?(CachingVariant1 @this) => @this.Ephemeral;

        /// <summary>
        /// 
        /// </summary>
        public CachingVariant1(global::Anthropic.BetaCacheControlEphemeral? value)
        {
            Ephemeral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CachingVariant1(
            global::Anthropic.BetaAdvisorTool20260301CachingVariant1DiscriminatorType? type,
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
            global::System.Func<global::Anthropic.BetaCacheControlEphemeral?, TResult>? ephemeral = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEphemeral && ephemeral != null)
            {
                return ephemeral(Ephemeral!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaCacheControlEphemeral?>? ephemeral = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEphemeral)
            {
                ephemeral?.Invoke(Ephemeral!);
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
        public bool Equals(CachingVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCacheControlEphemeral?>.Default.Equals(Ephemeral, other.Ephemeral) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CachingVariant1 obj1, CachingVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CachingVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CachingVariant1 obj1, CachingVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CachingVariant1 o && Equals(o);
        }
    }
}
