
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Like `automatic`, but Claude never pauses on its own. Available where it is enabled for the channel.
    /// </summary>
    public sealed partial class BetaClaudeTagReplyModeAlwaysAwake
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"always_awake"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "always_awake";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagReplyModeAlwaysAwake" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagReplyModeAlwaysAwake(
            string type = "always_awake")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagReplyModeAlwaysAwake" /> class.
        /// </summary>
        public BetaClaudeTagReplyModeAlwaysAwake()
        {
        }

    }
}