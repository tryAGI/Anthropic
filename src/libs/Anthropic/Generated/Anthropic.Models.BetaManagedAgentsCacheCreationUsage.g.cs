
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Prompt-cache creation token usage broken down by cache lifetime.
    /// </summary>
    public sealed partial class BetaManagedAgentsCacheCreationUsage
    {
        /// <summary>
        /// Tokens used to create 1-hour ephemeral cache entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_1h_input_tokens")]
        public int? Ephemeral1hInputTokens { get; set; }

        /// <summary>
        /// Tokens used to create 5-minute ephemeral cache entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_5m_input_tokens")]
        public int? Ephemeral5mInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCacheCreationUsage" /> class.
        /// </summary>
        /// <param name="ephemeral1hInputTokens">
        /// Tokens used to create 1-hour ephemeral cache entries.
        /// </param>
        /// <param name="ephemeral5mInputTokens">
        /// Tokens used to create 5-minute ephemeral cache entries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCacheCreationUsage(
            int? ephemeral1hInputTokens,
            int? ephemeral5mInputTokens)
        {
            this.Ephemeral1hInputTokens = ephemeral1hInputTokens;
            this.Ephemeral5mInputTokens = ephemeral5mInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCacheCreationUsage" /> class.
        /// </summary>
        public BetaManagedAgentsCacheCreationUsage()
        {
        }
    }
}