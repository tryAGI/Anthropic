
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWebhookExternalStorageFailedEventData
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_storage.failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "external_storage.failed";

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
        /// Initializes a new instance of the <see cref="BetaWebhookExternalStorageFailedEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// ID (`estrg_...`) of the External Storage whose bucket failed Anthropic's check or passes it again.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebhookExternalStorageFailedEventData(
            string id,
            string organizationId,
            string type = "external_storage.failed")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookExternalStorageFailedEventData" /> class.
        /// </summary>
        public BetaWebhookExternalStorageFailedEventData()
        {
        }

    }
}