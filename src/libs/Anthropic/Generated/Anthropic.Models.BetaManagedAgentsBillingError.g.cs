
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The caller's organization or workspace cannot make model requests — out of credits or spend limit reached. Retrying with the same credentials will not succeed; the caller must resolve the billing state.
    /// </summary>
    public sealed partial class BetaManagedAgentsBillingError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBillingErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsBillingErrorType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsBillingError" /> class.
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
        public BetaManagedAgentsBillingError(
            string message,
            global::Anthropic.BetaManagedAgentsRetryStatus retryStatus,
            global::Anthropic.BetaManagedAgentsBillingErrorType type)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RetryStatus = retryStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsBillingError" /> class.
        /// </summary>
        public BetaManagedAgentsBillingError()
        {
        }
    }
}