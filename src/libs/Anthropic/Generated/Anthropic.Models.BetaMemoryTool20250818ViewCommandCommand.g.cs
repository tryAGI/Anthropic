
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Command type identifier<br/>
    /// Default Value: view
    /// </summary>
    public enum BetaMemoryTool20250818ViewCommandCommand
    {
        /// <summary>
        /// 
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMemoryTool20250818ViewCommandCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMemoryTool20250818ViewCommandCommand value)
        {
            return value switch
            {
                BetaMemoryTool20250818ViewCommandCommand.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMemoryTool20250818ViewCommandCommand? ToEnum(string value)
        {
            return value switch
            {
                "view" => BetaMemoryTool20250818ViewCommandCommand.View,
                _ => null,
            };
        }
    }
}