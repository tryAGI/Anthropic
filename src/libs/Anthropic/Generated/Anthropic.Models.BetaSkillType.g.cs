
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Type of skill - either 'anthropic' (built-in) or 'custom' (user-defined)
    /// </summary>
    public enum BetaSkillType
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
    public static class BetaSkillTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSkillType value)
        {
            return value switch
            {
                BetaSkillType.Anthropic => "anthropic",
                BetaSkillType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSkillType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => BetaSkillType.Anthropic,
                "custom" => BetaSkillType.Custom,
                _ => null,
            };
        }
    }
}