
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The program's features, keyed by feature: `data_retention_exemption` (use of models that normally require data retention, without the data being retained), `cmek` (customer-managed encryption keys) and `storage` (customer-owned storage). Every feature that the caller's organization may read has a key, whether or not it is approved; a missing key does not mean that the feature is inactive. Anthropic may add features; ignore a key you do not recognize.
    /// </summary>
    public sealed partial class UserProfileEfsProgramFeatures
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}