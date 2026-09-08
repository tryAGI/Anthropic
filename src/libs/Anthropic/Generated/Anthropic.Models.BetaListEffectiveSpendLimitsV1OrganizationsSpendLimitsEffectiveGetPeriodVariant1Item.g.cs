
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        Daily,
        /// <summary>
        ///
        /// </summary>
        Monthly,
        /// <summary>
        ///
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item value)
        {
            return value switch
            {
                BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item.Daily => "daily",
                BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item.Monthly => "monthly",
                BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "daily" => BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item.Daily,
                "monthly" => BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item.Monthly,
                "weekly" => BetaListEffectiveSpendLimitsV1OrganizationsSpendLimitsEffectiveGetPeriodVariant1Item.Weekly,
                _ => null,
            };
        }
    }
}