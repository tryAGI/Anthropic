#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A session-resolved multiagent roster entry.
    /// </summary>
    public readonly partial struct BetaManagedAgentsSessionRosterEntry : global::System.IEquatable<BetaManagedAgentsSessionRosterEntry>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminatorType? Type { get; }

        /// <summary>
        /// Resolved `agent` definition for a single `session_thread`. Snapshot of the agent at thread creation time. The multiagent roster is not repeated here; read it from `Session.agent`.<br/>
        /// Example: {"type":"agent","id":"agent_011CZkYqphY8vELVzwCUpqiQ","version":1,"name":"Researcher","description":"A focused research subagent.","model":{"id":"claude-opus-5","speed":"standard"},"system":"You are a research subagent that gathers and summarises sources for the coordinating agent.","tools":[{"type":"agent_toolset_20260401","default_config":{"enabled":true,"permission_policy":{"type":"always_ask"}},"configs":[]}],"mcp_servers":[],"skills":[]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionThreadAgent? Agent { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionThreadAgent? Agent { get; }
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
            out global::Anthropic.BetaManagedAgentsSessionThreadAgent? value)
        {
            value = Agent;
            return IsAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadAgent PickAgent() => IsAgent
            ? Agent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Agent' but the value was {ToString()}.");

        /// <summary>
        /// Platform advisor roster entry: a model the session's primary thread may consult mid-turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAdvisor? Advisor { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAdvisor? Advisor { get; }
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
            out global::Anthropic.BetaManagedAgentsAdvisor? value)
        {
            value = Advisor;
            return IsAdvisor;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAdvisor PickAdvisor() => IsAdvisor
            ? Advisor!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Advisor' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionRosterEntry(global::Anthropic.BetaManagedAgentsSessionThreadAgent value) => new BetaManagedAgentsSessionRosterEntry((global::Anthropic.BetaManagedAgentsSessionThreadAgent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionThreadAgent?(BetaManagedAgentsSessionRosterEntry @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionRosterEntry(global::Anthropic.BetaManagedAgentsSessionThreadAgent? value)
        {
            Agent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionRosterEntry FromAgent(global::Anthropic.BetaManagedAgentsSessionThreadAgent? value) => new BetaManagedAgentsSessionRosterEntry(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionRosterEntry(global::Anthropic.BetaManagedAgentsAdvisor value) => new BetaManagedAgentsSessionRosterEntry((global::Anthropic.BetaManagedAgentsAdvisor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAdvisor?(BetaManagedAgentsSessionRosterEntry @this) => @this.Advisor;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionRosterEntry(global::Anthropic.BetaManagedAgentsAdvisor? value)
        {
            Advisor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionRosterEntry FromAdvisor(global::Anthropic.BetaManagedAgentsAdvisor? value) => new BetaManagedAgentsSessionRosterEntry(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionRosterEntry(
            global::Anthropic.BetaManagedAgentsSessionRosterEntryDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsSessionThreadAgent? agent,
            global::Anthropic.BetaManagedAgentsAdvisor? advisor
            )
        {
            Type = type;

            Agent = agent;
            Advisor = advisor;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Advisor as object ??
            Agent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Agent?.ToString() ??
            Advisor?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgent && !IsAdvisor || !IsAgent && IsAdvisor;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionThreadAgent, TResult>? agent = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAdvisor, TResult>? advisor = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? agent = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAdvisor>? advisor = null,
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
            else if (IsAdvisor)
            {
                advisor?.Invoke(Advisor!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadAgent>? agent = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAdvisor>? advisor = null,
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
                typeof(global::Anthropic.BetaManagedAgentsSessionThreadAgent),
                Advisor,
                typeof(global::Anthropic.BetaManagedAgentsAdvisor),
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
        public bool Equals(BetaManagedAgentsSessionRosterEntry other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionThreadAgent?>.Default.Equals(Agent, other.Agent) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAdvisor?>.Default.Equals(Advisor, other.Advisor) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSessionRosterEntry obj1, BetaManagedAgentsSessionRosterEntry obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSessionRosterEntry>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSessionRosterEntry obj1, BetaManagedAgentsSessionRosterEntry obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSessionRosterEntry o && Equals(o);
        }
    }
}
