
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolChoiceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolChoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolChoiceDiscriminatorType value)
        {
            return value switch
            {
                BetaToolChoiceDiscriminatorType.Any => "any",
                BetaToolChoiceDiscriminatorType.Auto => "auto",
                BetaToolChoiceDiscriminatorType.None => "none",
                BetaToolChoiceDiscriminatorType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolChoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "any" => BetaToolChoiceDiscriminatorType.Any,
                "auto" => BetaToolChoiceDiscriminatorType.Auto,
                "none" => BetaToolChoiceDiscriminatorType.None,
                "tool" => BetaToolChoiceDiscriminatorType.Tool,
                _ => null,
            };
        }
    }
}