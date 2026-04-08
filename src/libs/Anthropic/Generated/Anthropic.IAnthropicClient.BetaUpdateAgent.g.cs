#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Agent
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsAgent> BetaUpdateAgentAsync(
            string agentId,

            global::Anthropic.BetaManagedAgentsUpdateAgentParams request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="agentId"></param>
        /// <param name="version">
        /// The agent's current version, used to prevent concurrent overwrites. Obtain this value from a create or retrieve response. The request fails if this does not match the server's current version.
        /// </param>
        /// <param name="name">
        /// Human-readable name. 1-256 characters. Omit to preserve. Cannot be cleared.
        /// </param>
        /// <param name="description">
        /// Description. Up to 2048 characters. Omit to preserve; send empty string or null to clear.
        /// </param>
        /// <param name="model">
        /// Model identifier. Accepts the [model string](https://platform.claude.com/docs/en/about-claude/models/overview#latest-models-comparison), e.g. `claude-opus-4-6`, or a `model_config` object for additional configuration control. Omit to preserve. Cannot be cleared.
        /// </param>
        /// <param name="system">
        /// System prompt. Up to 100,000 characters. Omit to preserve; send empty string or null to clear.
        /// </param>
        /// <param name="tools">
        /// Tool configurations available to the agent. Full replacement. Omit to preserve; send empty array or null to clear. Maximum of 128 tools across all toolsets allowed.
        /// </param>
        /// <param name="mcpServers">
        /// MCP servers. Full replacement. Omit to preserve; send empty array or null to clear. Names must be unique. Maximum 20.
        /// </param>
        /// <param name="skills">
        /// Skills. Full replacement. Omit to preserve; send empty array or null to clear. Maximum 20.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve. The stored bag is limited to 16 keys (up to 64 chars each) with values up to 512 chars.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsAgent> BetaUpdateAgentAsync(
            string agentId,
            int version,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? name = default,
            string? description = default,
            global::Anthropic.BetaManagedAgentsModelParams? model = default,
            string? system = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? tools = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? mcpServers = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? skills = default,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}