
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaResponseContextManagementAppliedEditDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ClearThinking20251015,
        /// <summary>
        /// 
        /// </summary>
        ClearToolUses20250919,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseContextManagementAppliedEditDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseContextManagementAppliedEditDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseContextManagementAppliedEditDiscriminatorType.ClearThinking20251015 => "clear_thinking_20251015",
                BetaResponseContextManagementAppliedEditDiscriminatorType.ClearToolUses20250919 => "clear_tool_uses_20250919",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseContextManagementAppliedEditDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "clear_thinking_20251015" => BetaResponseContextManagementAppliedEditDiscriminatorType.ClearThinking20251015,
                "clear_tool_uses_20250919" => BetaResponseContextManagementAppliedEditDiscriminatorType.ClearToolUses20250919,
                _ => null,
            };
        }
    }
}