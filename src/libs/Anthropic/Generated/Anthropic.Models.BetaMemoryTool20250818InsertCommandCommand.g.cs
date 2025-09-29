
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Command type identifier<br/>
    /// Default Value: insert
    /// </summary>
    public enum BetaMemoryTool20250818InsertCommandCommand
    {
        /// <summary>
        /// 
        /// </summary>
        Insert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMemoryTool20250818InsertCommandCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMemoryTool20250818InsertCommandCommand value)
        {
            return value switch
            {
                BetaMemoryTool20250818InsertCommandCommand.Insert => "insert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMemoryTool20250818InsertCommandCommand? ToEnum(string value)
        {
            return value switch
            {
                "insert" => BetaMemoryTool20250818InsertCommandCommand.Insert,
                _ => null,
            };
        }
    }
}