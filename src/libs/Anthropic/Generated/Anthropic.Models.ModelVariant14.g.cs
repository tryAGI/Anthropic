
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our most capable model
    /// </summary>
    public enum ModelVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        Claude4Opus20250514,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant14 value)
        {
            return value switch
            {
                ModelVariant14.Claude4Opus20250514 => "claude-4-opus-20250514",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant14? ToEnum(string value)
        {
            return value switch
            {
                "claude-4-opus-20250514" => ModelVariant14.Claude4Opus20250514,
                _ => null,
            };
        }
    }
}