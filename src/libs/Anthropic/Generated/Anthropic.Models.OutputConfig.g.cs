
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputConfig
    {
        /// <summary>
        /// How much effort the model should put into its response. Higher effort levels may result in more thorough analysis but take longer.<br/>
        /// Valid values are `low`, `medium`, `high`, `xhigh`, or `max`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::Anthropic.EffortLevel? Effort { get; set; }

        /// <summary>
        /// A schema to specify Claude's output format in responses. See [structured outputs](https://platform.claude.com/docs/en/build-with-claude/structured-outputs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public global::Anthropic.JsonOutputFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputConfig" /> class.
        /// </summary>
        /// <param name="effort">
        /// How much effort the model should put into its response. Higher effort levels may result in more thorough analysis but take longer.<br/>
        /// Valid values are `low`, `medium`, `high`, `xhigh`, or `max`.
        /// </param>
        /// <param name="format">
        /// A schema to specify Claude's output format in responses. See [structured outputs](https://platform.claude.com/docs/en/build-with-claude/structured-outputs)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputConfig(
            global::Anthropic.EffortLevel? effort,
            global::Anthropic.JsonOutputFormat? format)
        {
            this.Effort = effort;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputConfig" /> class.
        /// </summary>
        public OutputConfig()
        {
        }
    }
}