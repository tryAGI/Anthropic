#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response from creating a `memory_store`. Returns the created store.
    /// </summary>
    public readonly partial struct BetaManagedAgentsCreateMemoryStoreResponse : global::System.IEquatable<BetaManagedAgentsCreateMemoryStoreResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// A `memory_store`: a named container for agent memories, scoped to a workspace. Attach a store to a session via `resources[]` to mount it as a directory the agent can read and write.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMemoryStore? MemoryStore { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMemoryStore? MemoryStore { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryStore))]
#endif
        public bool IsMemoryStore => MemoryStore != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMemoryStore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMemoryStore? value)
        {
            value = MemoryStore;
            return IsMemoryStore;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStore PickMemoryStore() => IsMemoryStore
            ? MemoryStore!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryStore' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCreateMemoryStoreResponse(global::Anthropic.BetaManagedAgentsMemoryStore value) => new BetaManagedAgentsCreateMemoryStoreResponse((global::Anthropic.BetaManagedAgentsMemoryStore?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMemoryStore?(BetaManagedAgentsCreateMemoryStoreResponse @this) => @this.MemoryStore;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCreateMemoryStoreResponse(global::Anthropic.BetaManagedAgentsMemoryStore? value)
        {
            MemoryStore = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCreateMemoryStoreResponse FromMemoryStore(global::Anthropic.BetaManagedAgentsMemoryStore? value) => new BetaManagedAgentsCreateMemoryStoreResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCreateMemoryStoreResponse(
            global::Anthropic.BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMemoryStore? memoryStore
            )
        {
            Type = type;

            MemoryStore = memoryStore;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MemoryStore as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MemoryStore?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMemoryStore;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsMemoryStore, TResult>? memoryStore = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMemoryStore && memoryStore != null)
            {
                return memoryStore(MemoryStore!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryStore>? memoryStore = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMemoryStore)
            {
                memoryStore?.Invoke(MemoryStore!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryStore>? memoryStore = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMemoryStore)
            {
                memoryStore?.Invoke(MemoryStore!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MemoryStore,
                typeof(global::Anthropic.BetaManagedAgentsMemoryStore),
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
        public bool Equals(BetaManagedAgentsCreateMemoryStoreResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMemoryStore?>.Default.Equals(MemoryStore, other.MemoryStore) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsCreateMemoryStoreResponse obj1, BetaManagedAgentsCreateMemoryStoreResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsCreateMemoryStoreResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsCreateMemoryStoreResponse obj1, BetaManagedAgentsCreateMemoryStoreResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsCreateMemoryStoreResponse o && Equals(o);
        }
    }
}
