
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsUsageGroupBy
    {
        /// <summary>
        ///
        /// </summary>
        Actor,
        /// <summary>
        ///
        /// </summary>
        ActorType,
        /// <summary>
        ///
        /// </summary>
        AgentId,
        /// <summary>
        ///
        /// </summary>
        ApiKeyId,
        /// <summary>
        ///
        /// </summary>
        ClaudeTagCategory,
        /// <summary>
        ///
        /// </summary>
        ClaudeTagUserId,
        /// <summary>
        ///
        /// </summary>
        ContextWindow,
        /// <summary>
        ///
        /// </summary>
        DeploymentId,
        /// <summary>
        ///
        /// </summary>
        EnvironmentId,
        /// <summary>
        ///
        /// </summary>
        InferenceGeo,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        Product,
        /// <summary>
        ///
        /// </summary>
        RbacGroupId,
        /// <summary>
        ///
        /// </summary>
        ServiceTier,
        /// <summary>
        ///
        /// </summary>
        SessionId,
        /// <summary>
        ///
        /// </summary>
        SlackChannelId,
        /// <summary>
        ///
        /// </summary>
        Speed,
        /// <summary>
        ///
        /// </summary>
        UserProfileId,
        /// <summary>
        ///
        /// </summary>
        WorkspaceId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsUsageGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsUsageGroupBy value)
        {
            return value switch
            {
                BetaAnalyticsUsageGroupBy.Actor => "actor",
                BetaAnalyticsUsageGroupBy.ActorType => "actor_type",
                BetaAnalyticsUsageGroupBy.AgentId => "agent_id",
                BetaAnalyticsUsageGroupBy.ApiKeyId => "api_key_id",
                BetaAnalyticsUsageGroupBy.ClaudeTagCategory => "claude_tag_category",
                BetaAnalyticsUsageGroupBy.ClaudeTagUserId => "claude_tag_user_id",
                BetaAnalyticsUsageGroupBy.ContextWindow => "context_window",
                BetaAnalyticsUsageGroupBy.DeploymentId => "deployment_id",
                BetaAnalyticsUsageGroupBy.EnvironmentId => "environment_id",
                BetaAnalyticsUsageGroupBy.InferenceGeo => "inference_geo",
                BetaAnalyticsUsageGroupBy.Model => "model",
                BetaAnalyticsUsageGroupBy.Product => "product",
                BetaAnalyticsUsageGroupBy.RbacGroupId => "rbac_group_id",
                BetaAnalyticsUsageGroupBy.ServiceTier => "service_tier",
                BetaAnalyticsUsageGroupBy.SessionId => "session_id",
                BetaAnalyticsUsageGroupBy.SlackChannelId => "slack_channel_id",
                BetaAnalyticsUsageGroupBy.Speed => "speed",
                BetaAnalyticsUsageGroupBy.UserProfileId => "user_profile_id",
                BetaAnalyticsUsageGroupBy.WorkspaceId => "workspace_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsUsageGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "actor" => BetaAnalyticsUsageGroupBy.Actor,
                "actor_type" => BetaAnalyticsUsageGroupBy.ActorType,
                "agent_id" => BetaAnalyticsUsageGroupBy.AgentId,
                "api_key_id" => BetaAnalyticsUsageGroupBy.ApiKeyId,
                "claude_tag_category" => BetaAnalyticsUsageGroupBy.ClaudeTagCategory,
                "claude_tag_user_id" => BetaAnalyticsUsageGroupBy.ClaudeTagUserId,
                "context_window" => BetaAnalyticsUsageGroupBy.ContextWindow,
                "deployment_id" => BetaAnalyticsUsageGroupBy.DeploymentId,
                "environment_id" => BetaAnalyticsUsageGroupBy.EnvironmentId,
                "inference_geo" => BetaAnalyticsUsageGroupBy.InferenceGeo,
                "model" => BetaAnalyticsUsageGroupBy.Model,
                "product" => BetaAnalyticsUsageGroupBy.Product,
                "rbac_group_id" => BetaAnalyticsUsageGroupBy.RbacGroupId,
                "service_tier" => BetaAnalyticsUsageGroupBy.ServiceTier,
                "session_id" => BetaAnalyticsUsageGroupBy.SessionId,
                "slack_channel_id" => BetaAnalyticsUsageGroupBy.SlackChannelId,
                "speed" => BetaAnalyticsUsageGroupBy.Speed,
                "user_profile_id" => BetaAnalyticsUsageGroupBy.UserProfileId,
                "workspace_id" => BetaAnalyticsUsageGroupBy.WorkspaceId,
                _ => null,
            };
        }
    }
}