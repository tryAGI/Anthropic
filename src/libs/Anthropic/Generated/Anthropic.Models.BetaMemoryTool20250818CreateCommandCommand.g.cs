
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Command type identifier<br/>
    /// Default Value: create
    /// </summary>
    public enum BetaMemoryTool20250818CreateCommandCommand
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMemoryTool20250818CreateCommandCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMemoryTool20250818CreateCommandCommand value)
        {
            return value switch
            {
                BetaMemoryTool20250818CreateCommandCommand.Create => "create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMemoryTool20250818CreateCommandCommand? ToEnum(string value)
        {
            return value switch
            {
                "create" => BetaMemoryTool20250818CreateCommandCommand.Create,
                _ => null,
            };
        }
    }
}