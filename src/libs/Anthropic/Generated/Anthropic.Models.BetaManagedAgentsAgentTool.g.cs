#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Union type for tool configurations returned in API responses.
    /// </summary>
    public readonly partial struct BetaManagedAgentsAgentTool : global::System.IEquatable<BetaManagedAgentsAgentTool>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401? AgentToolset20260401 { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401? AgentToolset20260401 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentToolset20260401))]
#endif
        public bool IsAgentToolset20260401 => AgentToolset20260401 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMCPToolset? McpToolset { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMCPToolset? McpToolset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolset))]
#endif
        public bool IsMcpToolset => McpToolset != null;

        /// <summary>
        /// A custom tool as returned in API responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsCustomTool? Custom { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsCustomTool? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentTool(global::Anthropic.BetaManagedAgentsAgentToolset20260401 value) => new BetaManagedAgentsAgentTool((global::Anthropic.BetaManagedAgentsAgentToolset20260401?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentToolset20260401?(BetaManagedAgentsAgentTool @this) => @this.AgentToolset20260401;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentTool(global::Anthropic.BetaManagedAgentsAgentToolset20260401? value)
        {
            AgentToolset20260401 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentTool(global::Anthropic.BetaManagedAgentsMCPToolset value) => new BetaManagedAgentsAgentTool((global::Anthropic.BetaManagedAgentsMCPToolset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMCPToolset?(BetaManagedAgentsAgentTool @this) => @this.McpToolset;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentTool(global::Anthropic.BetaManagedAgentsMCPToolset? value)
        {
            McpToolset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentTool(global::Anthropic.BetaManagedAgentsCustomTool value) => new BetaManagedAgentsAgentTool((global::Anthropic.BetaManagedAgentsCustomTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsCustomTool?(BetaManagedAgentsAgentTool @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentTool(global::Anthropic.BetaManagedAgentsCustomTool? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentTool(
            global::Anthropic.BetaManagedAgentsAgentToolDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAgentToolset20260401? agentToolset20260401,
            global::Anthropic.BetaManagedAgentsMCPToolset? mcpToolset,
            global::Anthropic.BetaManagedAgentsCustomTool? custom
            )
        {
            Type = type;

            AgentToolset20260401 = agentToolset20260401;
            McpToolset = mcpToolset;
            Custom = custom;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Custom as object ??
            McpToolset as object ??
            AgentToolset20260401 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentToolset20260401?.ToString() ??
            McpToolset?.ToString() ??
            Custom?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentToolset20260401 && !IsMcpToolset && !IsCustom || !IsAgentToolset20260401 && IsMcpToolset && !IsCustom || !IsAgentToolset20260401 && !IsMcpToolset && IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentToolset20260401?, TResult>? agentToolset20260401 = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMCPToolset?, TResult>? mcpToolset = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsCustomTool?, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentToolset20260401 && agentToolset20260401 != null)
            {
                return agentToolset20260401(AgentToolset20260401!);
            }
            else if (IsMcpToolset && mcpToolset != null)
            {
                return mcpToolset(McpToolset!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolset20260401?>? agentToolset20260401 = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMCPToolset?>? mcpToolset = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsCustomTool?>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentToolset20260401)
            {
                agentToolset20260401?.Invoke(AgentToolset20260401!);
            }
            else if (IsMcpToolset)
            {
                mcpToolset?.Invoke(McpToolset!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentToolset20260401,
                typeof(global::Anthropic.BetaManagedAgentsAgentToolset20260401),
                McpToolset,
                typeof(global::Anthropic.BetaManagedAgentsMCPToolset),
                Custom,
                typeof(global::Anthropic.BetaManagedAgentsCustomTool),
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
        public bool Equals(BetaManagedAgentsAgentTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentToolset20260401?>.Default.Equals(AgentToolset20260401, other.AgentToolset20260401) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMCPToolset?>.Default.Equals(McpToolset, other.McpToolset) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsCustomTool?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAgentTool obj1, BetaManagedAgentsAgentTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAgentTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAgentTool obj1, BetaManagedAgentsAgentTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAgentTool o && Equals(o);
        }
    }
}
