
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCacheMissModelChanged
    {
        /// <summary>
        /// Approximate number of input tokens that would have been read from cache had the prefix matched the previous request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_missed_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheMissedInputTokens { get; set; }

        /// <summary>
        /// Default Value: model_changed
        /// </summary>
        /// <default>"model_changed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "model_changed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCacheMissModelChanged" /> class.
        /// </summary>
        /// <param name="cacheMissedInputTokens">
        /// Approximate number of input tokens that would have been read from cache had the prefix matched the previous request.
        /// </param>
        /// <param name="type">
        /// Default Value: model_changed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCacheMissModelChanged(
            int cacheMissedInputTokens,
            string type = "model_changed")
        {
            this.CacheMissedInputTokens = cacheMissedInputTokens;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCacheMissModelChanged" /> class.
        /// </summary>
        public BetaCacheMissModelChanged()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaCacheMissModelChanged"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaCacheMissModelChanged FromCacheMissedInputTokens(int cacheMissedInputTokens)
        {
            return new BetaCacheMissModelChanged
            {
                CacheMissedInputTokens = cacheMissedInputTokens,
            };
        }

    }
}