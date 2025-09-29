
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaMemoryTool20250818Type
    {
        /// <summary>
        /// 
        /// </summary>
        Memory20250818,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMemoryTool20250818TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMemoryTool20250818Type value)
        {
            return value switch
            {
                BetaMemoryTool20250818Type.Memory20250818 => "memory_20250818",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMemoryTool20250818Type? ToEnum(string value)
        {
            return value switch
            {
                "memory_20250818" => BetaMemoryTool20250818Type.Memory20250818,
                _ => null,
            };
        }
    }
}