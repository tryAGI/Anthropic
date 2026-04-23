#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsMemoryListItem : global::System.IEquatable<BetaManagedAgentsMemoryListItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMemory? Memory { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMemory? Memory { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Memory))]
#endif
        public bool IsMemory => Memory != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMemoryPrefix? MemoryPrefix { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMemoryPrefix? MemoryPrefix { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryPrefix))]
#endif
        public bool IsMemoryPrefix => MemoryPrefix != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMemoryListItem(global::Anthropic.BetaManagedAgentsMemory value) => new BetaManagedAgentsMemoryListItem((global::Anthropic.BetaManagedAgentsMemory?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMemory?(BetaManagedAgentsMemoryListItem @this) => @this.Memory;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMemoryListItem(global::Anthropic.BetaManagedAgentsMemory? value)
        {
            Memory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMemoryListItem(global::Anthropic.BetaManagedAgentsMemoryPrefix value) => new BetaManagedAgentsMemoryListItem((global::Anthropic.BetaManagedAgentsMemoryPrefix?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMemoryPrefix?(BetaManagedAgentsMemoryListItem @this) => @this.MemoryPrefix;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMemoryListItem(global::Anthropic.BetaManagedAgentsMemoryPrefix? value)
        {
            MemoryPrefix = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMemoryListItem(
            global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMemory? memory,
            global::Anthropic.BetaManagedAgentsMemoryPrefix? memoryPrefix
            )
        {
            Type = type;

            Memory = memory;
            MemoryPrefix = memoryPrefix;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MemoryPrefix as object ??
            Memory as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Memory?.ToString() ??
            MemoryPrefix?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMemory && !IsMemoryPrefix || !IsMemory && IsMemoryPrefix;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsMemory?, TResult>? memory = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMemoryPrefix?, TResult>? memoryPrefix = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMemory && memory != null)
            {
                return memory(Memory!);
            }
            else if (IsMemoryPrefix && memoryPrefix != null)
            {
                return memoryPrefix(MemoryPrefix!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsMemory?>? memory = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryPrefix?>? memoryPrefix = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMemory)
            {
                memory?.Invoke(Memory!);
            }
            else if (IsMemoryPrefix)
            {
                memoryPrefix?.Invoke(MemoryPrefix!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Memory,
                typeof(global::Anthropic.BetaManagedAgentsMemory),
                MemoryPrefix,
                typeof(global::Anthropic.BetaManagedAgentsMemoryPrefix),
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
        public bool Equals(BetaManagedAgentsMemoryListItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMemory?>.Default.Equals(Memory, other.Memory) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMemoryPrefix?>.Default.Equals(MemoryPrefix, other.MemoryPrefix) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMemoryListItem obj1, BetaManagedAgentsMemoryListItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMemoryListItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMemoryListItem obj1, BetaManagedAgentsMemoryListItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMemoryListItem o && Equals(o);
        }
    }
}
