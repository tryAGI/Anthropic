
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaApproveSpendLimitIncreaseRequestResponseStatus
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
    public static class BetaApproveSpendLimitIncreaseRequestResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApproveSpendLimitIncreaseRequestResponseStatus value)
        {
            return value switch
            {
                BetaApproveSpendLimitIncreaseRequestResponseStatus.Approved => "approved",
                BetaApproveSpendLimitIncreaseRequestResponseStatus.Denied => "denied",
                BetaApproveSpendLimitIncreaseRequestResponseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApproveSpendLimitIncreaseRequestResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => BetaApproveSpendLimitIncreaseRequestResponseStatus.Approved,
                "denied" => BetaApproveSpendLimitIncreaseRequestResponseStatus.Denied,
                "pending" => BetaApproveSpendLimitIncreaseRequestResponseStatus.Pending,
                _ => null,
            };
        }
    }
}