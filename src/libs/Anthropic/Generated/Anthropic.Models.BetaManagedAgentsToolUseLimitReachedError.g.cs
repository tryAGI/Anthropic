
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The turn stopped because the agent loop reached its limit on tool-use rounds (one model response that calls tools, plus running those tools, is one round), not because a request failed. The thread goes idle with `stop_reason: retries_exhausted` (a child thread then terminates); the next `user.message` starts a new turn.<br/>
    /// Example: {"type":"tool_use_limit_reached_error","message":"This turn stopped because the agent loop reached its limit of 500 tool-use rounds since the turn started or last resumed. A round is one model response that calls tools, plus running those tools. Nothing failed. Send the session a new message to continue; nothing from the stopped turn is discarded.","retry_status":{"type":"exhausted"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsToolUseLimitReachedError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"tool_use_limit_reached_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_use_limit_reached_error";

        /// <summary>
        /// Human-readable error description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// What the client should do next.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsRetryStatus RetryStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsToolUseLimitReachedError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="retryStatus">
        /// What the client should do next.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsToolUseLimitReachedError(
            string message,
            global::Anthropic.BetaManagedAgentsRetryStatus retryStatus,
            string type = "tool_use_limit_reached_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RetryStatus = retryStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsToolUseLimitReachedError" /> class.
        /// </summary>
        public BetaManagedAgentsToolUseLimitReachedError()
        {
        }

    }
}