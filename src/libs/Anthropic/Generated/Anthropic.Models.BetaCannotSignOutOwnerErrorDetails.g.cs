
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The member is an owner or has owner permissions, and this API key or token cannot sign them out. In a Claude Enterprise organization, an API key with the `write:members` scope can.
    /// </summary>
    public sealed partial class BetaCannotSignOutOwnerErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cannot_sign_out_owner"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cannot_sign_out_owner";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutOwnerErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCannotSignOutOwnerErrorDetails(
            string errorCode = "cannot_sign_out_owner")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutOwnerErrorDetails" /> class.
        /// </summary>
        public BetaCannotSignOutOwnerErrorDetails()
        {
        }

    }
}