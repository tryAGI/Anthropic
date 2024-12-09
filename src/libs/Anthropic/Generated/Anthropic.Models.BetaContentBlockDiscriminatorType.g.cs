
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaContentBlockDiscriminatorType.Text => "text",
                BetaContentBlockDiscriminatorType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaContentBlockDiscriminatorType.Text,
                "tool_use" => BetaContentBlockDiscriminatorType.ToolUse,
                _ => null,
            };
        }
    }
}