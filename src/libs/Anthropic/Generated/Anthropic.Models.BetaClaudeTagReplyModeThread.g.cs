
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Every new top-level message in the channel gets its own reply from Claude, in a thread under it. Available where it is enabled for the channel, and only once Claude has been used in the channel.
    /// </summary>
    public sealed partial class BetaClaudeTagReplyModeThread
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "thread";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagReplyModeThread" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagReplyModeThread(
            string type = "thread")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagReplyModeThread" /> class.
        /// </summary>
        public BetaClaudeTagReplyModeThread()
        {
        }

    }
}