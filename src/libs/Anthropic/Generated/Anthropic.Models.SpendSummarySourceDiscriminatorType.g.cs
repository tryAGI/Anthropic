
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum SpendSummarySourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        OrganizationService,
        /// <summary>
        ///
        /// </summary>
        RbacGroup,
        /// <summary>
        ///
        /// </summary>
        SeatTier,
        /// <summary>
        ///
        /// </summary>
        UsageTier,
        /// <summary>
        ///
        /// </summary>
        User,
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpendSummarySourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendSummarySourceDiscriminatorType value)
        {
            return value switch
            {
                SpendSummarySourceDiscriminatorType.Organization => "organization",
                SpendSummarySourceDiscriminatorType.OrganizationService => "organization_service",
                SpendSummarySourceDiscriminatorType.RbacGroup => "rbac_group",
                SpendSummarySourceDiscriminatorType.SeatTier => "seat_tier",
                SpendSummarySourceDiscriminatorType.UsageTier => "usage_tier",
                SpendSummarySourceDiscriminatorType.User => "user",
                SpendSummarySourceDiscriminatorType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendSummarySourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => SpendSummarySourceDiscriminatorType.Organization,
                "organization_service" => SpendSummarySourceDiscriminatorType.OrganizationService,
                "rbac_group" => SpendSummarySourceDiscriminatorType.RbacGroup,
                "seat_tier" => SpendSummarySourceDiscriminatorType.SeatTier,
                "usage_tier" => SpendSummarySourceDiscriminatorType.UsageTier,
                "user" => SpendSummarySourceDiscriminatorType.User,
                "workspace" => SpendSummarySourceDiscriminatorType.Workspace,
                _ => null,
            };
        }
    }
}