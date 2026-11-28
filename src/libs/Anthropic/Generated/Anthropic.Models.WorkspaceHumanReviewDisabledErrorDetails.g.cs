
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request's Workspace has Human Review turned off, and this operation is not available there. Use a Workspace with Human Review on.
    /// </summary>
    public sealed partial class WorkspaceHumanReviewDisabledErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workspace_human_review_disabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "workspace_human_review_disabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceHumanReviewDisabledErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceHumanReviewDisabledErrorDetails(
            string errorCode = "workspace_human_review_disabled")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceHumanReviewDisabledErrorDetails" /> class.
        /// </summary>
        public WorkspaceHumanReviewDisabledErrorDetails()
        {
        }

    }
}