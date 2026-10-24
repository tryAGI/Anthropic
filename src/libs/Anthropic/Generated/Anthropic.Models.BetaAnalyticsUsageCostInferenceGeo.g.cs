
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsUsageCostInferenceGeo
    {
        /// <summary>
        ///
        /// </summary>
        Global,
        /// <summary>
        ///
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsUsageCostInferenceGeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsUsageCostInferenceGeo value)
        {
            return value switch
            {
                BetaAnalyticsUsageCostInferenceGeo.Global => "global",
                BetaAnalyticsUsageCostInferenceGeo.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsUsageCostInferenceGeo? ToEnum(string value)
        {
            return value switch
            {
                "global" => BetaAnalyticsUsageCostInferenceGeo.Global,
                "us" => BetaAnalyticsUsageCostInferenceGeo.Us,
                _ => null,
            };
        }
    }
}