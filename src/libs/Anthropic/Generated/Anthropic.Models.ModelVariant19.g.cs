
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our most capable model
    /// </summary>
    public enum ModelVariant19
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeOpus4120250805,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant19Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant19 value)
        {
            return value switch
            {
                ModelVariant19.ClaudeOpus4120250805 => "claude-opus-4-1-20250805",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant19? ToEnum(string value)
        {
            return value switch
            {
                "claude-opus-4-1-20250805" => ModelVariant19.ClaudeOpus4120250805,
                _ => null,
            };
        }
    }
}