
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The member is the organization's primary owner, whom no API key or token can sign out.
    /// </summary>
    public sealed partial class BetaCannotSignOutPrimaryOwnerErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cannot_sign_out_primary_owner"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cannot_sign_out_primary_owner";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutPrimaryOwnerErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCannotSignOutPrimaryOwnerErrorDetails(
            string errorCode = "cannot_sign_out_primary_owner")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutPrimaryOwnerErrorDetails" /> class.
        /// </summary>
        public BetaCannotSignOutPrimaryOwnerErrorDetails()
        {
        }

    }
}