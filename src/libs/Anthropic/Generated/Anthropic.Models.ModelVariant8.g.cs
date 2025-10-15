
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// High-performance model with extended thinking
    /// </summary>
    public enum ModelVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet420250514,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant8 value)
        {
            return value switch
            {
                ModelVariant8.ClaudeSonnet420250514 => "claude-sonnet-4-20250514",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant8? ToEnum(string value)
        {
            return value switch
            {
                "claude-sonnet-4-20250514" => ModelVariant8.ClaudeSonnet420250514,
                _ => null,
            };
        }
    }
}