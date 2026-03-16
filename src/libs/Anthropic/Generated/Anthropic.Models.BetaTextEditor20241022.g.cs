
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaTextEditor20241022
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
        public global::Anthropic.CacheControlVariant132? CacheControl { get; set; }

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
        /// <default>"str_replace_editor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = "str_replace_editor";

        /// <summary>
        /// When true, guarantees schema validation on tool names and inputs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"text_editor_20241022"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text_editor_20241022";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextEditor20241022" /> class.
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
        public BetaTextEditor20241022(
            global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedCaller>? allowedCallers,
            global::Anthropic.CacheControlVariant132? cacheControl,
            bool? deferLoading,
            global::System.Collections.Generic.IList<object>? inputExamples,
            bool? strict,
            string name = "str_replace_editor",
            string type = "text_editor_20241022")
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
        /// Initializes a new instance of the <see cref="BetaTextEditor20241022" /> class.
        /// </summary>
        public BetaTextEditor20241022()
        {
        }
    }
}