
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration overrides for specific tools, keyed by tool name
    /// </summary>
    public sealed partial class BetaMCPToolsetConfigs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}