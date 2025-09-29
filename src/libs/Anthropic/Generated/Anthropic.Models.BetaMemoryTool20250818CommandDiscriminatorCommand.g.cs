
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaMemoryTool20250818CommandDiscriminatorCommand
    {
        /// <summary>
        /// 
        /// </summary>
        View,
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        StrReplace,
        /// <summary>
        /// 
        /// </summary>
        Insert,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Rename,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMemoryTool20250818CommandDiscriminatorCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMemoryTool20250818CommandDiscriminatorCommand value)
        {
            return value switch
            {
                BetaMemoryTool20250818CommandDiscriminatorCommand.View => "view",
                BetaMemoryTool20250818CommandDiscriminatorCommand.Create => "create",
                BetaMemoryTool20250818CommandDiscriminatorCommand.StrReplace => "str_replace",
                BetaMemoryTool20250818CommandDiscriminatorCommand.Insert => "insert",
                BetaMemoryTool20250818CommandDiscriminatorCommand.Delete => "delete",
                BetaMemoryTool20250818CommandDiscriminatorCommand.Rename => "rename",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMemoryTool20250818CommandDiscriminatorCommand? ToEnum(string value)
        {
            return value switch
            {
                "view" => BetaMemoryTool20250818CommandDiscriminatorCommand.View,
                "create" => BetaMemoryTool20250818CommandDiscriminatorCommand.Create,
                "str_replace" => BetaMemoryTool20250818CommandDiscriminatorCommand.StrReplace,
                "insert" => BetaMemoryTool20250818CommandDiscriminatorCommand.Insert,
                "delete" => BetaMemoryTool20250818CommandDiscriminatorCommand.Delete,
                "rename" => BetaMemoryTool20250818CommandDiscriminatorCommand.Rename,
                _ => null,
            };
        }
    }
}