
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Hybrid model, capable of near-instant responses and extended thinking
    /// </summary>
    public enum ModelVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeHaiku45,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant6 value)
        {
            return value switch
            {
                ModelVariant6.ClaudeHaiku45 => "claude-haiku-4-5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant6? ToEnum(string value)
        {
            return value switch
            {
                "claude-haiku-4-5" => ModelVariant6.ClaudeHaiku45,
                _ => null,
            };
        }
    }
}