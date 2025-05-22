
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20240620,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant11 value)
        {
            return value switch
            {
                ModelVariant11.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant11? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet-20240620" => ModelVariant11.Claude35Sonnet20240620,
                _ => null,
            };
        }
    }
}