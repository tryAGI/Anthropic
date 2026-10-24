
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInputMessageUnionDiscriminatorRole
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
    public static class BetaInputMessageUnionDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputMessageUnionDiscriminatorRole value)
        {
            return value switch
            {
                BetaInputMessageUnionDiscriminatorRole.Assistant => "assistant",
                BetaInputMessageUnionDiscriminatorRole.System => "system",
                BetaInputMessageUnionDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputMessageUnionDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BetaInputMessageUnionDiscriminatorRole.Assistant,
                "system" => BetaInputMessageUnionDiscriminatorRole.System,
                "user" => BetaInputMessageUnionDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}