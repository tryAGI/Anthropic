
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendSummaryScopeDiscriminatorType
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
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSpendSummaryScopeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendSummaryScopeDiscriminatorType value)
        {
            return value switch
            {
                BetaSpendSummaryScopeDiscriminatorType.Organization => "organization",
                BetaSpendSummaryScopeDiscriminatorType.OrganizationService => "organization_service",
                BetaSpendSummaryScopeDiscriminatorType.RbacGroup => "rbac_group",
                BetaSpendSummaryScopeDiscriminatorType.SeatTier => "seat_tier",
                BetaSpendSummaryScopeDiscriminatorType.User => "user",
                BetaSpendSummaryScopeDiscriminatorType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendSummaryScopeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaSpendSummaryScopeDiscriminatorType.Organization,
                "organization_service" => BetaSpendSummaryScopeDiscriminatorType.OrganizationService,
                "rbac_group" => BetaSpendSummaryScopeDiscriminatorType.RbacGroup,
                "seat_tier" => BetaSpendSummaryScopeDiscriminatorType.SeatTier,
                "user" => BetaSpendSummaryScopeDiscriminatorType.User,
                "workspace" => BetaSpendSummaryScopeDiscriminatorType.Workspace,
                _ => null,
            };
        }
    }
}