
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-project activity data for a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsProjectActivity
    {
        /// <summary>
        /// Project creation timestamp in RFC 3339 format. Null if the project was deleted before attribution was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// User who created the project. Null if the project was deleted before attribution was recorded, or if the creator's account no longer exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::Anthropic.BetaAnalyticsUser? CreatedBy { get; set; }

        /// <summary>
        /// Number of distinct conversations in the project. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_conversation_count")]
        public int? DistinctConversationCount { get; set; }

        /// <summary>
        /// Number of distinct users who used the project on the requested day, or, in date-range mode, over the requested window — recomputed as an exact distinct count over the window's per-member daily rows, never a sum of per-day values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_user_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctUserCount { get; set; }

        /// <summary>
        /// Number of messages sent in the project on the requested day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageCount { get; set; }

        /// <summary>
        /// Product that produced this row's activity: one of `chat`, `claude_code`, `cowork`, or `office_agent` (the canonical Cost &amp; Usage product naming; an `office_agent` row's per-surface breakdown is in its `office_metrics`). On `/plugins` only `cowork` and `claude_code` occur (the only surfaces with plugin attribution); on `/artifacts` only `chat`, `claude_code`, and `cowork` occur (the surfaces that create artifacts); `/apps/chat/projects` does not support the product dimension (a `product` entry in `group_by[]` or `filter[]` there is rejected). Present only when the request grouped by `product`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public string? Product { get; set; }

        /// <summary>
        /// Tagged project identifier (e.g. `claude_proj_...`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Name of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// Tagged RBAC group identifier (`rbac_group_...`), matching the spend-limits API spelling. Present only when the request grouped by `rbac_group_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_id")]
        public string? RbacGroupId { get; set; }

        /// <summary>
        /// Resolved RBAC group display name, alongside `rbac_group_id` when name resolution is available. Null if the group has been deleted or its name could not be resolved; `rbac_group_id` remains the stable key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_name")]
        public string? RbacGroupName { get; set; }

        /// <summary>
        /// Tagged user identifier (e.g. `user_...`). Present only when the request grouped by `user_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsProjectActivity" /> class.
        /// </summary>
        /// <param name="distinctUserCount">
        /// Number of distinct users who used the project on the requested day, or, in date-range mode, over the requested window — recomputed as an exact distinct count over the window's per-member daily rows, never a sum of per-day values.
        /// </param>
        /// <param name="messageCount">
        /// Number of messages sent in the project on the requested day
        /// </param>
        /// <param name="projectId">
        /// Tagged project identifier (e.g. `claude_proj_...`)
        /// </param>
        /// <param name="projectName">
        /// Name of the project
        /// </param>
        /// <param name="createdAt">
        /// Project creation timestamp in RFC 3339 format. Null if the project was deleted before attribution was recorded.
        /// </param>
        /// <param name="createdBy">
        /// User who created the project. Null if the project was deleted before attribution was recorded, or if the creator's account no longer exists.
        /// </param>
        /// <param name="distinctConversationCount">
        /// Number of distinct conversations in the project. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="product">
        /// Product that produced this row's activity: one of `chat`, `claude_code`, `cowork`, or `office_agent` (the canonical Cost &amp; Usage product naming; an `office_agent` row's per-surface breakdown is in its `office_metrics`). On `/plugins` only `cowork` and `claude_code` occur (the only surfaces with plugin attribution); on `/artifacts` only `chat`, `claude_code`, and `cowork` occur (the surfaces that create artifacts); `/apps/chat/projects` does not support the product dimension (a `product` entry in `group_by[]` or `filter[]` there is rejected). Present only when the request grouped by `product`.
        /// </param>
        /// <param name="rbacGroupId">
        /// Tagged RBAC group identifier (`rbac_group_...`), matching the spend-limits API spelling. Present only when the request grouped by `rbac_group_id`.
        /// </param>
        /// <param name="rbacGroupName">
        /// Resolved RBAC group display name, alongside `rbac_group_id` when name resolution is available. Null if the group has been deleted or its name could not be resolved; `rbac_group_id` remains the stable key.
        /// </param>
        /// <param name="userId">
        /// Tagged user identifier (e.g. `user_...`). Present only when the request grouped by `user_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsProjectActivity(
            int distinctUserCount,
            int messageCount,
            string projectId,
            string projectName,
            global::System.DateTime? createdAt,
            global::Anthropic.BetaAnalyticsUser? createdBy,
            int? distinctConversationCount,
            string? product,
            string? rbacGroupId,
            string? rbacGroupName,
            string? userId)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.DistinctConversationCount = distinctConversationCount;
            this.DistinctUserCount = distinctUserCount;
            this.MessageCount = messageCount;
            this.Product = product;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.RbacGroupId = rbacGroupId;
            this.RbacGroupName = rbacGroupName;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsProjectActivity" /> class.
        /// </summary>
        public BetaAnalyticsProjectActivity()
        {
        }

    }
}