
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A message from Anthropic to an organization about its review cases or about the organization as a whole, such as a request to respond by a date, a warning, or a question. A notice doesn't change after Anthropic sends it.
    /// </summary>
    public sealed partial class BetaComplianceReviewNotice
    {
        /// <summary>
        /// The object type, always `compliance_review_notice`.
        /// </summary>
        /// <default>"compliance_review_notice"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "compliance_review_notice";

        /// <summary>
        /// The unique ID of the notice (`rvn_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The UUID of the organization that the notice is for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// The IDs of the cases that the notice is about (`rvc_...`). Empty when the notice is about the whole organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CaseIds { get; set; }

        /// <summary>
        /// What kind of notice this is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComplianceReviewNoticeKind Kind { get; set; }

        /// <summary>
        /// When Anthropic sent the notice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The text of the notice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The time by which Anthropic asks for an answer. Null when there is no deadline. Missing it changes nothing on a case, and the time to respond to a case can end before it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respond_by")]
        public global::System.DateTime? RespondBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewNotice" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the notice (`rvn_...`).
        /// </param>
        /// <param name="organizationId">
        /// The UUID of the organization that the notice is for.
        /// </param>
        /// <param name="caseIds">
        /// The IDs of the cases that the notice is about (`rvc_...`). Empty when the notice is about the whole organization.
        /// </param>
        /// <param name="kind">
        /// What kind of notice this is.
        /// </param>
        /// <param name="createdAt">
        /// When Anthropic sent the notice.
        /// </param>
        /// <param name="message">
        /// The text of the notice.
        /// </param>
        /// <param name="respondBy">
        /// The time by which Anthropic asks for an answer. Null when there is no deadline. Missing it changes nothing on a case, and the time to respond to a case can end before it.
        /// </param>
        /// <param name="type">
        /// The object type, always `compliance_review_notice`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewNotice(
            string id,
            string organizationId,
            global::System.Collections.Generic.IList<string> caseIds,
            global::Anthropic.BetaComplianceReviewNoticeKind kind,
            global::System.DateTime createdAt,
            string message,
            global::System.DateTime? respondBy,
            string type = "compliance_review_notice")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.CaseIds = caseIds ?? throw new global::System.ArgumentNullException(nameof(caseIds));
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.CreatedAt = createdAt;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RespondBy = respondBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewNotice" /> class.
        /// </summary>
        public BetaComplianceReviewNotice()
        {
        }

    }
}