
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Opaque cursor from previous response for pagination. Pass the `next_page` value from the previous response.
    /// </summary>
    public sealed partial class BetaListEnvironmentsV1EnvironmentsGetPage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}