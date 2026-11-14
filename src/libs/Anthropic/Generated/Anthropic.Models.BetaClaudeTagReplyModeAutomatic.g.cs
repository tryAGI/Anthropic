
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude reads along and joins in when it can help, and pauses on its own in quiet or busy channels.
    /// </summary>
    public sealed partial class BetaClaudeTagReplyModeAutomatic
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"automatic"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "automatic";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagReplyModeAutomatic" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagReplyModeAutomatic(
            string type = "automatic")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagReplyModeAutomatic" /> class.
        /// </summary>
        public BetaClaudeTagReplyModeAutomatic()
        {
        }

    }
}