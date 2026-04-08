
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Mount a file uploaded via the Files API into the session.<br/>
    /// Example: {"type":"file","file_id":"file_011CNha8iCJcU1wXNR6q4V8w","mount_path":"/uploads/receipt.pdf"}
    /// </summary>
    public sealed partial class BetaManagedAgentsFileResourceParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileResourceParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsFileResourceParamsType Type { get; set; }

        /// <summary>
        /// ID of a previously uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Mount path in the container. Defaults to `/mnt/session/uploads/&lt;file_id&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        public string? MountPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsFileResourceParams" /> class.
        /// </summary>
        /// <param name="fileId">
        /// ID of a previously uploaded file.
        /// </param>
        /// <param name="type"></param>
        /// <param name="mountPath">
        /// Mount path in the container. Defaults to `/mnt/session/uploads/&lt;file_id&gt;`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsFileResourceParams(
            string fileId,
            global::Anthropic.BetaManagedAgentsFileResourceParamsType type,
            string? mountPath)
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.MountPath = mountPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsFileResourceParams" /> class.
        /// </summary>
        public BetaManagedAgentsFileResourceParams()
        {
        }
    }
}