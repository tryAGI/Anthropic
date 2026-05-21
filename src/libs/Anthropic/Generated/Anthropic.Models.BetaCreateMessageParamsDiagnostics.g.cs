
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request-level diagnostics. Supply `previous_message_id` to have the response include `diagnostics.cache_miss_reason` explaining any prompt-cache divergence from that prior request.
    /// </summary>
    public sealed partial class BetaCreateMessageParamsDiagnostics
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}