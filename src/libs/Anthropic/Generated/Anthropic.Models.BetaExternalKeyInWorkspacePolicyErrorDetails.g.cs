
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The External Key can't be deleted or reconfigured while the organization's Workspace Policy lists it as an allowed key.
    /// </summary>
    public sealed partial class BetaExternalKeyInWorkspacePolicyErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_key_in_workspace_policy"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "external_key_in_workspace_policy";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKeyInWorkspacePolicyErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalKeyInWorkspacePolicyErrorDetails(
            string errorCode = "external_key_in_workspace_policy")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKeyInWorkspacePolicyErrorDetails" /> class.
        /// </summary>
        public BetaExternalKeyInWorkspacePolicyErrorDetails()
        {
        }

    }
}