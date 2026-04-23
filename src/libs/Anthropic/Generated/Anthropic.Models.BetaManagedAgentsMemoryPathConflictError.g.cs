
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryPathConflictError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryPathConflictErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMemoryPathConflictErrorType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conflicting_path")]
        public string? ConflictingPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conflicting_memory_id")]
        public string? ConflictingMemoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryPathConflictError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <param name="conflictingPath"></param>
        /// <param name="conflictingMemoryId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryPathConflictError(
            global::Anthropic.BetaManagedAgentsMemoryPathConflictErrorType type,
            string? message,
            string? conflictingPath,
            string? conflictingMemoryId)
        {
            this.Type = type;
            this.Message = message;
            this.ConflictingPath = conflictingPath;
            this.ConflictingMemoryId = conflictingMemoryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryPathConflictError" /> class.
        /// </summary>
        public BetaManagedAgentsMemoryPathConflictError()
        {
        }
    }
}