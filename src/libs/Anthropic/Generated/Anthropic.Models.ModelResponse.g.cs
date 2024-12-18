
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelResponse
    {
        /// <summary>
        /// Object type.<br/>
        /// For Models, this is always `"model"`.<br/>
        /// Default Value: model
        /// </summary>
        /// <default>global::Anthropic.ModelResponseType.Model</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ModelResponseTypeJsonConverter))]
        public global::Anthropic.ModelResponseType Type { get; set; } = global::Anthropic.ModelResponseType.Model;

        /// <summary>
        /// Unique model identifier.<br/>
        /// Example: claude-3-5-sonnet-20241022
        /// </summary>
        /// <example>claude-3-5-sonnet-20241022</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A human-readable name for the model.<br/>
        /// Example: Claude 3.5 Sonnet (New)
        /// </summary>
        /// <example>Claude 3.5 Sonnet (New)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the model was released. May be set to an epoch value if the release date is unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Object type.<br/>
        /// For Models, this is always `"model"`.<br/>
        /// Default Value: model
        /// </param>
        /// <param name="id">
        /// Unique model identifier.<br/>
        /// Example: claude-3-5-sonnet-20241022
        /// </param>
        /// <param name="displayName">
        /// A human-readable name for the model.<br/>
        /// Example: Claude 3.5 Sonnet (New)
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 datetime string representing the time at which the model was released. May be set to an epoch value if the release date is unknown.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelResponse(
            string id,
            string displayName,
            global::System.DateTime createdAt,
            global::Anthropic.ModelResponseType type = global::Anthropic.ModelResponseType.Model)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.CreatedAt = createdAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponse" /> class.
        /// </summary>
        public ModelResponse()
        {
        }
    }
}