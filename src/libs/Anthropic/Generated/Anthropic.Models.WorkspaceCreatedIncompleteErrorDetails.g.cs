
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The Workspace was created, but some of what the request asked for did not take effect, or may not have. Don't send the create again. The error's `message` says what to do with the Workspace at `workspace_id`.
    /// </summary>
    public sealed partial class WorkspaceCreatedIncompleteErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workspace_created_incomplete"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "workspace_created_incomplete";

        /// <summary>
        /// ID of the Workspace the request created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreatedIncompleteErrorDetails" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the Workspace the request created.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceCreatedIncompleteErrorDetails(
            string workspaceId,
            string errorCode = "workspace_created_incomplete")
        {
            this.ErrorCode = errorCode;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreatedIncompleteErrorDetails" /> class.
        /// </summary>
        public WorkspaceCreatedIncompleteErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="WorkspaceCreatedIncompleteErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static WorkspaceCreatedIncompleteErrorDetails FromWorkspaceId(string workspaceId)
        {
            return new WorkspaceCreatedIncompleteErrorDetails
            {
                WorkspaceId = workspaceId,
            };
        }

    }
}