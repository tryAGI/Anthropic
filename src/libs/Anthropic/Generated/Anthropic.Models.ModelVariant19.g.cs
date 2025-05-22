
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelVariant19
    {
        /// <summary>
        /// 
        /// </summary>
        Claude21,
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
                ModelVariant19.Claude21 => "claude-2.1",
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
                "claude-2.1" => ModelVariant19.Claude21,
                _ => null,
            };
        }
    }
}