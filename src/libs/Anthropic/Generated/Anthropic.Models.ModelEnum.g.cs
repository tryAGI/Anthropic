
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelEnum
    {
        /// <summary>
        /// Fast and cost-effective model
        /// </summary>
        Claude35HaikuLatest,
        /// <summary>
        /// Fast and cost-effective model
        /// </summary>
        Claude35Haiku20241022,
        /// <summary>
        /// Our most intelligent model
        /// </summary>
        Claude35SonnetLatest,
        /// <summary>
        /// Our most intelligent model
        /// </summary>
        Claude35Sonnet20241022,
        /// <summary>
        /// Our previous most intelligent model
        /// </summary>
        Claude35Sonnet20240620,
        /// <summary>
        /// Excels at writing and complex tasks
        /// </summary>
        Claude3OpusLatest,
        /// <summary>
        /// Excels at writing and complex tasks
        /// </summary>
        Claude3Opus20240229,
        /// <summary>
        /// Balance of speed and intelligence
        /// </summary>
        Claude3Sonnet20240229,
        /// <summary>
        /// Our previous fast and cost-effective
        /// </summary>
        Claude3Haiku20240307,
        /// <summary>
        /// 
        /// </summary>
        Claude21,
        /// <summary>
        /// 
        /// </summary>
        Claude20,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEnum value)
        {
            return value switch
            {
                ModelEnum.Claude35HaikuLatest => "claude-3-5-haiku-latest",
                ModelEnum.Claude35Haiku20241022 => "claude-3-5-haiku-20241022",
                ModelEnum.Claude35SonnetLatest => "claude-3-5-sonnet-latest",
                ModelEnum.Claude35Sonnet20241022 => "claude-3-5-sonnet-20241022",
                ModelEnum.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                ModelEnum.Claude3OpusLatest => "claude-3-opus-latest",
                ModelEnum.Claude3Opus20240229 => "claude-3-opus-20240229",
                ModelEnum.Claude3Sonnet20240229 => "claude-3-sonnet-20240229",
                ModelEnum.Claude3Haiku20240307 => "claude-3-haiku-20240307",
                ModelEnum.Claude21 => "claude-2.1",
                ModelEnum.Claude20 => "claude-2.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEnum? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-haiku-latest" => ModelEnum.Claude35HaikuLatest,
                "claude-3-5-haiku-20241022" => ModelEnum.Claude35Haiku20241022,
                "claude-3-5-sonnet-latest" => ModelEnum.Claude35SonnetLatest,
                "claude-3-5-sonnet-20241022" => ModelEnum.Claude35Sonnet20241022,
                "claude-3-5-sonnet-20240620" => ModelEnum.Claude35Sonnet20240620,
                "claude-3-opus-latest" => ModelEnum.Claude3OpusLatest,
                "claude-3-opus-20240229" => ModelEnum.Claude3Opus20240229,
                "claude-3-sonnet-20240229" => ModelEnum.Claude3Sonnet20240229,
                "claude-3-haiku-20240307" => ModelEnum.Claude3Haiku20240307,
                "claude-2.1" => ModelEnum.Claude21,
                "claude-2.0" => ModelEnum.Claude20,
                _ => null,
            };
        }
    }
}