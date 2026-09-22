
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Failure detail for a Dream whose `status` is `failed`.
    /// </summary>
    public sealed partial class BetaDreamError
    {
        /// <summary>
        /// A code for why the dream failed, such as `timeout` or `internal_error`.<br/>
        /// The [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#errors) lists common error codes and when they occur.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// A human-readable explanation of why the dream failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamError" /> class.
        /// </summary>
        /// <param name="type">
        /// A code for why the dream failed, such as `timeout` or `internal_error`.<br/>
        /// The [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#errors) lists common error codes and when they occur.
        /// </param>
        /// <param name="message">
        /// A human-readable explanation of why the dream failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDreamError(
            string type,
            string message)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamError" /> class.
        /// </summary>
        public BetaDreamError()
        {
        }

    }
}