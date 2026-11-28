
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The region stopped retrying verification before the configured bucket passed. To restart verification, send the region a bucket again. It can be the same bucket.
    /// </summary>
    public sealed partial class BetaStorageRegionFailed
    {
        /// <summary>
        /// The bucket that the region applies now. While a replacement bucket is `pending` or `failed`, this is the previous bucket. `null` when the region applies no bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_bucket")]
        public global::Anthropic.BetaEffectiveBucket? EffectiveBucket { get; set; }

        /// <summary>
        /// The checks that the last reported verification attempt failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaStorageFailedCheck> FailedChecks { get; set; }

        /// <summary>
        /// Default Value: failed
        /// </summary>
        /// <default>"failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "failed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageRegionFailed" /> class.
        /// </summary>
        /// <param name="failedChecks">
        /// The checks that the last reported verification attempt failed.
        /// </param>
        /// <param name="effectiveBucket">
        /// The bucket that the region applies now. While a replacement bucket is `pending` or `failed`, this is the previous bucket. `null` when the region applies no bucket.
        /// </param>
        /// <param name="type">
        /// Default Value: failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageRegionFailed(
            global::System.Collections.Generic.IList<global::Anthropic.BetaStorageFailedCheck> failedChecks,
            global::Anthropic.BetaEffectiveBucket? effectiveBucket,
            string type = "failed")
        {
            this.EffectiveBucket = effectiveBucket;
            this.FailedChecks = failedChecks ?? throw new global::System.ArgumentNullException(nameof(failedChecks));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageRegionFailed" /> class.
        /// </summary>
        public BetaStorageRegionFailed()
        {
        }

    }
}