
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserCustomToolResultEventParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParamsType Type { get; set; }

        /// <summary>
        /// The id of the `agent.custom_tool_use` event this result corresponds to, which can be found in the last `session.status_idle` [event's](https://platform.claude.com/docs/en/api/beta/sessions/events/list#beta_managed_agents_session_requires_action.event_ids) `stop_reason.event_ids` field.
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
        /// The id of the `agent.custom_tool_use` event this result corresponds to, which can be found in the last `session.status_idle` [event's](https://platform.claude.com/docs/en/api/beta/sessions/events/list#beta_managed_agents_session_requires_action.event_ids) `stop_reason.event_ids` field.
        /// </param>
        /// <param name="type"></param>
        /// <param name="content">
        /// The result content returned by the tool.
        /// </param>
        /// <param name="isError">
        /// Whether the tool execution resulted in an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserCustomToolResultEventParams(
            string customToolUseId,
            global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParamsType type,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? content,
            bool? isError)
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
    }
}