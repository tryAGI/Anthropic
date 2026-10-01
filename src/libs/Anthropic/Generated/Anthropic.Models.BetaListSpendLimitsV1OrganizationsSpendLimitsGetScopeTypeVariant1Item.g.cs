
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item
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
    public static class BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item value)
        {
            return value switch
            {
                BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.Organization => "organization",
                BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.OrganizationService => "organization_service",
                BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.RbacGroup => "rbac_group",
                BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.SeatTier => "seat_tier",
                BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.User => "user",
                BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.Organization,
                "organization_service" => BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.OrganizationService,
                "rbac_group" => BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.RbacGroup,
                "seat_tier" => BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.SeatTier,
                "user" => BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.User,
                "workspace" => BetaListSpendLimitsV1OrganizationsSpendLimitsGetScopeTypeVariant1Item.Workspace,
                _ => null,
            };
        }
    }
}