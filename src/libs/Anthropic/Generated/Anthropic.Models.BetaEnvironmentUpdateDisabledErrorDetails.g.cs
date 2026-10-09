
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has turned off updating environments for this organization. Existing environments still work as they are.
    /// </summary>
    public sealed partial class BetaEnvironmentUpdateDisabledErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"environment_update_disabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "environment_update_disabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnvironmentUpdateDisabledErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaEnvironmentUpdateDisabledErrorDetails(
            string errorCode = "environment_update_disabled")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnvironmentUpdateDisabledErrorDetails" /> class.
        /// </summary>
        public BetaEnvironmentUpdateDisabledErrorDetails()
        {
        }

    }
}