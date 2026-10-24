
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A vault referenced by the deployment no longer exists.
    /// </summary>
    public sealed partial class BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"vault_not_found_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "vault_not_found_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError(
            string type = "vault_not_found_error")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError" /> class.
        /// </summary>
        public BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError()
        {
        }

    }
}