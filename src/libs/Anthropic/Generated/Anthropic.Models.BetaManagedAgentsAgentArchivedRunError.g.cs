
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The deployment's agent was archived.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentArchivedRunError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"agent_archived_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "agent_archived_error";

        /// <summary>
        /// Human-readable error description.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentArchivedRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentArchivedRunError(
            string message,
            string type = "agent_archived_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentArchivedRunError" /> class.
        /// </summary>
        public BetaManagedAgentsAgentArchivedRunError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsAgentArchivedRunError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsAgentArchivedRunError FromMessage(string message)
        {
            return new BetaManagedAgentsAgentArchivedRunError
            {
                Message = message,
            };
        }

    }
}