
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The control is off and has no buckets.
    /// </summary>
    public sealed partial class BetaGoogleManagedStorageDisabled
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"disabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "disabled";

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
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageDisabled" /> class.
        /// </summary>
        /// <param name="retiredBuckets">
        /// Buckets that a region has retired, earliest `expires_at` first.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedStorageDisabled(
            global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedRetiredBucket> retiredBuckets,
            string type = "disabled")
        {
            this.Type = type;
            this.RetiredBuckets = retiredBuckets ?? throw new global::System.ArgumentNullException(nameof(retiredBuckets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageDisabled" /> class.
        /// </summary>
        public BetaGoogleManagedStorageDisabled()
        {
        }

    }
}