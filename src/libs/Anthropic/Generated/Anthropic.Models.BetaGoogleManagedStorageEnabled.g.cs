
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The control is on and has a bucket for at least one region.
    /// </summary>
    public sealed partial class BetaGoogleManagedStorageEnabled
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// The bucket configured for each region, keyed by region code. A region with no bucket is left out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaGoogleManagedStorageBucket> Buckets { get; set; }

        /// <summary>
        /// Each region's status for the control, keyed by region code. A region that your organization is not offered may have no entry, and Anthropic may add regions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaGoogleManagedStorageRegionStatus> Status { get; set; }

        /// <summary>
        /// Buckets that a region has retired, earliest `expires_at` first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retired_buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedRetiredBucket> RetiredBuckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageEnabled" /> class.
        /// </summary>
        /// <param name="buckets">
        /// The bucket configured for each region, keyed by region code. A region with no bucket is left out.
        /// </param>
        /// <param name="status">
        /// Each region's status for the control, keyed by region code. A region that your organization is not offered may have no entry, and Anthropic may add regions.
        /// </param>
        /// <param name="retiredBuckets">
        /// Buckets that a region has retired, earliest `expires_at` first.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedStorageEnabled(
            global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaGoogleManagedStorageBucket> buckets,
            global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaGoogleManagedStorageRegionStatus> status,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedRetiredBucket> retiredBuckets,
            string type = "enabled")
        {
            this.Type = type;
            this.Buckets = buckets ?? throw new global::System.ArgumentNullException(nameof(buckets));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.RetiredBuckets = retiredBuckets ?? throw new global::System.ArgumentNullException(nameof(retiredBuckets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageEnabled" /> class.
        /// </summary>
        public BetaGoogleManagedStorageEnabled()
        {
        }

    }
}