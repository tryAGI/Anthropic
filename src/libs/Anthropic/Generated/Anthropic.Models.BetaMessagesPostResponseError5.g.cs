
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMessagesPostResponseError5
    {
        /// <summary>
        /// Machine-readable detail about the cause of the error. `error_code` names the cause; branch on it rather than on `message`. Absent when the error has no code. Treat an unrecognized `error_code` as the bare `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails, global::Anthropic.BetaRampLimitExceededErrorDetails>))]
        public global::Anthropic.AnyOf<global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails, global::Anthropic.BetaRampLimitExceededErrorDetails>? Details { get; set; }

        /// <summary>
        /// A human-readable explanation of the error. Its wording can change, so don't match on it.<br/>
        /// Default Value: Rate limited
        /// </summary>
        /// <default>"Rate limited"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Rate limited";

        /// <summary>
        /// The broad category of the error.<br/>
        /// Default Value: rate_limit_error
        /// </summary>
        /// <default>"rate_limit_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rate_limit_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessagesPostResponseError5" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable explanation of the error. Its wording can change, so don't match on it.<br/>
        /// Default Value: Rate limited
        /// </param>
        /// <param name="details">
        /// Machine-readable detail about the cause of the error. `error_code` names the cause; branch on it rather than on `message`. Absent when the error has no code. Treat an unrecognized `error_code` as the bare `type`.
        /// </param>
        /// <param name="type">
        /// The broad category of the error.<br/>
        /// Default Value: rate_limit_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessagesPostResponseError5(
            string message,
            global::Anthropic.AnyOf<global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails, global::Anthropic.BetaRampLimitExceededErrorDetails>? details,
            string type = "rate_limit_error")
        {
            this.Details = details;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessagesPostResponseError5" /> class.
        /// </summary>
        public BetaMessagesPostResponseError5()
        {
        }

    }
}