#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaDreamInput : global::System.IEquatable<BetaDreamInput>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaDreamInputDiscriminatorType? Type { get; }

        /// <summary>
        /// An input memory store the dream reads from. The dream never mutates this store.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaDreamMemoryStoreInput? MemoryStore { get; init; }
#else
        public global::Anthropic.BetaDreamMemoryStoreInput? MemoryStore { get; }
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
            out global::Anthropic.BetaDreamMemoryStoreInput? value)
        {
            value = MemoryStore;
            return IsMemoryStore;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaDreamMemoryStoreInput PickMemoryStore() => IsMemoryStore
            ? MemoryStore!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryStore' but the value was {ToString()}.");

        /// <summary>
        /// Input session transcripts the dream reads.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaDreamSessionsInput? Sessions { get; init; }
#else
        public global::Anthropic.BetaDreamSessionsInput? Sessions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sessions))]
#endif
        public bool IsSessions => Sessions != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaDreamSessionsInput? value)
        {
            value = Sessions;
            return IsSessions;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaDreamSessionsInput PickSessions() => IsSessions
            ? Sessions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sessions' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaDreamInput(global::Anthropic.BetaDreamMemoryStoreInput value) => new BetaDreamInput((global::Anthropic.BetaDreamMemoryStoreInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaDreamMemoryStoreInput?(BetaDreamInput @this) => @this.MemoryStore;

        /// <summary>
        /// 
        /// </summary>
        public BetaDreamInput(global::Anthropic.BetaDreamMemoryStoreInput? value)
        {
            MemoryStore = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaDreamInput FromMemoryStore(global::Anthropic.BetaDreamMemoryStoreInput? value) => new BetaDreamInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaDreamInput(global::Anthropic.BetaDreamSessionsInput value) => new BetaDreamInput((global::Anthropic.BetaDreamSessionsInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaDreamSessionsInput?(BetaDreamInput @this) => @this.Sessions;

        /// <summary>
        /// 
        /// </summary>
        public BetaDreamInput(global::Anthropic.BetaDreamSessionsInput? value)
        {
            Sessions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaDreamInput FromSessions(global::Anthropic.BetaDreamSessionsInput? value) => new BetaDreamInput(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaDreamInput(
            global::Anthropic.BetaDreamInputDiscriminatorType? type,
            global::Anthropic.BetaDreamMemoryStoreInput? memoryStore,
            global::Anthropic.BetaDreamSessionsInput? sessions
            )
        {
            Type = type;

            MemoryStore = memoryStore;
            Sessions = sessions;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Sessions as object ??
            MemoryStore as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MemoryStore?.ToString() ??
            Sessions?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMemoryStore && !IsSessions || !IsMemoryStore && IsSessions;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaDreamMemoryStoreInput, TResult>? memoryStore = null,
            global::System.Func<global::Anthropic.BetaDreamSessionsInput, TResult>? sessions = null,
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
            else if (IsSessions && sessions != null)
            {
                return sessions(Sessions!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaDreamMemoryStoreInput>? memoryStore = null,

            global::System.Action<global::Anthropic.BetaDreamSessionsInput>? sessions = null,
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
            else if (IsSessions)
            {
                sessions?.Invoke(Sessions!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaDreamMemoryStoreInput>? memoryStore = null,
            global::System.Action<global::Anthropic.BetaDreamSessionsInput>? sessions = null,
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
            else if (IsSessions)
            {
                sessions?.Invoke(Sessions!);
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
                typeof(global::Anthropic.BetaDreamMemoryStoreInput),
                Sessions,
                typeof(global::Anthropic.BetaDreamSessionsInput),
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
        public bool Equals(BetaDreamInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaDreamMemoryStoreInput?>.Default.Equals(MemoryStore, other.MemoryStore) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaDreamSessionsInput?>.Default.Equals(Sessions, other.Sessions) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaDreamInput obj1, BetaDreamInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaDreamInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaDreamInput obj1, BetaDreamInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaDreamInput o && Equals(o);
        }
    }
}
