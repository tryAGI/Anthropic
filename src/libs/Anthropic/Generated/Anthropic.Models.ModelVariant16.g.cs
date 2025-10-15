
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our most capable model
    /// </summary>
    public enum ModelVariant16
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeOpus40,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant16 value)
        {
            return value switch
            {
                ModelVariant16.ClaudeOpus40 => "claude-opus-4-0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant16? ToEnum(string value)
        {
            return value switch
            {
                "claude-opus-4-0" => ModelVariant16.ClaudeOpus40,
                _ => null,
            };
        }
    }
}