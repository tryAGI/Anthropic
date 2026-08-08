
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An asynchronous memory-consolidation job that reads a memory store plus a set of session transcripts and writes consolidated memories into a new output memory store. The Dreams API is in research preview: the request and response shapes are volatile and may change without the deprecation period that applies to generally-available endpoints.
    /// </summary>
    public sealed partial class BetaDream
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaDreamTypeJsonConverter))]
        public global::Anthropic.BetaDreamType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaDreamOutput> Outputs { get; set; }

        /// <summary>
        /// Lifecycle status of a Dream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaDreamStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaDreamStatus Status { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndedAt { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ArchivedAt { get; set; }

        /// <summary>
        /// Failure detail for a Dream whose `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaDreamError Error { get; set; }

        /// <summary>
        /// Model identifier and configuration applied to every pipeline stage. Same wire shape as the Agents API ModelConfig.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaDreamModelConfig Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Cumulative token usage for the dream across every pipeline stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaDreamUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDream" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="status">
        /// Lifecycle status of a Dream.
        /// </param>
        /// <param name="createdAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="endedAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="archivedAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="error">
        /// Failure detail for a Dream whose `status` is `failed`.
        /// </param>
        /// <param name="model">
        /// Model identifier and configuration applied to every pipeline stage. Same wire shape as the Agents API ModelConfig.
        /// </param>
        /// <param name="usage">
        /// Cumulative token usage for the dream across every pipeline stage.
        /// </param>
        /// <param name="type"></param>
        /// <param name="instructions"></param>
        /// <param name="sessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDream(
            string id,
            global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput> inputs,
            global::System.Collections.Generic.IList<global::Anthropic.BetaDreamOutput> outputs,
            global::Anthropic.BetaDreamStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime endedAt,
            global::System.DateTime archivedAt,
            global::Anthropic.BetaDreamError error,
            global::Anthropic.BetaDreamModelConfig model,
            global::Anthropic.BetaDreamUsage usage,
            global::Anthropic.BetaDreamType type,
            string? instructions,
            string? sessionId)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.EndedAt = endedAt;
            this.ArchivedAt = archivedAt;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Instructions = instructions;
            this.SessionId = sessionId;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDream" /> class.
        /// </summary>
        public BetaDream()
        {
        }

    }
}