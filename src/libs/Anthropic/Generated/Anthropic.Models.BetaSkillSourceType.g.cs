
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
    public enum BetaSkillSourceType
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
    public static class BetaSkillSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSkillSourceType value)
        {
            return value switch
            {
                BetaSkillSourceType.Anthropic => "anthropic",
                BetaSkillSourceType.AnthropicExample => "anthropic_example",
                BetaSkillSourceType.Custom => "custom",
                BetaSkillSourceType.Plugin => "plugin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSkillSourceType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => BetaSkillSourceType.Anthropic,
                "anthropic_example" => BetaSkillSourceType.AnthropicExample,
                "custom" => BetaSkillSourceType.Custom,
                "plugin" => BetaSkillSourceType.Plugin,
                _ => null,
            };
        }
    }
}