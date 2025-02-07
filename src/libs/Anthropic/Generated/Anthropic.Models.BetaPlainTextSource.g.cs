
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaPlainTextSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaPlainTextSourceTypeJsonConverter))]
        public global::Anthropic.BetaPlainTextSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaPlainTextSourceMediaTypeJsonConverter))]
        public global::Anthropic.BetaPlainTextSourceMediaType MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPlainTextSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="mediaType"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPlainTextSource(
            string data,
            global::Anthropic.BetaPlainTextSourceType type,
            global::Anthropic.BetaPlainTextSourceMediaType mediaType)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
            this.MediaType = mediaType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPlainTextSource" /> class.
        /// </summary>
        public BetaPlainTextSource()
        {
        }
    }
}