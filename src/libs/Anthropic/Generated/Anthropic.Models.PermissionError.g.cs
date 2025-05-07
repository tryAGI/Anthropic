
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PermissionError
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
        /// <default>global::Anthropic.PermissionErrorType.PermissionError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.PermissionErrorTypeJsonConverter))]
        public global::Anthropic.PermissionErrorType Type { get; set; } = global::Anthropic.PermissionErrorType.PermissionError;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionError" /> class.
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
        public PermissionError(
            string message,
            global::Anthropic.PermissionErrorType type = global::Anthropic.PermissionErrorType.PermissionError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionError" /> class.
        /// </summary>
        public PermissionError()
        {
        }
    }
}