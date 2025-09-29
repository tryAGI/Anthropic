
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Excels at writing and complex tasks
    /// </summary>
    public enum ModelVariant18
    {
        /// <summary>
        /// 
        /// </summary>
        Claude3OpusLatest,
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
                ModelVariant18.Claude3OpusLatest => "claude-3-opus-latest",
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
                "claude-3-opus-latest" => ModelVariant18.Claude3OpusLatest,
                _ => null,
            };
        }
    }
}