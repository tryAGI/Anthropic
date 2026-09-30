
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendLimitIncreaseRequestStatus
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
    public static class BetaSpendLimitIncreaseRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendLimitIncreaseRequestStatus value)
        {
            return value switch
            {
                BetaSpendLimitIncreaseRequestStatus.Approved => "approved",
                BetaSpendLimitIncreaseRequestStatus.Denied => "denied",
                BetaSpendLimitIncreaseRequestStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendLimitIncreaseRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => BetaSpendLimitIncreaseRequestStatus.Approved,
                "denied" => BetaSpendLimitIncreaseRequestStatus.Denied,
                "pending" => BetaSpendLimitIncreaseRequestStatus.Pending,
                _ => null,
            };
        }
    }
}