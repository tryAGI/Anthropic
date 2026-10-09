
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A pending invite already exists for the email address. The message names the invite.
    /// </summary>
    public sealed partial class InviteAlreadyExistsErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"invite_already_exists"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "invite_already_exists";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteAlreadyExistsErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InviteAlreadyExistsErrorDetails(
            string errorCode = "invite_already_exists")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteAlreadyExistsErrorDetails" /> class.
        /// </summary>
        public InviteAlreadyExistsErrorDetails()
        {
        }

    }
}