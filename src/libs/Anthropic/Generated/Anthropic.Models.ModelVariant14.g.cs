
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our previous most intelligent model
    /// </summary>
    public enum ModelVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant14 value)
        {
            return value switch
            {
                ModelVariant14.Claude35Sonnet20241022 => "claude-3-5-sonnet-20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant14? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet-20241022" => ModelVariant14.Claude35Sonnet20241022,
                _ => null,
            };
        }
    }
}