
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Type of skill - either 'anthropic' (built-in) or 'custom' (user-defined)
    /// </summary>
    public enum ContainerSkillType
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
    public static class ContainerSkillTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerSkillType value)
        {
            return value switch
            {
                ContainerSkillType.Anthropic => "anthropic",
                ContainerSkillType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerSkillType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => ContainerSkillType.Anthropic,
                "custom" => ContainerSkillType.Custom,
                _ => null,
            };
        }
    }
}