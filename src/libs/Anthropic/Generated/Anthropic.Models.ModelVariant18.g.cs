
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our previous most fast and cost-effective
    /// </summary>
    public enum ModelVariant18
    {
        /// <summary>
        /// 
        /// </summary>
        Claude3Haiku20240307,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant18Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant18 value)
        {
            return value switch
            {
                ModelVariant18.Claude3Haiku20240307 => "claude-3-haiku-20240307",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant18? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-haiku-20240307" => ModelVariant18.Claude3Haiku20240307,
                _ => null,
            };
        }
    }
}