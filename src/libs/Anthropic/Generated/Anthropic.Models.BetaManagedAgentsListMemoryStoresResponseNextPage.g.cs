
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Opaque cursor for the next page (a `page_...` value). Pass as `page` on the next request. `null` when there are no more results.
    /// </summary>
    public sealed partial class BetaManagedAgentsListMemoryStoresResponseNextPage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}