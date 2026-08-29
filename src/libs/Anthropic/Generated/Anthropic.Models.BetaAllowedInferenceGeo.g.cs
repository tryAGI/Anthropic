
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAllowedInferenceGeo
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
    public static class BetaAllowedInferenceGeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAllowedInferenceGeo value)
        {
            return value switch
            {
                BetaAllowedInferenceGeo.Global => "global",
                BetaAllowedInferenceGeo.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAllowedInferenceGeo? ToEnum(string value)
        {
            return value switch
            {
                "global" => BetaAllowedInferenceGeo.Global,
                "us" => BetaAllowedInferenceGeo.Us,
                _ => null,
            };
        }
    }
}