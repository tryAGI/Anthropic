
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An asynchronous job that reads a memory store and past sessions, then writes a reorganized version of that memory store.<br/>
    /// By default the dream writes its result to a new memory store and doesn't change the input memory store. With `output_behavior` set to `update_existing`, it writes its result into the input memory store instead. The Dreams API is in research preview, so this resource can still change.<br/>
    /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#how-it-works) for what a dream reads and produces.
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
        /// The unique ID of the dream (`drm_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The sources that the dream reads, from the request that created it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput> Inputs { get; set; }

        /// <summary>
        /// The memory store that holds the dream's result, as a one-item array, or an empty array until the dream records that memory store.<br/>
        /// The array is empty while the dream is `pending` and for a short time after it starts `running`. It can stay empty if the dream fails or is canceled before then. The memory store holds the complete result only once `status` is `completed`.<br/>
        /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#use-the-output) for how to review and use the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaDreamOutput> Outputs { get; set; }

        /// <summary>
        /// Where a dream is in its lifecycle.<br/>
        /// `completed`, `failed`, and `canceled` are final: once a dream has one of these statuses, its status doesn't change again.<br/>
        /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#lifecycle) for what each status means.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaDreamStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaDreamStatus Status { get; set; }

        /// <summary>
        /// When the dream was created, in RFC 3339.<br/>
        /// Lists of dreams are sorted by this time, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the dream reached `completed`, `failed`, or `canceled`, in RFC 3339, or `null` if it is still `pending` or `running`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// When the dream was archived, in RFC 3339, or `null` if it hasn't been archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Why the dream failed, or `null` if `status` isn't `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Anthropic.BetaDreamError? Error { get; set; }

        /// <summary>
        /// The model that runs a dream, from the request that created it.<br/>
        /// The dream uses this model for all of its work. The response always gives the model as an object, even if the request gave only a model ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaDreamModelConfig Model { get; set; }

        /// <summary>
        /// The guidance given when the dream was created, or `null` if none was given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The ID of the session that runs the dream (`sesn_...`), or `null` if that session hasn't started.<br/>
        /// Stream that session's events to follow what the dream reads and writes.<br/>
        /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#watch-the-pipeline-run) for how to watch a running dream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The dream's token counts, which stop changing once its `status` is `completed` or `failed`. After a cancel, they can keep changing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaDreamUsage Usage { get; set; }

        /// <summary>
        /// Where the dream writes its result, as set in the request that created the dream. If that request left out `output_behavior`, the dream used the `create_new` behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaOutputBehaviorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaOutputBehavior OutputBehavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDream" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the dream (`drm_...`).
        /// </param>
        /// <param name="inputs">
        /// The sources that the dream reads, from the request that created it.
        /// </param>
        /// <param name="outputs">
        /// The memory store that holds the dream's result, as a one-item array, or an empty array until the dream records that memory store.<br/>
        /// The array is empty while the dream is `pending` and for a short time after it starts `running`. It can stay empty if the dream fails or is canceled before then. The memory store holds the complete result only once `status` is `completed`.<br/>
        /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#use-the-output) for how to review and use the result.
        /// </param>
        /// <param name="status">
        /// Where a dream is in its lifecycle.<br/>
        /// `completed`, `failed`, and `canceled` are final: once a dream has one of these statuses, its status doesn't change again.<br/>
        /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#lifecycle) for what each status means.
        /// </param>
        /// <param name="createdAt">
        /// When the dream was created, in RFC 3339.<br/>
        /// Lists of dreams are sorted by this time, newest first.
        /// </param>
        /// <param name="model">
        /// The model that runs a dream, from the request that created it.<br/>
        /// The dream uses this model for all of its work. The response always gives the model as an object, even if the request gave only a model ID.
        /// </param>
        /// <param name="usage">
        /// The dream's token counts, which stop changing once its `status` is `completed` or `failed`. After a cancel, they can keep changing.
        /// </param>
        /// <param name="outputBehavior">
        /// Where the dream writes its result, as set in the request that created the dream. If that request left out `output_behavior`, the dream used the `create_new` behavior.
        /// </param>
        /// <param name="type"></param>
        /// <param name="endedAt">
        /// When the dream reached `completed`, `failed`, or `canceled`, in RFC 3339, or `null` if it is still `pending` or `running`.
        /// </param>
        /// <param name="archivedAt">
        /// When the dream was archived, in RFC 3339, or `null` if it hasn't been archived.
        /// </param>
        /// <param name="error">
        /// Why the dream failed, or `null` if `status` isn't `failed`.
        /// </param>
        /// <param name="instructions">
        /// The guidance given when the dream was created, or `null` if none was given.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session that runs the dream (`sesn_...`), or `null` if that session hasn't started.<br/>
        /// Stream that session's events to follow what the dream reads and writes.<br/>
        /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#watch-the-pipeline-run) for how to watch a running dream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDream(
            string id,
            global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput> inputs,
            global::System.Collections.Generic.IList<global::Anthropic.BetaDreamOutput> outputs,
            global::Anthropic.BetaDreamStatus status,
            global::System.DateTime createdAt,
            global::Anthropic.BetaDreamModelConfig model,
            global::Anthropic.BetaDreamUsage usage,
            global::Anthropic.BetaOutputBehavior outputBehavior,
            global::Anthropic.BetaDreamType type,
            global::System.DateTime? endedAt,
            global::System.DateTime? archivedAt,
            global::Anthropic.BetaDreamError? error,
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
            this.Error = error;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Instructions = instructions;
            this.SessionId = sessionId;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.OutputBehavior = outputBehavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDream" /> class.
        /// </summary>
        public BetaDream()
        {
        }

    }
}