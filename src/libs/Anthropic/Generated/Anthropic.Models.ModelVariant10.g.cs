
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our previous most intelligent model
    /// </summary>
    public enum ModelVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant10 value)
        {
            return value switch
            {
                ModelVariant10.Claude35Sonnet20241022 => "claude-3-5-sonnet-20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant10? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet-20241022" => ModelVariant10.Claude35Sonnet20241022,
                _ => null,
            };
        }
    }
}