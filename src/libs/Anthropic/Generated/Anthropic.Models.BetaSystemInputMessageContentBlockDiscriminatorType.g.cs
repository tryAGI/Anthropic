
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSystemInputMessageContentBlockDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        ToolAddition,
        /// <summary>
        ///
        /// </summary>
        ToolRemoval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSystemInputMessageContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSystemInputMessageContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaSystemInputMessageContentBlockDiscriminatorType.Text => "text",
                BetaSystemInputMessageContentBlockDiscriminatorType.ToolAddition => "tool_addition",
                BetaSystemInputMessageContentBlockDiscriminatorType.ToolRemoval => "tool_removal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSystemInputMessageContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaSystemInputMessageContentBlockDiscriminatorType.Text,
                "tool_addition" => BetaSystemInputMessageContentBlockDiscriminatorType.ToolAddition,
                "tool_removal" => BetaSystemInputMessageContentBlockDiscriminatorType.ToolRemoval,
                _ => null,
            };
        }
    }
}