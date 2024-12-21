
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteMessageBatchResponse
    {
        /// <summary>
        /// ID of the Message Batch.<br/>
        /// Example: msgbatch_013Zva2CMHLNnXjNJJKqJ2EF
        /// </summary>
        /// <example>msgbatch_013Zva2CMHLNnXjNJJKqJ2EF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Deleted object type.<br/>
        /// For Message Batches, this is always `"message_batch_deleted"`.<br/>
        /// Default Value: message_batch_deleted
        /// </summary>
        /// <default>global::Anthropic.DeleteMessageBatchResponseType.MessageBatchDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.DeleteMessageBatchResponseTypeJsonConverter))]
        public global::Anthropic.DeleteMessageBatchResponseType Type { get; set; } = global::Anthropic.DeleteMessageBatchResponseType.MessageBatchDeleted;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMessageBatchResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the Message Batch.<br/>
        /// Example: msgbatch_013Zva2CMHLNnXjNJJKqJ2EF
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For Message Batches, this is always `"message_batch_deleted"`.<br/>
        /// Default Value: message_batch_deleted
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeleteMessageBatchResponse(
            string id,
            global::Anthropic.DeleteMessageBatchResponseType type = global::Anthropic.DeleteMessageBatchResponseType.MessageBatchDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMessageBatchResponse" /> class.
        /// </summary>
        public DeleteMessageBatchResponse()
        {
        }
    }
}