
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCodeExecutionTool20250825Type
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20250825,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCodeExecutionTool20250825TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeExecutionTool20250825Type value)
        {
            return value switch
            {
                BetaCodeExecutionTool20250825Type.CodeExecution20250825 => "code_execution_20250825",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCodeExecutionTool20250825Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => BetaCodeExecutionTool20250825Type.CodeExecution20250825,
                _ => null,
            };
        }
    }
}