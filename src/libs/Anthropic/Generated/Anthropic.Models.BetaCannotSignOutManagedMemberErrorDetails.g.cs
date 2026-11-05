
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// On a public-sector deployment, only an API key or token that belongs to a person with owner permissions can sign out a member with the `managed` role.
    /// </summary>
    public sealed partial class BetaCannotSignOutManagedMemberErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cannot_sign_out_managed_member"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cannot_sign_out_managed_member";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutManagedMemberErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCannotSignOutManagedMemberErrorDetails(
            string errorCode = "cannot_sign_out_managed_member")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutManagedMemberErrorDetails" /> class.
        /// </summary>
        public BetaCannotSignOutManagedMemberErrorDetails()
        {
        }

    }
}