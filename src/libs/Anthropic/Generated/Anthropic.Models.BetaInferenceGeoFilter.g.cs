
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInferenceGeoFilter
    {
        /// <summary>
        ///
        /// </summary>
        Global,
        /// <summary>
        ///
        /// </summary>
        NotAvailable,
        /// <summary>
        ///
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInferenceGeoFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInferenceGeoFilter value)
        {
            return value switch
            {
                BetaInferenceGeoFilter.Global => "global",
                BetaInferenceGeoFilter.NotAvailable => "not_available",
                BetaInferenceGeoFilter.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInferenceGeoFilter? ToEnum(string value)
        {
            return value switch
            {
                "global" => BetaInferenceGeoFilter.Global,
                "not_available" => BetaInferenceGeoFilter.NotAvailable,
                "us" => BetaInferenceGeoFilter.Us,
                _ => null,
            };
        }
    }
}