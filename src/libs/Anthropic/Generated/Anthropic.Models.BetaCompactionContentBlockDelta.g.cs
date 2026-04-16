
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCompactionContentBlockDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Opaque metadata from prior compaction, to be round-tripped verbatim<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// Default Value: compaction_delta
        /// </summary>
        /// <default>"compaction_delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "compaction_delta";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionContentBlockDelta" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="encryptedContent">
        /// Opaque metadata from prior compaction, to be round-tripped verbatim<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: compaction_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCompactionContentBlockDelta(
            string? content,
            string? encryptedContent,
            string type = "compaction_delta")
        {
            this.Content = content;
            this.EncryptedContent = encryptedContent;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionContentBlockDelta" /> class.
        /// </summary>
        public BetaCompactionContentBlockDelta()
        {
        }
    }
}