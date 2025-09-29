
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaInputTokensClearAtLeastType
    {
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputTokensClearAtLeastTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputTokensClearAtLeastType value)
        {
            return value switch
            {
                BetaInputTokensClearAtLeastType.InputTokens => "input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputTokensClearAtLeastType? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => BetaInputTokensClearAtLeastType.InputTokens,
                _ => null,
            };
        }
    }
}