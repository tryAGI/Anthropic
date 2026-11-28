
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The External Key to use in each region, keyed by region code, such as `us` or `eu`. An External Key ID (`ekey_...`) sets that region's key, `null` removes it, and a region you leave out keeps its key. While the control is on, at least one region must have a key.
    /// </summary>
    public sealed partial class BetaCmekControlEnabledParamsExternalKeyIds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}