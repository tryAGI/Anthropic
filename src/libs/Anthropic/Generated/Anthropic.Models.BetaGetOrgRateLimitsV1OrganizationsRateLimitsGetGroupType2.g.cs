
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2
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
    public static class BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2 value)
        {
            return value switch
            {
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.Batch => "batch",
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.Files => "files",
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.ModelGroup => "model_group",
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.Skills => "skills",
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.TokenCount => "token_count",
                BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.Batch,
                "files" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.Files,
                "model_group" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.ModelGroup,
                "skills" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.Skills,
                "token_count" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.TokenCount,
                "web_search" => BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2.WebSearch,
                _ => null,
            };
        }
    }
}