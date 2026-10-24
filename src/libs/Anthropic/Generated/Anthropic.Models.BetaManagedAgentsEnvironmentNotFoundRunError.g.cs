
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The deployment's environment no longer exists.
    /// </summary>
    public sealed partial class BetaManagedAgentsEnvironmentNotFoundRunError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"environment_not_found_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "environment_not_found_error";

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEnvironmentNotFoundRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEnvironmentNotFoundRunError(
            string message,
            string type = "environment_not_found_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEnvironmentNotFoundRunError" /> class.
        /// </summary>
        public BetaManagedAgentsEnvironmentNotFoundRunError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsEnvironmentNotFoundRunError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsEnvironmentNotFoundRunError FromMessage(string message)
        {
            return new BetaManagedAgentsEnvironmentNotFoundRunError
            {
                Message = message,
            };
        }

    }
}