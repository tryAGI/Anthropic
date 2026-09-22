
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType
    {
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
    public static class BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType.ToolAddition => "tool_addition",
                BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType.ToolRemoval => "tool_removal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "tool_addition" => BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType.ToolAddition,
                "tool_removal" => BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType.ToolRemoval,
                _ => null,
            };
        }
    }
}