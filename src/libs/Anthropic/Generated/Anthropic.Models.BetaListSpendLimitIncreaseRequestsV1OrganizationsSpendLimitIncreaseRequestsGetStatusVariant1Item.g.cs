
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        Denied,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item value)
        {
            return value switch
            {
                BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item.Approved => "approved",
                BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item.Denied => "denied",
                BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "approved" => BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item.Approved,
                "denied" => BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item.Denied,
                "pending" => BetaListSpendLimitIncreaseRequestsV1OrganizationsSpendLimitIncreaseRequestsGetStatusVariant1Item.Pending,
                _ => null,
            };
        }
    }
}