
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Rubric referenced by a file uploaded via the Files API.<br/>
    /// Example: {"type":"file","file_id":"file_011CNha8iCJcU1wXNR6q4V8w"}
    /// </summary>
    public sealed partial class BetaManagedAgentsFileRubricParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsFileRubricParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsFileRubricParamsType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsFileRubricParams" /> class.
        /// </summary>
        /// <param name="fileId">
        /// ID of the rubric file.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsFileRubricParams(
            string fileId,
            global::Anthropic.BetaManagedAgentsFileRubricParamsType type)
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsFileRubricParams" /> class.
        /// </summary>
        public BetaManagedAgentsFileRubricParams()
        {
        }
    }
}