#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Resolved multiagent orchestration configuration as returned in API responses.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMultiagent : global::System.IEquatable<BetaManagedAgentsMultiagent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentDiscriminatorType? Type { get; }

        /// <summary>
        /// Resolved coordinator topology with a concrete agent roster.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinator? Coordinator { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinator? Coordinator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Coordinator))]
#endif
        public bool IsCoordinator => Coordinator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCoordinator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMultiagentCoordinator? value)
        {
            value = Coordinator;
            return IsCoordinator;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagent(global::Anthropic.BetaManagedAgentsMultiagentCoordinator value) => new BetaManagedAgentsMultiagent((global::Anthropic.BetaManagedAgentsMultiagentCoordinator?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentCoordinator?(BetaManagedAgentsMultiagent @this) => @this.Coordinator;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMultiagent(global::Anthropic.BetaManagedAgentsMultiagentCoordinator? value)
        {
            Coordinator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMultiagent(
            global::Anthropic.BetaManagedAgentsMultiagentDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMultiagentCoordinator? coordinator
            )
        {
            Type = type;

            Coordinator = coordinator;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Coordinator as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Coordinator?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCoordinator;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentCoordinator, TResult>? coordinator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCoordinator && coordinator != null)
            {
                return coordinator(Coordinator!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentCoordinator>? coordinator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCoordinator)
            {
                coordinator?.Invoke(Coordinator!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentCoordinator>? coordinator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCoordinator)
            {
                coordinator?.Invoke(Coordinator!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Coordinator,
                typeof(global::Anthropic.BetaManagedAgentsMultiagentCoordinator),
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
        public bool Equals(BetaManagedAgentsMultiagent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentCoordinator?>.Default.Equals(Coordinator, other.Coordinator) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMultiagent obj1, BetaManagedAgentsMultiagent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMultiagent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMultiagent obj1, BetaManagedAgentsMultiagent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMultiagent o && Equals(o);
        }
    }
}
