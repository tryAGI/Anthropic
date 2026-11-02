
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum SpendLimitIncreaseRequestStatus
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
    public static class SpendLimitIncreaseRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendLimitIncreaseRequestStatus value)
        {
            return value switch
            {
                SpendLimitIncreaseRequestStatus.Approved => "approved",
                SpendLimitIncreaseRequestStatus.Denied => "denied",
                SpendLimitIncreaseRequestStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendLimitIncreaseRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => SpendLimitIncreaseRequestStatus.Approved,
                "denied" => SpendLimitIncreaseRequestStatus.Denied,
                "pending" => SpendLimitIncreaseRequestStatus.Pending,
                _ => null,
            };
        }
    }
}