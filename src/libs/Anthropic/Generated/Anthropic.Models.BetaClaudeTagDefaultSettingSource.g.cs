
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// No settings level sets a value, and the built-in default applies.
    /// </summary>
    public sealed partial class BetaClaudeTagDefaultSettingSource
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"default"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "default";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagDefaultSettingSource" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagDefaultSettingSource(
            string type = "default")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagDefaultSettingSource" /> class.
        /// </summary>
        public BetaClaudeTagDefaultSettingSource()
        {
        }

    }
}