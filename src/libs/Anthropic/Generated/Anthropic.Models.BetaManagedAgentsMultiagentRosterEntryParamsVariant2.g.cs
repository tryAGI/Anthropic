#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsMultiagentRosterEntryParamsVariant2 : global::System.IEquatable<BetaManagedAgentsMultiagentRosterEntryParamsVariant2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType? Type { get; }

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
        /// Sentinel roster entry meaning "the agent that owns this configuration". Resolved server-side to a concrete agent reference.<br/>
        /// Example: {"type":"self"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentSelfParams? Self { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentSelfParams? Self { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Self))]
#endif
        public bool IsSelf => Self != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSelf(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMultiagentSelfParams? value)
        {
            value = Self;
            return IsSelf;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSelfParams PickSelf() => IsSelf
            ? Self!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Self' but the value was {ToString()}.");

        /// <summary>
        /// Platform advisor roster entry: a model the session's primary thread may consult mid-turn. At most one per roster; the entry occupies the roster name `anthropic.advisor`.<br/>
        /// Example: {"type":"advisor","model":"claude-fable-5"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAdvisorParams? Advisor { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAdvisorParams? Advisor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Advisor))]
#endif
        public bool IsAdvisor => Advisor != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAdvisor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAdvisorParams? value)
        {
            value = Advisor;
            return IsAdvisor;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisorParams PickAdvisor() => IsAdvisor
            ? Advisor!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Advisor' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentRosterEntryParamsVariant2(global::Anthropic.BetaManagedAgentsAgentParams value) => new BetaManagedAgentsMultiagentRosterEntryParamsVariant2((global::Anthropic.BetaManagedAgentsAgentParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentParams?(BetaManagedAgentsMultiagentRosterEntryParamsVariant2 @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMultiagentRosterEntryParamsVariant2(global::Anthropic.BetaManagedAgentsAgentParams? value)
        {
            Agent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsMultiagentRosterEntryParamsVariant2 FromAgent(global::Anthropic.BetaManagedAgentsAgentParams? value) => new BetaManagedAgentsMultiagentRosterEntryParamsVariant2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentRosterEntryParamsVariant2(global::Anthropic.BetaManagedAgentsMultiagentSelfParams value) => new BetaManagedAgentsMultiagentRosterEntryParamsVariant2((global::Anthropic.BetaManagedAgentsMultiagentSelfParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentSelfParams?(BetaManagedAgentsMultiagentRosterEntryParamsVariant2 @this) => @this.Self;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMultiagentRosterEntryParamsVariant2(global::Anthropic.BetaManagedAgentsMultiagentSelfParams? value)
        {
            Self = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsMultiagentRosterEntryParamsVariant2 FromSelf(global::Anthropic.BetaManagedAgentsMultiagentSelfParams? value) => new BetaManagedAgentsMultiagentRosterEntryParamsVariant2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentRosterEntryParamsVariant2(global::Anthropic.BetaManagedAgentsAdvisorParams value) => new BetaManagedAgentsMultiagentRosterEntryParamsVariant2((global::Anthropic.BetaManagedAgentsAdvisorParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAdvisorParams?(BetaManagedAgentsMultiagentRosterEntryParamsVariant2 @this) => @this.Advisor;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMultiagentRosterEntryParamsVariant2(global::Anthropic.BetaManagedAgentsAdvisorParams? value)
        {
            Advisor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsMultiagentRosterEntryParamsVariant2 FromAdvisor(global::Anthropic.BetaManagedAgentsAdvisorParams? value) => new BetaManagedAgentsMultiagentRosterEntryParamsVariant2(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMultiagentRosterEntryParamsVariant2(
            global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAgentParams? agent,
            global::Anthropic.BetaManagedAgentsMultiagentSelfParams? self,
            global::Anthropic.BetaManagedAgentsAdvisorParams? advisor
            )
        {
            Type = type;

            Agent = agent;
            Self = self;
            Advisor = advisor;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Advisor as object ??
            Self as object ??
            Agent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Agent?.ToString() ??
            Self?.ToString() ??
            Advisor?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgent && !IsSelf && !IsAdvisor || !IsAgent && IsSelf && !IsAdvisor || !IsAgent && !IsSelf && IsAdvisor;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentParams, TResult>? agent = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentSelfParams, TResult>? self = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAdvisorParams, TResult>? advisor = null,
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
            else if (IsSelf && self != null)
            {
                return self(Self!);
            }
            else if (IsAdvisor && advisor != null)
            {
                return advisor(Advisor!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentParams>? agent = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? self = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAdvisorParams>? advisor = null,
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
            else if (IsSelf)
            {
                self?.Invoke(Self!);
            }
            else if (IsAdvisor)
            {
                advisor?.Invoke(Advisor!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentParams>? agent = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? self = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAdvisorParams>? advisor = null,
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
            else if (IsSelf)
            {
                self?.Invoke(Self!);
            }
            else if (IsAdvisor)
            {
                advisor?.Invoke(Advisor!);
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
                Self,
                typeof(global::Anthropic.BetaManagedAgentsMultiagentSelfParams),
                Advisor,
                typeof(global::Anthropic.BetaManagedAgentsAdvisorParams),
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
        public bool Equals(BetaManagedAgentsMultiagentRosterEntryParamsVariant2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentParams?>.Default.Equals(Agent, other.Agent) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentSelfParams?>.Default.Equals(Self, other.Self) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAdvisorParams?>.Default.Equals(Advisor, other.Advisor) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMultiagentRosterEntryParamsVariant2 obj1, BetaManagedAgentsMultiagentRosterEntryParamsVariant2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMultiagentRosterEntryParamsVariant2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMultiagentRosterEntryParamsVariant2 obj1, BetaManagedAgentsMultiagentRosterEntryParamsVariant2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMultiagentRosterEntryParamsVariant2 o && Equals(o);
        }
    }
}
