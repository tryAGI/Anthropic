
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaModelInfo
    {
        /// <summary>
        /// Model IDs this model accepts as `fallbacks[i].model` on the Messages API. An empty list means the `fallbacks` parameter is not supported for this model as primary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_fallback_models")]
        public global::System.Collections.Generic.IList<string>? AllowedFallbackModels { get; set; }

        /// <summary>
        /// Object mapping capability names to their support details. Keys are always present for all known capabilities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Anthropic.BetaModelCapabilities? Capabilities { get; set; }

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the model was released. May be set to an epoch value if the release date is unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string representing the time of the model's most recent deprecation. Populated for `deprecated` and `retired` models; `null` while the model is `active`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated_at")]
        public global::System.DateTime? DeprecatedAt { get; set; }

        /// <summary>
        /// A human-readable name for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Unique model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The model's current lifecycle stage.<br/>
        /// - `active`: The model is available for use, open to new adopters, and not scheduled for retirement.<br/>
        /// - `deprecated`: The model remains callable for organizations with existing access, but is headed for retirement and closed to new adopters.<br/>
        /// - `retired`: The model is no longer available for use; inference requests naming it fail. It remains in the catalogue as the historical record of its retirement.<br/>
        /// Default Value: active
        /// </summary>
        /// <default>global::Anthropic.BetaModelInfoLifecycle.Active</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaModelInfoLifecycleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaModelInfoLifecycle Lifecycle { get; set; } = global::Anthropic.BetaModelInfoLifecycle.Active;

        /// <summary>
        /// The model line this model belongs to, such as `opus` for both Claude Opus 4.5 and Claude Opus 4.6. More lines may be added. `null` when the model belongs to no line; do not infer a line from the `id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public global::Anthropic.BetaModelLine? Line { get; set; }

        /// <summary>
        /// Maximum input context window size in tokens for this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_input_tokens")]
        public int? MaxInputTokens { get; set; }

        /// <summary>
        /// Maximum value for the `max_tokens` parameter when using this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// RFC 3339 datetime string representing the model's currently scheduled retirement date. The schedule can be revised until retirement occurs; `null` while the model is `active` or while no retirement is scheduled. A past date on a `deprecated` model means retirement is overdue, not that it has occurred: `lifecycle` is the retirement signal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retires_at")]
        public global::System.DateTime? RetiresAt { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Models, this is always `"model"`.<br/>
        /// Default Value: model
        /// </summary>
        /// <default>"model"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "model";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaModelInfo" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339 datetime string representing the time at which the model was released. May be set to an epoch value if the release date is unknown.
        /// </param>
        /// <param name="displayName">
        /// A human-readable name for the model.
        /// </param>
        /// <param name="id">
        /// Unique model identifier.
        /// </param>
        /// <param name="lifecycle">
        /// The model's current lifecycle stage.<br/>
        /// - `active`: The model is available for use, open to new adopters, and not scheduled for retirement.<br/>
        /// - `deprecated`: The model remains callable for organizations with existing access, but is headed for retirement and closed to new adopters.<br/>
        /// - `retired`: The model is no longer available for use; inference requests naming it fail. It remains in the catalogue as the historical record of its retirement.<br/>
        /// Default Value: active
        /// </param>
        /// <param name="allowedFallbackModels">
        /// Model IDs this model accepts as `fallbacks[i].model` on the Messages API. An empty list means the `fallbacks` parameter is not supported for this model as primary.
        /// </param>
        /// <param name="capabilities">
        /// Object mapping capability names to their support details. Keys are always present for all known capabilities.
        /// </param>
        /// <param name="deprecatedAt">
        /// RFC 3339 datetime string representing the time of the model's most recent deprecation. Populated for `deprecated` and `retired` models; `null` while the model is `active`.
        /// </param>
        /// <param name="line">
        /// The model line this model belongs to, such as `opus` for both Claude Opus 4.5 and Claude Opus 4.6. More lines may be added. `null` when the model belongs to no line; do not infer a line from the `id`.
        /// </param>
        /// <param name="maxInputTokens">
        /// Maximum input context window size in tokens for this model.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum value for the `max_tokens` parameter when using this model.
        /// </param>
        /// <param name="retiresAt">
        /// RFC 3339 datetime string representing the model's currently scheduled retirement date. The schedule can be revised until retirement occurs; `null` while the model is `active` or while no retirement is scheduled. A past date on a `deprecated` model means retirement is overdue, not that it has occurred: `lifecycle` is the retirement signal.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Models, this is always `"model"`.<br/>
        /// Default Value: model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaModelInfo(
            global::System.DateTime createdAt,
            string displayName,
            string id,
            global::Anthropic.BetaModelInfoLifecycle lifecycle,
            global::System.Collections.Generic.IList<string>? allowedFallbackModels,
            global::Anthropic.BetaModelCapabilities? capabilities,
            global::System.DateTime? deprecatedAt,
            global::Anthropic.BetaModelLine? line,
            int? maxInputTokens,
            int? maxTokens,
            global::System.DateTime? retiresAt,
            string type = "model")
        {
            this.AllowedFallbackModels = allowedFallbackModels;
            this.Capabilities = capabilities;
            this.CreatedAt = createdAt;
            this.DeprecatedAt = deprecatedAt;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Lifecycle = lifecycle;
            this.Line = line;
            this.MaxInputTokens = maxInputTokens;
            this.MaxTokens = maxTokens;
            this.RetiresAt = retiresAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaModelInfo" /> class.
        /// </summary>
        public BetaModelInfo()
        {
        }

    }
}