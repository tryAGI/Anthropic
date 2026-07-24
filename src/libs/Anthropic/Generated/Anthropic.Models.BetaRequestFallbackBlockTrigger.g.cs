
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The response block's `trigger`, echoed verbatim. Accepted and ignored by the server; any object or `null` is allowed.
    /// </summary>
    public sealed partial class BetaRequestFallbackBlockTrigger
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}