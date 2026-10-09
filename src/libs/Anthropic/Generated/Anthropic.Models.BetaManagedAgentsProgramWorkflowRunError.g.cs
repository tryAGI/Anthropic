
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The plan, a program that the agent wrote, failed, or the server refused it.<br/>
    /// Example: {"type":"program_error","message":"The workflow run\u0027s plan failed."}
    /// </summary>
    public sealed partial class BetaManagedAgentsProgramWorkflowRunError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"program_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "program_error";

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsProgramWorkflowRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Short explanation written by the server. It never contains content from the run or its agents.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsProgramWorkflowRunError(
            string message,
            string type = "program_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsProgramWorkflowRunError" /> class.
        /// </summary>
        public BetaManagedAgentsProgramWorkflowRunError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsProgramWorkflowRunError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsProgramWorkflowRunError FromMessage(string message)
        {
            return new BetaManagedAgentsProgramWorkflowRunError
            {
                Message = message,
            };
        }

    }
}