
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginApiActor
    {
        /// <summary>
        /// The key's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyId { get; set; }

        /// <summary>
        /// An Admin API key, in the same form the Compliance API activity feed uses for it.<br/>
        /// Default Value: api_actor
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
        /// Initializes a new instance of the <see cref="BetaPluginApiActor" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// The key's ID.
        /// </param>
        /// <param name="type">
        /// An Admin API key, in the same form the Compliance API activity feed uses for it.<br/>
        /// Default Value: api_actor
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginApiActor(
            string apiKeyId,
            string type = "api_actor")
        {
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginApiActor" /> class.
        /// </summary>
        public BetaPluginApiActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaPluginApiActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaPluginApiActor FromApiKeyId(string apiKeyId)
        {
            return new BetaPluginApiActor
            {
                ApiKeyId = apiKeyId,
            };
        }

    }
}