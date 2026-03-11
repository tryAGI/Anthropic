
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaServerToolCaller20260120
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ToolId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"code_execution_20260120"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "code_execution_20260120";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServerToolCaller20260120" /> class.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServerToolCaller20260120(
            string toolId,
            string type = "code_execution_20260120")
        {
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServerToolCaller20260120" /> class.
        /// </summary>
        public BetaServerToolCaller20260120()
        {
        }
    }
}