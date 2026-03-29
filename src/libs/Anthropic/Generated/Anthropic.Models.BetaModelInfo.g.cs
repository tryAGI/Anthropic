
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaModelInfo
    {
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
        /// <param name="capabilities">
        /// Object mapping capability names to their support details. Keys are always present for all known capabilities.
        /// </param>
        /// <param name="maxInputTokens">
        /// Maximum input context window size in tokens for this model.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum value for the `max_tokens` parameter when using this model.
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
            global::Anthropic.BetaModelCapabilities? capabilities,
            int? maxInputTokens,
            int? maxTokens,
            string type = "model")
        {
            this.Capabilities = capabilities;
            this.CreatedAt = createdAt;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MaxInputTokens = maxInputTokens;
            this.MaxTokens = maxTokens;
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