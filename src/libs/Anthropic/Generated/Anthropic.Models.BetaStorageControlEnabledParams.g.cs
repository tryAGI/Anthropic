
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Turns the control on, or changes its buckets while it is on.
    /// </summary>
    public sealed partial class BetaStorageControlEnabledParams
    {
        /// <summary>
        /// The bucket to use in each region, keyed by region code, such as `us` or `eu`. An object with `project_number` and `bucket_name` sets that region's bucket, `null` removes it, and a region you leave out keeps its bucket. A bucket can serve only one region. While the control is on, at least one region must have a bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        public object? Buckets { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="BetaStorageControlEnabledParams" /> class.
        /// </summary>
        /// <param name="buckets">
        /// The bucket to use in each region, keyed by region code, such as `us` or `eu`. An object with `project_number` and `bucket_name` sets that region's bucket, `null` removes it, and a region you leave out keeps its bucket. A bucket can serve only one region. While the control is on, at least one region must have a bucket.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageControlEnabledParams(
            object? buckets,
            string type = "enabled")
        {
            this.Buckets = buckets;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageControlEnabledParams" /> class.
        /// </summary>
        public BetaStorageControlEnabledParams()
        {
        }

    }
}