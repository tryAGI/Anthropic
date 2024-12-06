
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Available models. Mind that the list may not be exhaustive nor up-to-date.
    /// </summary>
    public enum CreateMessageRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35SonnetLatest,
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20241022,
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20240620,
        /// <summary>
        /// 
        /// </summary>
        Claude3OpusLatest,
        /// <summary>
        /// 
        /// </summary>
        Claude3Opus20240229,
        /// <summary>
        /// 
        /// </summary>
        Claude3Sonnet20240229,
        /// <summary>
        /// 
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
    public static class CreateMessageRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageRequestModel value)
        {
            return value switch
            {
                CreateMessageRequestModel.Claude35SonnetLatest => "claude-3-5-sonnet-latest",
                CreateMessageRequestModel.Claude35Sonnet20241022 => "claude-3-5-sonnet-20241022",
                CreateMessageRequestModel.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                CreateMessageRequestModel.Claude3OpusLatest => "claude-3-opus-latest",
                CreateMessageRequestModel.Claude3Opus20240229 => "claude-3-opus-20240229",
                CreateMessageRequestModel.Claude3Sonnet20240229 => "claude-3-sonnet-20240229",
                CreateMessageRequestModel.Claude3Haiku20240307 => "claude-3-haiku-20240307",
                CreateMessageRequestModel.Claude21 => "claude-2.1",
                CreateMessageRequestModel.Claude20 => "claude-2.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet-latest" => CreateMessageRequestModel.Claude35SonnetLatest,
                "claude-3-5-sonnet-20241022" => CreateMessageRequestModel.Claude35Sonnet20241022,
                "claude-3-5-sonnet-20240620" => CreateMessageRequestModel.Claude35Sonnet20240620,
                "claude-3-opus-latest" => CreateMessageRequestModel.Claude3OpusLatest,
                "claude-3-opus-20240229" => CreateMessageRequestModel.Claude3Opus20240229,
                "claude-3-sonnet-20240229" => CreateMessageRequestModel.Claude3Sonnet20240229,
                "claude-3-haiku-20240307" => CreateMessageRequestModel.Claude3Haiku20240307,
                "claude-2.1" => CreateMessageRequestModel.Claude21,
                "claude-2.0" => CreateMessageRequestModel.Claude20,
                _ => null,
            };
        }
    }
}