
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType
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
    public static class GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType value)
        {
            return value switch
            {
                GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Batch => "batch",
                GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Files => "files",
                GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.ModelGroup => "model_group",
                GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Skills => "skills",
                GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.TokenCount => "token_count",
                GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType? ToEnum(string value)
        {
            return value switch
            {
                "batch" => GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Batch,
                "files" => GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Files,
                "model_group" => GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.ModelGroup,
                "skills" => GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.Skills,
                "token_count" => GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.TokenCount,
                "web_search" => GetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType.WebSearch,
                _ => null,
            };
        }
    }
}