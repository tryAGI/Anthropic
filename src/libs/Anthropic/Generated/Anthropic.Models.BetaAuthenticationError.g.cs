
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaAuthenticationError
    {
        /// <summary>
        /// Default Value: authentication_error
        /// </summary>
        /// <default>global::Anthropic.BetaAuthenticationErrorType.AuthenticationError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaAuthenticationErrorTypeJsonConverter))]
        public global::Anthropic.BetaAuthenticationErrorType Type { get; set; } = global::Anthropic.BetaAuthenticationErrorType.AuthenticationError;

        /// <summary>
        /// Default Value: Authentication error
        /// </summary>
        /// <default>"Authentication error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Authentication error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAuthenticationError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: authentication_error
        /// </param>
        /// <param name="message">
        /// Default Value: Authentication error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAuthenticationError(
            string message,
            global::Anthropic.BetaAuthenticationErrorType type = global::Anthropic.BetaAuthenticationErrorType.AuthenticationError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAuthenticationError" /> class.
        /// </summary>
        public BetaAuthenticationError()
        {
        }
    }
}