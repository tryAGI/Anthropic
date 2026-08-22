
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaInputMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputMessageRole value)
        {
            return value switch
            {
                BetaInputMessageRole.Assistant => "assistant",
                BetaInputMessageRole.System => "system",
                BetaInputMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BetaInputMessageRole.Assistant,
                "system" => BetaInputMessageRole.System,
                "user" => BetaInputMessageRole.User,
                _ => null,
            };
        }
    }
}