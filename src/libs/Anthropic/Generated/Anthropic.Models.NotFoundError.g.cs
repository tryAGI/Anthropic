
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotFoundError
    {
        /// <summary>
        /// Default Value: not_found_error
        /// </summary>
        /// <default>global::Anthropic.NotFoundErrorType.NotFoundError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.NotFoundErrorTypeJsonConverter))]
        public global::Anthropic.NotFoundErrorType Type { get; set; } = global::Anthropic.NotFoundErrorType.NotFoundError;

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
        /// Initializes a new instance of the <see cref="NotFoundError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: not_found_error
        /// </param>
        /// <param name="message">
        /// Default Value: Not found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotFoundError(
            string message,
            global::Anthropic.NotFoundErrorType type = global::Anthropic.NotFoundErrorType.NotFoundError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundError" /> class.
        /// </summary>
        public NotFoundError()
        {
        }
    }
}