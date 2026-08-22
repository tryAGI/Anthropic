
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `output_behavior.memory_store_id` target is still held by a prior `{type: "update_existing"}` dream — one that is `pending` or `running`, or was canceled with its final writes still landing. Rarely the named dream has just finished (`completed`/`failed`) and its execution is still closing; an immediate retry then almost always succeeds. The message names the holding dream when the server can identify it (rarely omitted); poll it to a terminal state or cancel it, then retry. Carried with `x-should-retry: false`.
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
        /// Human-readable description of the conflict, naming the dream that holds the target store when the server can identify it.
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
        /// Human-readable description of the conflict, naming the dream that holds the target store when the server can identify it.
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