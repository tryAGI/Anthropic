
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum InferenceGeo
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
    public static class InferenceGeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InferenceGeo value)
        {
            return value switch
            {
                InferenceGeo.Global => "global",
                InferenceGeo.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InferenceGeo? ToEnum(string value)
        {
            return value switch
            {
                "global" => InferenceGeo.Global,
                "us" => InferenceGeo.Us,
                _ => null,
            };
        }
    }
}