
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One stored item that the organization it belongs to can read for review.
    /// </summary>
    public sealed partial class BetaComplianceReviewItem
    {
        /// <summary>
        /// The object type, always `compliance_review_item`.
        /// </summary>
        /// <default>"compliance_review_item"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "compliance_review_item";

        /// <summary>
        /// The ID of the item. For a message, its own ID, such as `msg_...`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The UUID of the organization that the item belongs to. For a message, the organization that sent it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// For a message, when Anthropic received the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Read the item, and save any copy you need, by this time. The item can stop being readable sooner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ContentExpiresAt { get; set; }

        /// <summary>
        /// The ID of the workspace (`wrkspc_...`). Null when the item isn't attributed to a workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// For a message, who sent it. Null when no sender was recorded. New types can appear, so accept a type that you don't know.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public global::Anthropic.BetaComplianceReviewActor? Actor { get; set; }

        /// <summary>
        /// The ID of the user profile that the item was attributed to (`uprof_...`). Null when none was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_profile_id")]
        public string? UserProfileId { get; set; }

        /// <summary>
        /// Why the item is readable. New types can appear, so accept a type that you don't know.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaComplianceReviewReadReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComplianceReviewReadReason ReadReason { get; set; }

        /// <summary>
        /// What is particular to this kind of item. New types can appear, so accept a type that you don't know.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaComplianceReviewItemDetailsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComplianceReviewItemDetails Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the item. For a message, its own ID, such as `msg_...`.
        /// </param>
        /// <param name="organizationId">
        /// The UUID of the organization that the item belongs to. For a message, the organization that sent it.
        /// </param>
        /// <param name="createdAt">
        /// For a message, when Anthropic received the call.
        /// </param>
        /// <param name="contentExpiresAt">
        /// Read the item, and save any copy you need, by this time. The item can stop being readable sooner.
        /// </param>
        /// <param name="readReason">
        /// Why the item is readable. New types can appear, so accept a type that you don't know.
        /// </param>
        /// <param name="details">
        /// What is particular to this kind of item. New types can appear, so accept a type that you don't know.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace (`wrkspc_...`). Null when the item isn't attributed to a workspace.
        /// </param>
        /// <param name="actor">
        /// For a message, who sent it. Null when no sender was recorded. New types can appear, so accept a type that you don't know.
        /// </param>
        /// <param name="userProfileId">
        /// The ID of the user profile that the item was attributed to (`uprof_...`). Null when none was recorded.
        /// </param>
        /// <param name="type">
        /// The object type, always `compliance_review_item`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewItem(
            string id,
            string organizationId,
            global::System.DateTime createdAt,
            global::System.DateTime contentExpiresAt,
            global::Anthropic.BetaComplianceReviewReadReason readReason,
            global::Anthropic.BetaComplianceReviewItemDetails details,
            string? workspaceId,
            global::Anthropic.BetaComplianceReviewActor? actor,
            string? userProfileId,
            string type = "compliance_review_item")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.CreatedAt = createdAt;
            this.ContentExpiresAt = contentExpiresAt;
            this.WorkspaceId = workspaceId;
            this.Actor = actor;
            this.UserProfileId = userProfileId;
            this.ReadReason = readReason;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewItem" /> class.
        /// </summary>
        public BetaComplianceReviewItem()
        {
        }

    }
}