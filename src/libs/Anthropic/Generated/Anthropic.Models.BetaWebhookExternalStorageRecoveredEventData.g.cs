
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWebhookExternalStorageRecoveredEventData
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_storage.recovered"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "external_storage.recovered";

        /// <summary>
        /// ID (`estrg_...`) of the External Storage whose bucket failed Anthropic's check or passes it again.
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
        /// Initializes a new instance of the <see cref="BetaWebhookExternalStorageRecoveredEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// ID (`estrg_...`) of the External Storage whose bucket failed Anthropic's check or passes it again.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebhookExternalStorageRecoveredEventData(
            string id,
            string organizationId,
            string type = "external_storage.recovered")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookExternalStorageRecoveredEventData" /> class.
        /// </summary>
        public BetaWebhookExternalStorageRecoveredEventData()
        {
        }

    }
}