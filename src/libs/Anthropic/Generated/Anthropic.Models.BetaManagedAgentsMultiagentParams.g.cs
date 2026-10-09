#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Multiagent orchestration configuration.
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
        public bool TryPickCoordinator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? value)
        {
            value = Coordinator;
            return IsCoordinator;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams PickCoordinator() => Coordinator is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Coordinator' but the value was {ToString()}.");

        /// <summary>
        /// Multiagent configuration with three members, each enabled or disabled on its own. On an update, if the agent's stored `multiagent` also has type `multiagent_20261001`, this configuration is merged into the stored one, level by level, instead of replacing it. A key that the update omits keeps its stored value. A key sent as null takes its default, on create as well, so `"workflows": null` enables workflows. An object sent with a `type` other than the stored one replaces the stored object, and the keys that it omits take their defaults. A `predefined_agents` list that is sent replaces the stored list. Every object that is sent needs its `type`, and an enabled `advisor` needs its `model`. Other validation applies to the merged result.<br/>
        /// Example: {"type":"multiagent_20261001","workflows":{"type":"enabled"},"subagents":{"type":"enabled","predefined_agents":["agent_011CZkYqphY8vELVzwCUpqiQ"]},"advisor":{"type":"disabled"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagent20261001Params? Multiagent20261001 { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagent20261001Params? Multiagent20261001 { get; }
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
            out global::Anthropic.BetaManagedAgentsMultiagent20261001Params? value)
        {
            value = Multiagent20261001;
            return IsMultiagent20261001;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagent20261001Params PickMultiagent20261001() => Multiagent20261001 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Multiagent20261001' but the value was {ToString()}.");
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
        public static BetaManagedAgentsMultiagentParams FromCoordinator(global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? value) => new BetaManagedAgentsMultiagentParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentParams(global::Anthropic.BetaManagedAgentsMultiagent20261001Params value) => new BetaManagedAgentsMultiagentParams((global::Anthropic.BetaManagedAgentsMultiagent20261001Params?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagent20261001Params?(BetaManagedAgentsMultiagentParams @this) => @this.Multiagent20261001;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentParams(global::Anthropic.BetaManagedAgentsMultiagent20261001Params? value)
        {
            Multiagent20261001 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentParams FromMultiagent20261001(global::Anthropic.BetaManagedAgentsMultiagent20261001Params? value) => new BetaManagedAgentsMultiagentParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentParams(
            global::Anthropic.BetaManagedAgentsMultiagentParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams? coordinator,
            global::Anthropic.BetaManagedAgentsMultiagent20261001Params? multiagent20261001
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
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams, TResult>? coordinator = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagent20261001Params, TResult>? multiagent20261001 = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams>? coordinator = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagent20261001Params>? multiagent20261001 = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams>? coordinator = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagent20261001Params>? multiagent20261001 = null,
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
                typeof(global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams),
                Multiagent20261001,
                typeof(global::Anthropic.BetaManagedAgentsMultiagent20261001Params),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParams?>.Default.Equals(Coordinator, other.Coordinator) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagent20261001Params?>.Default.Equals(Multiagent20261001, other.Multiagent20261001)
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
