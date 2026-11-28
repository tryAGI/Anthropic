
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An API key.
    /// </summary>
    public sealed partial class BetaComplianceReviewApiActor
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"api_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "api_actor";

        /// <summary>
        /// The ID of the API key (`apikey_...`).
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
        /// Initializes a new instance of the <see cref="BetaComplianceReviewApiActor" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// The ID of the API key (`apikey_...`).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewApiActor(
            string apiKeyId,
            string type = "api_actor")
        {
            this.Type = type;
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewApiActor" /> class.
        /// </summary>
        public BetaComplianceReviewApiActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaComplianceReviewApiActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaComplianceReviewApiActor FromApiKeyId(string apiKeyId)
        {
            return new BetaComplianceReviewApiActor
            {
                ApiKeyId = apiKeyId,
            };
        }

    }
}