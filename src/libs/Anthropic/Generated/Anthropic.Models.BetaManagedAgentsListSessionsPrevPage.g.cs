
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Opaque cursor for the previous page. Null when on the first page. Pass as the `page` parameter to navigate backward.
    /// </summary>
    public sealed partial class BetaManagedAgentsListSessionsPrevPage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}