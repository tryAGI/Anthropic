
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWebhookExternalKeyRecoveredEventData
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_key.recovered"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "external_key.recovered";

        /// <summary>
        /// ID (`ekey_...`) of the external key that stopped working or works again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookExternalKeyRecoveredEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// ID (`ekey_...`) of the external key that stopped working or works again.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebhookExternalKeyRecoveredEventData(
            string id,
            string organizationId,
            string type = "external_key.recovered")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookExternalKeyRecoveredEventData" /> class.
        /// </summary>
        public BetaWebhookExternalKeyRecoveredEventData()
        {
        }

    }
}