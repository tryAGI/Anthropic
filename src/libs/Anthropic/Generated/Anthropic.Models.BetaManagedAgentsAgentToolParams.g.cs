#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Union type for tool configurations in the tools array.
    /// </summary>
    public readonly partial struct BetaManagedAgentsAgentToolParams : global::System.IEquatable<BetaManagedAgentsAgentToolParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Configuration for built-in agent tools. Use this to enable or disable groups of tools available to the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401Params? AgentToolset20260401 { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401Params? AgentToolset20260401 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentToolset20260401))]
#endif
        public bool IsAgentToolset20260401 => AgentToolset20260401 != null;

        /// <summary>
        /// Configuration for tools from an MCP server defined in `mcp_servers`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMCPToolsetParams? McpToolset { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMCPToolsetParams? McpToolset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolset))]
#endif
        public bool IsMcpToolset => McpToolset != null;

        /// <summary>
        /// A custom tool that is executed by the API client rather than the agent. When the agent calls this tool, an `agent.custom_tool_use` event is emitted and the session goes idle, waiting for the client to provide the result via a `user.custom_tool_result` event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsCustomToolParams? Custom { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsCustomToolParams? Custom { get; }
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
        public static implicit operator BetaManagedAgentsAgentToolParams(global::Anthropic.BetaManagedAgentsAgentToolset20260401Params value) => new BetaManagedAgentsAgentToolParams((global::Anthropic.BetaManagedAgentsAgentToolset20260401Params?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentToolset20260401Params?(BetaManagedAgentsAgentToolParams @this) => @this.AgentToolset20260401;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolParams(global::Anthropic.BetaManagedAgentsAgentToolset20260401Params? value)
        {
            AgentToolset20260401 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolParams(global::Anthropic.BetaManagedAgentsMCPToolsetParams value) => new BetaManagedAgentsAgentToolParams((global::Anthropic.BetaManagedAgentsMCPToolsetParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMCPToolsetParams?(BetaManagedAgentsAgentToolParams @this) => @this.McpToolset;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolParams(global::Anthropic.BetaManagedAgentsMCPToolsetParams? value)
        {
            McpToolset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolParams(global::Anthropic.BetaManagedAgentsCustomToolParams value) => new BetaManagedAgentsAgentToolParams((global::Anthropic.BetaManagedAgentsCustomToolParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsCustomToolParams?(BetaManagedAgentsAgentToolParams @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolParams(global::Anthropic.BetaManagedAgentsCustomToolParams? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolParams(
            global::Anthropic.BetaManagedAgentsAgentToolParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAgentToolset20260401Params? agentToolset20260401,
            global::Anthropic.BetaManagedAgentsMCPToolsetParams? mcpToolset,
            global::Anthropic.BetaManagedAgentsCustomToolParams? custom
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
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentToolset20260401Params?, TResult>? agentToolset20260401 = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMCPToolsetParams?, TResult>? mcpToolset = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsCustomToolParams?, TResult>? custom = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolset20260401Params?>? agentToolset20260401 = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMCPToolsetParams?>? mcpToolset = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsCustomToolParams?>? custom = null,
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
                typeof(global::Anthropic.BetaManagedAgentsAgentToolset20260401Params),
                McpToolset,
                typeof(global::Anthropic.BetaManagedAgentsMCPToolsetParams),
                Custom,
                typeof(global::Anthropic.BetaManagedAgentsCustomToolParams),
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
        public bool Equals(BetaManagedAgentsAgentToolParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentToolset20260401Params?>.Default.Equals(AgentToolset20260401, other.AgentToolset20260401) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMCPToolsetParams?>.Default.Equals(McpToolset, other.McpToolset) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsCustomToolParams?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAgentToolParams obj1, BetaManagedAgentsAgentToolParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAgentToolParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAgentToolParams obj1, BetaManagedAgentsAgentToolParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAgentToolParams o && Equals(o);
        }
    }
}
