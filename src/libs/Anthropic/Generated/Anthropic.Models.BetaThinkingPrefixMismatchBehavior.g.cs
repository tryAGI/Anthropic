
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What happens when a thinking block in `messages` fails the conversation<br/>
    /// check: it was created in a different conversation, or the messages before<br/>
    /// it have changed since. `"error"` (the default) fails the request with a<br/>
    /// 400 error. `"drop_block"` removes the failing blocks and the request<br/>
    /// proceeds; the model no longer sees the dropped reasoning.
    /// </summary>
    public enum BetaThinkingPrefixMismatchBehavior
    {
        /// <summary>
        ///
        /// </summary>
        DropBlock,
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaThinkingPrefixMismatchBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaThinkingPrefixMismatchBehavior value)
        {
            return value switch
            {
                BetaThinkingPrefixMismatchBehavior.DropBlock => "drop_block",
                BetaThinkingPrefixMismatchBehavior.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaThinkingPrefixMismatchBehavior? ToEnum(string value)
        {
            return value switch
            {
                "drop_block" => BetaThinkingPrefixMismatchBehavior.DropBlock,
                "error" => BetaThinkingPrefixMismatchBehavior.Error,
                _ => null,
            };
        }
    }
}