
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCreateSlackChannelResponseError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"invalid_request_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "invalid_request_error";

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
        public global::Anthropic.BetaSlackChannelSetUpSettingsRefusedErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateSlackChannelResponseError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="details"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateSlackChannelResponseError(
            string message,
            global::Anthropic.BetaSlackChannelSetUpSettingsRefusedErrorDetails? details,
            string type = "invalid_request_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateSlackChannelResponseError" /> class.
        /// </summary>
        public BetaCreateSlackChannelResponseError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaCreateSlackChannelResponseError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaCreateSlackChannelResponseError FromMessage(string message)
        {
            return new BetaCreateSlackChannelResponseError
            {
                Message = message,
            };
        }

    }
}