
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our most capable model
    /// </summary>
    public enum ModelVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeOpus420250514,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant13 value)
        {
            return value switch
            {
                ModelVariant13.ClaudeOpus420250514 => "claude-opus-4-20250514",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant13? ToEnum(string value)
        {
            return value switch
            {
                "claude-opus-4-20250514" => ModelVariant13.ClaudeOpus420250514,
                _ => null,
            };
        }
    }
}