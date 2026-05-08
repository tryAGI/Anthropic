#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Resolved multiagent orchestration configuration as returned on a `session`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsSessionMultiagent : global::System.IEquatable<BetaManagedAgentsSessionMultiagent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminatorType? Type { get; }

        /// <summary>
        /// Resolved coordinator topology with full agent definitions for each roster member.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator? Coordinator { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator? Coordinator { get; }
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
            out global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator? value)
        {
            value = Coordinator;
            return IsCoordinator;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionMultiagent(global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator value) => new BetaManagedAgentsSessionMultiagent((global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator?(BetaManagedAgentsSessionMultiagent @this) => @this.Coordinator;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionMultiagent(global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator? value)
        {
            Coordinator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionMultiagent(
            global::Anthropic.BetaManagedAgentsSessionMultiagentDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator? coordinator
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
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator, TResult>? coordinator = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator>? coordinator = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator>? coordinator = null,
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
                typeof(global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator),
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
        public bool Equals(BetaManagedAgentsSessionMultiagent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionMultiagentCoordinator?>.Default.Equals(Coordinator, other.Coordinator) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSessionMultiagent obj1, BetaManagedAgentsSessionMultiagent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSessionMultiagent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSessionMultiagent obj1, BetaManagedAgentsSessionMultiagent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSessionMultiagent o && Equals(o);
        }
    }
}
