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
        public BetaManagedAgentsMultiagentRosterEntryParamsVariant2(
            global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParamsVariant2DiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAgentParams? agent,
            global::Anthropic.BetaManagedAgentsMultiagentSelfParams? self
            )
        {
            Type = type;

            Agent = agent;
            Self = self;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Self as object ??
            Agent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Agent?.ToString() ??
            Self?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgent && !IsSelf || !IsAgent && IsSelf;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentParams?, TResult>? agent = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentSelfParams?, TResult>? self = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentParams?>? agent = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentSelfParams?>? self = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentSelfParams?>.Default.Equals(Self, other.Self) 
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
