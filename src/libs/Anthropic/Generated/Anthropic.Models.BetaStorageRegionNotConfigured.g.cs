
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// No bucket is set for this region.
    /// </summary>
    public sealed partial class BetaStorageRegionNotConfigured
    {
        /// <summary>
        /// The bucket that the region applies now. While a replacement bucket is `pending` or `failed`, this is the previous bucket. `null` when the region applies no bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_bucket")]
        public global::Anthropic.BetaEffectiveBucket? EffectiveBucket { get; set; }

        /// <summary>
        /// Default Value: not_configured
        /// </summary>
        /// <default>"not_configured"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "not_configured";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageRegionNotConfigured" /> class.
        /// </summary>
        /// <param name="effectiveBucket">
        /// The bucket that the region applies now. While a replacement bucket is `pending` or `failed`, this is the previous bucket. `null` when the region applies no bucket.
        /// </param>
        /// <param name="type">
        /// Default Value: not_configured
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageRegionNotConfigured(
            global::Anthropic.BetaEffectiveBucket? effectiveBucket,
            string type = "not_configured")
        {
            this.EffectiveBucket = effectiveBucket;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageRegionNotConfigured" /> class.
        /// </summary>
        public BetaStorageRegionNotConfigured()
        {
        }

    }
}