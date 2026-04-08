
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Base64-encoded image data.
    /// </summary>
    public sealed partial class BetaManagedAgentsBase64ImageSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBase64ImageSourceTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsBase64ImageSourceType Type { get; set; }

        /// <summary>
        /// MIME type of the image (e.g., "image/png", "image/jpeg", "image/gif", "image/webp").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// Base64-encoded image data.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsBase64ImageSource" /> class.
        /// </summary>
        /// <param name="mediaType">
        /// MIME type of the image (e.g., "image/png", "image/jpeg", "image/gif", "image/webp").
        /// </param>
        /// <param name="data">
        /// Base64-encoded image data.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsBase64ImageSource(
            string mediaType,
            string data,
            global::Anthropic.BetaManagedAgentsBase64ImageSourceType type)
        {
            this.Type = type;
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsBase64ImageSource" /> class.
        /// </summary>
        public BetaManagedAgentsBase64ImageSource()
        {
        }
    }
}