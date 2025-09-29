
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Command type identifier<br/>
    /// Default Value: delete
    /// </summary>
    public enum BetaMemoryTool20250818DeleteCommandCommand
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMemoryTool20250818DeleteCommandCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMemoryTool20250818DeleteCommandCommand value)
        {
            return value switch
            {
                BetaMemoryTool20250818DeleteCommandCommand.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMemoryTool20250818DeleteCommandCommand? ToEnum(string value)
        {
            return value switch
            {
                "delete" => BetaMemoryTool20250818DeleteCommandCommand.Delete,
                _ => null,
            };
        }
    }
}