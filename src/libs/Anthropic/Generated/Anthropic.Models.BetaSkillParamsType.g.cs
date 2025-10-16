
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Type of skill - either 'anthropic' (built-in) or 'custom' (user-defined)
    /// </summary>
    public enum BetaSkillParamsType
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
    public static class BetaSkillParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSkillParamsType value)
        {
            return value switch
            {
                BetaSkillParamsType.Anthropic => "anthropic",
                BetaSkillParamsType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSkillParamsType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => BetaSkillParamsType.Anthropic,
                "custom" => BetaSkillParamsType.Custom,
                _ => null,
            };
        }
    }
}