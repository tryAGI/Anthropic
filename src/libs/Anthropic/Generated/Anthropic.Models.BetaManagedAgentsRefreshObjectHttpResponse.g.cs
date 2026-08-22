
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The captured HTTP error response from the token endpoint. Populated only when `status` is `failed`.
    /// </summary>
    public sealed partial class BetaManagedAgentsRefreshObjectHttpResponse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}