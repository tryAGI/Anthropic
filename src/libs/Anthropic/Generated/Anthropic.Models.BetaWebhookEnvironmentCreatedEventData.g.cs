
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaWebhookEnvironmentCreatedEventData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"environment.created"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "environment.created";

        /// <summary>
        /// ID of the environment that triggered the event.
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
        /// Initializes a new instance of the <see cref="BetaWebhookEnvironmentCreatedEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the environment that triggered the event.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebhookEnvironmentCreatedEventData(
            string id,
            string organizationId,
            string workspaceId,
            string type = "environment.created")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookEnvironmentCreatedEventData" /> class.
        /// </summary>
        public BetaWebhookEnvironmentCreatedEventData()
        {
        }

    }
}