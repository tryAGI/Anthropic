
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaInputTokensTriggerType
    {
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputTokensTriggerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputTokensTriggerType value)
        {
            return value switch
            {
                BetaInputTokensTriggerType.InputTokens => "input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputTokensTriggerType? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => BetaInputTokensTriggerType.InputTokens,
                _ => null,
            };
        }
    }
}