#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaDreamOutput : global::System.IEquatable<BetaDreamOutput>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaDreamOutputDiscriminatorType? Type { get; }

        /// <summary>
        /// An output memory store the dream writes consolidated memories into.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaDreamMemoryStoreOutput? MemoryStore { get; init; }
#else
        public global::Anthropic.BetaDreamMemoryStoreOutput? MemoryStore { get; }
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
            out global::Anthropic.BetaDreamMemoryStoreOutput? value)
        {
            value = MemoryStore;
            return IsMemoryStore;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreOutput PickMemoryStore() => IsMemoryStore
            ? MemoryStore!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryStore' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaDreamOutput(global::Anthropic.BetaDreamMemoryStoreOutput value) => new BetaDreamOutput((global::Anthropic.BetaDreamMemoryStoreOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaDreamMemoryStoreOutput?(BetaDreamOutput @this) => @this.MemoryStore;

        /// <summary>
        /// 
        /// </summary>
        public BetaDreamOutput(global::Anthropic.BetaDreamMemoryStoreOutput? value)
        {
            MemoryStore = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaDreamOutput FromMemoryStore(global::Anthropic.BetaDreamMemoryStoreOutput? value) => new BetaDreamOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaDreamOutput(
            global::Anthropic.BetaDreamOutputDiscriminatorType? type,
            global::Anthropic.BetaDreamMemoryStoreOutput? memoryStore
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
            global::System.Func<global::Anthropic.BetaDreamMemoryStoreOutput, TResult>? memoryStore = null,
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
            global::System.Action<global::Anthropic.BetaDreamMemoryStoreOutput>? memoryStore = null,
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
            global::System.Action<global::Anthropic.BetaDreamMemoryStoreOutput>? memoryStore = null,
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
                typeof(global::Anthropic.BetaDreamMemoryStoreOutput),
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
        public bool Equals(BetaDreamOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaDreamMemoryStoreOutput?>.Default.Equals(MemoryStore, other.MemoryStore) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaDreamOutput obj1, BetaDreamOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaDreamOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaDreamOutput obj1, BetaDreamOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaDreamOutput o && Equals(o);
        }
    }
}
