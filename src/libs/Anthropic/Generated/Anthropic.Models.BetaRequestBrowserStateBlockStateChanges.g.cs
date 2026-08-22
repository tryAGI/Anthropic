
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Tabs opened and download state changes during this call. "Nothing to report" is expressed by omitting the field, never by an empty list.
    /// </summary>
    public sealed partial class BetaRequestBrowserStateBlockStateChanges
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}