
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendLimitScopeDiscriminatorType
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
    public static class BetaSpendLimitScopeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendLimitScopeDiscriminatorType value)
        {
            return value switch
            {
                BetaSpendLimitScopeDiscriminatorType.Organization => "organization",
                BetaSpendLimitScopeDiscriminatorType.OrganizationService => "organization_service",
                BetaSpendLimitScopeDiscriminatorType.RbacGroup => "rbac_group",
                BetaSpendLimitScopeDiscriminatorType.SeatTier => "seat_tier",
                BetaSpendLimitScopeDiscriminatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendLimitScopeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaSpendLimitScopeDiscriminatorType.Organization,
                "organization_service" => BetaSpendLimitScopeDiscriminatorType.OrganizationService,
                "rbac_group" => BetaSpendLimitScopeDiscriminatorType.RbacGroup,
                "seat_tier" => BetaSpendLimitScopeDiscriminatorType.SeatTier,
                "user" => BetaSpendLimitScopeDiscriminatorType.User,
                _ => null,
            };
        }
    }
}