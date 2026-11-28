
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has withdrawn or paused its approval of customer-owned storage for this profile, so the region does not apply the control.
    /// </summary>
    public sealed partial class BetaGoogleManagedStorageRegionSuspended
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"suspended"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "suspended";

        /// <summary>
        /// The bucket that the region applies now. While a replacement bucket is `pending` or `failed`, this is the previous bucket. `null` when the region applies no bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_bucket")]
        public global::Anthropic.BetaGoogleManagedBucketReference? EffectiveBucket { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageRegionSuspended" /> class.
        /// </summary>
        /// <param name="effectiveBucket">
        /// The bucket that the region applies now. While a replacement bucket is `pending` or `failed`, this is the previous bucket. `null` when the region applies no bucket.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedStorageRegionSuspended(
            global::Anthropic.BetaGoogleManagedBucketReference? effectiveBucket,
            string type = "suspended")
        {
            this.Type = type;
            this.EffectiveBucket = effectiveBucket;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageRegionSuspended" /> class.
        /// </summary>
        public BetaGoogleManagedStorageRegionSuspended()
        {
        }

    }
}