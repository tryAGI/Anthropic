
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCustomSkillParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCustomSkillParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCustomSkillParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsCustomSkillParamsType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCustomSkillParamsType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => BetaManagedAgentsCustomSkillParamsType.Custom,
                _ => null,
            };
        }
    }
}