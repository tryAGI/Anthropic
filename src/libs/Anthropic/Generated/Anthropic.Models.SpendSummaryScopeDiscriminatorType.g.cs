
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum SpendSummaryScopeDiscriminatorType
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
    public static class SpendSummaryScopeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendSummaryScopeDiscriminatorType value)
        {
            return value switch
            {
                SpendSummaryScopeDiscriminatorType.Organization => "organization",
                SpendSummaryScopeDiscriminatorType.OrganizationService => "organization_service",
                SpendSummaryScopeDiscriminatorType.RbacGroup => "rbac_group",
                SpendSummaryScopeDiscriminatorType.SeatTier => "seat_tier",
                SpendSummaryScopeDiscriminatorType.UsageTier => "usage_tier",
                SpendSummaryScopeDiscriminatorType.User => "user",
                SpendSummaryScopeDiscriminatorType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendSummaryScopeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => SpendSummaryScopeDiscriminatorType.Organization,
                "organization_service" => SpendSummaryScopeDiscriminatorType.OrganizationService,
                "rbac_group" => SpendSummaryScopeDiscriminatorType.RbacGroup,
                "seat_tier" => SpendSummaryScopeDiscriminatorType.SeatTier,
                "usage_tier" => SpendSummaryScopeDiscriminatorType.UsageTier,
                "user" => SpendSummaryScopeDiscriminatorType.User,
                "workspace" => SpendSummaryScopeDiscriminatorType.Workspace,
                _ => null,
            };
        }
    }
}