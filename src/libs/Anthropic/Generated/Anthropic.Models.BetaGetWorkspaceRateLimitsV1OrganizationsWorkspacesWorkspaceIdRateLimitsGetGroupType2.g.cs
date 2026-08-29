
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2
    {
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        Files,
        /// <summary>
        ///
        /// </summary>
        ModelGroup,
        /// <summary>
        ///
        /// </summary>
        Skills,
        /// <summary>
        ///
        /// </summary>
        TokenCount,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2 value)
        {
            return value switch
            {
                BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.Batch => "batch",
                BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.Files => "files",
                BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.ModelGroup => "model_group",
                BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.Skills => "skills",
                BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.TokenCount => "token_count",
                BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.Batch,
                "files" => BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.Files,
                "model_group" => BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.ModelGroup,
                "skills" => BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.Skills,
                "token_count" => BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.TokenCount,
                "web_search" => BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2.WebSearch,
                _ => null,
            };
        }
    }
}