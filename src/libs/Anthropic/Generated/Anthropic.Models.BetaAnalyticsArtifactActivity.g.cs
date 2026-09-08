
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Artifact-creation activity for one (`artifact_type`, `is_shared`) bucket<br/>
    /// on a given day.<br/>
    /// Artifacts form a small finite cube — the canonical MIME type (8 values incl.<br/>
    /// `other`) crossed with shared-vs-private — so the response is the full set of<br/>
    /// non-empty buckets, not a ranked/paginated list. Claude Code and Cowork<br/>
    /// artifacts report under `text/html` and are counted from 2026-08-17<br/>
    /// onward; earlier days contain claude.ai chat artifacts only. With<br/>
    /// `group_by[]=product` / `user_id` / `rbac_group_id` each row is further<br/>
    /// split by the flat group keys and counts are scoped to that cut.
    /// </summary>
    public sealed partial class BetaAnalyticsArtifactActivity
    {
        /// <summary>
        /// Canonical artifact MIME type (e.g. `text/markdown`, `application/vnd.ant.react`, `image/svg+xml`), or `other`. Claude Code and Cowork artifacts report as `text/html`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArtifactType { get; set; }

        /// <summary>
        /// Number of artifacts created in this bucket on the requested day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts_created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ArtifactsCreatedCount { get; set; }

        /// <summary>
        /// Number of distinct users who created artifacts in this bucket on the requested day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_user_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctUserCount { get; set; }

        /// <summary>
        /// Whether the artifacts in this bucket have ever been shared (a Claude Code / Cowork artifact is shared once anyone beyond its creator may open it: named members, the whole organization, or anyone with the link).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_shared")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsShared { get; set; }

        /// <summary>
        /// Product that produced this row's activity: one of `chat`, `claude_code`, `cowork`, or `office_agent` (the canonical Cost &amp; Usage product naming; an `office_agent` row's per-surface breakdown is in its `office_metrics`). On `/plugins` only `cowork` and `claude_code` occur (the only surfaces with plugin attribution); on `/artifacts` only `chat`, `claude_code`, and `cowork` occur (the surfaces that create artifacts); `/apps/chat/projects` does not support the product dimension (a `product` entry in `group_by[]` or `filter[]` there is rejected). Present only when the request grouped by `product`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public string? Product { get; set; }

        /// <summary>
        /// Number of those artifacts that have been published (for Claude Code / Cowork artifacts: open to anyone with the link); never exceeds `artifacts_created_count`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_artifacts_created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublishedArtifactsCreatedCount { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaAnalyticsArtifactActivity" /> class.
        /// </summary>
        /// <param name="artifactType">
        /// Canonical artifact MIME type (e.g. `text/markdown`, `application/vnd.ant.react`, `image/svg+xml`), or `other`. Claude Code and Cowork artifacts report as `text/html`.
        /// </param>
        /// <param name="artifactsCreatedCount">
        /// Number of artifacts created in this bucket on the requested day
        /// </param>
        /// <param name="distinctUserCount">
        /// Number of distinct users who created artifacts in this bucket on the requested day
        /// </param>
        /// <param name="isShared">
        /// Whether the artifacts in this bucket have ever been shared (a Claude Code / Cowork artifact is shared once anyone beyond its creator may open it: named members, the whole organization, or anyone with the link).
        /// </param>
        /// <param name="publishedArtifactsCreatedCount">
        /// Number of those artifacts that have been published (for Claude Code / Cowork artifacts: open to anyone with the link); never exceeds `artifacts_created_count`
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
        public BetaAnalyticsArtifactActivity(
            string artifactType,
            int artifactsCreatedCount,
            int distinctUserCount,
            bool isShared,
            int publishedArtifactsCreatedCount,
            string? product,
            string? rbacGroupId,
            string? rbacGroupName,
            string? userId)
        {
            this.ArtifactType = artifactType ?? throw new global::System.ArgumentNullException(nameof(artifactType));
            this.ArtifactsCreatedCount = artifactsCreatedCount;
            this.DistinctUserCount = distinctUserCount;
            this.IsShared = isShared;
            this.Product = product;
            this.PublishedArtifactsCreatedCount = publishedArtifactsCreatedCount;
            this.RbacGroupId = rbacGroupId;
            this.RbacGroupName = rbacGroupName;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsArtifactActivity" /> class.
        /// </summary>
        public BetaAnalyticsArtifactActivity()
        {
        }

    }
}