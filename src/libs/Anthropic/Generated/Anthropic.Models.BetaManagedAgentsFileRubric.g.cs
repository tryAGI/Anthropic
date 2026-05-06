
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Rubric referenced by a file uploaded via the Files API.
    /// </summary>
    public sealed partial class BetaManagedAgentsFileRubric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileRubricTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsFileRubricType Type { get; set; }

        /// <summary>
        /// ID of the rubric file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsFileRubric" /> class.
        /// </summary>
        /// <param name="fileId">
        /// ID of the rubric file.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsFileRubric(
            string fileId,
            global::Anthropic.BetaManagedAgentsFileRubricType type)
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsFileRubric" /> class.
        /// </summary>
        public BetaManagedAgentsFileRubric()
        {
        }
    }
}