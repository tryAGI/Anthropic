
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CacheCreation
    {
        /// <summary>
        /// The number of input tokens used to create the 1 hour cache entry.<br/>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_1h_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Ephemeral1hInputTokens { get; set; } = 0;

        /// <summary>
        /// The number of input tokens used to create the 5 minute cache entry.<br/>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_5m_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Ephemeral5mInputTokens { get; set; } = 0;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheCreation" /> class.
        /// </summary>
        /// <param name="ephemeral1hInputTokens">
        /// The number of input tokens used to create the 1 hour cache entry.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="ephemeral5mInputTokens">
        /// The number of input tokens used to create the 5 minute cache entry.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheCreation(
            int ephemeral1hInputTokens,
            int ephemeral5mInputTokens)
        {
            this.Ephemeral1hInputTokens = ephemeral1hInputTokens;
            this.Ephemeral5mInputTokens = ephemeral5mInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheCreation" /> class.
        /// </summary>
        public CacheCreation()
        {
        }
    }
}