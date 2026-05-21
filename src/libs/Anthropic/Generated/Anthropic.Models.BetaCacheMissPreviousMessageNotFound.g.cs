
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
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