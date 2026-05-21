
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Attribution for a write made directly via the public API (outside of any session).
    /// </summary>
    public sealed partial class BetaManagedAgentsApiActor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsApiActorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsApiActorType Type { get; set; }

        /// <summary>
        /// ID of the API key that performed the write. This identifies the key, not the secret.
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
        /// ID of the API key that performed the write. This identifies the key, not the secret.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsApiActor(
            string apiKeyId,
            global::Anthropic.BetaManagedAgentsApiActorType type)
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

    }
}