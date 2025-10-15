
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our best model for real-world agents and coding
    /// </summary>
    public enum ModelVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet45,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant11 value)
        {
            return value switch
            {
                ModelVariant11.ClaudeSonnet45 => "claude-sonnet-4-5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant11? ToEnum(string value)
        {
            return value switch
            {
                "claude-sonnet-4-5" => ModelVariant11.ClaudeSonnet45,
                _ => null,
            };
        }
    }
}