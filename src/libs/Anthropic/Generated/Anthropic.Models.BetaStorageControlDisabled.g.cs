
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The control is off and has no buckets.
    /// </summary>
    public sealed partial class BetaStorageControlDisabled
    {
        /// <summary>
        /// Buckets that a region has retired, earliest `expires_at` first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retired_buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaRetiredBucket> RetiredBuckets { get; set; }

        /// <summary>
        /// Default Value: disabled
        /// </summary>
        /// <default>"disabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "disabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageControlDisabled" /> class.
        /// </summary>
        /// <param name="retiredBuckets">
        /// Buckets that a region has retired, earliest `expires_at` first.
        /// </param>
        /// <param name="type">
        /// Default Value: disabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageControlDisabled(
            global::System.Collections.Generic.IList<global::Anthropic.BetaRetiredBucket> retiredBuckets,
            string type = "disabled")
        {
            this.RetiredBuckets = retiredBuckets ?? throw new global::System.ArgumentNullException(nameof(retiredBuckets));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageControlDisabled" /> class.
        /// </summary>
        public BetaStorageControlDisabled()
        {
        }

    }
}