
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSkillParamsDiscriminatorType
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
    public static class BetaManagedAgentsSkillParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSkillParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSkillParamsDiscriminatorType.Anthropic => "anthropic",
                BetaManagedAgentsSkillParamsDiscriminatorType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSkillParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => BetaManagedAgentsSkillParamsDiscriminatorType.Anthropic,
                "custom" => BetaManagedAgentsSkillParamsDiscriminatorType.Custom,
                _ => null,
            };
        }
    }
}