
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The member is the user the API key or token belongs to.
    /// </summary>
    public sealed partial class BetaCannotSignOutSelfErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cannot_sign_out_self"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cannot_sign_out_self";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutSelfErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCannotSignOutSelfErrorDetails(
            string errorCode = "cannot_sign_out_self")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutSelfErrorDetails" /> class.
        /// </summary>
        public BetaCannotSignOutSelfErrorDetails()
        {
        }

    }
}