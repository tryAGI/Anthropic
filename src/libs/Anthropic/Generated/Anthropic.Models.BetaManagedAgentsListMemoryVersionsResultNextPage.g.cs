
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Opaque cursor for the next page (a `page_...` value), or `null` if there are no more results. Pass as `page` on the next request.
    /// </summary>
    public sealed partial class BetaManagedAgentsListMemoryVersionsResultNextPage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}