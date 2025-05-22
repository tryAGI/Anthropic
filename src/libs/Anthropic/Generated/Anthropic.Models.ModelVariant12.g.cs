
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our most capable model
    /// </summary>
    public enum ModelVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeOpus40,
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
                ModelVariant12.ClaudeOpus40 => "claude-opus-4-0",
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
                "claude-opus-4-0" => ModelVariant12.ClaudeOpus40,
                _ => null,
            };
        }
    }
}