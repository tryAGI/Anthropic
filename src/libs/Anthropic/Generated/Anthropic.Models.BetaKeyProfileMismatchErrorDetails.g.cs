
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The External Key is bound to a user profile, and the Workspace does not have that user profile. A Workspace can use only a key bound to its own user profile or a key that isn't bound to one.
    /// </summary>
    public sealed partial class BetaKeyProfileMismatchErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"key_profile_mismatch"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "key_profile_mismatch";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaKeyProfileMismatchErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaKeyProfileMismatchErrorDetails(
            string errorCode = "key_profile_mismatch")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaKeyProfileMismatchErrorDetails" /> class.
        /// </summary>
        public BetaKeyProfileMismatchErrorDetails()
        {
        }

    }
}