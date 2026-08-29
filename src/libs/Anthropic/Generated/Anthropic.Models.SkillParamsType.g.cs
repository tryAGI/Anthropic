
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Type of skill - either 'anthropic' (built-in) or 'custom' (user-defined)
    /// </summary>
    public enum SkillParamsType
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
    public static class SkillParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillParamsType value)
        {
            return value switch
            {
                SkillParamsType.Anthropic => "anthropic",
                SkillParamsType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillParamsType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => SkillParamsType.Anthropic,
                "custom" => SkillParamsType.Custom,
                _ => null,
            };
        }
    }
}