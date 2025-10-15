
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelVariant15
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20240620,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant15Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant15 value)
        {
            return value switch
            {
                ModelVariant15.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant15? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet-20240620" => ModelVariant15.Claude35Sonnet20240620,
                _ => null,
            };
        }
    }
}