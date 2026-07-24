
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A file mounted into each session's container.
    /// </summary>
    public sealed partial class BetaManagedAgentsFileResourceConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileResourceConfigTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsFileResourceConfigType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsFileResourceConfig" /> class.
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
        public BetaManagedAgentsFileResourceConfig(
            string fileId,
            global::Anthropic.BetaManagedAgentsFileResourceConfigType type,
            string? mountPath)
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.MountPath = mountPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsFileResourceConfig" /> class.
        /// </summary>
        public BetaManagedAgentsFileResourceConfig()
        {
        }

    }
}