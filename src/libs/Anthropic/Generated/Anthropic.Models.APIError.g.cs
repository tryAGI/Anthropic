
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIError
    {
        /// <summary>
        /// Default Value: Internal server error
        /// </summary>
        /// <default>"Internal server error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Internal server error";

        /// <summary>
        /// Default Value: api_error
        /// </summary>
        /// <default>global::Anthropic.APIErrorType.ApiError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.APIErrorTypeJsonConverter))]
        public global::Anthropic.APIErrorType Type { get; set; } = global::Anthropic.APIErrorType.ApiError;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIError" /> class.
        /// </summary>
        /// <param name="message">
        /// Default Value: Internal server error
        /// </param>
        /// <param name="type">
        /// Default Value: api_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIError(
            string message,
            global::Anthropic.APIErrorType type = global::Anthropic.APIErrorType.ApiError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIError" /> class.
        /// </summary>
        public APIError()
        {
        }
    }
}