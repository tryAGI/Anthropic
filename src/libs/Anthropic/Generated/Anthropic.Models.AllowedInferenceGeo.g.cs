
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum AllowedInferenceGeo
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
    public static class AllowedInferenceGeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AllowedInferenceGeo value)
        {
            return value switch
            {
                AllowedInferenceGeo.Global => "global",
                AllowedInferenceGeo.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AllowedInferenceGeo? ToEnum(string value)
        {
            return value switch
            {
                "global" => AllowedInferenceGeo.Global,
                "us" => AllowedInferenceGeo.Us,
                _ => null,
            };
        }
    }
}