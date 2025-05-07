
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthenticationError
    {
        /// <summary>
        /// Default Value: Authentication error
        /// </summary>
        /// <default>"Authentication error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Authentication error";

        /// <summary>
        /// Default Value: authentication_error
        /// </summary>
        /// <default>global::Anthropic.AuthenticationErrorType.AuthenticationError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AuthenticationErrorTypeJsonConverter))]
        public global::Anthropic.AuthenticationErrorType Type { get; set; } = global::Anthropic.AuthenticationErrorType.AuthenticationError;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationError" /> class.
        /// </summary>
        /// <param name="message">
        /// Default Value: Authentication error
        /// </param>
        /// <param name="type">
        /// Default Value: authentication_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationError(
            string message,
            global::Anthropic.AuthenticationErrorType type = global::Anthropic.AuthenticationErrorType.AuthenticationError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationError" /> class.
        /// </summary>
        public AuthenticationError()
        {
        }
    }
}