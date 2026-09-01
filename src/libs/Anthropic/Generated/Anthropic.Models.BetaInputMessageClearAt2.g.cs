
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInputMessageClearAt2
    {
        /// <summary>
        ///
        /// </summary>
        Never,
        /// <summary>
        ///
        /// </summary>
        NextUserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputMessageClearAt2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputMessageClearAt2 value)
        {
            return value switch
            {
                BetaInputMessageClearAt2.Never => "never",
                BetaInputMessageClearAt2.NextUserMessage => "next_user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputMessageClearAt2? ToEnum(string value)
        {
            return value switch
            {
                "never" => BetaInputMessageClearAt2.Never,
                "next_user_message" => BetaInputMessageClearAt2.NextUserMessage,
                _ => null,
            };
        }
    }
}