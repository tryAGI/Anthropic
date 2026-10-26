
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude answers with only the Bundles attached to the channel itself.
    /// </summary>
    public sealed partial class BetaClaudeTagGuestPolicyChannelOnly
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"channel_only"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "channel_only";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagGuestPolicyChannelOnly" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagGuestPolicyChannelOnly(
            string type = "channel_only")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagGuestPolicyChannelOnly" /> class.
        /// </summary>
        public BetaClaudeTagGuestPolicyChannelOnly()
        {
        }

    }
}