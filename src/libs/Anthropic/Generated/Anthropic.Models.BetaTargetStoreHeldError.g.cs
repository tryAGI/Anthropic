
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Returned with status 409 when a request to create a dream sets `output_behavior` to `update_existing` and another dream that writes into the same memory store hasn't fully stopped.<br/>
    /// The other dream is `pending` or `running`, or it has just stopped and is still finishing its last writes. `message` gives the ID of the other dream when the server can identify it. If that dream has already reached `completed`, `failed`, or `canceled`, retry after a short wait. Otherwise, wait for the other dream to end or cancel it, then retry. The response sets the `x-should-retry` header to `false`.
    /// </summary>
    public sealed partial class BetaTargetStoreHeldError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"conflict_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "conflict_error";

        /// <summary>
        /// A human-readable explanation of why the memory store can't be used yet, with the ID of the dream that is using it when the server can identify it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTargetStoreHeldError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable explanation of why the memory store can't be used yet, with the ID of the dream that is using it when the server can identify it.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTargetStoreHeldError(
            string? message,
            string type = "conflict_error")
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTargetStoreHeldError" /> class.
        /// </summary>
        public BetaTargetStoreHeldError()
        {
        }

    }
}