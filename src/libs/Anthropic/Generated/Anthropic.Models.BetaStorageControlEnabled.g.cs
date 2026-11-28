
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The control is on and has a bucket for at least one region.
    /// </summary>
    public sealed partial class BetaStorageControlEnabled
    {
        /// <summary>
        /// The bucket configured for each region, keyed by region code. A region with no bucket is left out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaStorageBucket> Buckets { get; set; }

        /// <summary>
        /// Buckets that a region has retired, earliest `expires_at` first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retired_buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaRetiredBucket> RetiredBuckets { get; set; }

        /// <summary>
        /// Each region's status for the control, keyed by region code. A region that your organization is not offered may have no entry, and Anthropic may add regions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Status { get; set; }

        /// <summary>
        /// Default Value: enabled
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageControlEnabled" /> class.
        /// </summary>
        /// <param name="buckets">
        /// The bucket configured for each region, keyed by region code. A region with no bucket is left out.
        /// </param>
        /// <param name="retiredBuckets">
        /// Buckets that a region has retired, earliest `expires_at` first.
        /// </param>
        /// <param name="status">
        /// Each region's status for the control, keyed by region code. A region that your organization is not offered may have no entry, and Anthropic may add regions.
        /// </param>
        /// <param name="type">
        /// Default Value: enabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageControlEnabled(
            global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaStorageBucket> buckets,
            global::System.Collections.Generic.IList<global::Anthropic.BetaRetiredBucket> retiredBuckets,
            object status,
            string type = "enabled")
        {
            this.Buckets = buckets ?? throw new global::System.ArgumentNullException(nameof(buckets));
            this.RetiredBuckets = retiredBuckets ?? throw new global::System.ArgumentNullException(nameof(retiredBuckets));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageControlEnabled" /> class.
        /// </summary>
        public BetaStorageControlEnabled()
        {
        }

    }
}