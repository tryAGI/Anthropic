#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 : global::System.IEquatable<BetaManagedAgentsCreateSessionAgentUnionParamsVariant2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType? Type { get; }

        /// <summary>
        /// Specification for an Agent. Provide a specific `version` or use the short-form `agent="agent_id"` for the most recent version
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentParams? Agent { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentParams? Agent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Agent))]
#endif
        public bool IsAgent => Agent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentParams? value)
        {
            value = Agent;
            return IsAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentParams PickAgent() => IsAgent
            ? Agent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Agent' but the value was {ToString()}.");

        /// <summary>
        /// Reference to an `agent` plus optional configuration overrides. Each provided field replaces the agent's value for the caller's use; the agent resource is unchanged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? AgentWithOverrides { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? AgentWithOverrides { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentWithOverrides))]
#endif
        public bool IsAgentWithOverrides => AgentWithOverrides != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentWithOverrides(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? value)
        {
            value = AgentWithOverrides;
            return IsAgentWithOverrides;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentWithOverridesParams PickAgentWithOverrides() => IsAgentWithOverrides
            ? AgentWithOverrides!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentWithOverrides' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCreateSessionAgentUnionParamsVariant2(global::Anthropic.BetaManagedAgentsAgentParams value) => new BetaManagedAgentsCreateSessionAgentUnionParamsVariant2((global::Anthropic.BetaManagedAgentsAgentParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentParams?(BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCreateSessionAgentUnionParamsVariant2(global::Anthropic.BetaManagedAgentsAgentParams? value)
        {
            Agent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 FromAgent(global::Anthropic.BetaManagedAgentsAgentParams? value) => new BetaManagedAgentsCreateSessionAgentUnionParamsVariant2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCreateSessionAgentUnionParamsVariant2(global::Anthropic.BetaManagedAgentsAgentWithOverridesParams value) => new BetaManagedAgentsCreateSessionAgentUnionParamsVariant2((global::Anthropic.BetaManagedAgentsAgentWithOverridesParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentWithOverridesParams?(BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 @this) => @this.AgentWithOverrides;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCreateSessionAgentUnionParamsVariant2(global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? value)
        {
            AgentWithOverrides = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 FromAgentWithOverrides(global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? value) => new BetaManagedAgentsCreateSessionAgentUnionParamsVariant2(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCreateSessionAgentUnionParamsVariant2(
            global::Anthropic.BetaManagedAgentsCreateSessionAgentUnionParamsVariant2DiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAgentParams? agent,
            global::Anthropic.BetaManagedAgentsAgentWithOverridesParams? agentWithOverrides
            )
        {
            Type = type;

            Agent = agent;
            AgentWithOverrides = agentWithOverrides;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentWithOverrides as object ??
            Agent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Agent?.ToString() ??
            AgentWithOverrides?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgent && !IsAgentWithOverrides || !IsAgent && IsAgentWithOverrides;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentParams, TResult>? agent = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentWithOverridesParams, TResult>? agentWithOverrides = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent && agent != null)
            {
                return agent(Agent!);
            }
            else if (IsAgentWithOverrides && agentWithOverrides != null)
            {
                return agentWithOverrides(AgentWithOverrides!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentParams>? agent = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? agentWithOverrides = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
            else if (IsAgentWithOverrides)
            {
                agentWithOverrides?.Invoke(AgentWithOverrides!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentParams>? agent = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? agentWithOverrides = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
            else if (IsAgentWithOverrides)
            {
                agentWithOverrides?.Invoke(AgentWithOverrides!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Agent,
                typeof(global::Anthropic.BetaManagedAgentsAgentParams),
                AgentWithOverrides,
                typeof(global::Anthropic.BetaManagedAgentsAgentWithOverridesParams),
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
        public bool Equals(BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentParams?>.Default.Equals(Agent, other.Agent) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentWithOverridesParams?>.Default.Equals(AgentWithOverrides, other.AgentWithOverrides) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 obj1, BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsCreateSessionAgentUnionParamsVariant2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 obj1, BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 o && Equals(o);
        }
    }
}
