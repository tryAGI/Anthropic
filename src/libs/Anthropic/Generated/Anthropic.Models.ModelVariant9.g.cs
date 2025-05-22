
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Our previous most intelligent model
    /// </summary>
    public enum ModelVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35SonnetLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant9 value)
        {
            return value switch
            {
                ModelVariant9.Claude35SonnetLatest => "claude-3-5-sonnet-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant9? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet-latest" => ModelVariant9.Claude35SonnetLatest,
                _ => null,
            };
        }
    }
}