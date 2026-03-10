
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Token for fetching the next page of results.<br/>
    /// If `null`, there are no more results available. Pass this value to the `page_token` parameter in the next request to get the next page.
    /// </summary>
    public sealed partial class BetaListSkillsResponseNextPage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}