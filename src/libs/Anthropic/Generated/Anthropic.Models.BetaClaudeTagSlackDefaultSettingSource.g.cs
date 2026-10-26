
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The value comes from the organization's Slack defaults, which have no identifier.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackDefaultSettingSource
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"slack_default"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "slack_default";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackDefaultSettingSource" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackDefaultSettingSource(
            string type = "slack_default")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackDefaultSettingSource" /> class.
        /// </summary>
        public BetaClaudeTagSlackDefaultSettingSource()
        {
        }

    }
}