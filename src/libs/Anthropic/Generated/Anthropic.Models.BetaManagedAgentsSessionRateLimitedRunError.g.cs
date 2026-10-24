
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Session creation was rejected due to rate limiting. The schedule keeps firing; subsequent runs may succeed.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionRateLimitedRunError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"session_rate_limited_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "session_rate_limited_error";

        /// <summary>
        /// Human-readable error description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionRateLimitedRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionRateLimitedRunError(
            string message,
            string type = "session_rate_limited_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionRateLimitedRunError" /> class.
        /// </summary>
        public BetaManagedAgentsSessionRateLimitedRunError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsSessionRateLimitedRunError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsSessionRateLimitedRunError FromMessage(string message)
        {
            return new BetaManagedAgentsSessionRateLimitedRunError
            {
                Message = message,
            };
        }

    }
}