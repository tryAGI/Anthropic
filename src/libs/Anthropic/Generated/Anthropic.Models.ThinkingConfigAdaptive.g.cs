
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThinkingConfigAdaptive
    {
        /// <summary>
        /// Controls how thinking content appears in the response. When set to `summarized`, thinking is returned normally. When set to `omitted`, thinking content is redacted but a signature is returned for multi-turn continuity. Defaults to `summarized`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display")]
        public global::Anthropic.ThinkingDisplayMode? Display { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"adaptive"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "adaptive";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfigAdaptive" /> class.
        /// </summary>
        /// <param name="display">
        /// Controls how thinking content appears in the response. When set to `summarized`, thinking is returned normally. When set to `omitted`, thinking content is redacted but a signature is returned for multi-turn continuity. Defaults to `summarized`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkingConfigAdaptive(
            global::Anthropic.ThinkingDisplayMode? display,
            string type = "adaptive")
        {
            this.Display = display;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfigAdaptive" /> class.
        /// </summary>
        public ThinkingConfigAdaptive()
        {
        }
    }
}