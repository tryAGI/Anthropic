
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OverloadedError
    {
        /// <summary>
        /// Default Value: overloaded_error
        /// </summary>
        /// <default>global::Anthropic.OverloadedErrorType.OverloadedError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.OverloadedErrorTypeJsonConverter))]
        public global::Anthropic.OverloadedErrorType Type { get; set; } = global::Anthropic.OverloadedErrorType.OverloadedError;

        /// <summary>
        /// Default Value: Overloaded
        /// </summary>
        /// <default>"Overloaded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Overloaded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OverloadedError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: overloaded_error
        /// </param>
        /// <param name="message">
        /// Default Value: Overloaded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OverloadedError(
            string message,
            global::Anthropic.OverloadedErrorType type = global::Anthropic.OverloadedErrorType.OverloadedError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OverloadedError" /> class.
        /// </summary>
        public OverloadedError()
        {
        }
    }
}