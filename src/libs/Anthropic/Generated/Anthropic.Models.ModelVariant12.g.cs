
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our best model for real-world agents and coding
    /// </summary>
    public enum ModelVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet4520250929,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant12 value)
        {
            return value switch
            {
                ModelVariant12.ClaudeSonnet4520250929 => "claude-sonnet-4-5-20250929",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant12? ToEnum(string value)
        {
            return value switch
            {
                "claude-sonnet-4-5-20250929" => ModelVariant12.ClaudeSonnet4520250929,
                _ => null,
            };
        }
    }
}