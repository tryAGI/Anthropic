
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Input context window used. `null` if not grouping by description or for non-token costs.
    /// </summary>
    public sealed partial class BetaCostReportItemContextWindow
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}