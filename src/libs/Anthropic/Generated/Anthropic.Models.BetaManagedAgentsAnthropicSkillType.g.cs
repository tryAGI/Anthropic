
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAnthropicSkillType
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAnthropicSkillTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAnthropicSkillType value)
        {
            return value switch
            {
                BetaManagedAgentsAnthropicSkillType.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAnthropicSkillType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => BetaManagedAgentsAnthropicSkillType.Anthropic,
                _ => null,
            };
        }
    }
}