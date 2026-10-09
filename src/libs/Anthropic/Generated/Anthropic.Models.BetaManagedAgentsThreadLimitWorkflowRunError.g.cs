
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The run exceeded the limit on the number of threads that a run can create.<br/>
    /// Example: {"type":"thread_limit_error","message":"The workflow run exceeded its limit of threads."}
    /// </summary>
    public sealed partial class BetaManagedAgentsThreadLimitWorkflowRunError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread_limit_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "thread_limit_error";

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsThreadLimitWorkflowRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Short explanation written by the server. It never contains content from the run or its agents.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsThreadLimitWorkflowRunError(
            string message,
            string type = "thread_limit_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsThreadLimitWorkflowRunError" /> class.
        /// </summary>
        public BetaManagedAgentsThreadLimitWorkflowRunError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsThreadLimitWorkflowRunError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsThreadLimitWorkflowRunError FromMessage(string message)
        {
            return new BetaManagedAgentsThreadLimitWorkflowRunError
            {
                Message = message,
            };
        }

    }
}