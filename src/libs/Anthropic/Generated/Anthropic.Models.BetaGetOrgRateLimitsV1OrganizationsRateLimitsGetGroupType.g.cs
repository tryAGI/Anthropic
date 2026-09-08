
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType
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
    public static class BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType value)
        {
            return value switch
            {
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Batch => "batch",
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Files => "files",
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.ModelGroup => "model_group",
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Skills => "skills",
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.TokenCount => "token_count",
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Batch,
                "files" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Files,
                "model_group" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.ModelGroup,
                "skills" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Skills,
                "token_count" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.TokenCount,
                "web_search" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.WebSearch,
                _ => null,
            };
        }
    }
}