
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAnthropicSkillParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAnthropicSkillParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAnthropicSkillParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsAnthropicSkillParamsType.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAnthropicSkillParamsType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => BetaManagedAgentsAnthropicSkillParamsType.Anthropic,
                _ => null,
            };
        }
    }
}