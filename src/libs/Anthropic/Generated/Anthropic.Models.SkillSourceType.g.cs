
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where the Skill comes from.<br/>
    /// Possible values:<br/>
    /// * `"custom"`: authored by the platform user; private to their workspace<br/>
    /// * `"anthropic"`: published by Anthropic; shared and read-only<br/>
    /// * `"anthropic_example"`: Anthropic-published sample Skill<br/>
    /// * `"plugin"`: resolved from an installed plugin
    /// </summary>
    public enum SkillSourceType
    {
        /// <summary>
        /// published by Anthropic; shared and read-only
        /// </summary>
        Anthropic,
        /// <summary>
        /// Anthropic-published sample Skill
        /// </summary>
        AnthropicExample,
        /// <summary>
        /// authored by the platform user; private to their workspace
        /// </summary>
        Custom,
        /// <summary>
        /// resolved from an installed plugin
        /// </summary>
        Plugin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkillSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillSourceType value)
        {
            return value switch
            {
                SkillSourceType.Anthropic => "anthropic",
                SkillSourceType.AnthropicExample => "anthropic_example",
                SkillSourceType.Custom => "custom",
                SkillSourceType.Plugin => "plugin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillSourceType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => SkillSourceType.Anthropic,
                "anthropic_example" => SkillSourceType.AnthropicExample,
                "custom" => SkillSourceType.Custom,
                "plugin" => SkillSourceType.Plugin,
                _ => null,
            };
        }
    }
}