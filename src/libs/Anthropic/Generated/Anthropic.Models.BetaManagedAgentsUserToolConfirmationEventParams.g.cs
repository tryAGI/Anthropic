
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for confirming or denying a tool execution request.
    /// </summary>
    public sealed partial class BetaManagedAgentsUserToolConfirmationEventParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserToolConfirmationEventParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParamsType Type { get; set; }

        /// <summary>
        /// The id of the `agent.tool_use` or `agent.mcp_tool_use` event this result corresponds to, which can be found in the last `session.status_idle` [event's](https://platform.claude.com/docs/en/api/beta/sessions/events/list#beta_managed_agents_session_requires_action.event_ids) `stop_reason.event_ids` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// The confirmation result: 'allow' or 'deny'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserToolConfirmationResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsUserToolConfirmationResult Result { get; set; }

        /// <summary>
        /// Optional message providing context for a 'deny' decision. Only allowed when result is 'deny'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deny_message")]
        public string? DenyMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserToolConfirmationEventParams" /> class.
        /// </summary>
        /// <param name="toolUseId">
        /// The id of the `agent.tool_use` or `agent.mcp_tool_use` event this result corresponds to, which can be found in the last `session.status_idle` [event's](https://platform.claude.com/docs/en/api/beta/sessions/events/list#beta_managed_agents_session_requires_action.event_ids) `stop_reason.event_ids` field.
        /// </param>
        /// <param name="result">
        /// The confirmation result: 'allow' or 'deny'.
        /// </param>
        /// <param name="type"></param>
        /// <param name="denyMessage">
        /// Optional message providing context for a 'deny' decision. Only allowed when result is 'deny'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserToolConfirmationEventParams(
            string toolUseId,
            global::Anthropic.BetaManagedAgentsUserToolConfirmationResult result,
            global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParamsType type,
            string? denyMessage)
        {
            this.Type = type;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Result = result;
            this.DenyMessage = denyMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserToolConfirmationEventParams" /> class.
        /// </summary>
        public BetaManagedAgentsUserToolConfirmationEventParams()
        {
        }
    }
}