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
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinator PickCoordinator() => Coordinator is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Coordinator' but the value was {ToString()}.");

        /// <summary>
        /// Resolved multiagent configuration with three members, each enabled or disabled on its own.<br/>
        /// Example: {"type":"multiagent_20261001","workflows":{"type":"enabled","inline_agents":{"type":"enabled"},"predefined_agents":[]},"subagents":{"type":"enabled","inline_agents":{"type":"enabled"},"predefined_agents":[{"type":"agent","id":"agent_011CZkYqphY8vELVzwCUpqiQ","version":1}]},"advisor":{"type":"disabled"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagent20261001? Multiagent20261001 { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagent20261001? Multiagent20261001 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Multiagent20261001))]
#endif
        public bool IsMultiagent20261001 => Multiagent20261001 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMultiagent20261001(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMultiagent20261001? value)
        {
            value = Multiagent20261001;
            return IsMultiagent20261001;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001 PickMultiagent20261001() => Multiagent20261001 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Multiagent20261001' but the value was {ToString()}.");
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
        public static BetaManagedAgentsMultiagent FromCoordinator(global::Anthropic.BetaManagedAgentsMultiagentCoordinator? value) => new BetaManagedAgentsMultiagent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagent(global::Anthropic.BetaManagedAgentsMultiagent20261001 value) => new BetaManagedAgentsMultiagent((global::Anthropic.BetaManagedAgentsMultiagent20261001?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagent20261001?(BetaManagedAgentsMultiagent @this) => @this.Multiagent20261001;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagent(global::Anthropic.BetaManagedAgentsMultiagent20261001? value)
        {
            Multiagent20261001 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagent FromMultiagent20261001(global::Anthropic.BetaManagedAgentsMultiagent20261001? value) => new BetaManagedAgentsMultiagent(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagent(
            global::Anthropic.BetaManagedAgentsMultiagentDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMultiagentCoordinator? coordinator,
            global::Anthropic.BetaManagedAgentsMultiagent20261001? multiagent20261001
            )
        {
            Type = type;

            Coordinator = coordinator;
            Multiagent20261001 = multiagent20261001;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Multiagent20261001 as object ??
            Coordinator as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Coordinator?.ToString() ??
            Multiagent20261001?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCoordinator && !IsMultiagent20261001 || !IsCoordinator && IsMultiagent20261001;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentCoordinator, TResult>? coordinator = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagent20261001, TResult>? multiagent20261001 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Coordinator is { } __value0 && coordinator != null)
            {
                return coordinator(__value0);
            }
            else if (Multiagent20261001 is { } __value1 && multiagent20261001 != null)
            {
                return multiagent20261001(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentCoordinator>? coordinator = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagent20261001>? multiagent20261001 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Coordinator is { } __value0)
            {
                coordinator?.Invoke(__value0);
            }
            else if (Multiagent20261001 is { } __value1)
            {
                multiagent20261001?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentCoordinator>? coordinator = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagent20261001>? multiagent20261001 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Coordinator is { } __value0)
            {
                coordinator?.Invoke(__value0);
            }
            else if (Multiagent20261001 is { } __value1)
            {
                multiagent20261001?.Invoke(__value1);
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
                Multiagent20261001,
                typeof(global::Anthropic.BetaManagedAgentsMultiagent20261001),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentCoordinator?>.Default.Equals(Coordinator, other.Coordinator) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagent20261001?>.Default.Equals(Multiagent20261001, other.Multiagent20261001)
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
