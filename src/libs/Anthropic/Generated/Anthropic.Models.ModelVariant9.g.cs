
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// High-performance model with extended thinking
    /// </summary>
    public enum ModelVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet40,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant9 value)
        {
            return value switch
            {
                ModelVariant9.ClaudeSonnet40 => "claude-sonnet-4-0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant9? ToEnum(string value)
        {
            return value switch
            {
                "claude-sonnet-4-0" => ModelVariant9.ClaudeSonnet40,
                _ => null,
            };
        }
    }
}