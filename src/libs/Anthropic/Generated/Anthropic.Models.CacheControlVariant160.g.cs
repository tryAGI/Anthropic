#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CacheControlVariant160 : global::System.IEquatable<CacheControlVariant160>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? Type { get; }

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
        public static implicit operator CacheControlVariant160(global::Anthropic.CacheControlEphemeral value) => new CacheControlVariant160((global::Anthropic.CacheControlEphemeral?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.CacheControlEphemeral?(CacheControlVariant160 @this) => @this.Ephemeral;

        /// <summary>
        /// 
        /// </summary>
        public CacheControlVariant160(global::Anthropic.CacheControlEphemeral? value)
        {
            Ephemeral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CacheControlVariant160(
            global::Anthropic.RequestToolSearchToolResultBlockCacheControlVariant1DiscriminatorType? type,
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
            global::System.Func<global::Anthropic.CacheControlEphemeral?, TResult>? ephemeral = null,
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
            global::System.Action<global::Anthropic.CacheControlEphemeral?>? ephemeral = null,
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
        public bool Equals(CacheControlVariant160 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.CacheControlEphemeral?>.Default.Equals(Ephemeral, other.Ephemeral) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CacheControlVariant160 obj1, CacheControlVariant160 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CacheControlVariant160>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CacheControlVariant160 obj1, CacheControlVariant160 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CacheControlVariant160 o && Equals(o);
        }
    }
}
