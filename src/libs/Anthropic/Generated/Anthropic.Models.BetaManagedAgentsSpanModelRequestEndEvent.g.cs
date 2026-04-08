
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Emitted when a model request completes.
    /// </summary>
    public sealed partial class BetaManagedAgentsSpanModelRequestEndEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpanModelRequestEndEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when the model request completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Whether the model request resulted in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// Token usage for this model request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSpanModelUsage ModelUsage { get; set; }

        /// <summary>
        /// The id of the corresponding `span.model_request_start` event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_request_start_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelRequestStartId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSpanModelRequestEndEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when the model request completed.
        /// </param>
        /// <param name="modelUsage">
        /// Token usage for this model request.
        /// </param>
        /// <param name="modelRequestStartId">
        /// The id of the corresponding `span.model_request_start` event.
        /// </param>
        /// <param name="type"></param>
        /// <param name="isError">
        /// Whether the model request resulted in an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSpanModelRequestEndEvent(
            string id,
            global::System.DateTime processedAt,
            global::Anthropic.BetaManagedAgentsSpanModelUsage modelUsage,
            string modelRequestStartId,
            global::Anthropic.BetaManagedAgentsSpanModelRequestEndEventType type,
            bool? isError)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.IsError = isError;
            this.ModelUsage = modelUsage ?? throw new global::System.ArgumentNullException(nameof(modelUsage));
            this.ModelRequestStartId = modelRequestStartId ?? throw new global::System.ArgumentNullException(nameof(modelRequestStartId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSpanModelRequestEndEvent" /> class.
        /// </summary>
        public BetaManagedAgentsSpanModelRequestEndEvent()
        {
        }
    }
}