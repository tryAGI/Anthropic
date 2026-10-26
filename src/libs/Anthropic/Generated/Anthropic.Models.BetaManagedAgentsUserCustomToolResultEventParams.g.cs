
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for providing the result of a custom tool execution.
    /// </summary>
    public sealed partial class BetaManagedAgentsUserCustomToolResultEventParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"user.custom_tool_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user.custom_tool_result";

        /// <summary>
        /// The id of the `agent.custom_tool_use` event this result corresponds to. It is also listed in the last `session.status_idle` [event's](https://platform.claude.com/docs/en/api/beta/sessions/events/list#beta_managed_agents_session_requires_action.event_ids) `stop_reason.event_ids` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomToolUseId { get; set; }

        /// <summary>
        /// The result content returned by the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? Content { get; set; }

        /// <summary>
        /// Whether the tool execution resulted in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserCustomToolResultEventParams" /> class.
        /// </summary>
        /// <param name="customToolUseId">
        /// The id of the `agent.custom_tool_use` event this result corresponds to. It is also listed in the last `session.status_idle` [event's](https://platform.claude.com/docs/en/api/beta/sessions/events/list#beta_managed_agents_session_requires_action.event_ids) `stop_reason.event_ids` field.
        /// </param>
        /// <param name="content">
        /// The result content returned by the tool.
        /// </param>
        /// <param name="isError">
        /// Whether the tool execution resulted in an error.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserCustomToolResultEventParams(
            string customToolUseId,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? content,
            bool? isError,
            string type = "user.custom_tool_result")
        {
            this.Type = type;
            this.CustomToolUseId = customToolUseId ?? throw new global::System.ArgumentNullException(nameof(customToolUseId));
            this.Content = content;
            this.IsError = isError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserCustomToolResultEventParams" /> class.
        /// </summary>
        public BetaManagedAgentsUserCustomToolResultEventParams()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsUserCustomToolResultEventParams"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsUserCustomToolResultEventParams FromCustomToolUseId(string customToolUseId)
        {
            return new BetaManagedAgentsUserCustomToolResultEventParams
            {
                CustomToolUseId = customToolUseId,
            };
        }

    }
}