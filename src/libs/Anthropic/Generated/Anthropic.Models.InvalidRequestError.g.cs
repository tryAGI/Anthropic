
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvalidRequestError
    {
        /// <summary>
        /// Default Value: invalid_request_error
        /// </summary>
        /// <default>global::Anthropic.InvalidRequestErrorType.InvalidRequestError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.InvalidRequestErrorTypeJsonConverter))]
        public global::Anthropic.InvalidRequestErrorType Type { get; set; } = global::Anthropic.InvalidRequestErrorType.InvalidRequestError;

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
        /// Initializes a new instance of the <see cref="InvalidRequestError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: invalid_request_error
        /// </param>
        /// <param name="message">
        /// Default Value: Invalid request
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public InvalidRequestError(
            string message,
            global::Anthropic.InvalidRequestErrorType type = global::Anthropic.InvalidRequestErrorType.InvalidRequestError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRequestError" /> class.
        /// </summary>
        public InvalidRequestError()
        {
        }
    }
}