
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Pagination token for fetching a specific page of results.<br/>
    /// Pass the value from a previous response's `next_page` field to get the next page of results.
    /// </summary>
    public sealed partial class ListSkillsV1SkillsGetPage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}