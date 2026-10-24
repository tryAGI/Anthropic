
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A direct caller of the public API, identified by the API key that authenticated the request.
    /// </summary>
    public sealed partial class BetaManagedAgentsApiActor
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"api_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "api_actor";

        /// <summary>
        /// ID of the API key (an `apikey_...` value). This identifies the key, not the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsApiActor" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// ID of the API key (an `apikey_...` value). This identifies the key, not the secret.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsApiActor(
            string apiKeyId,
            string type = "api_actor")
        {
            this.Type = type;
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsApiActor" /> class.
        /// </summary>
        public BetaManagedAgentsApiActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsApiActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsApiActor FromApiKeyId(string apiKeyId)
        {
            return new BetaManagedAgentsApiActor
            {
                ApiKeyId = apiKeyId,
            };
        }

    }
}