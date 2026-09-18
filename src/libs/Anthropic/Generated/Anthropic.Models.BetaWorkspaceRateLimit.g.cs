
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWorkspaceRateLimit
    {
        /// <summary>
        /// The rate-limit group this entry's limits apply to. Its `type` equals `group_type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Group2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Group2 Group { get; set; }

        /// <summary>
        /// Deprecated: use `group.type` instead. The kind of rate-limit group this entry represents. `model_group` entries apply to a family of models (listed in `models`); other values apply to an API-surface category and have `models` set to `null`. Always equal to `group.type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaWorkspaceRateLimitGroupTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaWorkspaceRateLimitGroupType GroupType { get; set; }

        /// <summary>
        /// The limiter values overridden for this group in this workspace. Limiter types without a workspace override are omitted and inherit the organization value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitValue> Limits { get; set; }

        /// <summary>
        /// Model names this entry's limits apply to, including aliases. `null` when `group_type` is not `"model_group"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// The `id` of the organization's RateLimit entry this override applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RateLimitId { get; set; }

        /// <summary>
        /// Object type. Always `workspace_rate_limit` for workspace rate-limit entries.<br/>
        /// Default Value: workspace_rate_limit
        /// </summary>
        /// <default>"workspace_rate_limit"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workspace_rate_limit";

        /// <summary>
        /// ID of the Workspace this override applies to.
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
        /// Initializes a new instance of the <see cref="BetaWorkspaceRateLimit" /> class.
        /// </summary>
        /// <param name="group">
        /// The rate-limit group this entry's limits apply to. Its `type` equals `group_type`.
        /// </param>
        /// <param name="groupType">
        /// Deprecated: use `group.type` instead. The kind of rate-limit group this entry represents. `model_group` entries apply to a family of models (listed in `models`); other values apply to an API-surface category and have `models` set to `null`. Always equal to `group.type`.
        /// </param>
        /// <param name="limits">
        /// The limiter values overridden for this group in this workspace. Limiter types without a workspace override are omitted and inherit the organization value.
        /// </param>
        /// <param name="rateLimitId">
        /// The `id` of the organization's RateLimit entry this override applies to.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the Workspace this override applies to.
        /// </param>
        /// <param name="models">
        /// Model names this entry's limits apply to, including aliases. `null` when `group_type` is not `"model_group"`.
        /// </param>
        /// <param name="type">
        /// Object type. Always `workspace_rate_limit` for workspace rate-limit entries.<br/>
        /// Default Value: workspace_rate_limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceRateLimit(
            global::Anthropic.Group2 group,
            global::Anthropic.BetaWorkspaceRateLimitGroupType groupType,
            global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitValue> limits,
            string rateLimitId,
            string workspaceId,
            global::System.Collections.Generic.IList<string>? models,
            string type = "workspace_rate_limit")
        {
            this.Group = group;
            this.GroupType = groupType;
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
            this.Models = models;
            this.RateLimitId = rateLimitId ?? throw new global::System.ArgumentNullException(nameof(rateLimitId));
            this.Type = type;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceRateLimit" /> class.
        /// </summary>
        public BetaWorkspaceRateLimit()
        {
        }

    }
}