
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our best model for real-world agents and coding
    /// </summary>
    public enum ModelVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet4520250929,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant10 value)
        {
            return value switch
            {
                ModelVariant10.ClaudeSonnet4520250929 => "claude-sonnet-4-5-20250929",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant10? ToEnum(string value)
        {
            return value switch
            {
                "claude-sonnet-4-5-20250929" => ModelVariant10.ClaudeSonnet4520250929,
                _ => null,
            };
        }
    }
}