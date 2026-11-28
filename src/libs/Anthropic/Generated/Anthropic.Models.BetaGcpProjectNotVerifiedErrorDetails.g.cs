
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization has not proved that it owns the Google Cloud project that holds the key or bucket. The message names the field.
    /// </summary>
    public sealed partial class BetaGcpProjectNotVerifiedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"gcp_project_not_verified"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "gcp_project_not_verified";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGcpProjectNotVerifiedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGcpProjectNotVerifiedErrorDetails(
            string errorCode = "gcp_project_not_verified")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGcpProjectNotVerifiedErrorDetails" /> class.
        /// </summary>
        public BetaGcpProjectNotVerifiedErrorDetails()
        {
        }

    }
}