
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInputMessageClearAt
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
    public static class BetaInputMessageClearAtExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputMessageClearAt value)
        {
            return value switch
            {
                BetaInputMessageClearAt.Never => "never",
                BetaInputMessageClearAt.NextUserMessage => "next_user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputMessageClearAt? ToEnum(string value)
        {
            return value switch
            {
                "never" => BetaInputMessageClearAt.Never,
                "next_user_message" => BetaInputMessageClearAt.NextUserMessage,
                _ => null,
            };
        }
    }
}