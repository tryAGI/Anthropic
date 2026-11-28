
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The configured bucket passed verification, and the region applies it.
    /// </summary>
    public sealed partial class BetaGoogleManagedStorageRegionActive
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"active"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "active";

        /// <summary>
        /// The bucket that the region applies now. While a replacement bucket is `pending` or `failed`, this is the previous bucket. `null` when the region applies no bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_bucket")]
        public global::Anthropic.BetaGoogleManagedBucketReference? EffectiveBucket { get; set; }

        /// <summary>
        /// When the status last became `active`, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ValidatedAt { get; set; }

        /// <summary>
        /// The checks that the latest reported daily verification failed. Empty when it passed.
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
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageRegionActive" /> class.
        /// </summary>
        /// <param name="validatedAt">
        /// When the status last became `active`, in RFC 3339 format.
        /// </param>
        /// <param name="failedChecks">
        /// The checks that the latest reported daily verification failed. Empty when it passed.
        /// </param>
        /// <param name="effectiveBucket">
        /// The bucket that the region applies now. While a replacement bucket is `pending` or `failed`, this is the previous bucket. `null` when the region applies no bucket.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedStorageRegionActive(
            global::System.DateTime validatedAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedStorageFailedCheck> failedChecks,
            global::Anthropic.BetaGoogleManagedBucketReference? effectiveBucket,
            string type = "active")
        {
            this.Type = type;
            this.EffectiveBucket = effectiveBucket;
            this.ValidatedAt = validatedAt;
            this.FailedChecks = failedChecks ?? throw new global::System.ArgumentNullException(nameof(failedChecks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageRegionActive" /> class.
        /// </summary>
        public BetaGoogleManagedStorageRegionActive()
        {
        }

    }
}