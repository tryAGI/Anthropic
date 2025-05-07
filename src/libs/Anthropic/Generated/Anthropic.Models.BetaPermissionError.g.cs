
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaPermissionError
    {
        /// <summary>
        /// Default Value: Permission denied
        /// </summary>
        /// <default>"Permission denied"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Permission denied";

        /// <summary>
        /// Default Value: permission_error
        /// </summary>
        /// <default>global::Anthropic.BetaPermissionErrorType.PermissionError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaPermissionErrorTypeJsonConverter))]
        public global::Anthropic.BetaPermissionErrorType Type { get; set; } = global::Anthropic.BetaPermissionErrorType.PermissionError;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPermissionError" /> class.
        /// </summary>
        /// <param name="message">
        /// Default Value: Permission denied
        /// </param>
        /// <param name="type">
        /// Default Value: permission_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPermissionError(
            string message,
            global::Anthropic.BetaPermissionErrorType type = global::Anthropic.BetaPermissionErrorType.PermissionError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPermissionError" /> class.
        /// </summary>
        public BetaPermissionError()
        {
        }
    }
}