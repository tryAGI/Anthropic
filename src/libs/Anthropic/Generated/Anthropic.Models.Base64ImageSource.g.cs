
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Base64ImageSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Base64ImageSourceMediaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Base64ImageSourceMediaType MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"base64"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "base64";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Base64ImageSource" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="mediaType"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Base64ImageSource(
            byte[] data,
            global::Anthropic.Base64ImageSourceMediaType mediaType,
            string type = "base64")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MediaType = mediaType;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Base64ImageSource" /> class.
        /// </summary>
        public Base64ImageSource()
        {
        }
    }
}