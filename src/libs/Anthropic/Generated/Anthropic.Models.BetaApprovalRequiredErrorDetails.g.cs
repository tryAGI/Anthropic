
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Turning human review off needs Anthropic's approval for the organization, and the organization doesn't have it. Contact Anthropic support to request approval.
    /// </summary>
    public sealed partial class BetaApprovalRequiredErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"approval_required"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "approval_required";

        /// <summary>
        /// The request field that needs the approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApprovalRequiredErrorDetails" /> class.
        /// </summary>
        /// <param name="field">
        /// The request field that needs the approval.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApprovalRequiredErrorDetails(
            string field,
            string errorCode = "approval_required")
        {
            this.ErrorCode = errorCode;
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApprovalRequiredErrorDetails" /> class.
        /// </summary>
        public BetaApprovalRequiredErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaApprovalRequiredErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaApprovalRequiredErrorDetails FromField(string field)
        {
            return new BetaApprovalRequiredErrorDetails
            {
                Field = field,
            };
        }

    }
}