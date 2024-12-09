
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaNotFoundError
    {
        /// <summary>
        /// Default Value: not_found_error
        /// </summary>
        /// <default>global::Anthropic.BetaNotFoundErrorType.NotFoundError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaNotFoundErrorTypeJsonConverter))]
        public global::Anthropic.BetaNotFoundErrorType Type { get; set; } = global::Anthropic.BetaNotFoundErrorType.NotFoundError;

        /// <summary>
        /// Default Value: Not found
        /// </summary>
        /// <default>"Not found"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Not found";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaNotFoundError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: not_found_error
        /// </param>
        /// <param name="message">
        /// Default Value: Not found
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaNotFoundError(
            string message,
            global::Anthropic.BetaNotFoundErrorType type = global::Anthropic.BetaNotFoundErrorType.NotFoundError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaNotFoundError" /> class.
        /// </summary>
        public BetaNotFoundError()
        {
        }
    }
}