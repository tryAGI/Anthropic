
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaInvalidRequestError
    {
        /// <summary>
        /// Default Value: invalid_request_error
        /// </summary>
        /// <default>global::Anthropic.BetaInvalidRequestErrorType.InvalidRequestError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaInvalidRequestErrorTypeJsonConverter))]
        public global::Anthropic.BetaInvalidRequestErrorType Type { get; set; } = global::Anthropic.BetaInvalidRequestErrorType.InvalidRequestError;

        /// <summary>
        /// Default Value: Invalid request
        /// </summary>
        /// <default>"Invalid request"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Invalid request";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInvalidRequestError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: invalid_request_error
        /// </param>
        /// <param name="message">
        /// Default Value: Invalid request
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaInvalidRequestError(
            string message,
            global::Anthropic.BetaInvalidRequestErrorType type = global::Anthropic.BetaInvalidRequestErrorType.InvalidRequestError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInvalidRequestError" /> class.
        /// </summary>
        public BetaInvalidRequestError()
        {
        }
    }
}