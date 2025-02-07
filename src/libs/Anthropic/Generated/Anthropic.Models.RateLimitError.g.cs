
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitError
    {
        /// <summary>
        /// Default Value: rate_limit_error
        /// </summary>
        /// <default>global::Anthropic.RateLimitErrorType.RateLimitError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.RateLimitErrorTypeJsonConverter))]
        public global::Anthropic.RateLimitErrorType Type { get; set; } = global::Anthropic.RateLimitErrorType.RateLimitError;

        /// <summary>
        /// Default Value: Rate limited
        /// </summary>
        /// <default>"Rate limited"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Rate limited";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: rate_limit_error
        /// </param>
        /// <param name="message">
        /// Default Value: Rate limited
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitError(
            string message,
            global::Anthropic.RateLimitErrorType type = global::Anthropic.RateLimitErrorType.RateLimitError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitError" /> class.
        /// </summary>
        public RateLimitError()
        {
        }
    }
}