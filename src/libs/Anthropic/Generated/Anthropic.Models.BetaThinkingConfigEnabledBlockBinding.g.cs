
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Controls for block binding: what happens when a thinking block this request sends back fails the conversation check. `null`, absent or an empty object means every default.
    /// </summary>
    public sealed partial class BetaThinkingConfigEnabledBlockBinding
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}