
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInferenceGeo
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
    public static class BetaInferenceGeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInferenceGeo value)
        {
            return value switch
            {
                BetaInferenceGeo.Global => "global",
                BetaInferenceGeo.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInferenceGeo? ToEnum(string value)
        {
            return value switch
            {
                "global" => BetaInferenceGeo.Global,
                "us" => BetaInferenceGeo.Us,
                _ => null,
            };
        }
    }
}