
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The bucket to use in each region, keyed by region code, such as `us` or `eu`. An object with `project_number` and `bucket_name` sets that region's bucket, `null` removes it, and a region you leave out keeps its bucket. A bucket can serve only one region. While the control is on, at least one region must have a bucket.
    /// </summary>
    public sealed partial class BetaGoogleManagedStorageEnabledParamsBuckets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}