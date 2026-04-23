#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsDeleteMemoryStoreResponse : global::System.IEquatable<BetaManagedAgentsDeleteMemoryStoreResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsDeletedMemoryStore? MemoryStoreDeleted { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsDeletedMemoryStore? MemoryStoreDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryStoreDeleted))]
#endif
        public bool IsMemoryStoreDeleted => MemoryStoreDeleted != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeleteMemoryStoreResponse(global::Anthropic.BetaManagedAgentsDeletedMemoryStore value) => new BetaManagedAgentsDeleteMemoryStoreResponse((global::Anthropic.BetaManagedAgentsDeletedMemoryStore?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsDeletedMemoryStore?(BetaManagedAgentsDeleteMemoryStoreResponse @this) => @this.MemoryStoreDeleted;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeleteMemoryStoreResponse(global::Anthropic.BetaManagedAgentsDeletedMemoryStore? value)
        {
            MemoryStoreDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeleteMemoryStoreResponse(
            global::Anthropic.BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsDeletedMemoryStore? memoryStoreDeleted
            )
        {
            Type = type;

            MemoryStoreDeleted = memoryStoreDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MemoryStoreDeleted as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MemoryStoreDeleted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMemoryStoreDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsDeletedMemoryStore?, TResult>? memoryStoreDeleted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMemoryStoreDeleted && memoryStoreDeleted != null)
            {
                return memoryStoreDeleted(MemoryStoreDeleted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsDeletedMemoryStore?>? memoryStoreDeleted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMemoryStoreDeleted)
            {
                memoryStoreDeleted?.Invoke(MemoryStoreDeleted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MemoryStoreDeleted,
                typeof(global::Anthropic.BetaManagedAgentsDeletedMemoryStore),
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
        public bool Equals(BetaManagedAgentsDeleteMemoryStoreResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsDeletedMemoryStore?>.Default.Equals(MemoryStoreDeleted, other.MemoryStoreDeleted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsDeleteMemoryStoreResponse obj1, BetaManagedAgentsDeleteMemoryStoreResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsDeleteMemoryStoreResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsDeleteMemoryStoreResponse obj1, BetaManagedAgentsDeleteMemoryStoreResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsDeleteMemoryStoreResponse o && Equals(o);
        }
    }
}
