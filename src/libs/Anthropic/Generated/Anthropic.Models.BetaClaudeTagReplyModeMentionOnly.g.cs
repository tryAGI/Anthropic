
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude replies only when it is @-mentioned.
    /// </summary>
    public sealed partial class BetaClaudeTagReplyModeMentionOnly
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"mention_only"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mention_only";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagReplyModeMentionOnly" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagReplyModeMentionOnly(
            string type = "mention_only")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagReplyModeMentionOnly" /> class.
        /// </summary>
        public BetaClaudeTagReplyModeMentionOnly()
        {
        }

    }
}