
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An object containing the input being passed to the tool, conforming to the tool’s `input_schema`.
    /// </summary>
    public sealed partial class ToolUseBlockInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}