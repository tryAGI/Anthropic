
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A record of an organization's messages that Anthropic flagged and sent to the organization to review. It lists the messages by ID and doesn't include their content.
    /// </summary>
    public sealed partial class BetaComplianceReviewCase
    {
        /// <summary>
        /// The object type, always `compliance_review_case`.
        /// </summary>
        /// <default>"compliance_review_case"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "compliance_review_case";

        /// <summary>
        /// The unique ID of the case (`rvc_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The UUID of the organization that sent the flagged messages, which the case belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Whether Anthropic is still waiting for a response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaComplianceReviewCaseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComplianceReviewCaseStatus Status { get; set; }

        /// <summary>
        /// When Anthropic sent the case. The time you have to respond starts here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the case last changed. It changes when Anthropic sends the case, when the case closes, and when Anthropic sends a notice about the case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The ID of the workspace that sent the flagged messages (`wrkspc_...`). Null when the messages have no workspace, and it can be null for the default workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Anthropic's labels for why the messages were flagged, such as `cyber` or `fraud`. There is at least one. New values can appear, so accept a value that you don't know.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewPolicyCategory> PolicyCategories { get; set; }

        /// <summary>
        /// The action that Anthropic took before it sent the case. Null when it took none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement_action")]
        public global::Anthropic.BetaComplianceReviewEnforcementAction? EnforcementAction { get; set; }

        /// <summary>
        /// The flagged messages. There is at least one, and the list isn't paginated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcripts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewTranscript> Transcripts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewCase" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the case (`rvc_...`).
        /// </param>
        /// <param name="organizationId">
        /// The UUID of the organization that sent the flagged messages, which the case belongs to.
        /// </param>
        /// <param name="status">
        /// Whether Anthropic is still waiting for a response.
        /// </param>
        /// <param name="createdAt">
        /// When Anthropic sent the case. The time you have to respond starts here.
        /// </param>
        /// <param name="updatedAt">
        /// When the case last changed. It changes when Anthropic sends the case, when the case closes, and when Anthropic sends a notice about the case.
        /// </param>
        /// <param name="policyCategories">
        /// Anthropic's labels for why the messages were flagged, such as `cyber` or `fraud`. There is at least one. New values can appear, so accept a value that you don't know.
        /// </param>
        /// <param name="transcripts">
        /// The flagged messages. There is at least one, and the list isn't paginated.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace that sent the flagged messages (`wrkspc_...`). Null when the messages have no workspace, and it can be null for the default workspace.
        /// </param>
        /// <param name="enforcementAction">
        /// The action that Anthropic took before it sent the case. Null when it took none.
        /// </param>
        /// <param name="type">
        /// The object type, always `compliance_review_case`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewCase(
            string id,
            string organizationId,
            global::Anthropic.BetaComplianceReviewCaseStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewPolicyCategory> policyCategories,
            global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewTranscript> transcripts,
            string? workspaceId,
            global::Anthropic.BetaComplianceReviewEnforcementAction? enforcementAction,
            string type = "compliance_review_case")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.WorkspaceId = workspaceId;
            this.PolicyCategories = policyCategories ?? throw new global::System.ArgumentNullException(nameof(policyCategories));
            this.EnforcementAction = enforcementAction;
            this.Transcripts = transcripts ?? throw new global::System.ArgumentNullException(nameof(transcripts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewCase" /> class.
        /// </summary>
        public BetaComplianceReviewCase()
        {
        }

    }
}