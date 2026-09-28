
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ThinkingConfigBetweenTools
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"between_tools"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "between_tools";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfigBetweenTools" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkingConfigBetweenTools(
            string type = "between_tools")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfigBetweenTools" /> class.
        /// </summary>
        public ThinkingConfigBetweenTools()
        {
        }

    }
}