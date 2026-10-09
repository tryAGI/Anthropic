
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The user is the organization's only member. Add another member before removing this one.
    /// </summary>
    public sealed partial class CannotRemoveLastMemberErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cannot_remove_last_member"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cannot_remove_last_member";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CannotRemoveLastMemberErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CannotRemoveLastMemberErrorDetails(
            string errorCode = "cannot_remove_last_member")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CannotRemoveLastMemberErrorDetails" /> class.
        /// </summary>
        public CannotRemoveLastMemberErrorDetails()
        {
        }

    }
}