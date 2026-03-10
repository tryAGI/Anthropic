
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputJsonContentBlockDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartialJson { get; set; }

        /// <summary>
        /// Default Value: input_json_delta
        /// </summary>
        /// <default>"input_json_delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "input_json_delta";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputJsonContentBlockDelta" /> class.
        /// </summary>
        /// <param name="partialJson"></param>
        /// <param name="type">
        /// Default Value: input_json_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputJsonContentBlockDelta(
            string partialJson,
            string type = "input_json_delta")
        {
            this.PartialJson = partialJson ?? throw new global::System.ArgumentNullException(nameof(partialJson));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputJsonContentBlockDelta" /> class.
        /// </summary>
        public InputJsonContentBlockDelta()
        {
        }
    }
}