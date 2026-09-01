
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// "error" (default) | "drop_block". What happens when a thinking block in `messages` fails the conversation check (it was created in a different conversation, or the messages before it have changed since). "error" fails the request with a 400 error. "drop_block" removes the failing blocks and the request proceeds; each removal is reported in `input_transformations`.
    /// </summary>
    public sealed partial class BetaThinkingBlockBindingPrefixMismatchBehavior
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}