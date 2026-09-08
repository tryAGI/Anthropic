
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendSummarySourceDiscriminatorType
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
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSpendSummarySourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendSummarySourceDiscriminatorType value)
        {
            return value switch
            {
                BetaSpendSummarySourceDiscriminatorType.Organization => "organization",
                BetaSpendSummarySourceDiscriminatorType.OrganizationService => "organization_service",
                BetaSpendSummarySourceDiscriminatorType.RbacGroup => "rbac_group",
                BetaSpendSummarySourceDiscriminatorType.SeatTier => "seat_tier",
                BetaSpendSummarySourceDiscriminatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendSummarySourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaSpendSummarySourceDiscriminatorType.Organization,
                "organization_service" => BetaSpendSummarySourceDiscriminatorType.OrganizationService,
                "rbac_group" => BetaSpendSummarySourceDiscriminatorType.RbacGroup,
                "seat_tier" => BetaSpendSummarySourceDiscriminatorType.SeatTier,
                "user" => BetaSpendSummarySourceDiscriminatorType.User,
                _ => null,
            };
        }
    }
}