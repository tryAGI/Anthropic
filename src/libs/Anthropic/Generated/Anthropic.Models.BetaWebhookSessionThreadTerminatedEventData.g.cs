
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaWebhookSessionThreadTerminatedEventData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"session.thread_terminated"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "session.thread_terminated";

        /// <summary>
        /// ID of the session that triggered the event.
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
        /// ID of the session thread this event refers to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookSessionThreadTerminatedEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the session that triggered the event.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="sessionThreadId">
        /// ID of the session thread this event refers to.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebhookSessionThreadTerminatedEventData(
            string id,
            string organizationId,
            string workspaceId,
            string sessionThreadId,
            string type = "session.thread_terminated")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.SessionThreadId = sessionThreadId ?? throw new global::System.ArgumentNullException(nameof(sessionThreadId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookSessionThreadTerminatedEventData" /> class.
        /// </summary>
        public BetaWebhookSessionThreadTerminatedEventData()
        {
        }

    }
}