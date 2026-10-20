
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A `cache_miss_reason` for when the API doesn't have a stored record of the request that `diagnostics.previous_message_id` references.<br/>
    /// This doesn't mean that this request changed.<br/>
    /// See the [cache diagnostics guide](https://platform.claude.com/docs/en/build-with-claude/cache-diagnostics#cache-miss-reason-types) to learn what to change for each reason.
    /// </summary>
    public sealed partial class BetaCacheMissPreviousMessageNotFound
    {
        /// <summary>
        /// Default Value: previous_message_not_found
        /// </summary>
        /// <default>"previous_message_not_found"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "previous_message_not_found";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCacheMissPreviousMessageNotFound" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: previous_message_not_found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCacheMissPreviousMessageNotFound(
            string type = "previous_message_not_found")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCacheMissPreviousMessageNotFound" /> class.
        /// </summary>
        public BetaCacheMissPreviousMessageNotFound()
        {
        }

    }
}