
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileMetadataSchema
    {
        /// <summary>
        /// RFC 3339 datetime string representing when the file was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Whether the file can be downloaded.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// Original filename of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// MIME type of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// Size of the file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeBytes { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For files, this is always `"file"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.FileMetadataSchemaTypeJsonConverter))]
        public global::Anthropic.FileMetadataSchemaType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMetadataSchema" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339 datetime string representing when the file was created.
        /// </param>
        /// <param name="downloadable">
        /// Whether the file can be downloaded.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filename">
        /// Original filename of the uploaded file.
        /// </param>
        /// <param name="id">
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the file.
        /// </param>
        /// <param name="sizeBytes">
        /// Size of the file in bytes.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For files, this is always `"file"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileMetadataSchema(
            global::System.DateTime createdAt,
            string filename,
            string id,
            string mimeType,
            int sizeBytes,
            bool? downloadable,
            global::Anthropic.FileMetadataSchemaType type)
        {
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.SizeBytes = sizeBytes;
            this.Downloadable = downloadable;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMetadataSchema" /> class.
        /// </summary>
        public FileMetadataSchema()
        {
        }
    }
}