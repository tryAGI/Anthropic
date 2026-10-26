
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The dimension values one usage row is broken out by; each is null<br/>
    /// unless its dimension is in `group_by[]`.
    /// </summary>
    public sealed partial class BetaAnalyticsFlatGroup
    {
        /// <summary>
        /// The identity the usage is attributed to: the user if one is attributed, else the service account, else the federated (cloud-platform) identity, else the API key. Populated only when `actor` is in `group_by[]`; null for usage with no attributable identity, and for users' and federated identities' usage when the reader is a member who can see only some workspaces. Distinct identities the server cannot render also read null, each as its own row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public global::Anthropic.BetaAnalyticsReportActor? Actor { get; set; }

        /// <summary>
        /// Kind of identity the usage is attributed to; matches `actor.type` when `actor` is set. Populated only when `actor_type` is in `group_by[]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_type")]
        public global::Anthropic.BetaAnalyticsActorType? ActorType { get; set; }

        /// <summary>
        /// Claude Managed Agents agent whose session incurred the usage. Populated only when `agent_id` is in `group_by[]`; null for usage outside a managed session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// API key that authenticated the requests, as a tagged API key ID, whichever identity `actor` resolves to. Populated only when `api_key_id` is in `group_by[]`; null for usage not authenticated by an API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// Claude Tag (Claude in Slack) spend category: `engaged` (a person addressed Claude in a channel or thread), `proactive` (Claude responded without being addressed), `scheduled` (a scheduled routine ran), `monitoring` (Claude watching a channel it was asked to monitor), or `dm` (direct messages with Claude). Populated only when `claude_tag_category` is in `group_by[]`; null for usage that is not Claude Tag. Direct-message usage is billed to the individual user and is reported under that user's product, not under `claude_tag`. New categories may be added over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_tag_category")]
        public global::Anthropic.BetaAnalyticsClaudeTagCategory? ClaudeTagCategory { get; set; }

        /// <summary>
        /// Slack user ID (for example `U0123ABCDEF`) of the member the Claude Tag (Claude in Slack) usage is attributed to, not a claude.ai user ID. Populated only when `claude_tag_user_id` is in `group_by[]`; null for usage that is not Claude Tag and for Claude Tag usage that is not attributed to a single user (for example `monitoring`, and `proactive` usage Claude initiated), so per-user rows can sum to less than the Claude Tag total. Cannot be combined with `group_by[]=rbac_group_id` or the `rbac_group_ids[]` filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_tag_user_id")]
        public string? ClaudeTagUserId { get; set; }

        /// <summary>
        /// Context-window pricing tier of the usage or cost. Null unless `context_window` is in `group_by[]`; it can also be null on grouped rows with no context-window tier, such as code execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window")]
        public global::Anthropic.BetaMessagesUsageReportContextWindow? ContextWindow { get; set; }

        /// <summary>
        /// Deployment that started the Claude Managed Agents session. Populated only when `deployment_id` is in `group_by[]`; null for usage outside a managed session and for sessions no deployment started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// Claude Managed Agents environment the session ran in. Populated only when `environment_id` is in `group_by[]`; null for usage outside a managed session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// Inference region of the usage or cost. Null unless `inference_geo` is in `group_by[]`; it can also be null on grouped rows where the region is not set (the rows that `inference_geos[]=not_available` matches).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_geo")]
        public global::Anthropic.BetaAnalyticsUsageCostInferenceGeo? InferenceGeo { get; set; }

        /// <summary>
        /// Model that produced the usage or cost, as a model name in the form the `models[]` filter accepts (for example, `claude-opus-5-5`). Null unless `model` is in `group_by[]`; it can also be null on grouped rows whose usage or cost is not attributed to a specific model, such as code execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Product surface that produced the usage or cost. Null unless product is in `group_by[]`; it can also be null on grouped rows whose usage cannot be attributed to a known surface. Values include `chat`, `claude_code`, `cowork`, `office_agent`, `claude_in_chrome`, `claude_design`, `claude_tag`, and `chat_cowork_unified`. `claude_tag` is Claude Tag, the Claude product in Slack. `chat_cowork_unified` is Chat and Cowork unified, Cowork's features inside claude.ai chat: chat and Cowork usage by a member who has it turned on is reported under this value instead of `chat` or `cowork`. It is accepted as a filter only on deployments that offer Chat and Cowork unified. Some unattributed usage is reported as "other".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public string? Product { get; set; }

        /// <summary>
        /// RBAC group (team) the usage is attributed to, in the public tagged `rbac_group_...` spelling — the same spelling the activity resources use for this key, so the same team has one id across resources and it round-trips as an `rbac_group_ids[]` filter value. Populated only when `rbac_group_id` is in `group_by[]`. Any-membership semantics: a user in several groups contributes their full usage to each of those groups' rows, so the named-group rows overlap and their sum can exceed the org total. A null value is the single unassigned row: users in no group on that (UTC) day. For the true org total, run the same query without `group_by[]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_id")]
        public string? RbacGroupId { get; set; }

        /// <summary>
        /// Service tier the usage was served at. Populated only when `service_tier` is in `group_by[]`; null for usage with no service tier (for example, code execution) and for Claude Enterprise usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::Anthropic.BetaUsageReportServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Claude Managed Agents session that incurred the usage. Populated only when `session_id` is in `group_by[]`; null for usage outside a managed session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Slack channel the usage originated from. Populated only when `slack_channel_id` is in `group_by[]`; null for usage outside Slack (and for rows recorded before channel attribution was enabled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_channel_id")]
        public string? SlackChannelId { get; set; }

        /// <summary>
        /// Inference speed mode of the usage or cost: `fast` or `standard`. Null unless `speed` is in `group_by[]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public global::Anthropic.BetaAnalyticsSpeed? Speed { get; set; }

        /// <summary>
        /// User profile the usage was attributed to, as a tagged `uprof_` ID. Populated only when `user_profile_id` is in `group_by[]`; null for usage that named no profile and for Claude Enterprise usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_profile_id")]
        public string? UserProfileId { get; set; }

        /// <summary>
        /// Workspace the usage occurred in, as a tagged workspace ID, including the organization's default workspace. Populated only when `workspace_id` is in `group_by[]`; null for Claude Enterprise usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFlatGroup" /> class.
        /// </summary>
        /// <param name="actor">
        /// The identity the usage is attributed to: the user if one is attributed, else the service account, else the federated (cloud-platform) identity, else the API key. Populated only when `actor` is in `group_by[]`; null for usage with no attributable identity, and for users' and federated identities' usage when the reader is a member who can see only some workspaces. Distinct identities the server cannot render also read null, each as its own row.
        /// </param>
        /// <param name="actorType">
        /// Kind of identity the usage is attributed to; matches `actor.type` when `actor` is set. Populated only when `actor_type` is in `group_by[]`.
        /// </param>
        /// <param name="agentId">
        /// Claude Managed Agents agent whose session incurred the usage. Populated only when `agent_id` is in `group_by[]`; null for usage outside a managed session.
        /// </param>
        /// <param name="apiKeyId">
        /// API key that authenticated the requests, as a tagged API key ID, whichever identity `actor` resolves to. Populated only when `api_key_id` is in `group_by[]`; null for usage not authenticated by an API key.
        /// </param>
        /// <param name="claudeTagCategory">
        /// Claude Tag (Claude in Slack) spend category: `engaged` (a person addressed Claude in a channel or thread), `proactive` (Claude responded without being addressed), `scheduled` (a scheduled routine ran), `monitoring` (Claude watching a channel it was asked to monitor), or `dm` (direct messages with Claude). Populated only when `claude_tag_category` is in `group_by[]`; null for usage that is not Claude Tag. Direct-message usage is billed to the individual user and is reported under that user's product, not under `claude_tag`. New categories may be added over time.
        /// </param>
        /// <param name="claudeTagUserId">
        /// Slack user ID (for example `U0123ABCDEF`) of the member the Claude Tag (Claude in Slack) usage is attributed to, not a claude.ai user ID. Populated only when `claude_tag_user_id` is in `group_by[]`; null for usage that is not Claude Tag and for Claude Tag usage that is not attributed to a single user (for example `monitoring`, and `proactive` usage Claude initiated), so per-user rows can sum to less than the Claude Tag total. Cannot be combined with `group_by[]=rbac_group_id` or the `rbac_group_ids[]` filter.
        /// </param>
        /// <param name="contextWindow">
        /// Context-window pricing tier of the usage or cost. Null unless `context_window` is in `group_by[]`; it can also be null on grouped rows with no context-window tier, such as code execution.
        /// </param>
        /// <param name="deploymentId">
        /// Deployment that started the Claude Managed Agents session. Populated only when `deployment_id` is in `group_by[]`; null for usage outside a managed session and for sessions no deployment started.
        /// </param>
        /// <param name="environmentId">
        /// Claude Managed Agents environment the session ran in. Populated only when `environment_id` is in `group_by[]`; null for usage outside a managed session.
        /// </param>
        /// <param name="inferenceGeo">
        /// Inference region of the usage or cost. Null unless `inference_geo` is in `group_by[]`; it can also be null on grouped rows where the region is not set (the rows that `inference_geos[]=not_available` matches).
        /// </param>
        /// <param name="model">
        /// Model that produced the usage or cost, as a model name in the form the `models[]` filter accepts (for example, `claude-opus-5-5`). Null unless `model` is in `group_by[]`; it can also be null on grouped rows whose usage or cost is not attributed to a specific model, such as code execution.
        /// </param>
        /// <param name="product">
        /// Product surface that produced the usage or cost. Null unless product is in `group_by[]`; it can also be null on grouped rows whose usage cannot be attributed to a known surface. Values include `chat`, `claude_code`, `cowork`, `office_agent`, `claude_in_chrome`, `claude_design`, `claude_tag`, and `chat_cowork_unified`. `claude_tag` is Claude Tag, the Claude product in Slack. `chat_cowork_unified` is Chat and Cowork unified, Cowork's features inside claude.ai chat: chat and Cowork usage by a member who has it turned on is reported under this value instead of `chat` or `cowork`. It is accepted as a filter only on deployments that offer Chat and Cowork unified. Some unattributed usage is reported as "other".
        /// </param>
        /// <param name="rbacGroupId">
        /// RBAC group (team) the usage is attributed to, in the public tagged `rbac_group_...` spelling — the same spelling the activity resources use for this key, so the same team has one id across resources and it round-trips as an `rbac_group_ids[]` filter value. Populated only when `rbac_group_id` is in `group_by[]`. Any-membership semantics: a user in several groups contributes their full usage to each of those groups' rows, so the named-group rows overlap and their sum can exceed the org total. A null value is the single unassigned row: users in no group on that (UTC) day. For the true org total, run the same query without `group_by[]`.
        /// </param>
        /// <param name="serviceTier">
        /// Service tier the usage was served at. Populated only when `service_tier` is in `group_by[]`; null for usage with no service tier (for example, code execution) and for Claude Enterprise usage.
        /// </param>
        /// <param name="sessionId">
        /// Claude Managed Agents session that incurred the usage. Populated only when `session_id` is in `group_by[]`; null for usage outside a managed session.
        /// </param>
        /// <param name="slackChannelId">
        /// Slack channel the usage originated from. Populated only when `slack_channel_id` is in `group_by[]`; null for usage outside Slack (and for rows recorded before channel attribution was enabled).
        /// </param>
        /// <param name="speed">
        /// Inference speed mode of the usage or cost: `fast` or `standard`. Null unless `speed` is in `group_by[]`.
        /// </param>
        /// <param name="userProfileId">
        /// User profile the usage was attributed to, as a tagged `uprof_` ID. Populated only when `user_profile_id` is in `group_by[]`; null for usage that named no profile and for Claude Enterprise usage.
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the usage occurred in, as a tagged workspace ID, including the organization's default workspace. Populated only when `workspace_id` is in `group_by[]`; null for Claude Enterprise usage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsFlatGroup(
            global::Anthropic.BetaAnalyticsReportActor? actor,
            global::Anthropic.BetaAnalyticsActorType? actorType,
            string? agentId,
            string? apiKeyId,
            global::Anthropic.BetaAnalyticsClaudeTagCategory? claudeTagCategory,
            string? claudeTagUserId,
            global::Anthropic.BetaMessagesUsageReportContextWindow? contextWindow,
            string? deploymentId,
            string? environmentId,
            global::Anthropic.BetaAnalyticsUsageCostInferenceGeo? inferenceGeo,
            string? model,
            string? product,
            string? rbacGroupId,
            global::Anthropic.BetaUsageReportServiceTier? serviceTier,
            string? sessionId,
            string? slackChannelId,
            global::Anthropic.BetaAnalyticsSpeed? speed,
            string? userProfileId,
            string? workspaceId)
        {
            this.Actor = actor;
            this.ActorType = actorType;
            this.AgentId = agentId;
            this.ApiKeyId = apiKeyId;
            this.ClaudeTagCategory = claudeTagCategory;
            this.ClaudeTagUserId = claudeTagUserId;
            this.ContextWindow = contextWindow;
            this.DeploymentId = deploymentId;
            this.EnvironmentId = environmentId;
            this.InferenceGeo = inferenceGeo;
            this.Model = model;
            this.Product = product;
            this.RbacGroupId = rbacGroupId;
            this.ServiceTier = serviceTier;
            this.SessionId = sessionId;
            this.SlackChannelId = slackChannelId;
            this.Speed = speed;
            this.UserProfileId = userProfileId;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFlatGroup" /> class.
        /// </summary>
        public BetaAnalyticsFlatGroup()
        {
        }

    }
}