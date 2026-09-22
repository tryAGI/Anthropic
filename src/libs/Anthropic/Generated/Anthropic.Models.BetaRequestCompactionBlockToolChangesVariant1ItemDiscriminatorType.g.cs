
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType
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
    public static class BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType.ToolAddition => "tool_addition",
                BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType.ToolRemoval => "tool_removal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "tool_addition" => BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType.ToolAddition,
                "tool_removal" => BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType.ToolRemoval,
                _ => null,
            };
        }
    }
}