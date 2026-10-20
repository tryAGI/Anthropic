#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One item in a [List Memories](https://platform.claude.com/docs/en/api/beta/memory_stores/memories/list) response: a `memory`, or a `memory_prefix` marker when `depth` is `1`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMemoryListItem : global::System.IEquatable<BetaManagedAgentsMemoryListItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryListItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A text document at a path inside a memory store.<br/>
        /// `content` is `null` when the response uses `view=basic`. `content_size_bytes` and `content_sha256` are always set, so you can detect changes without fetching the content. To retrieve, update, or delete a memory, pass its ID, which stays the same when its path changes.<br/>
        /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#view-and-edit-memories) to learn more about working with memories.
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
        public bool TryPickMemory(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMemory? value)
        {
            value = Memory;
            return IsMemory;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemory PickMemory() => Memory is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Memory' but the value was {ToString()}.");

        /// <summary>
        /// A directory marker that [List Memories](https://platform.claude.com/docs/en/api/beta/memory_stores/memories/list) returns instead of the memories below the requested `depth`.<br/>
        /// It stands for one or more memories whose paths start with `path`. It isn't a stored object and doesn't have an ID. Each marker counts toward the page `limit`.
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
        public bool TryPickMemoryPrefix(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMemoryPrefix? value)
        {
            value = MemoryPrefix;
            return IsMemoryPrefix;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryPrefix PickMemoryPrefix() => MemoryPrefix is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryPrefix' but the value was {ToString()}.");
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
        public static BetaManagedAgentsMemoryListItem FromMemory(global::Anthropic.BetaManagedAgentsMemory? value) => new BetaManagedAgentsMemoryListItem(value);

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
        public static BetaManagedAgentsMemoryListItem FromMemoryPrefix(global::Anthropic.BetaManagedAgentsMemoryPrefix? value) => new BetaManagedAgentsMemoryListItem(value);

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
            global::System.Func<global::Anthropic.BetaManagedAgentsMemory, TResult>? memory = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMemoryPrefix, TResult>? memoryPrefix = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Memory is { } __value0 && memory != null)
            {
                return memory(__value0);
            }
            else if (MemoryPrefix is { } __value1 && memoryPrefix != null)
            {
                return memoryPrefix(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsMemory>? memory = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryPrefix>? memoryPrefix = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Memory is { } __value0)
            {
                memory?.Invoke(__value0);
            }
            else if (MemoryPrefix is { } __value1)
            {
                memoryPrefix?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsMemory>? memory = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryPrefix>? memoryPrefix = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Memory is { } __value0)
            {
                memory?.Invoke(__value0);
            }
            else if (MemoryPrefix is { } __value1)
            {
                memoryPrefix?.Invoke(__value1);
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
