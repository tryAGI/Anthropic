
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The RBAC Group is not one of the organization's groups.
    /// </summary>
    public sealed partial class BetaRbacGroupNotFoundErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"rbac_group_not_found"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "rbac_group_not_found";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacGroupNotFoundErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRbacGroupNotFoundErrorDetails(
            string errorCode = "rbac_group_not_found")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacGroupNotFoundErrorDetails" /> class.
        /// </summary>
        public BetaRbacGroupNotFoundErrorDetails()
        {
        }

    }
}