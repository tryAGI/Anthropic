
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSkillDiscriminatorType
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
    public static class BetaManagedAgentsSkillDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSkillDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSkillDiscriminatorType.Anthropic => "anthropic",
                BetaManagedAgentsSkillDiscriminatorType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSkillDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => BetaManagedAgentsSkillDiscriminatorType.Anthropic,
                "custom" => BetaManagedAgentsSkillDiscriminatorType.Custom,
                _ => null,
            };
        }
    }
}