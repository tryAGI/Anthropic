
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The error returned with HTTP status 409 when a request's precondition doesn't hold for the memory's current state, such as `precondition` on an update or `expected_content_sha256` on a delete.<br/>
    /// The error doesn't include the memory's current state. Retrieve the memory to see its current content and `content_sha256` before you retry.<br/>
    /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#safe-content-edits-optimistic-concurrency) to learn more about safe content edits with content hash preconditions.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryPreconditionFailedError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"memory_precondition_failed_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "memory_precondition_failed_error";

        /// <summary>
        /// A human-readable explanation of why the precondition failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryPreconditionFailedError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable explanation of why the precondition failed.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryPreconditionFailedError(
            string? message,
            string type = "memory_precondition_failed_error")
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryPreconditionFailedError" /> class.
        /// </summary>
        public BetaManagedAgentsMemoryPreconditionFailedError()
        {
        }

    }
}