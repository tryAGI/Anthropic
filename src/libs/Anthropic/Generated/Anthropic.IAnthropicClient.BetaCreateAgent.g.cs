#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Agent
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsAgent> BetaCreateAgentAsync(

            global::Anthropic.BetaManagedAgentsCreateAgentParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsAgent>> BetaCreateAgentAsResponseAsync(

            global::Anthropic.BetaManagedAgentsCreateAgentParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="name">
        /// Human-readable name for the agent.
        /// </param>
        /// <param name="model">
        /// Model identifier. Accepts the [model string](https://platform.claude.com/docs/en/about-claude/models/overview#latest-models-comparison), e.g. `claude-opus-4-6`, or a `model_config` object for additional configuration control
        /// </param>
        /// <param name="description">
        /// Description of what the agent does.
        /// </param>
        /// <param name="system">
        /// System prompt for the agent.
        /// </param>
        /// <param name="tools">
        /// Tool configurations available to the agent. Maximum of 128 tools across all toolsets allowed.
        /// </param>
        /// <param name="mcpServers">
        /// MCP servers this agent connects to. Maximum 20. Names must be unique within the array. Every server must be referenced by an `mcp_toolset` in `tools`; unreferenced servers are rejected. See the [MCP connector guide](https://platform.claude.com/docs/en/managed-agents/mcp-connector).
        /// </param>
        /// <param name="skills">
        /// Skills available to the agent.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </param>
        /// <param name="multiagent">
        /// Multiagent orchestration configuration. Currently supports the `coordinator` topology with a roster of 1-20 agents.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsAgent> BetaCreateAgentAsync(
            string name,
            global::Anthropic.BetaManagedAgentsModelParams model,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? description = default,
            string? system = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? tools = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? mcpServers = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? skills = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Anthropic.BetaManagedAgentsMultiagentParams? multiagent = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}