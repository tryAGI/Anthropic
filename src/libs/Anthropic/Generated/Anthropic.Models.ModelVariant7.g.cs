
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Hybrid model, capable of near-instant responses and extended thinking
    /// </summary>
    public enum ModelVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeHaiku4520251001,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant7 value)
        {
            return value switch
            {
                ModelVariant7.ClaudeHaiku4520251001 => "claude-haiku-4-5-20251001",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant7? ToEnum(string value)
        {
            return value switch
            {
                "claude-haiku-4-5-20251001" => ModelVariant7.ClaudeHaiku4520251001,
                _ => null,
            };
        }
    }
}