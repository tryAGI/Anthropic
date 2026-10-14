
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The Anthropic-managed service account as returned in API responses.
    /// </summary>
    public sealed partial class BetaManagedAgentsServiceAccountExecutionIdentity
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"service_account"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "service_account";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsServiceAccountExecutionIdentity" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsServiceAccountExecutionIdentity(
            string type = "service_account")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsServiceAccountExecutionIdentity" /> class.
        /// </summary>
        public BetaManagedAgentsServiceAccountExecutionIdentity()
        {
        }

    }
}