
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeApiActor
    {
        /// <summary>
        /// Name of the API key used to perform Claude Code actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyName { get; set; }

        /// <summary>
        /// Actor type. Always `"api_actor"` for an API key.
        /// </summary>
        /// <default>"api_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "api_actor";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeApiActor" /> class.
        /// </summary>
        /// <param name="apiKeyName">
        /// Name of the API key used to perform Claude Code actions.
        /// </param>
        /// <param name="type">
        /// Actor type. Always `"api_actor"` for an API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeApiActor(
            string apiKeyName,
            string type = "api_actor")
        {
            this.ApiKeyName = apiKeyName ?? throw new global::System.ArgumentNullException(nameof(apiKeyName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeApiActor" /> class.
        /// </summary>
        public BetaClaudeCodeApiActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeCodeApiActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeCodeApiActor FromApiKeyName(string apiKeyName)
        {
            return new BetaClaudeCodeApiActor
            {
                ApiKeyName = apiKeyName,
            };
        }

    }
}