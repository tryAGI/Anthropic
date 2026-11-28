
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Each region's status for the control, keyed by region code. A region that your organization is not offered may have no entry, and Anthropic may add regions.
    /// </summary>
    public sealed partial class BetaCmekControlEnabledStatus
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}