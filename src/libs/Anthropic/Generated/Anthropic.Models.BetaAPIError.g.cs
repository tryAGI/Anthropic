
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaAPIError
    {
        /// <summary>
        /// Default Value: Internal server error
        /// </summary>
        /// <default>"Internal server error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Default Value: api_error
        /// </summary>
        /// <default>"api_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "api_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAPIError" /> class.
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
        public BetaAPIError(
            string message,
            string type = "api_error")
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAPIError" /> class.
        /// </summary>
        public BetaAPIError()
        {
        }
    }
}