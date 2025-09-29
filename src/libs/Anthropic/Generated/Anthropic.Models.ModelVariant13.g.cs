
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20240620,
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
                ModelVariant13.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
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
                "claude-3-5-sonnet-20240620" => ModelVariant13.Claude35Sonnet20240620,
                _ => null,
            };
        }
    }
}