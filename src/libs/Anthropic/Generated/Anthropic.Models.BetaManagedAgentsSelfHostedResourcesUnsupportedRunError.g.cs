
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The deployment configures resources, but its environment is self-hosted and cannot mount them.
    /// </summary>
    public sealed partial class BetaManagedAgentsSelfHostedResourcesUnsupportedRunError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"self_hosted_resources_unsupported_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "self_hosted_resources_unsupported_error";

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSelfHostedResourcesUnsupportedRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSelfHostedResourcesUnsupportedRunError(
            string message,
            string type = "self_hosted_resources_unsupported_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSelfHostedResourcesUnsupportedRunError" /> class.
        /// </summary>
        public BetaManagedAgentsSelfHostedResourcesUnsupportedRunError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsSelfHostedResourcesUnsupportedRunError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsSelfHostedResourcesUnsupportedRunError FromMessage(string message)
        {
            return new BetaManagedAgentsSelfHostedResourcesUnsupportedRunError
            {
                Message = message,
            };
        }

    }
}