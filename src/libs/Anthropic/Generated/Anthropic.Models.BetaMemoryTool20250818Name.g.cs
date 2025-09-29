
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in `tool_use` blocks.
    /// </summary>
    public enum BetaMemoryTool20250818Name
    {
        /// <summary>
        /// 
        /// </summary>
        Memory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMemoryTool20250818NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMemoryTool20250818Name value)
        {
            return value switch
            {
                BetaMemoryTool20250818Name.Memory => "memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMemoryTool20250818Name? ToEnum(string value)
        {
            return value switch
            {
                "memory" => BetaMemoryTool20250818Name.Memory,
                _ => null,
            };
        }
    }
}