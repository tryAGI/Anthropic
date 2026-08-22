#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsEventDeltaEventDelta : global::System.IEquatable<BetaManagedAgentsEventDeltaEventDelta>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? ContentDelta { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? ContentDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentDelta))]
#endif
        public bool IsContentDelta => ContentDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContentDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? value)
        {
            value = ContentDelta;
            return IsContentDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta PickContentDelta() => IsContentDelta
            ? ContentDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentDelta' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEventDeltaEventDelta(global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta value) => new BetaManagedAgentsEventDeltaEventDelta((global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta?(BetaManagedAgentsEventDeltaEventDelta @this) => @this.ContentDelta;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventDeltaEventDelta(global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? value)
        {
            ContentDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEventDeltaEventDelta FromContentDelta(global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? value) => new BetaManagedAgentsEventDeltaEventDelta(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventDeltaEventDelta(
            global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? contentDelta
            )
        {
            Type = type;

            ContentDelta = contentDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContentDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ContentDelta?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsContentDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta, TResult>? contentDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentDelta && contentDelta != null)
            {
                return contentDelta(ContentDelta!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta>? contentDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentDelta)
            {
                contentDelta?.Invoke(ContentDelta!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta>? contentDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentDelta)
            {
                contentDelta?.Invoke(ContentDelta!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ContentDelta,
                typeof(global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta),
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
        public bool Equals(BetaManagedAgentsEventDeltaEventDelta other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta?>.Default.Equals(ContentDelta, other.ContentDelta) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsEventDeltaEventDelta obj1, BetaManagedAgentsEventDeltaEventDelta obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsEventDeltaEventDelta>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsEventDeltaEventDelta obj1, BetaManagedAgentsEventDeltaEventDelta obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsEventDeltaEventDelta o && Equals(o);
        }
    }
}
