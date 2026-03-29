
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolSearchToolBM2520251119
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::Anthropic.AllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant169? CacheControl { get; set; }

        /// <summary>
        /// If true, tool will not be included in initial system prompt. Only loaded when returned via tool_reference from tool search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in `tool_use` blocks.
        /// </summary>
        /// <default>"tool_search_tool_bm25"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = "tool_search_tool_bm25";

        /// <summary>
        /// When true, guarantees schema validation on tool names and inputs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ToolSearchToolBM2520251119TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ToolSearchToolBM2520251119Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchToolBM2520251119" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="allowedCallers"></param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="deferLoading">
        /// If true, tool will not be included in initial system prompt. Only loaded when returned via tool_reference from tool search.
        /// </param>
        /// <param name="strict">
        /// When true, guarantees schema validation on tool names and inputs
        /// </param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in `tool_use` blocks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchToolBM2520251119(
            global::Anthropic.ToolSearchToolBM2520251119Type type,
            global::System.Collections.Generic.IList<global::Anthropic.AllowedCaller>? allowedCallers,
            global::Anthropic.CacheControlVariant169? cacheControl,
            bool? deferLoading,
            bool? strict,
            string name = "tool_search_tool_bm25")
        {
            this.AllowedCallers = allowedCallers;
            this.CacheControl = cacheControl;
            this.DeferLoading = deferLoading;
            this.Name = name;
            this.Strict = strict;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchToolBM2520251119" /> class.
        /// </summary>
        public ToolSearchToolBM2520251119()
        {
        }
    }
}