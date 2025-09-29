
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Command type identifier<br/>
    /// Default Value: str_replace
    /// </summary>
    public enum BetaMemoryTool20250818StrReplaceCommandCommand
    {
        /// <summary>
        /// 
        /// </summary>
        StrReplace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMemoryTool20250818StrReplaceCommandCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMemoryTool20250818StrReplaceCommandCommand value)
        {
            return value switch
            {
                BetaMemoryTool20250818StrReplaceCommandCommand.StrReplace => "str_replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMemoryTool20250818StrReplaceCommandCommand? ToEnum(string value)
        {
            return value switch
            {
                "str_replace" => BetaMemoryTool20250818StrReplaceCommandCommand.StrReplace,
                _ => null,
            };
        }
    }
}