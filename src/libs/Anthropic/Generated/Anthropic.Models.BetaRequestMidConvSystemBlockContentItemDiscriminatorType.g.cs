
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestMidConvSystemBlockContentItemDiscriminatorType
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
    public static class BetaRequestMidConvSystemBlockContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestMidConvSystemBlockContentItemDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestMidConvSystemBlockContentItemDiscriminatorType.Text => "text",
                BetaRequestMidConvSystemBlockContentItemDiscriminatorType.ToolAddition => "tool_addition",
                BetaRequestMidConvSystemBlockContentItemDiscriminatorType.ToolRemoval => "tool_removal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestMidConvSystemBlockContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaRequestMidConvSystemBlockContentItemDiscriminatorType.Text,
                "tool_addition" => BetaRequestMidConvSystemBlockContentItemDiscriminatorType.ToolAddition,
                "tool_removal" => BetaRequestMidConvSystemBlockContentItemDiscriminatorType.ToolRemoval,
                _ => null,
            };
        }
    }
}