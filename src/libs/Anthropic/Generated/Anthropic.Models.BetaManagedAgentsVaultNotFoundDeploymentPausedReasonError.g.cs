
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonErrorType Type { get; set; }

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
            global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonErrorType type)
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