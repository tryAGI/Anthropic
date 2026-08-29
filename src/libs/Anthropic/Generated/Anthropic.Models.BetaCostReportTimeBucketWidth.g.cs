
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCostReportTimeBucketWidth
    {
        /// <summary>
        ///
        /// </summary>
        x1d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCostReportTimeBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCostReportTimeBucketWidth value)
        {
            return value switch
            {
                BetaCostReportTimeBucketWidth.x1d => "1d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCostReportTimeBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => BetaCostReportTimeBucketWidth.x1d,
                _ => null,
            };
        }
    }
}