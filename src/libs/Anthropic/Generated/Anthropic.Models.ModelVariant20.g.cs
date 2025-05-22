
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelVariant20
    {
        /// <summary>
        /// 
        /// </summary>
        Claude20,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant20Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant20 value)
        {
            return value switch
            {
                ModelVariant20.Claude20 => "claude-2.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant20? ToEnum(string value)
        {
            return value switch
            {
                "claude-2.0" => ModelVariant20.Claude20,
                _ => null,
            };
        }
    }
}