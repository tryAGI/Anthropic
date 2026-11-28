
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has not approved External Storage for the organization, for the Workspace or, for storage bound to a user profile, for that user profile. Contact your Anthropic account team.
    /// </summary>
    public sealed partial class BetaGrantRequiredErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"grant_required"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "grant_required";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGrantRequiredErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGrantRequiredErrorDetails(
            string errorCode = "grant_required")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGrantRequiredErrorDetails" /> class.
        /// </summary>
        public BetaGrantRequiredErrorDetails()
        {
        }

    }
}