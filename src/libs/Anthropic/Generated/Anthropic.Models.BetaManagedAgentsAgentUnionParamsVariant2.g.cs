#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsAgentUnionParamsVariant2 : global::System.IEquatable<BetaManagedAgentsAgentUnionParamsVariant2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType? Type { get; }

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
        public static implicit operator BetaManagedAgentsAgentUnionParamsVariant2(global::Anthropic.BetaManagedAgentsAgentParams value) => new BetaManagedAgentsAgentUnionParamsVariant2((global::Anthropic.BetaManagedAgentsAgentParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentParams?(BetaManagedAgentsAgentUnionParamsVariant2 @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentUnionParamsVariant2(global::Anthropic.BetaManagedAgentsAgentParams? value)
        {
            Agent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentUnionParamsVariant2(
            global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAgentParams? agent
            )
        {
            Type = type;

            Agent = agent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Agent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Agent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentParams?, TResult>? agent = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentParams?>? agent = null,
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
        public bool Equals(BetaManagedAgentsAgentUnionParamsVariant2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentParams?>.Default.Equals(Agent, other.Agent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAgentUnionParamsVariant2 obj1, BetaManagedAgentsAgentUnionParamsVariant2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAgentUnionParamsVariant2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAgentUnionParamsVariant2 obj1, BetaManagedAgentsAgentUnionParamsVariant2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAgentUnionParamsVariant2 o && Equals(o);
        }
    }
}
