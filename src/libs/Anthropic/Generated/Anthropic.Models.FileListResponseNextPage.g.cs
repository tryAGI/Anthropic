
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Opaque cursor for the next page. Supply as `?page=` to fetch the next page; null when there are no more results.
    /// </summary>
    public sealed partial class FileListResponseNextPage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}