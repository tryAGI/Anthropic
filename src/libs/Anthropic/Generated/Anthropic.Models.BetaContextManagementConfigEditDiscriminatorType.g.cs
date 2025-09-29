
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaContextManagementConfigEditDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ClearToolUses20250919,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContextManagementConfigEditDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContextManagementConfigEditDiscriminatorType value)
        {
            return value switch
            {
                BetaContextManagementConfigEditDiscriminatorType.ClearToolUses20250919 => "clear_tool_uses_20250919",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContextManagementConfigEditDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "clear_tool_uses_20250919" => BetaContextManagementConfigEditDiscriminatorType.ClearToolUses20250919,
                _ => null,
            };
        }
    }
}