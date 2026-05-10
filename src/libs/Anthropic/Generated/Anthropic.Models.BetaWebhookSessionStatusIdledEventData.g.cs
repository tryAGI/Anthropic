
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"type":"session.status_idled","id":"sesn_011CZkZAtmR3yMPDzynEDxu7","organization_id":"org_011CZkZZAe0sMna4vkBdtrfx","workspace_id":"wrkspc_011CZkZaBF1tNoB5wlCeusgy"}
    /// </summary>
    public sealed partial class BetaWebhookSessionStatusIdledEventData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"session.status_idled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "session.status_idled";

        /// <summary>
        /// ID of the resource that triggered the event.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookSessionStatusIdledEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the resource that triggered the event.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebhookSessionStatusIdledEventData(
            string id,
            string organizationId,
            string workspaceId,
            string type = "session.status_idled")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookSessionStatusIdledEventData" /> class.
        /// </summary>
        public BetaWebhookSessionStatusIdledEventData()
        {
        }

    }
}