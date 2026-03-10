
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Deprecated: Use `output_config.format` instead. See [structured outputs](https://platform.claude.com/docs/en/build-with-claude/structured-outputs)<br/>
    /// A schema to specify Claude's output format in responses. This parameter will be removed in a future release.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class BetaCreateMessageParamsOutputFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}