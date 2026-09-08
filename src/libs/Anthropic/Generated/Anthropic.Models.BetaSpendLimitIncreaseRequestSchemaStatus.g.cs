
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendLimitIncreaseRequestSchemaStatus
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
    public static class BetaSpendLimitIncreaseRequestSchemaStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendLimitIncreaseRequestSchemaStatus value)
        {
            return value switch
            {
                BetaSpendLimitIncreaseRequestSchemaStatus.Approved => "approved",
                BetaSpendLimitIncreaseRequestSchemaStatus.Denied => "denied",
                BetaSpendLimitIncreaseRequestSchemaStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendLimitIncreaseRequestSchemaStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => BetaSpendLimitIncreaseRequestSchemaStatus.Approved,
                "denied" => BetaSpendLimitIncreaseRequestSchemaStatus.Denied,
                "pending" => BetaSpendLimitIncreaseRequestSchemaStatus.Pending,
                _ => null,
            };
        }
    }
}