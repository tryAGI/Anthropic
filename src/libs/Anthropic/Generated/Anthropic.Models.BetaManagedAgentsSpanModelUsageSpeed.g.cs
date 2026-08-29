
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Inference speed tier this request actually ran at. Mirrors `usage.speed` on /v1/messages. Only present when the fast-mode beta is active.
    /// </summary>
    public sealed partial class BetaManagedAgentsSpanModelUsageSpeed
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}