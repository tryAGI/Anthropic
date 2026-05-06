#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Multiagent orchestration configuration. Currently supports the `coordinator` topology.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMultiagentParams : global::System.IEquatable<BetaManagedAgentsMultiagentParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// A coordinator topology: the session's primary thread orchestrates work by spawning session threads, each running an agent drawn from the `agents` roster.<br/>
        /// Example: {"type":"coordinator","agents":["agent_011CZkYqphY8vELVzwCUpqiQ",{"type":"self"}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? Coordinator { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? Coordinator { get; }
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
        public static implicit operator BetaManagedAgentsMultiagentParams(global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams value) => new BetaManagedAgentsMultiagentParams((global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams?(BetaManagedAgentsMultiagentParams @this) => @this.Coordinator;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMultiagentParams(global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? value)
        {
            Coordinator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMultiagentParams(
            global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? coordinator
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
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams?, TResult>? coordinator = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams?>? coordinator = null,
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
                typeof(global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams),
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
        public bool Equals(BetaManagedAgentsMultiagentParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams?>.Default.Equals(Coordinator, other.Coordinator) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMultiagentParams obj1, BetaManagedAgentsMultiagentParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMultiagentParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMultiagentParams obj1, BetaManagedAgentsMultiagentParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMultiagentParams o && Equals(o);
        }
    }
}
