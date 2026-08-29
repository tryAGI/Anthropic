
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCostReportServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCostReportServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCostReportServiceTier value)
        {
            return value switch
            {
                BetaCostReportServiceTier.Batch => "batch",
                BetaCostReportServiceTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCostReportServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "batch" => BetaCostReportServiceTier.Batch,
                "standard" => BetaCostReportServiceTier.Standard,
                _ => null,
            };
        }
    }
}