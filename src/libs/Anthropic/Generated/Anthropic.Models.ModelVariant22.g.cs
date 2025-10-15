
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our previous most fast and cost-effective
    /// </summary>
    public enum ModelVariant22
    {
        /// <summary>
        /// 
        /// </summary>
        Claude3Haiku20240307,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant22Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant22 value)
        {
            return value switch
            {
                ModelVariant22.Claude3Haiku20240307 => "claude-3-haiku-20240307",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant22? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-haiku-20240307" => ModelVariant22.Claude3Haiku20240307,
                _ => null,
            };
        }
    }
}