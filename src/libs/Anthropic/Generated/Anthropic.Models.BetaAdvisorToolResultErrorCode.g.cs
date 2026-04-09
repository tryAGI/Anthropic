
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAdvisorToolResultErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        ExecutionTimeExceeded,
        /// <summary>
        /// 
        /// </summary>
        MaxUsesExceeded,
        /// <summary>
        /// 
        /// </summary>
        Overloaded,
        /// <summary>
        /// 
        /// </summary>
        PromptTooLong,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAdvisorToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAdvisorToolResultErrorCode value)
        {
            return value switch
            {
                BetaAdvisorToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BetaAdvisorToolResultErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                BetaAdvisorToolResultErrorCode.Overloaded => "overloaded",
                BetaAdvisorToolResultErrorCode.PromptTooLong => "prompt_too_long",
                BetaAdvisorToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaAdvisorToolResultErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAdvisorToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => BetaAdvisorToolResultErrorCode.ExecutionTimeExceeded,
                "max_uses_exceeded" => BetaAdvisorToolResultErrorCode.MaxUsesExceeded,
                "overloaded" => BetaAdvisorToolResultErrorCode.Overloaded,
                "prompt_too_long" => BetaAdvisorToolResultErrorCode.PromptTooLong,
                "too_many_requests" => BetaAdvisorToolResultErrorCode.TooManyRequests,
                "unavailable" => BetaAdvisorToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}