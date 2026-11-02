
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCreateSlackChannelResponseError3
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"not_found_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "not_found_error";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaClaudeTagEnvironmentNotFoundErrorDetails, global::Anthropic.BetaClaudeTagSlackChannelSetUpEnvironmentNotFoundErrorDetails>))]
        public global::Anthropic.AnyOf<global::Anthropic.BetaClaudeTagEnvironmentNotFoundErrorDetails, global::Anthropic.BetaClaudeTagSlackChannelSetUpEnvironmentNotFoundErrorDetails>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateSlackChannelResponseError3" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="details"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateSlackChannelResponseError3(
            string message,
            global::Anthropic.AnyOf<global::Anthropic.BetaClaudeTagEnvironmentNotFoundErrorDetails, global::Anthropic.BetaClaudeTagSlackChannelSetUpEnvironmentNotFoundErrorDetails>? details,
            string type = "not_found_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateSlackChannelResponseError3" /> class.
        /// </summary>
        public BetaCreateSlackChannelResponseError3()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaCreateSlackChannelResponseError3"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaCreateSlackChannelResponseError3 FromMessage(string message)
        {
            return new BetaCreateSlackChannelResponseError3
            {
                Message = message,
            };
        }

    }
}