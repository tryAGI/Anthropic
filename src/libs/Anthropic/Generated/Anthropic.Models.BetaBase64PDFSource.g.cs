
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaBase64PDFSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public byte[] Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"application/pdf"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public string MediaType { get; set; } = "application/pdf";

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
        /// Initializes a new instance of the <see cref="BetaBase64PDFSource" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="mediaType"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBase64PDFSource(
            byte[] data,
            string mediaType = "application/pdf",
            string type = "base64")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MediaType = mediaType;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBase64PDFSource" /> class.
        /// </summary>
        public BetaBase64PDFSource()
        {
        }
    }
}