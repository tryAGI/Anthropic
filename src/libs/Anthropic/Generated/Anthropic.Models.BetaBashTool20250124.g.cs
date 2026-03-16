
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaBashTool20250124
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant13? CacheControl { get; set; }

        /// <summary>
        /// If true, tool will not be included in initial system prompt. Only loaded when returned via tool_reference from tool search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_examples")]
        public global::System.Collections.Generic.IList<object>? InputExamples { get; set; }

        /// <summary>
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in `tool_use` blocks.
        /// </summary>
        /// <default>"bash"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = "bash";

        /// <summary>
        /// When true, guarantees schema validation on tool names and inputs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"bash_20250124"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "bash_20250124";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBashTool20250124" /> class.
        /// </summary>
        /// <param name="allowedCallers"></param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="deferLoading">
        /// If true, tool will not be included in initial system prompt. Only loaded when returned via tool_reference from tool search.
        /// </param>
        /// <param name="inputExamples"></param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in `tool_use` blocks.
        /// </param>
        /// <param name="strict">
        /// When true, guarantees schema validation on tool names and inputs
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBashTool20250124(
            global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedCaller>? allowedCallers,
            global::Anthropic.CacheControlVariant13? cacheControl,
            bool? deferLoading,
            global::System.Collections.Generic.IList<object>? inputExamples,
            bool? strict,
            string name = "bash",
            string type = "bash_20250124")
        {
            this.AllowedCallers = allowedCallers;
            this.CacheControl = cacheControl;
            this.DeferLoading = deferLoading;
            this.InputExamples = inputExamples;
            this.Name = name;
            this.Strict = strict;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBashTool20250124" /> class.
        /// </summary>
        public BetaBashTool20250124()
        {
        }
    }
}