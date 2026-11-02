
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum SpendLimitScopeDiscriminatorType
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
    public static class SpendLimitScopeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendLimitScopeDiscriminatorType value)
        {
            return value switch
            {
                SpendLimitScopeDiscriminatorType.Organization => "organization",
                SpendLimitScopeDiscriminatorType.OrganizationService => "organization_service",
                SpendLimitScopeDiscriminatorType.RbacGroup => "rbac_group",
                SpendLimitScopeDiscriminatorType.SeatTier => "seat_tier",
                SpendLimitScopeDiscriminatorType.UsageTier => "usage_tier",
                SpendLimitScopeDiscriminatorType.User => "user",
                SpendLimitScopeDiscriminatorType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendLimitScopeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => SpendLimitScopeDiscriminatorType.Organization,
                "organization_service" => SpendLimitScopeDiscriminatorType.OrganizationService,
                "rbac_group" => SpendLimitScopeDiscriminatorType.RbacGroup,
                "seat_tier" => SpendLimitScopeDiscriminatorType.SeatTier,
                "usage_tier" => SpendLimitScopeDiscriminatorType.UsageTier,
                "user" => SpendLimitScopeDiscriminatorType.User,
                "workspace" => SpendLimitScopeDiscriminatorType.Workspace,
                _ => null,
            };
        }
    }
}