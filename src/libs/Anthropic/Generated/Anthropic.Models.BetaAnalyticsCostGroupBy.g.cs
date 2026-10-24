
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsCostGroupBy
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
        CostType,
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
        TokenType,
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
    public static class BetaAnalyticsCostGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsCostGroupBy value)
        {
            return value switch
            {
                BetaAnalyticsCostGroupBy.Actor => "actor",
                BetaAnalyticsCostGroupBy.ActorType => "actor_type",
                BetaAnalyticsCostGroupBy.AgentId => "agent_id",
                BetaAnalyticsCostGroupBy.ApiKeyId => "api_key_id",
                BetaAnalyticsCostGroupBy.ClaudeTagCategory => "claude_tag_category",
                BetaAnalyticsCostGroupBy.ClaudeTagUserId => "claude_tag_user_id",
                BetaAnalyticsCostGroupBy.ContextWindow => "context_window",
                BetaAnalyticsCostGroupBy.CostType => "cost_type",
                BetaAnalyticsCostGroupBy.DeploymentId => "deployment_id",
                BetaAnalyticsCostGroupBy.EnvironmentId => "environment_id",
                BetaAnalyticsCostGroupBy.InferenceGeo => "inference_geo",
                BetaAnalyticsCostGroupBy.Model => "model",
                BetaAnalyticsCostGroupBy.Product => "product",
                BetaAnalyticsCostGroupBy.RbacGroupId => "rbac_group_id",
                BetaAnalyticsCostGroupBy.ServiceTier => "service_tier",
                BetaAnalyticsCostGroupBy.SessionId => "session_id",
                BetaAnalyticsCostGroupBy.SlackChannelId => "slack_channel_id",
                BetaAnalyticsCostGroupBy.Speed => "speed",
                BetaAnalyticsCostGroupBy.TokenType => "token_type",
                BetaAnalyticsCostGroupBy.UserProfileId => "user_profile_id",
                BetaAnalyticsCostGroupBy.WorkspaceId => "workspace_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsCostGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "actor" => BetaAnalyticsCostGroupBy.Actor,
                "actor_type" => BetaAnalyticsCostGroupBy.ActorType,
                "agent_id" => BetaAnalyticsCostGroupBy.AgentId,
                "api_key_id" => BetaAnalyticsCostGroupBy.ApiKeyId,
                "claude_tag_category" => BetaAnalyticsCostGroupBy.ClaudeTagCategory,
                "claude_tag_user_id" => BetaAnalyticsCostGroupBy.ClaudeTagUserId,
                "context_window" => BetaAnalyticsCostGroupBy.ContextWindow,
                "cost_type" => BetaAnalyticsCostGroupBy.CostType,
                "deployment_id" => BetaAnalyticsCostGroupBy.DeploymentId,
                "environment_id" => BetaAnalyticsCostGroupBy.EnvironmentId,
                "inference_geo" => BetaAnalyticsCostGroupBy.InferenceGeo,
                "model" => BetaAnalyticsCostGroupBy.Model,
                "product" => BetaAnalyticsCostGroupBy.Product,
                "rbac_group_id" => BetaAnalyticsCostGroupBy.RbacGroupId,
                "service_tier" => BetaAnalyticsCostGroupBy.ServiceTier,
                "session_id" => BetaAnalyticsCostGroupBy.SessionId,
                "slack_channel_id" => BetaAnalyticsCostGroupBy.SlackChannelId,
                "speed" => BetaAnalyticsCostGroupBy.Speed,
                "token_type" => BetaAnalyticsCostGroupBy.TokenType,
                "user_profile_id" => BetaAnalyticsCostGroupBy.UserProfileId,
                "workspace_id" => BetaAnalyticsCostGroupBy.WorkspaceId,
                _ => null,
            };
        }
    }
}