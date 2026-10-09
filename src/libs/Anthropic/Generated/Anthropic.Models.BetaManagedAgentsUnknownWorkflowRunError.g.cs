
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A failure that has no type of its own.<br/>
    /// Example: {"type":"unknown_error","message":"The workflow run failed."}
    /// </summary>
    public sealed partial class BetaManagedAgentsUnknownWorkflowRunError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"unknown_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "unknown_error";

        /// <summary>
        /// Short explanation written by the server. It never contains content from the run or its agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUnknownWorkflowRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Short explanation written by the server. It never contains content from the run or its agents.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUnknownWorkflowRunError(
            string message,
            string type = "unknown_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUnknownWorkflowRunError" /> class.
        /// </summary>
        public BetaManagedAgentsUnknownWorkflowRunError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsUnknownWorkflowRunError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsUnknownWorkflowRunError FromMessage(string message)
        {
            return new BetaManagedAgentsUnknownWorkflowRunError
            {
                Message = message,
            };
        }

    }
}