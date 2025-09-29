
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Excels at writing and complex tasks
    /// </summary>
    public enum ModelVariant19
    {
        /// <summary>
        /// 
        /// </summary>
        Claude3Opus20240229,
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
                ModelVariant19.Claude3Opus20240229 => "claude-3-opus-20240229",
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
                "claude-3-opus-20240229" => ModelVariant19.Claude3Opus20240229,
                _ => null,
            };
        }
    }
}