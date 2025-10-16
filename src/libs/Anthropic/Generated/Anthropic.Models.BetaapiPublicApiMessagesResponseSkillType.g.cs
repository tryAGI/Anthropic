
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Type of skill - either 'anthropic' (built-in) or 'custom' (user-defined)
    /// </summary>
    public enum BetaapiPublicApiMessagesResponseSkillType
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
    public static class BetaapiPublicApiMessagesResponseSkillTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaapiPublicApiMessagesResponseSkillType value)
        {
            return value switch
            {
                BetaapiPublicApiMessagesResponseSkillType.Anthropic => "anthropic",
                BetaapiPublicApiMessagesResponseSkillType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaapiPublicApiMessagesResponseSkillType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => BetaapiPublicApiMessagesResponseSkillType.Anthropic,
                "custom" => BetaapiPublicApiMessagesResponseSkillType.Custom,
                _ => null,
            };
        }
    }
}