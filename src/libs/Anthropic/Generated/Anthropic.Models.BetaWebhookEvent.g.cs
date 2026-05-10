
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"type":"event","id":"wevt_011CZkZYZd9rLmz3ujAcsqEw","created_at":"2026-03-15T10:00:00Z","data":{"type":"session.status_idled","id":"sesn_011CZkZAtmR3yMPDzynEDxu7","organization_id":"org_011CZkZZAe0sMna4vkBdtrfx","workspace_id":"wrkspc_011CZkZaBF1tNoB5wlCeusgy"}}
    /// </summary>
    public sealed partial class BetaWebhookEvent
    {
        /// <summary>
        /// Object type. Always `event` for webhook payloads.
        /// </summary>
        /// <default>"event"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "event";

        /// <summary>
        /// Unique event identifier for idempotency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// RFC 3339 timestamp when the event occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaWebhookEventDataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaWebhookEventData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique event identifier for idempotency.
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 timestamp when the event occurred.
        /// </param>
        /// <param name="data"></param>
        /// <param name="type">
        /// Object type. Always `event` for webhook payloads.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebhookEvent(
            string id,
            global::System.DateTime createdAt,
            global::Anthropic.BetaWebhookEventData data,
            string type = "event")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookEvent" /> class.
        /// </summary>
        public BetaWebhookEvent()
        {
        }

    }
}