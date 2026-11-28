
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The region is verifying the configured bucket.
    /// </summary>
    public sealed partial class BetaGoogleManagedStorageRegionPending
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"pending"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "pending";

        /// <summary>
        /// The bucket that the region applies now. While a replacement bucket is `pending` or `failed`, this is the previous bucket. `null` when the region applies no bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_bucket")]
        public global::Anthropic.BetaGoogleManagedBucketReference? EffectiveBucket { get; set; }

        /// <summary>
        /// The checks that the latest reported verification attempt failed. Empty when none has failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedStorageFailedCheck> FailedChecks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageRegionPending" /> class.
        /// </summary>
        /// <param name="failedChecks">
        /// The checks that the latest reported verification attempt failed. Empty when none has failed.
        /// </param>
        /// <param name="effectiveBucket">
        /// The bucket that the region applies now. While a replacement bucket is `pending` or `failed`, this is the previous bucket. `null` when the region applies no bucket.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedStorageRegionPending(
            global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedStorageFailedCheck> failedChecks,
            global::Anthropic.BetaGoogleManagedBucketReference? effectiveBucket,
            string type = "pending")
        {
            this.Type = type;
            this.EffectiveBucket = effectiveBucket;
            this.FailedChecks = failedChecks ?? throw new global::System.ArgumentNullException(nameof(failedChecks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageRegionPending" /> class.
        /// </summary>
        public BetaGoogleManagedStorageRegionPending()
        {
        }

    }
}