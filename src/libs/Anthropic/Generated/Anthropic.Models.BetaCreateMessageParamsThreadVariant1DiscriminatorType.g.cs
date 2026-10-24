
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCreateMessageParamsThreadVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Continue,
        /// <summary>
        ///
        /// </summary>
        Create,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCreateMessageParamsThreadVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCreateMessageParamsThreadVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaCreateMessageParamsThreadVariant1DiscriminatorType.Continue => "continue",
                BetaCreateMessageParamsThreadVariant1DiscriminatorType.Create => "create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCreateMessageParamsThreadVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "continue" => BetaCreateMessageParamsThreadVariant1DiscriminatorType.Continue,
                "create" => BetaCreateMessageParamsThreadVariant1DiscriminatorType.Create,
                _ => null,
            };
        }
    }
}