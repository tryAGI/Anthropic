
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSystemInputMessageClearAt
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
    public static class BetaSystemInputMessageClearAtExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSystemInputMessageClearAt value)
        {
            return value switch
            {
                BetaSystemInputMessageClearAt.Never => "never",
                BetaSystemInputMessageClearAt.NextUserMessage => "next_user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSystemInputMessageClearAt? ToEnum(string value)
        {
            return value switch
            {
                "never" => BetaSystemInputMessageClearAt.Never,
                "next_user_message" => BetaSystemInputMessageClearAt.NextUserMessage,
                _ => null,
            };
        }
    }
}