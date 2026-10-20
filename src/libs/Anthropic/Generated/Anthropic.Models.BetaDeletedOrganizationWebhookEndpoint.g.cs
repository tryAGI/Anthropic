
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A deleted organization webhook endpoint.
    /// </summary>
    public sealed partial class BetaDeletedOrganizationWebhookEndpoint
    {
        /// <summary>
        /// ID of the deleted webhook endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Always `webhook_endpoint_deleted`.<br/>
        /// Default Value: webhook_endpoint_deleted
        /// </summary>
        /// <default>"webhook_endpoint_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "webhook_endpoint_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeletedOrganizationWebhookEndpoint" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted webhook endpoint.
        /// </param>
        /// <param name="type">
        /// Always `webhook_endpoint_deleted`.<br/>
        /// Default Value: webhook_endpoint_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeletedOrganizationWebhookEndpoint(
            string id,
            string type = "webhook_endpoint_deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeletedOrganizationWebhookEndpoint" /> class.
        /// </summary>
        public BetaDeletedOrganizationWebhookEndpoint()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDeletedOrganizationWebhookEndpoint"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDeletedOrganizationWebhookEndpoint FromId(string id)
        {
            return new BetaDeletedOrganizationWebhookEndpoint
            {
                Id = id,
            };
        }

    }
}