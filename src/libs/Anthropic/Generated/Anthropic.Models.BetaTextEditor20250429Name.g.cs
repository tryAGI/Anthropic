
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in `tool_use` blocks.
    /// </summary>
    public enum BetaTextEditor20250429Name
    {
        /// <summary>
        /// 
        /// </summary>
        StrReplaceBasedEditTool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTextEditor20250429NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextEditor20250429Name value)
        {
            return value switch
            {
                BetaTextEditor20250429Name.StrReplaceBasedEditTool => "str_replace_based_edit_tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextEditor20250429Name? ToEnum(string value)
        {
            return value switch
            {
                "str_replace_based_edit_tool" => BetaTextEditor20250429Name.StrReplaceBasedEditTool,
                _ => null,
            };
        }
    }
}