
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude does not answer in the channel.
    /// </summary>
    public sealed partial class BetaClaudeTagGuestPolicyRestrict
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"restrict"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "restrict";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagGuestPolicyRestrict" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagGuestPolicyRestrict(
            string type = "restrict")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagGuestPolicyRestrict" /> class.
        /// </summary>
        public BetaClaudeTagGuestPolicyRestrict()
        {
        }

    }
}