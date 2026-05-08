#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Optional condition that must hold for an update to apply. When omitted, the update is unconditional. Asserts the current state of the memory being updated. When an update changes `path`, the precondition still refers to the memory's current content, not the destination path. Currently the only supported variant is `content_sha256`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsPrecondition : global::System.IEquatable<BetaManagedAgentsPrecondition>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPreconditionDiscriminatorType? Type { get; }

        /// <summary>
        /// Optimistic-concurrency precondition: the update applies only if the memory's stored `content_sha256` equals the supplied value. On mismatch, the request returns `memory_precondition_failed_error` (HTTP 409); re-read the memory and retry against the fresh state. If the precondition fails but the stored state already exactly matches the requested `content` and `path`, the server returns 200 instead of 409.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsContentSha256Precondition? ContentSha256 { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsContentSha256Precondition? ContentSha256 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentSha256))]
#endif
        public bool IsContentSha256 => ContentSha256 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContentSha256(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsContentSha256Precondition? value)
        {
            value = ContentSha256;
            return IsContentSha256;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsPrecondition(global::Anthropic.BetaManagedAgentsContentSha256Precondition value) => new BetaManagedAgentsPrecondition((global::Anthropic.BetaManagedAgentsContentSha256Precondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsContentSha256Precondition?(BetaManagedAgentsPrecondition @this) => @this.ContentSha256;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsPrecondition(global::Anthropic.BetaManagedAgentsContentSha256Precondition? value)
        {
            ContentSha256 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsPrecondition(
            global::Anthropic.BetaManagedAgentsPreconditionDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsContentSha256Precondition? contentSha256
            )
        {
            Type = type;

            ContentSha256 = contentSha256;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContentSha256 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ContentSha256?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsContentSha256;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsContentSha256Precondition, TResult>? contentSha256 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentSha256 && contentSha256 != null)
            {
                return contentSha256(ContentSha256!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsContentSha256Precondition>? contentSha256 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentSha256)
            {
                contentSha256?.Invoke(ContentSha256!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsContentSha256Precondition>? contentSha256 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentSha256)
            {
                contentSha256?.Invoke(ContentSha256!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ContentSha256,
                typeof(global::Anthropic.BetaManagedAgentsContentSha256Precondition),
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
        public bool Equals(BetaManagedAgentsPrecondition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsContentSha256Precondition?>.Default.Equals(ContentSha256, other.ContentSha256) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsPrecondition obj1, BetaManagedAgentsPrecondition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsPrecondition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsPrecondition obj1, BetaManagedAgentsPrecondition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsPrecondition o && Equals(o);
        }
    }
}
