
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Type of skill - either 'anthropic' (built-in) or 'custom' (user-defined)
    /// </summary>
    public enum BetaContainerSkillType
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContainerSkillTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContainerSkillType value)
        {
            return value switch
            {
                BetaContainerSkillType.Anthropic => "anthropic",
                BetaContainerSkillType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContainerSkillType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => BetaContainerSkillType.Anthropic,
                "custom" => BetaContainerSkillType.Custom,
                _ => null,
            };
        }
    }
}