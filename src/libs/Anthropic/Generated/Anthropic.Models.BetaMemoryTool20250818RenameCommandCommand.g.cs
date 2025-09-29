
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Command type identifier<br/>
    /// Default Value: rename
    /// </summary>
    public enum BetaMemoryTool20250818RenameCommandCommand
    {
        /// <summary>
        /// 
        /// </summary>
        Rename,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMemoryTool20250818RenameCommandCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMemoryTool20250818RenameCommandCommand value)
        {
            return value switch
            {
                BetaMemoryTool20250818RenameCommandCommand.Rename => "rename",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMemoryTool20250818RenameCommandCommand? ToEnum(string value)
        {
            return value switch
            {
                "rename" => BetaMemoryTool20250818RenameCommandCommand.Rename,
                _ => null,
            };
        }
    }
}